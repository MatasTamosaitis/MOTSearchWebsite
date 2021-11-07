using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RegistrationLookupApp
{
    public class SearchRegistration
    {
        public readonly VehicleRegistrationContext _motContext;

        // Inject the db context into the function.
        public SearchRegistration(VehicleRegistrationContext motContext)
        {
            _motContext = motContext;
        }

        [FunctionName("SearchRegistration")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req, ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
           
            string registrationNumber = req.Query["Registration"];

            var registrationDetails = await _motContext.VehicleDetails.Where(r => r.RegistrationNumber == registrationNumber).FirstOrDefaultAsync();

            // Check if the details weren't retrieved and propagate the message to the front end. 
            if (registrationDetails == null)
            {
                log.LogInformation($"Registration {registrationNumber} was not found");
                return new NotFoundResult();
            }

            return new OkObjectResult(registrationDetails);
        }
    }
}

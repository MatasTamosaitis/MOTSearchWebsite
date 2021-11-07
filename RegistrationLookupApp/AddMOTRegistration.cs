using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SharedLibrary;

namespace RegistrationLookupApp
{
    public class AddMOTRegistration
    {
        public VehicleRegistrationContext _motContext;

        // Inject the db context into the function.
        public AddMOTRegistration(VehicleRegistrationContext motContext)
        {
            _motContext = motContext;
        }

        [FunctionName("AddMOTRegistration")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req, ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();

            MOTDetailModel model = JsonConvert.DeserializeObject<MOTDetailModel>(requestBody);

            var newRegistration = new VehicleDetails() { Id = new Guid() ,RegistrationNumber = model.RegistrationNumber, Make = model.Make, Model = model.Model, Colour = model.Colour, ExpiryDate = GenerateExpiryDate(), Milage = GenerateMilage() };

            await _motContext.VehicleDetails.AddAsync(newRegistration);

            await _motContext.SaveChangesAsync();
            return new OkObjectResult(newRegistration);
        }

        /// <summary>
        /// Generate a random expiry date .
        /// </summary>
        /// <returns></returns>
        public string GenerateExpiryDate()
        {
            Random rand = new Random();
            int year = rand.Next(2022, 2024);
            int month = rand.Next(1, 12);
            int day = DateTime.DaysInMonth(year, month);

            int Day = rand.Next(1, day);

            DateTime datetime = new DateTime(year, month, Day);
            return datetime.ToShortDateString();
        }

        /// <summary>
        /// Generate random vehicle milage since last MOT.
        /// </summary>
        /// <returns></returns>
        public string GenerateMilage()
        {
            Random rand = new Random();
            int randomMilage = rand.Next(10000, 170000);
            return Convert.ToString(randomMilage);
        }
    }
}

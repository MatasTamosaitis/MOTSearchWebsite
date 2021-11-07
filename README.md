# MOTSearchWebsite
This website will allow users to create vehicle regristation details and retrieve them.

To debug this solution locally you'll need to create a local.settings.json file in the RegistrationLookupApp here's the code for that file :)

{
  "IsEncrypted": false,
  "Values": {
    "AzureWebJobsStorage": "UseDevelopmentStorage=true",
    "FUNCTIONS_WORKER_RUNTIME": "dotnet",
    "DefaultConnection": "Server=tcp:mot-registration-server.database.windows.net,1433;Initial Catalog=RegistrationDetails;Persist Security Info=False;User ID=motUser;Password=@8BrPKCvqR3Zv@i;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
  },

  "Host": {
    "LocalHttpPort": 7071,
    "CORS": "*",
    "CORSCredentials": false
  }

}

Also once the solution is running locally you might encounter an error where access to sql server is not allowed for a particular IP address if that happens
please give me a shout and I'll add a firewall rule to allow access. Though I enabled public access so the error may not happen. 

Thanks :)

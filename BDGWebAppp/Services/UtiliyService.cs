using BDGWebAppp.Models;
using Newtonsoft.Json;

namespace BDGWebAppp.Services
{
    public class UtiliyService:IUtilityService
    {
        public async Task<List<User>> GetListOfUsers() 
        {
            var users = new List<User>();
            var fileLoaction = Environment.GetEnvironmentVariable("FileLocation"); //please check your file location to update the json path on your local machine
            try {
                var inputFile = await File.ReadAllTextAsync(fileLoaction);
                users = JsonConvert.DeserializeObject<List<User>>(inputFile);
                return users;
            }
            catch(Exception ex) { 

                return users;
            } 
        }
    }
}

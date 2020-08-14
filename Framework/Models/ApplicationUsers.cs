using System.Collections.Generic;
using Newtonsoft.Json;

namespace Framework.Models
{
    public class ApplicationUsers
    {
        [JsonProperty("id")]
        public int Id {get; set;}

        [JsonProperty("name")]
        public string Name {get; set;}
        
        [JsonProperty("username")]
        public string UserName {get; set;}

        [JsonProperty("email")]
        public string Email {get; set;}

        [JsonProperty("address")]
        public string Address {get; set;}

        [JsonProperty("phone")]
        public string Phone {get; set;}

        [JsonProperty("website")]
        public string Website {get; set;}

        [JsonProperty("company")]
        public string Company {get; set;}
    }
}
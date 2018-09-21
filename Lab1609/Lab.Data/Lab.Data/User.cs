using Newtonsoft.Json;
using System;

namespace Lab.Data
{
    public class User
    {
        [JsonProperty(PropertyName = "id")]
        private int ID;

        [JsonProperty(PropertyName = "name")]
        private string Name;

        [JsonProperty(PropertyName = "username")]
        private string Username;

        [JsonProperty(PropertyName = "email")]
        private string Email;

        [JsonProperty(PropertyName = "address")]
        private UserAddress Address;

        [JsonProperty(PropertyName = "phone")]
        private string Phone;

        [JsonProperty(PropertyName = "website")]
        private string Website;

        [JsonProperty(PropertyName = "company")]
        private UserCompany Company;

        public int ID1 { get => ID; set => ID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Username1 { get => Username; set => Username = value; }
        public string Email1 { get => Email; set => Email = value; }
        public UserAddress Address1 { get => Address; set => Address = value; }
        public string Phone1 { get => Phone; set => Phone = value; }
        public string Website1 { get => Website; set => Website = value; }
        public UserCompany Company1 { get => Company; set => Company = value; }
    }
}

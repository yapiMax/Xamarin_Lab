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

        public int pID { get => ID; set => ID = value; }
        public string pName { get => Name; set => Name = value; }
        public string pUsername { get => Username; set => Username = value; }
        public string pEmail { get => Email; set => Email = value; }
        public UserAddress pAddress { get => Address; set => Address = value; }
        public string pPhone { get => Phone; set => Phone = value; }
        public string pWebsite { get => Website; set => Website = value; }
        public UserCompany pCompany { get => Company; set => Company = value; }
    }
}

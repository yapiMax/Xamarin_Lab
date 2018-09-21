using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab.Data
{
    public class UserAddress
    {
        [JsonProperty(PropertyName = "street")]
        private string Street;

        [JsonProperty(PropertyName = "suite")]
        private string Suite;

        [JsonProperty(PropertyName = "city")]
        private string City;

        [JsonProperty(PropertyName = "zipcode")]
        private string Zipcode;

        [JsonProperty(PropertyName = "geo")]
        private UserAddressGeo Geo;

        public string Street1 { get => Street; set => Street = value; }
        public string Suite1 { get => Suite; set => Suite = value; }
        public string City1 { get => City; set => City = value; }
        public string Zipcode1 { get => Zipcode; set => Zipcode = value; }
        public UserAddressGeo Geo1 { get => Geo; set => Geo = value; }
    }
}

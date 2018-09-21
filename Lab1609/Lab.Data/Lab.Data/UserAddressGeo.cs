using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab.Data
{
    public class UserAddressGeo
    {
        [JsonProperty(PropertyName = "lat")]
        private double latitude;

        [JsonProperty(PropertyName = "lng")]
        private double longtitude;

        public double Latitude { get => latitude; set => latitude = value; }
        public double Longtitude { get => longtitude; set => longtitude = value; }
    }
}

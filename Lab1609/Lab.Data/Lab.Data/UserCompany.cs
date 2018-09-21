using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab.Data
{
    public class UserCompany
    {
        [JsonProperty(PropertyName = "name")]
        private string Name;

        [JsonProperty(PropertyName = "catchphrase")]
        private string Catchphase;

        [JsonProperty(PropertyName = "bs")]
        private string BusinessStrategy;

        public string Name1 { get => Name; set => Name = value; }
        public string Catchphase1 { get => Catchphase; set => Catchphase = value; }
        public string BusinessStrategy1 { get => BusinessStrategy; set => BusinessStrategy = value; }
    }
}

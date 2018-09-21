using Lab.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Lab.Net
{
    public class DataRetriever
    {
        public DataRetriever()
        {

        }

        public List<User> GetUsers()
        {
            using (WebClient webClient = new WebClient())
            {
                string json = webClient.DownloadString("https://jsonplaceholder.typicode.com/users");

                return JsonConvert.DeserializeObject<User[]>(json).ToList();
            }
        }
    }
}

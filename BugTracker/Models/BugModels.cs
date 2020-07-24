using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class BugModels
    {
        [JsonProperty("autore")]
        public string Autore { get; set; }

        [JsonProperty("data")]
        public DateTimeOffset Data { get; set; } = DateTime.Parse(DateTime.Now.Date.ToShortDateString());

        [JsonProperty("descrizione")]
        public string Descrizione { get; set; }

        [JsonProperty("stato")]
        public bool Stato { get; set; }

        [JsonProperty("titolo")]
        public string Titolo { get; set; }

    }
}

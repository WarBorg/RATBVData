﻿using Newtonsoft.Json;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace RATBVData.Models.Models
{
    public class BusTimeTableModel
    {
        [JsonIgnore]
        [PrimaryKey, AutoIncrement]
        public int? Id { get; set; } // without nullable on Id, InsertOrReplace will not autoincrement the Id

        [JsonIgnore]
        [ForeignKey(typeof(BusStationModel))]
        public int BusStationId { get; set; }

        [JsonProperty("hour")]
        public string Hour { get; set; } = string.Empty;

        [JsonProperty("minutes")]
        public string Minutes { get; set; } = string.Empty;

        [JsonProperty("timeOfWeek")]
        public string TimeOfWeek { get; set; } = string.Empty;

        [JsonIgnore]
        public string LastUpdateDate { get; set; } = string.Empty;
    }
}
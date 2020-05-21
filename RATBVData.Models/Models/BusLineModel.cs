using System.Collections.Generic;
using Newtonsoft.Json;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace RATBVData.Models.Models
{
    public class BusLineModel
    {
        [JsonProperty("id")]
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("route")]
        public string Route { get; set; } = string.Empty;

        [JsonProperty("type")]
        public string Type { get; set; } = default!;

        // TODO check this property if we still need it
        [JsonProperty("color")]
        public string Color { get; set; } = string.Empty;

        [JsonProperty("linkNormalWay")]
        public string LinkNormalWay { get; set; } = default!;

        [JsonProperty("linkReverseWay")]
        public string LinkReverseWay { get; set; } = default!;

        [JsonIgnore]
        public string LastUpdateDate { get; set; } = string.Empty;

        [JsonIgnore]
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<BusStationModel>? BusStations { get; set; }
    }
}
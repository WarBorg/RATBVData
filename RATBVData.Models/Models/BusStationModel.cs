using System.Collections.Generic;
using Newtonsoft.Json;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace RATBVData.Models.Models
{
    public class BusStationModel
    {
        [JsonIgnore]
        [PrimaryKey, AutoIncrement]
        public int? Id { get; set; } // without nullable on Id, InsertOrReplace will not autoincrement the Id

        [JsonIgnore]
        [ForeignKey(typeof(BusLineModel))]
        public int BusLineId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        // TODO check this property if it is still needed
        [JsonProperty("direction")]
        public string Direction { get; set; } = default!;

        [JsonProperty("schedualLink")]
        public string ScheduleLink { get; set; } = default!;

        [JsonIgnore]
        public string LastUpdateDate { get; set; } = string.Empty;

        [JsonIgnore]
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<BusTimeTableModel>? BusTimeTables { get; set; }
    }
}

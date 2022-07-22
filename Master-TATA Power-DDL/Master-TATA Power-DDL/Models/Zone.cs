using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Master_TATA_Power_DDL.Models
{
    public class Zone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ZsoNumber { get; set; }
        public string ZmNumber { get; set; }
        public string ZrdmoNumber { get; set; }
        public DateTime CreationTime   { get; set; }
        public DateTime LastUpdateTime  { get; set; }
        public int DistrictId { get; set; }
        public District District { get; set; }
    }
}
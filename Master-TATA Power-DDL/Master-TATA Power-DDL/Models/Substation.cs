using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Master_TATA_Power_DDL.Models
{
    public class Substation
    {
        public int  Id  { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastUpdateTime  { get; set; }
        public int  ZoneId { get; set; }
        public Zone Zone { get; set; }

    }
}
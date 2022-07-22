using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Master_TATA_Power_DDL.Models
{
    public class Dt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public int PanelId { get; set; }
        public Panel Panel { get; set; }

    }
}
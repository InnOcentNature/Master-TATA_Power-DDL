using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Master_TATA_Power_DDL.Models
{
    public enum PanelType
    {
        CB = 0,
        FPI = 1,
        RELAY = 2,
        SF6 = 3,
    }

    public class Panel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public PanelType PanelType { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public int RmuId { get; set; }
        public Rmu Rmu { get; set; }

    }
}
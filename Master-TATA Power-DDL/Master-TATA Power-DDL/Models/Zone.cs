using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Master_TATA_Power_DDL.Models
{
    public class Zone : IValidatableObject
    {
        [Key]
        public int Id { get; set; }

        [Required,Display(Name="Zone Name"),StringLength(100),Index]
        public string Name { get; set; }

        [Required ,Display(Name="Zone Code"),StringLength(50),Index(IsUnique =true)]
        public string Code { get; set; }

        [Display(Name="ZSO Number"),RegularExpression(@"^[0-9]{10}$",ErrorMessage ="Enter a valid Number")]
        public string ZsoNumber { get; set; }

        [Display(Name="ZM Number"),RegularExpression(@"^[0-9]{10}$",ErrorMessage ="Enter a vaild Number")]
        public string ZmNumber { get; set; }

        [Display(Name ="ZRDMO Number"),RegularExpression(@"^[0-9]{10}$",ErrorMessage ="Enter a vaild Number")]
        public string ZrdmoNumber { get; set; }

        [Display(Name="Creation Time")]
        public DateTime CreationTime   { get; set; }

        [Display(Name ="Last Update Time")]
        public DateTime LastUpdateTime  { get; set; }

        [Required, Range(1,int.MaxValue ,ErrorMessage ="")]
        public int DistrictId { get; set; }

        public District District { get; set; }
    }
}
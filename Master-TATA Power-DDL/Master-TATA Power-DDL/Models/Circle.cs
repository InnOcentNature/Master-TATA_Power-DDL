using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Master_TATA_Power_DDL.Services;

namespace Master_TATA_Power_DDL.Models
{
    public class Circle : IValidatableObject
    {
        [Key]
        public int Id { get; set; }
        [Required ,StringLength(100),Index ,Display(Name="Circle Name")]
        public string Name { get; set; }
        [Required,StringLength(50),Index(IsUnique =true),Display(Name="Circle Code")]
        public string Code { get; set; }
        [Display(Name ="Creation Time")]
        public DateTime CreationTime { get; set; }
        [Display(Name ="Last Update Time")]
        public DateTime LastUpdateTime  { get; set; }
        public virtual ICollection<District> Districts { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            using (MasterDbContext dbContext = new MasterDbContext())
            {
                Circle circle = dbContext.Circles.FirstOrDefault(x => x.Code == Code && x.Id != Id);
                if(circle != null)
                {
                    yield return new ValidationResult($"{Code} already exists.", new[] { nameof(Code) });
                }
                else
                {
                    yield return ValidationResult.Success;
                }
            }
               // throw new NotImplementedException();
        }
    }
}
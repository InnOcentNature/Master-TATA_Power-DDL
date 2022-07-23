using Master_TATA_Power_DDL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Master_TATA_Power_DDL.Models
{
    public class District : IValidatableObject
    {
        [Key]
        public int Id { get; set; }

        [Required, Display(Name = "District Name"), StringLength(100), Index]
        public string Name { get; set; }

        [Required, StringLength(50), Index(IsUnique = true), Display(Name = "District Code")]
        public string Code { get; set; }

        [Display(Name = "Creation Time")]
        public DateTime CreationTime { get; set; }

        [Display(Name = "Last Update Time")]
        public DateTime LastUpdatedTime { get; set; }

        [Required, Range(1, int.MaxValue, ErrorMessage = "Circle field is required"), Display(Name = "Circle")]
        public int CircleId { get; set; }

        public Circle Circle { get; set; }

        public virtual ICollection<Zone> Zones { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            using (MasterDbContext dbContext = new MasterDbContext())
            {
                District district = dbContext.Districts.FirstOrDefault(x => x.Code == Code && x.Id != Id);
                if(district != null)
                {
                    yield return new ValidationResult($"{Code} already exists ", new[] { nameof(Code) });
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
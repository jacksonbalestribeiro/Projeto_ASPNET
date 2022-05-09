using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo {0} Required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be betwwen {2} and {1}")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo {0} Required")]
        [EmailAddress(ErrorMessage = "Enter a valid Email")]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo {0} Required")]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Campo {0} Required")]
        [Range(100.0, 50000.0 , ErrorMessage = "{0} must be from {1} to {2}")]
        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double BaseSalary { get; set; }

        public Department Department { get; set; }

        public ICollection<SalesRecord> SalesRecords { get; set; } = new List<SalesRecord>();

        public int DepartmentId { get; set; }

        public Seller()
        {
        }
        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }
        public void addSales(SalesRecord sr)
        {
            SalesRecords.Add(sr);
        }
        public void removeSales(SalesRecord sr)
        {
            SalesRecords.Remove(sr);
        }

        public double totalSales(DateTime initial, DateTime final)
        {
            return SalesRecords.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}

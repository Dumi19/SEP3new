using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class Administrator
    {
        [Key, MaxLength(15)]
        public string adminUsername{get;set;}
        [Required, MaxLength(15)]
        public string adminPassword{get;set;}
    }
}
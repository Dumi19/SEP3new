using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class User{
        [Key, MaxLength(15)]
        public string username{get;set;}
        
        [Required, MaxLength(15)]
        public string password{get;set;}


    }
}
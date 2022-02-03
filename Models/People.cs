using System.ComponentModel.DataAnnotations;

namespace MVC_Basics.Models
{
    public class People
    {

        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Tele { get; set; }
        public string City { get; set; }
    }
}

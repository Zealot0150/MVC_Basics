namespace MVC_Basics.Models
{

    // id, namn, short desc, long desc, price, ImageURL,
    public class Crab
    {
        public int CrabID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public Category Category { get; set; }

    }
}

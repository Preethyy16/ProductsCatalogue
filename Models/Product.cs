namespace ProductsCatalogue.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string category { get; set; }

        public decimal price { get; set; }  
    }
}

namespace API.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public long Price { get; set; }
        public String PictureUrl { get; set; }
        public String Type { get; set; }
        public String Brand { get; set; }
        public int QuantityInStock { get; set; }
    }
}
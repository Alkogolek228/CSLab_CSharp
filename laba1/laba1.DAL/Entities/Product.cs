namespace laba1.DAL.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageFileName { get; set; }
        public string ImageMimeType { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}

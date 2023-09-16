using laba1.DAL.Entities;

namespace laba1.DAL.Entities
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}

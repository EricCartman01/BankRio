using BankRio.Models.Enums;

namespace BankRio.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }

        public Product(int id, string name, string description, Category category)
        {
            Id = id;
            Name = name;
            Description = description;
            Category = category;
        }
    }

}

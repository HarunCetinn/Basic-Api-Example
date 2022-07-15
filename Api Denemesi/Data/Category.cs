using System.Collections.Generic;

namespace Api_Denemesi.Data
{
    public class Category
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}

using System;

namespace Api_Denemesi.Data
{
    public class Product
    {
        public int Id { get;set; }

        public string Name { get;set; } 

        public int Stock { get;set; }

        public decimal Price { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now; //değer gelmezse bu anı referans alır. 

        public string ImagePath { get; set; }

        public int? CategoryId { get; set; }

        public Category Category { get; set; }

    }
}

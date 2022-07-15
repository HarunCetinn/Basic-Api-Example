using System;

namespace ConsumeApı.ResponseModels
{
    public class ProductResponseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Stock { get; set; }

        public decimal Price { get; set; }

        public DateTime CreateDate { get; set; }  

        public string ImagePath { get; set; }

        public int? CategoryId { get; set; }




    }
}

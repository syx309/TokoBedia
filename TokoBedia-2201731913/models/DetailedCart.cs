
namespace TokoBedia_2201731913.models
{
    using System;
    using System.Collections.Generic;

    public partial class DetailedCart
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int Subtotal { get; set; }
    }
}
using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Available { get; set; }
        public DateTime DateUpdated { get; set; }
        public int ShoeId { get; set; }
        public string ShoeName { get; set; }
        public string Supplier { get; set; }
        public int ShoeSize { get; set; }
        public string ShoeColor { get; set; }
        public decimal ShoePrice { get; set; }
    }
}
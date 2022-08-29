
namespace Order_Management_System___OODJ.models
{
    internal class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public decimal ProductPrice { get; set; }
        public double ProductRate { get; set; }
    }
}

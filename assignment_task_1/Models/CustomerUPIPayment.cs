namespace assignment_task_1.Models
{
    public class CustomerUPIPayment
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public string Customer_Name { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Product_Price { get; set; }
        public string CardNumber { get; set; }
        public string Expiry { get; set; }
        public string cvv { get; set; }
        public string nameOnCard { get; set; }
        public string Product_Name { get; set; }
        public string Product_Detail { get; set; }
        public string Product_warranty { get; set; }
    }
}

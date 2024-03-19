namespace assignment_task_1.Models
{
    public class UPIPayment
    {
        public int Id { get; set; }
        public string Customer_Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string TotalPrice { get; set; }
        public string cardNumber { get; set; }
        public string nameOnCard { get; set; }
        public string cvv { get; set; }
        public DateTime UPI_TransactionDate { get; set; }
    }
}

namespace SqlRequests.Models
{
    public class ContractProperties
    {
        public int ContractId { get; set; }
        public Contracts Contracts;
        public int PropId { get; set; }
        public Properties Properties { get; set; }

        public int Quantity { get; set; }
    }
}

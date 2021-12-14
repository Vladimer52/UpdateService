namespace SqlRequests.Models
{
    public sealed class ContractProperty
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public Contracts Contract;
        public Property Property { get; set; }
        public int Quantity { get; set; }
    }
}

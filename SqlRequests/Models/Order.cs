using System;

namespace SqlRequests.Models
{
    public sealed class Order
    {
        public int Id { get; set; }

        public int ContractId { get; set; }
        public Contracts Contract { get; set; }

        public DateTime CreateDate { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }
}

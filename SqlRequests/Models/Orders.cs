using System;

namespace SqlRequests.Models
{
    public class Orders
    {
        public int OrderId { get; set; }
        public int ContractId { get; set; }
        public Contracts Contracts { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserId { get; set; }
        public Users Users { get; set; }

    }
}

using System;

namespace SqlRequests.Models
{
    public sealed class Contracts
    {
        public int Id { get; set; }
        public string Account { get; set; }

        public int PeopleId { get; set; }
        public People Peoples { get; set; }

        public int FirmId { get; set; }
        public Firm Firms { get; set; }

        public Int16 Status { get; set; }
    }
}

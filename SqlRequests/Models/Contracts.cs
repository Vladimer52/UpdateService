using System;

namespace SqlRequests.Models
{
    public class Contracts
    {
        public int ConrtactId { get; set; }
        public string Account { get; set; }

        public int PeopleId { get; set; }
        public Peoples Peoples { get; set; }

        public int FirmId { get; set; }
        public Firms Firms { get; set; }

        public Int16 Status { get; set; }
    }
}

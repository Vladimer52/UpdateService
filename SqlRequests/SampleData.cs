using SqlRequests.Models;
using System.Linq;

namespace SqlRequests
{
    public static class SampleData
    {
        public static void Initialize(DataContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                        FirstName = "aaa",
                        LastName = "bbb"
                    },
                    new User
                    {
                        FirstName = "ccc",
                        LastName = "ddd"
                    },
                    new User
                    {
                        FirstName = "eee",
                        LastName = "fff"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}

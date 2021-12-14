using Microsoft.AspNetCore.Mvc;
using SqlRequests.Models;
using System.Data.SqlClient;
using System.Linq;

namespace SqlRequests.Controllers
{
    public class HomeController : Controller
    {
        private const string ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=svtel;Trusted_Connection=True;MultipleActiveResultSets=true";

        private const string SqlCommand1 = "SELECT Account, FirstName, LastName " +
                                     "FROM Contracts, Peoples" +
                                     "WHERE Peoples.PeopleId = Contracts.PeopleId AND Contracts.Status = 1";
        private const string SqlCommand2 = "SELECT Account, Status, Quantity " +
                                     "FROM Contracts, ContractProperties " +
                                     "WHERE ContractProperties.Quantity > 10 AND Contracts.ContractId = ContractProperties.ContractId";
        private const string SqlCommand3 = "SELECT Account, Status, Quantity" +
                                     "FROM Contracts, ContractProperties " +
                                     "WHERE Contracts.ContractId = ContractProperties.ContractId ORDERBY ContractProperties.Quantity";
        private const string SqlCommand4 = "SELECT Quantity" +
                                     "FROM Contracts, ContractProperties " +
                                     "WHERE Contracts.Status = 1 AND ContractProperties.Quantity LIKE 'PROP%'";
        DataContext db;

        public HomeController(DataContext context)
        {
            db = context;
        }

        [HttpPost]
        public void SqlReport1()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(SqlCommand1, conn);
        }

        [HttpPost]
        public void SqlReport2()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(SqlCommand2, conn);
        }

        [HttpPost]
        public void SqlReport3()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(SqlCommand3, conn);
        }

        [HttpPost]
        public void SqlReport4()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(SqlCommand4, conn);
        }

        public IActionResult Index()
        {
            return View(db.Users.ToList());
        }

    }
}

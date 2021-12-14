using System;
using System.Data.SqlClient;
using System.Threading;

namespace UpdateService
{
    class TimerUdateDb
    {
        public static Timer timer;
        private readonly int _period = 20000; //default value
        private readonly int _dueTime = 1000; //start after 1s

        public TimerUdateDb(int period, int dueTime)
        {
            _period = period;
            _dueTime = dueTime;
        }
        public void Start()
        {
            timer = new Timer(
                        callback: new TimerCallback(TimerTask),
                        state: null,
                        dueTime: _dueTime,
                        period:  _period);

            UpdateDb();

            Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff}: done.");
        }

        public void Stop() => timer.Dispose();


        private static void TimerTask(object timerState)
    {
        Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff}: Updating DataBase..");
    }

        /// <summary>
        /// Generate Random string, using 26 characters
        /// </summary>
        /// <returns>randomString</returns>
        private static string GenerateRandomName()
        {
            const int numChar = 26;
            string randomString = String.Empty;
            Random rnd = new Random();
            Char[] pwdChars = new Char[numChar] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 
                                                  'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            for (int i = 0; i < 10; i++)
                randomString += pwdChars[rnd.Next(0, 25)];
            return randomString;
        }

        public static void UpdateDb()
        {
            SqlConnection conn = DbUtils.GetDbConnection();
            string firstname = GenerateRandomName();
            string lastName = GenerateRandomName();

            conn.Open();
            try
            {
                string sql = "INSERT INTO Users (FirstName, LastName) VALUES ( @firstName, @lastName)";

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandText = sql;

                int rowCount = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }
}
    }


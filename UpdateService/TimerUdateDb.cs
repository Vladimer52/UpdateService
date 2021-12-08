using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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

        public static void UpdateDb()
        {
            SqlConnection conn = DbUtils.GetDbConnection();
            conn.Open();
            try
            {
                string sql = "Update Employee set Salary = @salary where Emp_Id = @empId";

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandText = sql;

                // Добавить и настроить значение для параметра.
                cmd.Parameters.Add("@salary", SqlDbType.Float).Value = 850;
                cmd.Parameters.Add("@empId", SqlDbType.Decimal).Value = 7369;

                // Выполнить Command (Используется для delete, insert, update).
                int rowCount = cmd.ExecuteNonQuery();

                Console.WriteLine("Row Count affected = " + rowCount);
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


            Console.Read();
        }
}
    }


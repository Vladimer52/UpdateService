using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UpdateService
{
    class TimerUdateDb
    {
        public static Timer timer;
        private readonly int _period = 20000; //20s
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

            //replace to SQL
            Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff}: done.");
        }

        public void Stop() => timer.Dispose();


        private static void TimerTask(object timerState)
    {
        Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff}: starting a new callback.");
    }
}
    }


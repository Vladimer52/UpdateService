using System.ServiceProcess;

namespace UpdateService
{
    public partial class UpdateService : ServiceBase
    {
        TimerUdateDb timerUdateDb;
        public UpdateService()
        {
            InitializeComponent();
            this.CanStop = true;
            this.CanPauseAndContinue = true;
            timerUdateDb = new TimerUdateDb(20000, 1000);
        }

        protected override void OnStart(string[] args) => timerUdateDb.Start();

        protected override void OnStop() => timerUdateDb.Stop();
    }
}

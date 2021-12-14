using System.ServiceProcess;

namespace UpdateService
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new UpdateService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}

using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

namespace UpdateService
{
    [RunInstaller(true)]
    public partial class UpdateServiceInstaller : Installer
    {
        ServiceInstaller serviceInstaller;
        ServiceProcessInstaller processInstaller;

        public UpdateServiceInstaller()
        {
            InitializeComponent();
            serviceInstaller = new ServiceInstaller();
            processInstaller = new ServiceProcessInstaller();

            processInstaller.Account = ServiceAccount.LocalSystem;
            serviceInstaller.StartType = ServiceStartMode.Manual;
            serviceInstaller.ServiceName = "UpdateDbService";
            Installers.Add(processInstaller);
            Installers.Add(serviceInstaller);
        }
    }
}

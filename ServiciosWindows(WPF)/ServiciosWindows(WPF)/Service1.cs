using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace ServiciosWindows_WPF_
{
    public partial class Service1 : ServiceBase
    {
        bool flag = false;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            tejecutar.Start();
        }

        protected override void OnStop()
        {
            tejecutar.Stop();
        }

        private void tejecutar_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if(flag) return;
            try
            {
                flag = true;
                string pathorigen = ConfigurationSettings.AppSettings["pathorigen"];
                string pathdestino = ConfigurationSettings.AppSettings["pathdestino"];

                EventLog.WriteEntry($"incio el proceso de la carpeta : {pathorigen}", EventLogEntryType.Information);

                DirectoryInfo d = new DirectoryInfo(pathorigen);
                /*foreach (var archivo in d.GetFiles("*.txt", SearchOption.AllDirectories))
                {

                }*/
                foreach (var archivo in d.GetFiles())
                {
                    if (File.Exists(pathdestino + archivo.Name))
                    {
                        File.Delete(pathdestino + archivo.Name);
                    }
                    File.Copy(pathorigen + archivo.Name, pathdestino + archivo.Name);

                    if (File.Exists(pathdestino + archivo.Name))
                    {
                        EventLog.WriteEntry($"Se copio el archivo: {archivo.Name}", EventLogEntryType.Information);
                    }
                    else
                    {
                        EventLog.WriteEntry($"No Se copio el archivo: {archivo.Name}", EventLogEntryType.Information);
                    }                  
                }
                EventLog.WriteEntry($"Finalizo el proceso de la carpeta : {pathorigen}", EventLogEntryType.Information);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(ex.Message, EventLogEntryType.Error);
            }
            flag = false;
            
        }
    }
}

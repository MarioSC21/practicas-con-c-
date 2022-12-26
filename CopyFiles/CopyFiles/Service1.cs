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

namespace CopyFiles
{
    public partial class Service1 : ServiceBase
    {
       bool flag =false;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            tEjecutar.Start();
        }

        protected override void OnStop()
        {
            tEjecutar.Stop();
        }

        private void tEjecutar_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            if (flag) return;
            try
            {
                flag = true;
                string pathorgen = ConfigurationSettings.AppSettings["pathorigen"];
             string pathdestino = ConfigurationSettings.AppSettings["pathdestino"];

            EventLog.WriteEntry("Inicio el proceso de copia de carpeta : " + pathorgen, EventLogEntryType.Information);
            DirectoryInfo d = new DirectoryInfo(pathorgen);
            foreach (var archivo in d.GetFiles() )
            {
                if(File.Exists(pathdestino + archivo.Name))
                {
                    File.Delete(pathdestino + archivo.Name);
                }
                File.Copy(pathorgen + archivo.Name, pathdestino + archivo.Name);
                if (File.Exists(pathdestino + archivo.Name))
                {
                    EventLog.WriteEntry("Se copio el archivo : " + archivo.Name, EventLogEntryType.Information);
                }
                else
                {
                    EventLog.WriteEntry("No se pudo copiar el archivo : " + archivo.Name, EventLogEntryType.Information);
                }
            }
            EventLog.WriteEntry("Finalizo el proceso de copia de carpeta : " + pathorgen, EventLogEntryType.Information);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(ex.Message, EventLogEntryType.Error);
            }
            flag = false;
        }
    }
}

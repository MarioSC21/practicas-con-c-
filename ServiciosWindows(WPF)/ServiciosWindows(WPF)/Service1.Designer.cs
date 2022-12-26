namespace ServiciosWindows_WPF_
{
    partial class Service1
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tejecutar = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.tejecutar)).BeginInit();
            // 
            // tejecutar
            // 
            this.tejecutar.Enabled = true;
            this.tejecutar.Interval = 60000D;
            this.tejecutar.Elapsed += new System.Timers.ElapsedEventHandler(this.tejecutar_Elapsed);
            // 
            // Service1
            // 
            this.ServiceName = "Service1";
            ((System.ComponentModel.ISupportInitialize)(this.tejecutar)).EndInit();

        }

        #endregion

        private System.Timers.Timer tejecutar;
    }
}

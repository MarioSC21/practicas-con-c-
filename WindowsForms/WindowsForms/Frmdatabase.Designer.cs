namespace WindowsForms
{
    partial class Frmdatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboBasedatos = new System.Windows.Forms.ComboBox();
            this.lblbasedatos = new System.Windows.Forms.Label();
            this.btnCargardb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTablas = new System.Windows.Forms.ComboBox();
            this.btnCargarTablas = new System.Windows.Forms.Button();
            this.panel_data = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cboBasedatos
            // 
            this.cboBasedatos.FormattingEnabled = true;
            this.cboBasedatos.Location = new System.Drawing.Point(110, 30);
            this.cboBasedatos.Name = "cboBasedatos";
            this.cboBasedatos.Size = new System.Drawing.Size(156, 21);
            this.cboBasedatos.TabIndex = 0;
            // 
            // lblbasedatos
            // 
            this.lblbasedatos.AutoSize = true;
            this.lblbasedatos.Location = new System.Drawing.Point(22, 33);
            this.lblbasedatos.Name = "lblbasedatos";
            this.lblbasedatos.Size = new System.Drawing.Size(82, 13);
            this.lblbasedatos.TabIndex = 1;
            this.lblbasedatos.Text = "Bases de Datos";
            // 
            // btnCargardb
            // 
            this.btnCargardb.Location = new System.Drawing.Point(272, 28);
            this.btnCargardb.Name = "btnCargardb";
            this.btnCargardb.Size = new System.Drawing.Size(55, 23);
            this.btnCargardb.TabIndex = 2;
            this.btnCargardb.Text = "Cargar";
            this.btnCargardb.UseVisualStyleBackColor = true;
            this.btnCargardb.Click += new System.EventHandler(this.btnCargardb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tablas";
            // 
            // cboTablas
            // 
            this.cboTablas.FormattingEnabled = true;
            this.cboTablas.Location = new System.Drawing.Point(110, 57);
            this.cboTablas.Name = "cboTablas";
            this.cboTablas.Size = new System.Drawing.Size(156, 21);
            this.cboTablas.TabIndex = 0;
            // 
            // btnCargarTablas
            // 
            this.btnCargarTablas.Location = new System.Drawing.Point(272, 59);
            this.btnCargarTablas.Name = "btnCargarTablas";
            this.btnCargarTablas.Size = new System.Drawing.Size(55, 23);
            this.btnCargarTablas.TabIndex = 2;
            this.btnCargarTablas.Text = "Cargar";
            this.btnCargarTablas.UseVisualStyleBackColor = true;
            this.btnCargarTablas.Click += new System.EventHandler(this.btnCargarTablas_Click);
            // 
            // panel_data
            // 
            this.panel_data.Location = new System.Drawing.Point(25, 100);
            this.panel_data.Name = "panel_data";
            this.panel_data.Size = new System.Drawing.Size(321, 258);
            this.panel_data.TabIndex = 5;
            // 
            // Frmdatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 387);
            this.Controls.Add(this.panel_data);
            this.Controls.Add(this.btnCargarTablas);
            this.Controls.Add(this.btnCargardb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblbasedatos);
            this.Controls.Add(this.cboTablas);
            this.Controls.Add(this.cboBasedatos);
            this.Name = "Frmdatabase";
            this.Text = "Frmdatabase";
            this.Load += new System.EventHandler(this.Frmdatabase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBasedatos;
        private System.Windows.Forms.Label lblbasedatos;
        private System.Windows.Forms.Button btnCargardb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTablas;
        private System.Windows.Forms.Button btnCargarTablas;
        private System.Windows.Forms.Panel panel_data;
    }
}
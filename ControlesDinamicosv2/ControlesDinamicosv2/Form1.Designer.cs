namespace ControlesDinamicosv2
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_data = new System.Windows.Forms.Panel();
            this.btnCargarTablas = new System.Windows.Forms.Button();
            this.btnCargardb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblbasedatos = new System.Windows.Forms.Label();
            this.cboTablas = new System.Windows.Forms.ComboBox();
            this.cboBasedatos = new System.Windows.Forms.ComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel_data
            // 
            this.panel_data.Location = new System.Drawing.Point(108, 213);
            this.panel_data.Name = "panel_data";
            this.panel_data.Size = new System.Drawing.Size(321, 258);
            this.panel_data.TabIndex = 12;
            // 
            // btnCargarTablas
            // 
            this.btnCargarTablas.Location = new System.Drawing.Point(344, 75);
            this.btnCargarTablas.Name = "btnCargarTablas";
            this.btnCargarTablas.Size = new System.Drawing.Size(55, 23);
            this.btnCargarTablas.TabIndex = 10;
            this.btnCargarTablas.Text = "Cargar";
            this.btnCargarTablas.UseVisualStyleBackColor = true;
            this.btnCargarTablas.Click += new System.EventHandler(this.btnCargarTablas_Click);
            // 
            // btnCargardb
            // 
            this.btnCargardb.Location = new System.Drawing.Point(344, 44);
            this.btnCargardb.Name = "btnCargardb";
            this.btnCargardb.Size = new System.Drawing.Size(55, 23);
            this.btnCargardb.TabIndex = 11;
            this.btnCargardb.Text = "Cargar";
            this.btnCargardb.UseVisualStyleBackColor = true;
            this.btnCargardb.Click += new System.EventHandler(this.btnCargardb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tablas";
            // 
            // lblbasedatos
            // 
            this.lblbasedatos.AutoSize = true;
            this.lblbasedatos.Location = new System.Drawing.Point(94, 49);
            this.lblbasedatos.Name = "lblbasedatos";
            this.lblbasedatos.Size = new System.Drawing.Size(82, 13);
            this.lblbasedatos.TabIndex = 9;
            this.lblbasedatos.Text = "Bases de Datos";
            // 
            // cboTablas
            // 
            this.cboTablas.FormattingEnabled = true;
            this.cboTablas.Location = new System.Drawing.Point(182, 73);
            this.cboTablas.Name = "cboTablas";
            this.cboTablas.Size = new System.Drawing.Size(156, 21);
            this.cboTablas.TabIndex = 6;
            this.cboTablas.SelectedIndexChanged += new System.EventHandler(this.cboTablas_SelectedIndexChanged);
            // 
            // cboBasedatos
            // 
            this.cboBasedatos.FormattingEnabled = true;
            this.cboBasedatos.Location = new System.Drawing.Point(182, 46);
            this.cboBasedatos.Name = "cboBasedatos";
            this.cboBasedatos.Size = new System.Drawing.Size(156, 21);
            this.cboBasedatos.TabIndex = 7;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(388, 149);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnNext1
            // 
            this.btnNext1.Location = new System.Drawing.Point(280, 149);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(75, 23);
            this.btnNext1.TabIndex = 15;
            this.btnNext1.Text = ">";
            this.btnNext1.UseVisualStyleBackColor = true;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(178, 149);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 14;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(86, 149);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 13;
            this.btnPrev.Text = "<<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 502);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnNext1);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.panel_data);
            this.Controls.Add(this.btnCargarTablas);
            this.Controls.Add(this.btnCargardb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblbasedatos);
            this.Controls.Add(this.cboTablas);
            this.Controls.Add(this.cboBasedatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_data;
        private System.Windows.Forms.Button btnCargarTablas;
        private System.Windows.Forms.Button btnCargardb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblbasedatos;
        private System.Windows.Forms.ComboBox cboTablas;
        private System.Windows.Forms.ComboBox cboBasedatos;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnPrev;
    }
}


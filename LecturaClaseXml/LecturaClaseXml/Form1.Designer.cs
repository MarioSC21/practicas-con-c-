namespace LecturaClaseXml
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
            this.btnXml = new System.Windows.Forms.Button();
            this.btnXml2 = new System.Windows.Forms.Button();
            this.btnUpdateXml = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(144, 66);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(75, 23);
            this.btnXml.TabIndex = 0;
            this.btnXml.Text = "LeerXml";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // btnXml2
            // 
            this.btnXml2.Location = new System.Drawing.Point(144, 122);
            this.btnXml2.Name = "btnXml2";
            this.btnXml2.Size = new System.Drawing.Size(75, 23);
            this.btnXml2.TabIndex = 1;
            this.btnXml2.Text = "LeerXml2";
            this.btnXml2.UseVisualStyleBackColor = true;
            this.btnXml2.Click += new System.EventHandler(this.btnXml2_Click);
            // 
            // btnUpdateXml
            // 
            this.btnUpdateXml.Location = new System.Drawing.Point(618, 71);
            this.btnUpdateXml.Name = "btnUpdateXml";
            this.btnUpdateXml.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateXml.TabIndex = 2;
            this.btnUpdateXml.Text = "update Xml";
            this.btnUpdateXml.UseVisualStyleBackColor = true;
            this.btnUpdateXml.Click += new System.EventHandler(this.btnUpdateXml_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(364, 76);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(15, 13);
            this.id.TabIndex = 3;
            this.id.Text = "id";
            // 
            // telefono
            // 
            this.telefono.AutoSize = true;
            this.telefono.Location = new System.Drawing.Point(364, 153);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(45, 13);
            this.telefono.TabIndex = 4;
            this.telefono.Text = "telefono";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(453, 76);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(453, 153);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(618, 108);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "delete Xml";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(618, 153);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(75, 23);
            this.btninsertar.TabIndex = 8;
            this.btninsertar.Text = "insertar Xml";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(453, 111);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(364, 111);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(44, 13);
            this.nombre.TabIndex = 9;
            this.nombre.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.id);
            this.Controls.Add(this.btnUpdateXml);
            this.Controls.Add(this.btnXml2);
            this.Controls.Add(this.btnXml);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.Button btnXml2;
        private System.Windows.Forms.Button btnUpdateXml;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label telefono;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label nombre;
    }
}


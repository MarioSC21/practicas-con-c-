namespace Serialiacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSerie = new System.Windows.Forms.Button();
            this.btndeser = new System.Windows.Forms.Button();
            this.btnSerXml = new System.Windows.Forms.Button();
            this.btnDesSerXml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "celular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "email";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(107, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(107, 99);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(107, 139);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(107, 174);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // btnSerie
            // 
            this.btnSerie.Location = new System.Drawing.Point(297, 27);
            this.btnSerie.Name = "btnSerie";
            this.btnSerie.Size = new System.Drawing.Size(75, 23);
            this.btnSerie.TabIndex = 10;
            this.btnSerie.Text = "serializar";
            this.btnSerie.UseVisualStyleBackColor = true;
            this.btnSerie.Click += new System.EventHandler(this.btnSerie_Click);
            // 
            // btndeser
            // 
            this.btndeser.Location = new System.Drawing.Point(297, 68);
            this.btndeser.Name = "btndeser";
            this.btndeser.Size = new System.Drawing.Size(75, 23);
            this.btndeser.TabIndex = 11;
            this.btndeser.Text = "deserealizar";
            this.btndeser.UseVisualStyleBackColor = true;
            this.btndeser.Click += new System.EventHandler(this.btndeser_Click);
            // 
            // btnSerXml
            // 
            this.btnSerXml.Location = new System.Drawing.Point(297, 113);
            this.btnSerXml.Name = "btnSerXml";
            this.btnSerXml.Size = new System.Drawing.Size(75, 23);
            this.btnSerXml.TabIndex = 12;
            this.btnSerXml.Text = "ser Xml";
            this.btnSerXml.UseVisualStyleBackColor = true;
            this.btnSerXml.Click += new System.EventHandler(this.btnSerXml_Click);
            // 
            // btnDesSerXml
            // 
            this.btnDesSerXml.Location = new System.Drawing.Point(285, 163);
            this.btnDesSerXml.Name = "btnDesSerXml";
            this.btnDesSerXml.Size = new System.Drawing.Size(106, 27);
            this.btnDesSerXml.TabIndex = 13;
            this.btnDesSerXml.Text = "deserealizar Xml";
            this.btnDesSerXml.UseVisualStyleBackColor = true;
            this.btnDesSerXml.Click += new System.EventHandler(this.btnDesSerXml_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDesSerXml);
            this.Controls.Add(this.btnSerXml);
            this.Controls.Add(this.btndeser);
            this.Controls.Add(this.btnSerie);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSerie;
        private System.Windows.Forms.Button btndeser;
        private System.Windows.Forms.Button btnSerXml;
        private System.Windows.Forms.Button btnDesSerXml;
    }
}



namespace Lab_DataReader
{
    partial class BtnBuscar
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtModelo = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.ChkActivo = new System.Windows.Forms.CheckBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.DgvProducto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(121, 81);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(161, 20);
            this.TxtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marca";
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(121, 131);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(161, 20);
            this.TxtMarca.TabIndex = 4;
            this.TxtMarca.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modelo";
            // 
            // TxtModelo
            // 
            this.TxtModelo.Location = new System.Drawing.Point(121, 176);
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.Size = new System.Drawing.Size(161, 20);
            this.TxtModelo.TabIndex = 6;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(121, 42);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(82, 20);
            this.TxtCodigo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Codigo";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(139, 276);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(111, 30);
            this.BtnActualizar.TabIndex = 9;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(271, 276);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(111, 30);
            this.BtnEliminar.TabIndex = 10;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // ChkActivo
            // 
            this.ChkActivo.AutoSize = true;
            this.ChkActivo.Location = new System.Drawing.Point(271, 223);
            this.ChkActivo.Name = "ChkActivo";
            this.ChkActivo.Size = new System.Drawing.Size(56, 17);
            this.ChkActivo.TabIndex = 11;
            this.ChkActivo.Text = "Activo";
            this.ChkActivo.UseVisualStyleBackColor = true;
            // 
            // DatePicker
            // 
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(128, 223);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(97, 20);
            this.DatePicker.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha de Fabricacion";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DgvProducto
            // 
            this.DgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProducto.Location = new System.Drawing.Point(15, 337);
            this.DgvProducto.Name = "DgvProducto";
            this.DgvProducto.Size = new System.Drawing.Size(367, 267);
            this.DgvProducto.TabIndex = 15;
            // 
            // BtnBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 640);
            this.Controls.Add(this.DgvProducto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.ChkActivo);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "BtnBuscar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtModelo;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.CheckBox ChkActivo;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DgvProducto;
    }
}


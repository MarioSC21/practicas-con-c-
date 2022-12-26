
namespace Lab_DataReader
{
    partial class FrmBuscar
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
            this.DgvProducto = new System.Windows.Forms.DataGridView();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProducto
            // 
            this.DgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProducto.Location = new System.Drawing.Point(30, 12);
            this.DgvProducto.Name = "DgvProducto";
            this.DgvProducto.Size = new System.Drawing.Size(367, 267);
            this.DgvProducto.TabIndex = 16;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(50, 319);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 17;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(250, 319);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 18;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 381);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.DgvProducto);
            this.Name = "FrmBuscar";
            this.Text = "Aceptar";
            this.Load += new System.EventHandler(this.FrmBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProducto;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}
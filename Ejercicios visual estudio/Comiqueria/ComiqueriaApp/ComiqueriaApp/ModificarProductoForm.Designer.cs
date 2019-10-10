namespace ComiqueriaApp
{
    partial class ModificarProductoForm
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecioActual = new System.Windows.Forms.Label();
            this.txtPrecioActual = new System.Windows.Forms.TextBox();
            this.lblNuevoPrecio = new System.Windows.Forms.Label();
            this.txtNuevoPrecio = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(12, 9);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(206, 37);
            this.lblDescripcion.TabIndex = 1;
            // 
            // lblPrecioActual
            // 
            this.lblPrecioActual.AutoSize = true;
            this.lblPrecioActual.Location = new System.Drawing.Point(12, 60);
            this.lblPrecioActual.Name = "lblPrecioActual";
            this.lblPrecioActual.Size = new System.Drawing.Size(73, 13);
            this.lblPrecioActual.TabIndex = 2;
            this.lblPrecioActual.Text = "Precio Actual:";
            // 
            // txtPrecioActual
            // 
            this.txtPrecioActual.Location = new System.Drawing.Point(13, 77);
            this.txtPrecioActual.Name = "txtPrecioActual";
            this.txtPrecioActual.ReadOnly = true;
            this.txtPrecioActual.Size = new System.Drawing.Size(205, 20);
            this.txtPrecioActual.TabIndex = 3;
            // 
            // lblNuevoPrecio
            // 
            this.lblNuevoPrecio.AutoSize = true;
            this.lblNuevoPrecio.Location = new System.Drawing.Point(12, 112);
            this.lblNuevoPrecio.Name = "lblNuevoPrecio";
            this.lblNuevoPrecio.Size = new System.Drawing.Size(75, 13);
            this.lblNuevoPrecio.TabIndex = 4;
            this.lblNuevoPrecio.Text = "Nuevo Precio:";
            // 
            // txtNuevoPrecio
            // 
            this.txtNuevoPrecio.Location = new System.Drawing.Point(12, 128);
            this.txtNuevoPrecio.Name = "txtNuevoPrecio";
            this.txtNuevoPrecio.Size = new System.Drawing.Size(206, 20);
            this.txtNuevoPrecio.TabIndex = 5;
            this.txtNuevoPrecio.TextChanged += new System.EventHandler(this.TxtNuevoPrecio_TextChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(12, 187);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(119, 187);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 151);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 8;
            // 
            // ModificarProductoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 222);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtNuevoPrecio);
            this.Controls.Add(this.lblNuevoPrecio);
            this.Controls.Add(this.txtPrecioActual);
            this.Controls.Add(this.lblPrecioActual);
            this.Controls.Add(this.lblDescripcion);
            this.Name = "ModificarProductoForm";
            this.Text = "ModificarProductoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecioActual;
        private System.Windows.Forms.TextBox txtPrecioActual;
        private System.Windows.Forms.Label lblNuevoPrecio;
        private System.Windows.Forms.TextBox txtNuevoPrecio;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblError;
    }
}
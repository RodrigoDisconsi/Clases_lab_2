namespace FrmCantina
{
    partial class FrmCantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCantina));
            this.rbCerveza = new System.Windows.Forms.RadioButton();
            this.rbAgua = new System.Windows.Forms.RadioButton();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.numericCapacidad = new System.Windows.Forms.NumericUpDown();
            this.numericContenido = new System.Windows.Forms.NumericUpDown();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.barra1 = new ControlCantina.Barra();
            ((System.ComponentModel.ISupportInitialize)(this.numericCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // rbCerveza
            // 
            this.rbCerveza.AutoSize = true;
            this.rbCerveza.Location = new System.Drawing.Point(12, 397);
            this.rbCerveza.Name = "rbCerveza";
            this.rbCerveza.Size = new System.Drawing.Size(64, 17);
            this.rbCerveza.TabIndex = 1;
            this.rbCerveza.TabStop = true;
            this.rbCerveza.Text = "Cerveza";
            this.rbCerveza.UseVisualStyleBackColor = true;
            // 
            // rbAgua
            // 
            this.rbAgua.AutoSize = true;
            this.rbAgua.Location = new System.Drawing.Point(12, 429);
            this.rbAgua.Name = "rbAgua";
            this.rbAgua.Size = new System.Drawing.Size(50, 17);
            this.rbAgua.TabIndex = 2;
            this.rbAgua.TabStop = true;
            this.rbAgua.Text = "Agua";
            this.rbAgua.UseVisualStyleBackColor = true;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(191, 397);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(194, 413);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 4;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(191, 436);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 5;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(265, 436);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(55, 13);
            this.lblContenido.TabIndex = 6;
            this.lblContenido.Text = "Contenido";
            // 
            // numericCapacidad
            // 
            this.numericCapacidad.Location = new System.Drawing.Point(194, 452);
            this.numericCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCapacidad.Name = "numericCapacidad";
            this.numericCapacidad.Size = new System.Drawing.Size(45, 20);
            this.numericCapacidad.TabIndex = 7;
            this.numericCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericContenido
            // 
            this.numericContenido.Location = new System.Drawing.Point(268, 452);
            this.numericContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericContenido.Name = "numericContenido";
            this.numericContenido.Size = new System.Drawing.Size(45, 20);
            this.numericContenido.TabIndex = 8;
            this.numericContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(403, 412);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 9;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(400, 396);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(66, 13);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Botella Tipo:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(403, 439);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(145, 42);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(11, 12);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(552, 368);
            this.barra1.TabIndex = 0;
            // 
            // FrmCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 493);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.numericContenido);
            this.Controls.Add(this.numericCapacidad);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.rbAgua);
            this.Controls.Add(this.rbCerveza);
            this.Controls.Add(this.barra1);
            this.Name = "FrmCantina";
            this.Text = "Franco Rodrigo Disconsi 2C.";
            this.Load += new System.EventHandler(this.FrmCantina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericContenido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlCantina.Barra barra1;
        private System.Windows.Forms.RadioButton rbCerveza;
        private System.Windows.Forms.RadioButton rbAgua;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.NumericUpDown numericCapacidad;
        private System.Windows.Forms.NumericUpDown numericContenido;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnAgregar;
    }
}


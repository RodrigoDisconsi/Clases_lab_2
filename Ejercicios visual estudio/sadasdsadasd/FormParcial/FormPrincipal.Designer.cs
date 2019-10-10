namespace FormParcial
{
    partial class FormPrincipal
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombrePlaneta = new System.Windows.Forms.TextBox();
            this.txtOrbitaPlaneta = new System.Windows.Forms.TextBox();
            this.txtNombreSatelite = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnAgregarPlaneta = new System.Windows.Forms.Button();
            this.btnAgregarSatelite = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnMoverAstros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de planeta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiempo en completar orbita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiempo en completar rotacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de lunas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de planeta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Planeta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre del satélite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tiempo en ejecutar orbita";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(346, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tiempo en ejecutar rotación";
            // 
            // txtNombrePlaneta
            // 
            this.txtNombrePlaneta.Location = new System.Drawing.Point(168, 29);
            this.txtNombrePlaneta.Name = "txtNombrePlaneta";
            this.txtNombrePlaneta.Size = new System.Drawing.Size(155, 20);
            this.txtNombrePlaneta.TabIndex = 9;
            // 
            // txtOrbitaPlaneta
            // 
            this.txtOrbitaPlaneta.Location = new System.Drawing.Point(168, 66);
            this.txtOrbitaPlaneta.Name = "txtOrbitaPlaneta";
            this.txtOrbitaPlaneta.Size = new System.Drawing.Size(155, 20);
            this.txtOrbitaPlaneta.TabIndex = 10;
            // 
            // txtNombreSatelite
            // 
            this.txtNombreSatelite.Location = new System.Drawing.Point(518, 63);
            this.txtNombreSatelite.Name = "txtNombreSatelite";
            this.txtNombreSatelite.Size = new System.Drawing.Size(155, 20);
            this.txtNombreSatelite.TabIndex = 11;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(168, 181);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(155, 21);
            this.cmbTipo.TabIndex = 12;
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(518, 26);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(155, 21);
            this.cmbPlanetas.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(168, 102);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(155, 20);
            this.numericUpDown1.TabIndex = 14;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(168, 138);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(155, 20);
            this.numericUpDown2.TabIndex = 15;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(518, 102);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(155, 20);
            this.numericUpDown3.TabIndex = 16;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(518, 138);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(155, 20);
            this.numericUpDown4.TabIndex = 17;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(723, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(250, 426);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // btnAgregarPlaneta
            // 
            this.btnAgregarPlaneta.Location = new System.Drawing.Point(15, 237);
            this.btnAgregarPlaneta.Name = "btnAgregarPlaneta";
            this.btnAgregarPlaneta.Size = new System.Drawing.Size(308, 58);
            this.btnAgregarPlaneta.TabIndex = 19;
            this.btnAgregarPlaneta.Text = "Agregar Planeta";
            this.btnAgregarPlaneta.UseVisualStyleBackColor = true;
            this.btnAgregarPlaneta.Click += new System.EventHandler(this.BtnAgregarPlaneta_Click);
            // 
            // btnAgregarSatelite
            // 
            this.btnAgregarSatelite.Location = new System.Drawing.Point(365, 237);
            this.btnAgregarSatelite.Name = "btnAgregarSatelite";
            this.btnAgregarSatelite.Size = new System.Drawing.Size(308, 58);
            this.btnAgregarSatelite.TabIndex = 20;
            this.btnAgregarSatelite.Text = "Agregar Satelite";
            this.btnAgregarSatelite.UseVisualStyleBackColor = true;
            this.btnAgregarSatelite.Click += new System.EventHandler(this.BtnAgregarSatelite_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(15, 301);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(658, 65);
            this.btnInfo.TabIndex = 21;
            this.btnInfo.Text = "Mostrar Informacion";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnMoverAstros
            // 
            this.btnMoverAstros.Location = new System.Drawing.Point(15, 373);
            this.btnMoverAstros.Name = "btnMoverAstros";
            this.btnMoverAstros.Size = new System.Drawing.Size(658, 65);
            this.btnMoverAstros.TabIndex = 22;
            this.btnMoverAstros.Text = "Mover Astros";
            this.btnMoverAstros.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 450);
            this.Controls.Add(this.btnMoverAstros);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnAgregarSatelite);
            this.Controls.Add(this.btnAgregarPlaneta);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cmbPlanetas);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtNombreSatelite);
            this.Controls.Add(this.txtOrbitaPlaneta);
            this.Controls.Add(this.txtNombrePlaneta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombrePlaneta;
        private System.Windows.Forms.TextBox txtOrbitaPlaneta;
        private System.Windows.Forms.TextBox txtNombreSatelite;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnAgregarPlaneta;
        private System.Windows.Forms.Button btnAgregarSatelite;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnMoverAstros;
    }
}


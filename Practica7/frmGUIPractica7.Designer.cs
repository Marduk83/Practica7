namespace Practica7
{
    partial class frmGUIPractica7
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudNumHExtras = new System.Windows.Forms.NumericUpDown();
            this.lblHExtras = new System.Windows.Forms.Label();
            this.nudNumTrienios = new System.Windows.Forms.NumericUpDown();
            this.lblTrienios = new System.Windows.Forms.Label();
            this.nudNumHijos = new System.Windows.Forms.NumericUpDown();
            this.lblHijos = new System.Windows.Forms.Label();
            this.nudCategoria = new System.Windows.Forms.NumericUpDown();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNif = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPeriodoLiquidacion = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumHExtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumTrienios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumHijos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lblPeriodoLiquidacion);
            this.groupBox1.Controls.Add(this.nudNumHExtras);
            this.groupBox1.Controls.Add(this.lblHExtras);
            this.groupBox1.Controls.Add(this.nudNumTrienios);
            this.groupBox1.Controls.Add(this.lblTrienios);
            this.groupBox1.Controls.Add(this.nudNumHijos);
            this.groupBox1.Controls.Add(this.lblHijos);
            this.groupBox1.Controls.Add(this.nudCategoria);
            this.groupBox1.Controls.Add(this.lblCategoria);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtNif);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblNif);
            this.groupBox1.Location = new System.Drawing.Point(16, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // nudNumHExtras
            // 
            this.nudNumHExtras.Location = new System.Drawing.Point(488, 104);
            this.nudNumHExtras.Name = "nudNumHExtras";
            this.nudNumHExtras.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudNumHExtras.Size = new System.Drawing.Size(40, 20);
            this.nudNumHExtras.TabIndex = 11;
            this.nudNumHExtras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclasPulsadas);
            // 
            // lblHExtras
            // 
            this.lblHExtras.AutoSize = true;
            this.lblHExtras.Location = new System.Drawing.Point(400, 112);
            this.lblHExtras.Name = "lblHExtras";
            this.lblHExtras.Size = new System.Drawing.Size(79, 13);
            this.lblHExtras.TabIndex = 10;
            this.lblHExtras.Text = "Nº horas extras";
            // 
            // nudNumTrienios
            // 
            this.nudNumTrienios.Location = new System.Drawing.Point(328, 104);
            this.nudNumTrienios.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudNumTrienios.Name = "nudNumTrienios";
            this.nudNumTrienios.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudNumTrienios.Size = new System.Drawing.Size(40, 20);
            this.nudNumTrienios.TabIndex = 9;
            this.nudNumTrienios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclasPulsadas);
            // 
            // lblTrienios
            // 
            this.lblTrienios.AutoSize = true;
            this.lblTrienios.Location = new System.Drawing.Point(264, 112);
            this.lblTrienios.Name = "lblTrienios";
            this.lblTrienios.Size = new System.Drawing.Size(59, 13);
            this.lblTrienios.TabIndex = 8;
            this.lblTrienios.Text = "Nº Trienios";
            // 
            // nudNumHijos
            // 
            this.nudNumHijos.Location = new System.Drawing.Point(192, 104);
            this.nudNumHijos.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudNumHijos.Name = "nudNumHijos";
            this.nudNumHijos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudNumHijos.Size = new System.Drawing.Size(40, 20);
            this.nudNumHijos.TabIndex = 7;
            this.nudNumHijos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclasPulsadas);
            // 
            // lblHijos
            // 
            this.lblHijos.AutoSize = true;
            this.lblHijos.Location = new System.Drawing.Point(144, 112);
            this.lblHijos.Name = "lblHijos";
            this.lblHijos.Size = new System.Drawing.Size(45, 13);
            this.lblHijos.TabIndex = 6;
            this.lblHijos.Text = "Nº Hijos";
            // 
            // nudCategoria
            // 
            this.nudCategoria.Location = new System.Drawing.Point(72, 104);
            this.nudCategoria.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudCategoria.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCategoria.Name = "nudCategoria";
            this.nudCategoria.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudCategoria.Size = new System.Drawing.Size(40, 20);
            this.nudCategoria.TabIndex = 5;
            this.nudCategoria.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCategoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclasPulsadas);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(16, 112);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoría";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(72, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclasPulsadas);
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(72, 24);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(100, 20);
            this.txtNif.TabIndex = 2;
            this.txtNif.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclasPulsadas);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 72);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Location = new System.Drawing.Point(16, 32);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(24, 13);
            this.lblNif.TabIndex = 0;
            this.lblNif.Text = "NIF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CÁLCULO DE HOJA SALARIAL. INTRODUZCA SUS DATOS Y PULSE EL BOTÓN CALCULAR. ";
            // 
            // lblPeriodoLiquidacion
            // 
            this.lblPeriodoLiquidacion.AutoSize = true;
            this.lblPeriodoLiquidacion.Location = new System.Drawing.Point(16, 144);
            this.lblPeriodoLiquidacion.Name = "lblPeriodoLiquidacion";
            this.lblPeriodoLiquidacion.Size = new System.Drawing.Size(147, 13);
            this.lblPeriodoLiquidacion.TabIndex = 12;
            this.lblPeriodoLiquidacion.Text = "Periodo liquidación(mm/aaaa)";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "\"mm yyyy\"";
            this.dateTimePicker1.Location = new System.Drawing.Point(168, 136);
            this.dateTimePicker1.MaxDate = new System.DateTime(2016, 6, 13, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2016, 6, 13, 0, 0, 0, 0);
            // 
            // frmGUIPractica7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGUIPractica7";
            this.Text = "Practica 7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumHExtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumTrienios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumHijos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.NumericUpDown nudNumTrienios;
        private System.Windows.Forms.Label lblTrienios;
        private System.Windows.Forms.NumericUpDown nudNumHijos;
        private System.Windows.Forms.Label lblHijos;
        private System.Windows.Forms.NumericUpDown nudNumHExtras;
        private System.Windows.Forms.Label lblHExtras;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblPeriodoLiquidacion;
    }
}


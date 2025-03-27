namespace LaboratorioRepaso1
{
    partial class FormAsistencia
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
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEmpleados = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericHoras = new System.Windows.Forms.NumericUpDown();
            this.numericMes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(665, 377);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(110, 45);
            this.buttonCerrar.TabIndex = 0;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empleado";
            // 
            // comboBoxEmpleados
            // 
            this.comboBoxEmpleados.FormattingEnabled = true;
            this.comboBoxEmpleados.Location = new System.Drawing.Point(175, 69);
            this.comboBoxEmpleados.Name = "comboBoxEmpleados";
            this.comboBoxEmpleados.Size = new System.Drawing.Size(343, 21);
            this.comboBoxEmpleados.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Horas Trabajadas";
            // 
            // numericHoras
            // 
            this.numericHoras.Location = new System.Drawing.Point(175, 152);
            this.numericHoras.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericHoras.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHoras.Name = "numericHoras";
            this.numericHoras.Size = new System.Drawing.Size(69, 20);
            this.numericHoras.TabIndex = 4;
            this.numericHoras.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericMes
            // 
            this.numericMes.Location = new System.Drawing.Point(175, 232);
            this.numericMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMes.Name = "numericMes";
            this.numericMes.Size = new System.Drawing.Size(69, 20);
            this.numericMes.TabIndex = 5;
            this.numericMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mes";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(175, 322);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(170, 56);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "Guardar Asistencia";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // FormAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericMes);
            this.Controls.Add(this.numericHoras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEmpleados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCerrar);
            this.Name = "FormAsistencia";
            this.Text = "Asistencia";
            this.Load += new System.EventHandler(this.FormAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEmpleados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericHoras;
        private System.Windows.Forms.NumericUpDown numericMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGuardar;
    }
}
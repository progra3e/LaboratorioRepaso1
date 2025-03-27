namespace LaboratorioRepaso1
{
    partial class FormEmpleado
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
            this.buttonAsistencia = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.numericNoEmpleado = new System.Windows.Forms.NumericUpDown();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.maskedTextBoxSueldo = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericNoEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAsistencia
            // 
            this.buttonAsistencia.Location = new System.Drawing.Point(605, 504);
            this.buttonAsistencia.Name = "buttonAsistencia";
            this.buttonAsistencia.Size = new System.Drawing.Size(125, 55);
            this.buttonAsistencia.TabIndex = 0;
            this.buttonAsistencia.Text = "Ir Asistencia";
            this.buttonAsistencia.UseVisualStyleBackColor = true;
            this.buttonAsistencia.Click += new System.EventHandler(this.buttonAsistencia_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(928, 509);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(172, 44);
            this.buttonCerrar.TabIndex = 1;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "No. de Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sueldo x Hora";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(171, 116);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(276, 20);
            this.textBoxNombre.TabIndex = 6;
            // 
            // numericNoEmpleado
            // 
            this.numericNoEmpleado.Location = new System.Drawing.Point(171, 52);
            this.numericNoEmpleado.Name = "numericNoEmpleado";
            this.numericNoEmpleado.Size = new System.Drawing.Size(120, 20);
            this.numericNoEmpleado.TabIndex = 8;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(59, 260);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(181, 42);
            this.buttonGuardar.TabIndex = 9;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // maskedTextBoxSueldo
            // 
            this.maskedTextBoxSueldo.Location = new System.Drawing.Point(171, 190);
            this.maskedTextBoxSueldo.Mask = "999.99";
            this.maskedTextBoxSueldo.Name = "maskedTextBoxSueldo";
            this.maskedTextBoxSueldo.Size = new System.Drawing.Size(45, 20);
            this.maskedTextBoxSueldo.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(605, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 266);
            this.dataGridView1.TabIndex = 11;
            // 
            // buttonReporte
            // 
            this.buttonReporte.Location = new System.Drawing.Point(752, 504);
            this.buttonReporte.Name = "buttonReporte";
            this.buttonReporte.Size = new System.Drawing.Size(140, 55);
            this.buttonReporte.TabIndex = 12;
            this.buttonReporte.Text = "Ir a Reporte";
            this.buttonReporte.UseVisualStyleBackColor = true;
            this.buttonReporte.Click += new System.EventHandler(this.buttonReporte_Click);
            // 
            // FormEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 591);
            this.Controls.Add(this.buttonReporte);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.maskedTextBoxSueldo);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.numericNoEmpleado);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonAsistencia);
            this.Name = "FormEmpleado";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericNoEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAsistencia;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.NumericUpDown numericNoEmpleado;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSueldo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonReporte;
    }
}


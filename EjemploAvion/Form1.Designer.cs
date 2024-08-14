namespace EjemploAvion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxModelo = new TextBox();
            label2 = new Label();
            numericUpDownTiempoDeServicio = new NumericUpDown();
            activo = new RadioButton();
            noActivo = new RadioButton();
            groupBoxActivo = new GroupBox();
            label3 = new Label();
            textBoxAniosDeServicio = new TextBox();
            label4 = new Label();
            textBoxCantidadPasajeros = new TextBox();
            label5 = new Label();
            dateTimePickerPrimerVuelo = new DateTimePicker();
            button1 = new Button();
            tablaAviones = new DataGridView();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTiempoDeServicio).BeginInit();
            groupBoxActivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaAviones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 61);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Modelo";
            // 
            // textBoxModelo
            // 
            textBoxModelo.Location = new Point(220, 58);
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.Size = new Size(100, 23);
            textBoxModelo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 102);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 0;
            label2.Text = "Tiempo de servicio";
            // 
            // numericUpDownTiempoDeServicio
            // 
            numericUpDownTiempoDeServicio.Location = new Point(220, 100);
            numericUpDownTiempoDeServicio.Name = "numericUpDownTiempoDeServicio";
            numericUpDownTiempoDeServicio.Size = new Size(120, 23);
            numericUpDownTiempoDeServicio.TabIndex = 2;
            // 
            // activo
            // 
            activo.AutoSize = true;
            activo.Location = new Point(14, 22);
            activo.Name = "activo";
            activo.Size = new Size(34, 19);
            activo.TabIndex = 3;
            activo.TabStop = true;
            activo.Text = "SI";
            activo.UseVisualStyleBackColor = true;
            // 
            // noActivo
            // 
            noActivo.AutoSize = true;
            noActivo.Location = new Point(93, 22);
            noActivo.Name = "noActivo";
            noActivo.Size = new Size(43, 19);
            noActivo.TabIndex = 3;
            noActivo.TabStop = true;
            noActivo.Text = "NO";
            noActivo.UseVisualStyleBackColor = true;
            // 
            // groupBoxActivo
            // 
            groupBoxActivo.Controls.Add(activo);
            groupBoxActivo.Controls.Add(noActivo);
            groupBoxActivo.Location = new Point(98, 142);
            groupBoxActivo.Name = "groupBoxActivo";
            groupBoxActivo.Size = new Size(200, 66);
            groupBoxActivo.TabIndex = 5;
            groupBoxActivo.TabStop = false;
            groupBoxActivo.Text = "Está activo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(374, 66);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 0;
            label3.Text = "Años de servicio";
            // 
            // textBoxAniosDeServicio
            // 
            textBoxAniosDeServicio.Location = new Point(482, 63);
            textBoxAniosDeServicio.Name = "textBoxAniosDeServicio";
            textBoxAniosDeServicio.Size = new Size(53, 23);
            textBoxAniosDeServicio.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 102);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 0;
            label4.Text = "Cantidad pasajeros";
            // 
            // textBoxCantidadPasajeros
            // 
            textBoxCantidadPasajeros.Location = new Point(482, 99);
            textBoxCantidadPasajeros.Name = "textBoxCantidadPasajeros";
            textBoxCantidadPasajeros.Size = new Size(53, 23);
            textBoxCantidadPasajeros.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(329, 166);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 0;
            label5.Text = "PrimerVuelo";
            // 
            // dateTimePickerPrimerVuelo
            // 
            dateTimePickerPrimerVuelo.Location = new Point(442, 164);
            dateTimePickerPrimerVuelo.Name = "dateTimePickerPrimerVuelo";
            dateTimePickerPrimerVuelo.Size = new Size(160, 23);
            dateTimePickerPrimerVuelo.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(292, 243);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tablaAviones
            // 
            tablaAviones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaAviones.Location = new Point(89, 288);
            tablaAviones.Name = "tablaAviones";
            tablaAviones.RowTemplate.Height = 25;
            tablaAviones.Size = new Size(504, 150);
            tablaAviones.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(485, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 450);
            Controls.Add(dataGridView1);
            Controls.Add(tablaAviones);
            Controls.Add(button1);
            Controls.Add(dateTimePickerPrimerVuelo);
            Controls.Add(groupBoxActivo);
            Controls.Add(numericUpDownTiempoDeServicio);
            Controls.Add(textBoxCantidadPasajeros);
            Controls.Add(textBoxAniosDeServicio);
            Controls.Add(textBoxModelo);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownTiempoDeServicio).EndInit();
            groupBoxActivo.ResumeLayout(false);
            groupBoxActivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaAviones).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxModelo;
        private Label label2;
        private NumericUpDown numericUpDownTiempoDeServicio;
        private RadioButton activo;
        private RadioButton noActivo;
        private GroupBox groupBoxActivo;
        private Label label3;
        private TextBox textBoxAniosDeServicio;
        private Label label4;
        private TextBox textBoxCantidadPasajeros;
        private Label label5;
        private DateTimePicker dateTimePickerPrimerVuelo;
        private Button button1;
        private DataGridView tablaAviones;
        private DataGridView dataGridView1;
    }
}
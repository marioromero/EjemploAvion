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
            ((System.ComponentModel.ISupportInitialize)numericUpDownTiempoDeServicio).BeginInit();
            groupBoxActivo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 81);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Modelo";
            // 
            // textBoxModelo
            // 
            textBoxModelo.Location = new Point(251, 77);
            textBoxModelo.Margin = new Padding(3, 4, 3, 4);
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.Size = new Size(114, 27);
            textBoxModelo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 136);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 0;
            label2.Text = "Tiempo de servicio";
            // 
            // numericUpDownTiempoDeServicio
            // 
            numericUpDownTiempoDeServicio.Location = new Point(251, 133);
            numericUpDownTiempoDeServicio.Margin = new Padding(3, 4, 3, 4);
            numericUpDownTiempoDeServicio.Name = "numericUpDownTiempoDeServicio";
            numericUpDownTiempoDeServicio.Size = new Size(137, 27);
            numericUpDownTiempoDeServicio.TabIndex = 2;
            // 
            // activo
            // 
            activo.AutoSize = true;
            activo.Location = new Point(16, 29);
            activo.Margin = new Padding(3, 4, 3, 4);
            activo.Name = "activo";
            activo.Size = new Size(42, 24);
            activo.TabIndex = 3;
            activo.TabStop = true;
            activo.Text = "SI";
            activo.UseVisualStyleBackColor = true;
            // 
            // noActivo
            // 
            noActivo.AutoSize = true;
            noActivo.Location = new Point(106, 29);
            noActivo.Margin = new Padding(3, 4, 3, 4);
            noActivo.Name = "noActivo";
            noActivo.Size = new Size(52, 24);
            noActivo.TabIndex = 3;
            noActivo.TabStop = true;
            noActivo.Text = "NO";
            noActivo.UseVisualStyleBackColor = true;
            // 
            // groupBoxActivo
            // 
            groupBoxActivo.Controls.Add(activo);
            groupBoxActivo.Controls.Add(noActivo);
            groupBoxActivo.Location = new Point(112, 189);
            groupBoxActivo.Margin = new Padding(3, 4, 3, 4);
            groupBoxActivo.Name = "groupBoxActivo";
            groupBoxActivo.Padding = new Padding(3, 4, 3, 4);
            groupBoxActivo.Size = new Size(229, 88);
            groupBoxActivo.TabIndex = 5;
            groupBoxActivo.TabStop = false;
            groupBoxActivo.Text = "Está activo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(427, 88);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 0;
            label3.Text = "Años de servicio";
            // 
            // textBoxAniosDeServicio
            // 
            textBoxAniosDeServicio.Location = new Point(551, 84);
            textBoxAniosDeServicio.Margin = new Padding(3, 4, 3, 4);
            textBoxAniosDeServicio.Name = "textBoxAniosDeServicio";
            textBoxAniosDeServicio.Size = new Size(60, 27);
            textBoxAniosDeServicio.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(411, 136);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 0;
            label4.Text = "Cantidad pasajeros";
            // 
            // textBoxCantidadPasajeros
            // 
            textBoxCantidadPasajeros.Location = new Point(551, 132);
            textBoxCantidadPasajeros.Margin = new Padding(3, 4, 3, 4);
            textBoxCantidadPasajeros.Name = "textBoxCantidadPasajeros";
            textBoxCantidadPasajeros.Size = new Size(60, 27);
            textBoxCantidadPasajeros.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(376, 221);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 0;
            label5.Text = "PrimerVuelo";
            // 
            // dateTimePickerPrimerVuelo
            // 
            dateTimePickerPrimerVuelo.Location = new Point(505, 219);
            dateTimePickerPrimerVuelo.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerPrimerVuelo.Name = "dateTimePickerPrimerVuelo";
            dateTimePickerPrimerVuelo.Size = new Size(182, 27);
            dateTimePickerPrimerVuelo.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(333, 345);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 7;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 600);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownTiempoDeServicio).EndInit();
            groupBoxActivo.ResumeLayout(false);
            groupBoxActivo.PerformLayout();
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
    }
}
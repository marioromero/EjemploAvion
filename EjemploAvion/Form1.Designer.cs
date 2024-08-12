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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownTiempoDeServicio = new System.Windows.Forms.NumericUpDown();
            this.SI = new System.Windows.Forms.RadioButton();
            this.NO = new System.Windows.Forms.RadioButton();
            this.groupBoxActivo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAniosDeServicio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCantidadPasajeros = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerPrimerVuelo = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTiempoDeServicio)).BeginInit();
            this.groupBoxActivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(220, 58);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(100, 23);
            this.textBoxModelo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tiempo de servicio";
            // 
            // numericUpDownTiempoDeServicio
            // 
            this.numericUpDownTiempoDeServicio.Location = new System.Drawing.Point(220, 100);
            this.numericUpDownTiempoDeServicio.Name = "numericUpDownTiempoDeServicio";
            this.numericUpDownTiempoDeServicio.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownTiempoDeServicio.TabIndex = 2;
            // 
            // SI
            // 
            this.SI.AutoSize = true;
            this.SI.Location = new System.Drawing.Point(14, 22);
            this.SI.Name = "SI";
            this.SI.Size = new System.Drawing.Size(34, 19);
            this.SI.TabIndex = 3;
            this.SI.TabStop = true;
            this.SI.Text = "SI";
            this.SI.UseVisualStyleBackColor = true;
            // 
            // NO
            // 
            this.NO.AutoSize = true;
            this.NO.Location = new System.Drawing.Point(71, 22);
            this.NO.Name = "NO";
            this.NO.Size = new System.Drawing.Size(43, 19);
            this.NO.TabIndex = 3;
            this.NO.TabStop = true;
            this.NO.Text = "NO";
            this.NO.UseVisualStyleBackColor = true;
            // 
            // groupBoxActivo
            // 
            this.groupBoxActivo.Controls.Add(this.SI);
            this.groupBoxActivo.Controls.Add(this.NO);
            this.groupBoxActivo.Location = new System.Drawing.Point(98, 142);
            this.groupBoxActivo.Name = "groupBoxActivo";
            this.groupBoxActivo.Size = new System.Drawing.Size(200, 66);
            this.groupBoxActivo.TabIndex = 5;
            this.groupBoxActivo.TabStop = false;
            this.groupBoxActivo.Text = "Está activo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Años de servicio";
            // 
            // textBoxAniosDeServicio
            // 
            this.textBoxAniosDeServicio.Location = new System.Drawing.Point(482, 63);
            this.textBoxAniosDeServicio.Name = "textBoxAniosDeServicio";
            this.textBoxAniosDeServicio.Size = new System.Drawing.Size(53, 23);
            this.textBoxAniosDeServicio.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad pasajeros";
            // 
            // textBoxCantidadPasajeros
            // 
            this.textBoxCantidadPasajeros.Location = new System.Drawing.Point(482, 99);
            this.textBoxCantidadPasajeros.Name = "textBoxCantidadPasajeros";
            this.textBoxCantidadPasajeros.Size = new System.Drawing.Size(53, 23);
            this.textBoxCantidadPasajeros.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "PrimerVuelo";
            // 
            // dateTimePickerPrimerVuelo
            // 
            this.dateTimePickerPrimerVuelo.Location = new System.Drawing.Point(442, 164);
            this.dateTimePickerPrimerVuelo.Name = "dateTimePickerPrimerVuelo";
            this.dateTimePickerPrimerVuelo.Size = new System.Drawing.Size(160, 23);
            this.dateTimePickerPrimerVuelo.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerPrimerVuelo);
            this.Controls.Add(this.groupBoxActivo);
            this.Controls.Add(this.numericUpDownTiempoDeServicio);
            this.Controls.Add(this.textBoxCantidadPasajeros);
            this.Controls.Add(this.textBoxAniosDeServicio);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTiempoDeServicio)).EndInit();
            this.groupBoxActivo.ResumeLayout(false);
            this.groupBoxActivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxModelo;
        private Label label2;
        private NumericUpDown numericUpDownTiempoDeServicio;
        private RadioButton SI;
        private RadioButton NO;
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
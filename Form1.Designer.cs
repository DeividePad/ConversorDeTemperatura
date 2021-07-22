
namespace ConversorDeTemperatura
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
            this.Temperatura = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.rbTCelsius = new System.Windows.Forms.RadioButton();
            this.rbTKelvins = new System.Windows.Forms.RadioButton();
            this.rbTFahrenheit = new System.Windows.Forms.RadioButton();
            this.btnConverter = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.rbRCelsius = new System.Windows.Forms.RadioButton();
            this.rbRKelvins = new System.Windows.Forms.RadioButton();
            this.rbRFahrenheit = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.grbEntrada = new System.Windows.Forms.GroupBox();
            this.grbSaida = new System.Windows.Forms.GroupBox();
            this.grbSaida.SuspendLayout();
            this.SuspendLayout();
            // 
            // Temperatura
            // 
            this.Temperatura.AutoSize = true;
            this.Temperatura.Location = new System.Drawing.Point(106, 63);
            this.Temperatura.Name = "Temperatura";
            this.Temperatura.Size = new System.Drawing.Size(126, 19);
            this.Temperatura.TabIndex = 0;
            this.Temperatura.Text = "Temperatura :";
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Futura Md BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Resultado.Location = new System.Drawing.Point(108, 457);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(130, 25);
            this.Resultado.TabIndex = 0;
            this.Resultado.Text = "Resultado :";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(241, 60);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(95, 27);
            this.txtTemperatura.TabIndex = 1;
            this.txtTemperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTemperatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTemperatura_KeyPress);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Futura Md BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(238, 454);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(98, 33);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbTCelsius
            // 
            this.rbTCelsius.AutoSize = true;
            this.rbTCelsius.Location = new System.Drawing.Point(56, 120);
            this.rbTCelsius.Name = "rbTCelsius";
            this.rbTCelsius.Size = new System.Drawing.Size(83, 23);
            this.rbTCelsius.TabIndex = 2;
            this.rbTCelsius.TabStop = true;
            this.rbTCelsius.Text = "Celsius";
            this.rbTCelsius.UseVisualStyleBackColor = true;
            this.rbTCelsius.CheckedChanged += new System.EventHandler(this.rbTCelsius_CheckedChanged);
            // 
            // rbTKelvins
            // 
            this.rbTKelvins.AutoSize = true;
            this.rbTKelvins.Location = new System.Drawing.Point(214, 120);
            this.rbTKelvins.Name = "rbTKelvins";
            this.rbTKelvins.Size = new System.Drawing.Size(86, 23);
            this.rbTKelvins.TabIndex = 2;
            this.rbTKelvins.TabStop = true;
            this.rbTKelvins.Text = "Kelvins";
            this.rbTKelvins.UseVisualStyleBackColor = true;
            this.rbTKelvins.CheckedChanged += new System.EventHandler(this.rbTKelvins_CheckedChanged);
            // 
            // rbTFahrenheit
            // 
            this.rbTFahrenheit.AutoSize = true;
            this.rbTFahrenheit.Location = new System.Drawing.Point(366, 120);
            this.rbTFahrenheit.Name = "rbTFahrenheit";
            this.rbTFahrenheit.Size = new System.Drawing.Size(115, 23);
            this.rbTFahrenheit.TabIndex = 2;
            this.rbTFahrenheit.TabStop = true;
            this.rbTFahrenheit.Text = "Fahrenheit";
            this.rbTFahrenheit.UseVisualStyleBackColor = true;
            this.rbTFahrenheit.CheckedChanged += new System.EventHandler(this.rbTFahrenheit_CheckedChanged);
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(105, 384);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(127, 34);
            this.btnConverter.TabIndex = 3;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(287, 384);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(127, 34);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // rbRCelsius
            // 
            this.rbRCelsius.AutoSize = true;
            this.rbRCelsius.Location = new System.Drawing.Point(39, 116);
            this.rbRCelsius.Name = "rbRCelsius";
            this.rbRCelsius.Size = new System.Drawing.Size(83, 23);
            this.rbRCelsius.TabIndex = 2;
            this.rbRCelsius.TabStop = true;
            this.rbRCelsius.Text = "Celsius";
            this.rbRCelsius.UseVisualStyleBackColor = true;
            this.rbRCelsius.CheckedChanged += new System.EventHandler(this.rbRCelsius_CheckedChanged);
            // 
            // rbRKelvins
            // 
            this.rbRKelvins.AutoSize = true;
            this.rbRKelvins.Location = new System.Drawing.Point(197, 116);
            this.rbRKelvins.Name = "rbRKelvins";
            this.rbRKelvins.Size = new System.Drawing.Size(86, 23);
            this.rbRKelvins.TabIndex = 2;
            this.rbRKelvins.TabStop = true;
            this.rbRKelvins.Text = "Kelvins";
            this.rbRKelvins.UseVisualStyleBackColor = true;
            this.rbRKelvins.CheckedChanged += new System.EventHandler(this.rbRKelvins_CheckedChanged);
            // 
            // rbRFahrenheit
            // 
            this.rbRFahrenheit.AutoSize = true;
            this.rbRFahrenheit.Location = new System.Drawing.Point(349, 116);
            this.rbRFahrenheit.Name = "rbRFahrenheit";
            this.rbRFahrenheit.Size = new System.Drawing.Size(115, 23);
            this.rbRFahrenheit.TabIndex = 2;
            this.rbRFahrenheit.TabStop = true;
            this.rbRFahrenheit.Text = "Fahrenheit";
            this.rbRFahrenheit.UseVisualStyleBackColor = true;
            this.rbRFahrenheit.CheckedChanged += new System.EventHandler(this.rbRFahrenheit_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Md BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escolha um tipo de temperatura para conversão :";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Futura Md BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(342, 457);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 25);
            this.lblResultado.TabIndex = 5;
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(342, 63);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(0, 19);
            this.lblTemperatura.TabIndex = 5;
            // 
            // grbEntrada
            // 
            this.grbEntrada.Location = new System.Drawing.Point(17, 14);
            this.grbEntrada.Name = "grbEntrada";
            this.grbEntrada.Size = new System.Drawing.Size(538, 175);
            this.grbEntrada.TabIndex = 6;
            this.grbEntrada.TabStop = false;
            // 
            // grbSaida
            // 
            this.grbSaida.Controls.Add(this.rbRCelsius);
            this.grbSaida.Controls.Add(this.rbRKelvins);
            this.grbSaida.Controls.Add(this.label1);
            this.grbSaida.Controls.Add(this.rbRFahrenheit);
            this.grbSaida.Location = new System.Drawing.Point(17, 203);
            this.grbSaida.Name = "grbSaida";
            this.grbSaida.Size = new System.Drawing.Size(538, 175);
            this.grbSaida.TabIndex = 6;
            this.grbSaida.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 579);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.rbTFahrenheit);
            this.Controls.Add(this.rbTKelvins);
            this.Controls.Add(this.rbTCelsius);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Temperatura);
            this.Controls.Add(this.grbEntrada);
            this.Controls.Add(this.grbSaida);
            this.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de temperatura";
            this.grbSaida.ResumeLayout(false);
            this.grbSaida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Temperatura;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.RadioButton rbTCelsius;
        private System.Windows.Forms.RadioButton rbTKelvins;
        private System.Windows.Forms.RadioButton rbTFahrenheit;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.RadioButton rbRCelsius;
        private System.Windows.Forms.RadioButton rbRKelvins;
        private System.Windows.Forms.RadioButton rbRFahrenheit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.GroupBox grbEntrada;
        private System.Windows.Forms.GroupBox grbSaida;
        protected System.Windows.Forms.TextBox txtResultado;
    }
}


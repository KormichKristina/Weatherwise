namespace Weatherwise
{
    partial class AirPollutionControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.coLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.no2Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.noLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.o3Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nh3Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pm25Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.so2Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pm10Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.airQualityIndexLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pm10Label);
            this.panel1.Controls.Add(this.so2Label);
            this.panel1.Controls.Add(this.nh3Label);
            this.panel1.Controls.Add(this.pm25Label);
            this.panel1.Controls.Add(this.o3Label);
            this.panel1.Controls.Add(this.noLabel);
            this.panel1.Controls.Add(this.no2Label);
            this.panel1.Controls.Add(this.coLabel);
            this.panel1.Location = new System.Drawing.Point(28, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 155);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(274, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 155);
            this.panel2.TabIndex = 0;
            // 
            // coLabel
            // 
            this.coLabel.BackColor = System.Drawing.Color.Transparent;
            this.coLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coLabel.ForeColor = System.Drawing.Color.White;
            this.coLabel.Location = new System.Drawing.Point(20, 11);
            this.coLabel.Name = "coLabel";
            this.coLabel.Size = new System.Drawing.Size(28, 22);
            this.coLabel.TabIndex = 0;
            this.coLabel.Text = "CO";
            // 
            // no2Label
            // 
            this.no2Label.BackColor = System.Drawing.Color.Transparent;
            this.no2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.no2Label.ForeColor = System.Drawing.Color.White;
            this.no2Label.Location = new System.Drawing.Point(20, 79);
            this.no2Label.Name = "no2Label";
            this.no2Label.Padding = new System.Windows.Forms.Padding(3);
            this.no2Label.Size = new System.Drawing.Size(42, 28);
            this.no2Label.TabIndex = 1;
            this.no2Label.Text = "NO<sub>2</sub>";
            // 
            // noLabel
            // 
            this.noLabel.BackColor = System.Drawing.Color.Transparent;
            this.noLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noLabel.ForeColor = System.Drawing.Color.White;
            this.noLabel.Location = new System.Drawing.Point(20, 45);
            this.noLabel.Name = "noLabel";
            this.noLabel.Size = new System.Drawing.Size(28, 22);
            this.noLabel.TabIndex = 2;
            this.noLabel.Text = "NO";
            // 
            // o3Label
            // 
            this.o3Label.BackColor = System.Drawing.Color.Transparent;
            this.o3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.o3Label.ForeColor = System.Drawing.Color.White;
            this.o3Label.Location = new System.Drawing.Point(20, 113);
            this.o3Label.Name = "o3Label";
            this.o3Label.Padding = new System.Windows.Forms.Padding(3);
            this.o3Label.Size = new System.Drawing.Size(30, 28);
            this.o3Label.TabIndex = 3;
            this.o3Label.Text = "O<sub>3</sub>";
            // 
            // nh3Label
            // 
            this.nh3Label.BackColor = System.Drawing.Color.Transparent;
            this.nh3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nh3Label.ForeColor = System.Drawing.Color.White;
            this.nh3Label.Location = new System.Drawing.Point(263, 113);
            this.nh3Label.Name = "nh3Label";
            this.nh3Label.Padding = new System.Windows.Forms.Padding(3);
            this.nh3Label.Size = new System.Drawing.Size(42, 28);
            this.nh3Label.TabIndex = 7;
            this.nh3Label.Text = "NH<sub>3</sub>";
            // 
            // pm25Label
            // 
            this.pm25Label.BackColor = System.Drawing.Color.Transparent;
            this.pm25Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pm25Label.ForeColor = System.Drawing.Color.White;
            this.pm25Label.Location = new System.Drawing.Point(262, 39);
            this.pm25Label.Name = "pm25Label";
            this.pm25Label.Padding = new System.Windows.Forms.Padding(3);
            this.pm25Label.Size = new System.Drawing.Size(54, 28);
            this.pm25Label.TabIndex = 5;
            this.pm25Label.Text = "PM<sub>2.5</sub>";
            // 
            // so2Label
            // 
            this.so2Label.BackColor = System.Drawing.Color.Transparent;
            this.so2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.so2Label.ForeColor = System.Drawing.Color.White;
            this.so2Label.Location = new System.Drawing.Point(263, 5);
            this.so2Label.Name = "so2Label";
            this.so2Label.Padding = new System.Windows.Forms.Padding(3);
            this.so2Label.Size = new System.Drawing.Size(41, 28);
            this.so2Label.TabIndex = 8;
            this.so2Label.Text = "SO<sub>2</sub>";
            // 
            // pm10Label
            // 
            this.pm10Label.BackColor = System.Drawing.Color.Transparent;
            this.pm10Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pm10Label.ForeColor = System.Drawing.Color.White;
            this.pm10Label.Location = new System.Drawing.Point(262, 79);
            this.pm10Label.Name = "pm10Label";
            this.pm10Label.Padding = new System.Windows.Forms.Padding(3);
            this.pm10Label.Size = new System.Drawing.Size(50, 28);
            this.pm10Label.TabIndex = 9;
            this.pm10Label.Text = "PM<sub>10</sub>";
            // 
            // airQualityIndexLabel
            // 
            this.airQualityIndexLabel.BackColor = System.Drawing.Color.Transparent;
            this.airQualityIndexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.airQualityIndexLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.airQualityIndexLabel.Location = new System.Drawing.Point(28, 214);
            this.airQualityIndexLabel.Name = "airQualityIndexLabel";
            this.airQualityIndexLabel.Size = new System.Drawing.Size(125, 22);
            this.airQualityIndexLabel.TabIndex = 1;
            this.airQualityIndexLabel.Text = "Air Quality Index";
            // 
            // AirPollutionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.airQualityIndexLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AirPollutionControl";
            this.Size = new System.Drawing.Size(558, 275);
            this.Load += new System.EventHandler(this.AirPollutionControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel coLabel;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel no2Label;
        private Guna.UI2.WinForms.Guna2HtmlLabel nh3Label;
        private Guna.UI2.WinForms.Guna2HtmlLabel pm25Label;
        private Guna.UI2.WinForms.Guna2HtmlLabel o3Label;
        private Guna.UI2.WinForms.Guna2HtmlLabel noLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel pm10Label;
        private Guna.UI2.WinForms.Guna2HtmlLabel so2Label;
        private Guna.UI2.WinForms.Guna2HtmlLabel airQualityIndexLabel;
    }
}

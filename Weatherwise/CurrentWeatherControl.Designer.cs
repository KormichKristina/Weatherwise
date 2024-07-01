namespace Weatherwise
{
    partial class CurrentWeatherControl
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
            this.tempGradLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.coordLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pressureLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.sunriseLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.sunsetLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.humidityLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.feelsLikeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.windLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cityNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.degLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.descLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.weatherPictureBox = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tempGradLabel
            // 
            this.tempGradLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempGradLabel.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tempGradLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tempGradLabel.Location = new System.Drawing.Point(40, 264);
            this.tempGradLabel.Name = "tempGradLabel";
            this.tempGradLabel.Size = new System.Drawing.Size(35, 21);
            this.tempGradLabel.TabIndex = 13;
            this.tempGradLabel.Text = "temp";
            // 
            // coordLabel
            // 
            this.coordLabel.BackColor = System.Drawing.Color.Transparent;
            this.coordLabel.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.coordLabel.Location = new System.Drawing.Point(40, 327);
            this.coordLabel.Name = "coordLabel";
            this.coordLabel.Size = new System.Drawing.Size(76, 21);
            this.coordLabel.TabIndex = 12;
            this.coordLabel.Text = "Coordinates";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.pressureLabel);
            this.panel3.Controls.Add(this.sunriseLabel);
            this.panel3.Controls.Add(this.sunsetLabel);
            this.panel3.Controls.Add(this.guna2Button4);
            this.panel3.Controls.Add(this.humidityLabel);
            this.panel3.Controls.Add(this.feelsLikeLabel);
            this.panel3.Controls.Add(this.windLabel);
            this.panel3.Location = new System.Drawing.Point(250, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 365);
            this.panel3.TabIndex = 11;
            // 
            // pressureLabel
            // 
            this.pressureLabel.BackColor = System.Drawing.Color.Transparent;
            this.pressureLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pressureLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pressureLabel.Location = new System.Drawing.Point(12, 137);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(66, 25);
            this.pressureLabel.TabIndex = 8;
            this.pressureLabel.Text = "Pressure";
            // 
            // sunriseLabel
            // 
            this.sunriseLabel.BackColor = System.Drawing.Color.Transparent;
            this.sunriseLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sunriseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sunriseLabel.Location = new System.Drawing.Point(12, 211);
            this.sunriseLabel.Name = "sunriseLabel";
            this.sunriseLabel.Size = new System.Drawing.Size(59, 25);
            this.sunriseLabel.TabIndex = 7;
            this.sunriseLabel.Text = "Sunrise";
            // 
            // sunsetLabel
            // 
            this.sunsetLabel.BackColor = System.Drawing.Color.Transparent;
            this.sunsetLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sunsetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sunsetLabel.Location = new System.Drawing.Point(12, 248);
            this.sunsetLabel.Name = "sunsetLabel";
            this.sunsetLabel.Size = new System.Drawing.Size(53, 25);
            this.sunsetLabel.TabIndex = 6;
            this.sunsetLabel.Text = "Sunset";
            // 
            // guna2Button4
            // 
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.guna2Button4.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(0, 291);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.PressedColor = System.Drawing.Color.White;
            this.guna2Button4.Size = new System.Drawing.Size(189, 74);
            this.guna2Button4.TabIndex = 5;
            this.guna2Button4.Text = "Weather forecast";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // humidityLabel
            // 
            this.humidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.humidityLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.humidityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.humidityLabel.Location = new System.Drawing.Point(12, 100);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(73, 25);
            this.humidityLabel.TabIndex = 4;
            this.humidityLabel.Text = "Humidity";
            // 
            // feelsLikeLabel
            // 
            this.feelsLikeLabel.BackColor = System.Drawing.Color.Transparent;
            this.feelsLikeLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feelsLikeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.feelsLikeLabel.Location = new System.Drawing.Point(12, 63);
            this.feelsLikeLabel.Name = "feelsLikeLabel";
            this.feelsLikeLabel.Size = new System.Drawing.Size(69, 25);
            this.feelsLikeLabel.TabIndex = 1;
            this.feelsLikeLabel.Text = "feels like";
            // 
            // windLabel
            // 
            this.windLabel.BackColor = System.Drawing.Color.Transparent;
            this.windLabel.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.windLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.windLabel.Location = new System.Drawing.Point(12, 26);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(49, 25);
            this.windLabel.TabIndex = 0;
            this.windLabel.Text = "Wind:";
            // 
            // cityNameLabel
            // 
            this.cityNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityNameLabel.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cityNameLabel.Location = new System.Drawing.Point(40, 291);
            this.cityNameLabel.Name = "cityNameLabel";
            this.cityNameLabel.Size = new System.Drawing.Size(38, 30);
            this.cityNameLabel.TabIndex = 10;
            this.cityNameLabel.Text = "City";
            // 
            // degLabel
            // 
            this.degLabel.BackColor = System.Drawing.Color.Transparent;
            this.degLabel.Font = new System.Drawing.Font("Sitka Text", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.degLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.degLabel.Location = new System.Drawing.Point(40, 179);
            this.degLabel.Name = "degLabel";
            this.degLabel.Size = new System.Drawing.Size(56, 79);
            this.degLabel.TabIndex = 9;
            this.degLabel.Text = "17";
            // 
            // descLabel
            // 
            this.descLabel.BackColor = System.Drawing.Color.Transparent;
            this.descLabel.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.descLabel.Location = new System.Drawing.Point(40, 150);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(44, 30);
            this.descLabel.TabIndex = 8;
            this.descLabel.Text = "Desc";
            // 
            // weatherPictureBox
            // 
            this.weatherPictureBox.Image = global::Weatherwise.Properties.Resources.broken_clouds;
            this.weatherPictureBox.Location = new System.Drawing.Point(40, 3);
            this.weatherPictureBox.Name = "weatherPictureBox";
            this.weatherPictureBox.Size = new System.Drawing.Size(176, 131);
            this.weatherPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weatherPictureBox.TabIndex = 7;
            this.weatherPictureBox.TabStop = false;
            // 
            // CurrentWeatherControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tempGradLabel);
            this.Controls.Add(this.coordLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cityNameLabel);
            this.Controls.Add(this.degLabel);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.weatherPictureBox);
            this.Name = "CurrentWeatherControl";
            this.Size = new System.Drawing.Size(439, 365);
            this.Load += new System.EventHandler(this.CurrentWeatherControl_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel tempGradLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel coordLabel;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel pressureLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel sunriseLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel sunsetLabel;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2HtmlLabel humidityLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel feelsLikeLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel windLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel cityNameLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel degLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel descLabel;
        private System.Windows.Forms.PictureBox weatherPictureBox;
    }
}

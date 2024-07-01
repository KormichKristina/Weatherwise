namespace Weatherwise
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exploreButton = new Guna.UI2.WinForms.Guna2Button();
            this.settingsButton = new Guna.UI2.WinForms.Guna2Button();
            this.currentWeatherButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.settingsControl1 = new Weatherwise.SettingsControl();
            this.currentWeatherControl1 = new Weatherwise.CurrentWeatherControl();
            this.exploreControl1 = new Weatherwise.ExploreControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.exploreButton);
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.currentWeatherButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 365);
            this.panel1.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.exitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.exitButton.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.exitButton.Image = global::Weatherwise.Properties.Resources.exit;
            this.exitButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.exitButton.Location = new System.Drawing.Point(0, 289);
            this.exitButton.Name = "exitButton";
            this.exitButton.PressedColor = System.Drawing.Color.White;
            this.exitButton.Size = new System.Drawing.Size(121, 45);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.TextOffset = new System.Drawing.Point(5, 0);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 70);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(100, 25);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Weatherwise";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Weatherwise.Properties.Resources.weather_forecast;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // exploreButton
            // 
            this.exploreButton.BackColor = System.Drawing.Color.Transparent;
            this.exploreButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exploreButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.exploreButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exploreButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exploreButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exploreButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exploreButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.exploreButton.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exploreButton.ForeColor = System.Drawing.Color.White;
            this.exploreButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.exploreButton.Image = global::Weatherwise.Properties.Resources.search;
            this.exploreButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.exploreButton.Location = new System.Drawing.Point(0, 234);
            this.exploreButton.Name = "exploreButton";
            this.exploreButton.PressedColor = System.Drawing.Color.White;
            this.exploreButton.Size = new System.Drawing.Size(121, 45);
            this.exploreButton.TabIndex = 3;
            this.exploreButton.Text = "Explore";
            this.exploreButton.TextOffset = new System.Drawing.Point(5, 0);
            this.exploreButton.Click += new System.EventHandler(this.exploreButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settingsButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.settingsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.settingsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.settingsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.settingsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.settingsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.settingsButton.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.settingsButton.Image = global::Weatherwise.Properties.Resources.setting__1_;
            this.settingsButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.settingsButton.Location = new System.Drawing.Point(0, 179);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.PressedColor = System.Drawing.Color.White;
            this.settingsButton.Size = new System.Drawing.Size(121, 45);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextOffset = new System.Drawing.Point(5, 0);
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // currentWeatherButton
            // 
            this.currentWeatherButton.BackColor = System.Drawing.Color.Transparent;
            this.currentWeatherButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.currentWeatherButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.currentWeatherButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.currentWeatherButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.currentWeatherButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.currentWeatherButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.currentWeatherButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.currentWeatherButton.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentWeatherButton.ForeColor = System.Drawing.Color.White;
            this.currentWeatherButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.currentWeatherButton.Image = global::Weatherwise.Properties.Resources.SunIcon;
            this.currentWeatherButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.currentWeatherButton.Location = new System.Drawing.Point(0, 124);
            this.currentWeatherButton.Name = "currentWeatherButton";
            this.currentWeatherButton.PressedColor = System.Drawing.Color.White;
            this.currentWeatherButton.Size = new System.Drawing.Size(121, 45);
            this.currentWeatherButton.TabIndex = 1;
            this.currentWeatherButton.Text = "Weather";
            this.currentWeatherButton.TextOffset = new System.Drawing.Point(5, 0);
            this.currentWeatherButton.Click += new System.EventHandler(this.currentWeatherButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.exploreControl1);
            this.panel2.Controls.Add(this.settingsControl1);
            this.panel2.Controls.Add(this.currentWeatherControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(118, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 365);
            this.panel2.TabIndex = 1;
            // 
            // settingsControl1
            // 
            this.settingsControl1.BackColor = System.Drawing.Color.White;
            this.settingsControl1.CurrentWeather = null;
            this.settingsControl1.Location = new System.Drawing.Point(0, 0);
            this.settingsControl1.Name = "settingsControl1";
            this.settingsControl1.Size = new System.Drawing.Size(439, 365);
            this.settingsControl1.TabIndex = 1;
            // 
            // currentWeatherControl1
            // 
            this.currentWeatherControl1.BackColor = System.Drawing.Color.White;
            this.currentWeatherControl1.Location = new System.Drawing.Point(0, 0);
            this.currentWeatherControl1.Name = "currentWeatherControl1";
            this.currentWeatherControl1.Size = new System.Drawing.Size(439, 365);
            this.currentWeatherControl1.TabIndex = 0;
            // 
            // exploreControl1
            // 
            this.exploreControl1.BackColor = System.Drawing.Color.White;
            this.exploreControl1.Location = new System.Drawing.Point(0, 0);
            this.exploreControl1.Name = "exploreControl1";
            this.exploreControl1.Size = new System.Drawing.Size(439, 365);
            this.exploreControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(557, 365);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button currentWeatherButton;
        private Guna.UI2.WinForms.Guna2Button exploreButton;
        private Guna.UI2.WinForms.Guna2Button settingsButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button exitButton;
        private CurrentWeatherControl currentWeatherControl1;
        private SettingsControl settingsControl1;
        private ExploreControl exploreControl1;
    }
}


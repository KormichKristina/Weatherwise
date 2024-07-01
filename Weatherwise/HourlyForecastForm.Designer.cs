using System.Drawing;
using Weatherwise.Classes;

namespace Weatherwise
{
    partial class HourlyForecastForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HourlyForecastForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.airPollutionButton = new Guna.UI2.WinForms.Guna2Button();
            this.dayForecastButton = new Guna.UI2.WinForms.Guna2Button();
            this.backButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.hourlyWeatherShowControl1 = new Weatherwise.HourlyWeatherShowControl();
            this.airPollutionControl1 = new Weatherwise.AirPollutionControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.airPollutionButton);
            this.panel1.Controls.Add(this.dayForecastButton);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 329);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // airPollutionButton
            // 
            this.airPollutionButton.BackColor = System.Drawing.Color.Transparent;
            this.airPollutionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.airPollutionButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.airPollutionButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.airPollutionButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.airPollutionButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.airPollutionButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.airPollutionButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.airPollutionButton.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airPollutionButton.ForeColor = System.Drawing.Color.White;
            this.airPollutionButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.airPollutionButton.Image = global::Weatherwise.Properties.Resources.precipitation;
            this.airPollutionButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.airPollutionButton.Location = new System.Drawing.Point(0, 219);
            this.airPollutionButton.Name = "airPollutionButton";
            this.airPollutionButton.PressedColor = System.Drawing.Color.White;
            this.airPollutionButton.Size = new System.Drawing.Size(97, 45);
            this.airPollutionButton.TabIndex = 6;
            this.airPollutionButton.Text = "Air pollution";
            this.airPollutionButton.TextOffset = new System.Drawing.Point(10, 0);
            this.airPollutionButton.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // dayForecastButton
            // 
            this.dayForecastButton.BackColor = System.Drawing.Color.Transparent;
            this.dayForecastButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dayForecastButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dayForecastButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dayForecastButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dayForecastButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dayForecastButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dayForecastButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dayForecastButton.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayForecastButton.ForeColor = System.Drawing.Color.White;
            this.dayForecastButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dayForecastButton.Image = global::Weatherwise.Properties.Resources.calendar;
            this.dayForecastButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dayForecastButton.Location = new System.Drawing.Point(0, 164);
            this.dayForecastButton.Name = "dayForecastButton";
            this.dayForecastButton.PressedColor = System.Drawing.Color.White;
            this.dayForecastButton.Size = new System.Drawing.Size(97, 45);
            this.dayForecastButton.TabIndex = 5;
            this.dayForecastButton.Text = "3 day forecast";
            this.dayForecastButton.TextOffset = new System.Drawing.Point(10, 0);
            this.dayForecastButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.backButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.backButton.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.backButton.Image = global::Weatherwise.Properties.Resources.Back;
            this.backButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.backButton.Location = new System.Drawing.Point(0, 113);
            this.backButton.Name = "backButton";
            this.backButton.PressedColor = System.Drawing.Color.White;
            this.backButton.Size = new System.Drawing.Size(97, 45);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.TextOffset = new System.Drawing.Point(5, 0);
            this.backButton.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.guna2HtmlLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(97, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 58);
            this.panel2.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(17, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(139, 27);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "3 day  forecast";
            // 
            // hourlyWeatherShowControl1
            // 
            this.hourlyWeatherShowControl1.Lat = 0F;
            this.hourlyWeatherShowControl1.Location = new System.Drawing.Point(97, 54);
            this.hourlyWeatherShowControl1.Lon = 0F;
            this.hourlyWeatherShowControl1.Name = "hourlyWeatherShowControl1";
            this.hourlyWeatherShowControl1.Size = new System.Drawing.Size(558, 275);
            this.hourlyWeatherShowControl1.TabIndex = 2;
            // 
            // airPollutionControl1
            // 
            this.airPollutionControl1.BackColor = System.Drawing.Color.White;
            this.airPollutionControl1.Location = new System.Drawing.Point(97, 54);
            this.airPollutionControl1.Name = "airPollutionControl1";
            this.airPollutionControl1.Size = new System.Drawing.Size(558, 275);
            this.airPollutionControl1.TabIndex = 3;
            // 
            // HourlyForecastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 329);
            this.Controls.Add(this.airPollutionControl1);
            this.Controls.Add(this.hourlyWeatherShowControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HourlyForecastForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HourlyForecastForm";
            this.Load += new System.EventHandler(this.HourlyForecastForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button backButton;
        private Guna.UI2.WinForms.Guna2Button dayForecastButton;
        private Guna.UI2.WinForms.Guna2Button airPollutionButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private HourlyWeatherShowControl hourlyWeatherShowControl1;
        private AirPollutionControl airPollutionControl1;
    }
}
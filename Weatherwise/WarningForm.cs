using System;
using System.Windows.Forms;
using Weatherwise.Classes;

namespace Weatherwise
{
    public partial class WarningForm : Form
    {
        public string CurrentCityName { get; set; }
        public WarningForm()
        {
            InitializeComponent();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            CitiesClass.RemoveCity(CurrentCityName);
            new Form1().Show();
            Hide();
        }
    }
}

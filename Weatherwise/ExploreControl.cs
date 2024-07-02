using System;
using System.Windows.Forms;
using Weatherwise.Classes;

namespace Weatherwise
{
    public partial class ExploreControl : UserControl
    {
        public ExploreControl()
        {
            InitializeComponent();
        }

        private void ExploreControl_Load(object sender, EventArgs e)
        {
            CitiesClass.GetCitiesNamesFromFile();
            foreach(var i in CitiesClass.CitiesNames)
            {
                flowLayoutPanel1.Controls.Add(new CityControl() { CityName = i });
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new AddCityForm().Show();
            ParentForm.Hide();
        }
    }
}

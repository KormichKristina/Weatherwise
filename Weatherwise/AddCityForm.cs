using System;
using System.Windows.Forms;
using Weatherwise.Classes;

namespace Weatherwise
{
    public partial class AddCityForm : Form
    {
        public AddCityForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var list = CitiesClass.GetFullListOfCities();
            if (list.Contains(citiesTextBox.Text))
            {
                if (CitiesClass.CitiesNames.Contains(citiesTextBox.Text))
                {
                    MessageBox.Show("this city is added");
                }
                else
                {
                    CitiesClass.AddCityToFile(citiesTextBox.Text);
                    new Form1().Show();
                    Hide();
                }
                
            }
            else
            {
                MessageBox.Show("This city doesnt exist");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();
        }

        private void addRandomCityButton_Click(object sender, EventArgs e)
        {
            var list = CitiesClass.GetFullListOfCities();
            int index = new Random().Next(0, list.Count);
            while (CitiesClass.CitiesNames.Contains(list[index]))
            {
                index = new Random().Next(0, list.Count);
            }
            CitiesClass.AddCityToFile(list[index]);
            new Form1().Show();
            Hide();
        }
    }
}

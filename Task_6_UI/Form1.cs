using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Solutions.Task_6;

namespace Task_6_UI
{
    public partial class Form1 : Form
    {
        private const string InvalidValues = "Enter valid values.";
        private List<IVehicle> TramsList { get; set; }
        
        public Form1()
        {
            InitializeComponent();
            TramsList = new List<IVehicle>();
        }

        private void AddTramButton_Click(object sender, EventArgs e)
        {
            try
            {
                var routeName = Route.Text;
                var seatsNumber = Convert.ToInt32(Seats.Text);
                var depot = Depot.Text;
                var voltage = Convert.ToInt32(Voltage.Text);
                TramsList.Add(new Tram(routeName, seatsNumber, 
                    depot, false, 0, voltage));
                TransportList.Items.Add(routeName);
            }
            catch (Exception)
            {
                OutputField.Text = InvalidValues;
            }
        }

        private void BrokeButton_Click(object sender, EventArgs e)
        {
            var index = TransportList.SelectedIndex;
            OutputField.Text = TramsList[index].Broke();
        }

        private void AddPassButton_Click(object sender, EventArgs e)
        {
            var index = TransportList.SelectedIndex;
            OutputField.Text = TramsList[index].Move();
        }
    }
}
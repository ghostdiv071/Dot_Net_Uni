using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Solutions.Task_3;

namespace Task_3_UI
{
    public partial class Form1 : Form
    {
        private const string InvalidValue = "Enter a valid value";
        private const string EmptyValue = "Enter some value";

        private Home HomeModel { get; set; }
        public Form1()
        {
            InitializeComponent(); 
            HomeModel = new Home();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            try
            {
                var number = Convert.ToInt32(textBox1.Text);
                textBox1.Text = HomeModel.Open(number);
            }
            catch (Exception)
            {
                textBox1.Text = InvalidValue;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            try
            {
                var number = Convert.ToInt32(textBox1.Text);
                textBox1.Text = HomeModel.Close(number);
            }
            catch (Exception)
            {
                textBox1.Text = InvalidValue;
            }
        }

        private void DoorButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = HomeModel.GetDoorsAmount().ToString();
        }
        
        private void WindowButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = HomeModel.GetWindowsAmount().ToString();
        }

        private void AddDoor_Click(object sender, EventArgs e)
        {
            if (doorMaterial.Text.Length != 0 )
            {
                HomeModel.AddDoor(doorMaterial.Text);
                doorMaterial.Text = string.Empty;
            }
            else
            {
                doorMaterial.Text = EmptyValue;
            }
        }

        private void AddWindow_Click(object sender, EventArgs e)
        {
            if (leavesAmount.Text.Length != 0 
                & windowType.Text.Length != 0)
            {
                try
                {
                    var leaves = Convert.ToInt32(leavesAmount.Text);
                    HomeModel.AddWindow(leaves, windowType.Text);
                    leavesAmount.Text = windowType.Text = string.Empty;
                }
                catch (Exception)
                {
                    leavesAmount.Text = InvalidValue;
                }
            }
            else
            {
                leavesAmount.Text = EmptyValue;
                windowType.Text = EmptyValue;
            }
        }
    }
}
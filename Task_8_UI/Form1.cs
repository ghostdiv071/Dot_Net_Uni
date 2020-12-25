using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Solutions.Task_8;

namespace Task_8_UI
{
    public partial class Form1 : Form
    {
        private Factory Factory { get; } = new Factory();
        private Graphics _graphics;
        
        public Form1()
        {
            InitializeComponent();
            Factory.Update += Repaint;
        }
        
        private void Repaint()
        {
            
            Invoke((MethodInvoker)Refresh);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            _graphics = e.Graphics;
            _graphics.Clear(Color.White);
            foreach (var furnace in Factory._furnaces)
            {
                var fSize = new Size(100, 100);
                var fBitmap = new Bitmap(furnace.Path);
                var fImage = new Bitmap(fBitmap, fSize);
                var fPoint = furnace.Position;
                _graphics.DrawImage(fImage, fPoint);
            }
            
        }
    }
}
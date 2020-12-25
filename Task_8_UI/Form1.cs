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
            //Factory.StartFurnace();
            Factory.Update += Repaint;
        }
        
        private void Repaint()
        { 
            Invoke((MethodInvoker)Refresh);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            _graphics = e.Graphics;
            foreach (var furnace in Factory.Furnaces)
            {
                Drawing(100, 100, new Point(10,10), Paths.Furnace);
            }

            if (Factory.Worker.Busy)
            {
                Drawing(100, 100, new Point(200, 10), Paths.Worker);
            }

            if (Factory.BeltLoader.Busy)
            {
                Drawing(100, 100, new Point(10, 200), Paths.Belt);
            }
            
            if (Factory.BucketLoader.Busy)
            {
                Drawing(100, 100, new Point(10, 200), Paths.Bucket);
            }
            
            if (Factory.Excavator.Busy)
            {
                Drawing(100, 100, new Point(10, 200), Paths.Excavator);
            }
        }

        private void Drawing(int width, int height, Point position, string path)
        {
            var size = new Size(width, height);
            var bitmap = new Bitmap(path);
            var image = new Bitmap(bitmap, size);
            var point = position;
            _graphics.DrawImage(image, point);
        }
    }
}
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
        private int FYStart = 10;  
        
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
            foreach (var furnace in Factory.Furnaces)
            {
                Drawing(100, 100, new Point(furnace.X, furnace.Y), Paths.Furnace);
                if (furnace.State== FurnaceState.Empty)
                {
                    _graphics.DrawString("I'm empty!", new Font("Arial", 16), new SolidBrush(Color.Green), new Point(furnace.X, furnace.Y) );
                }

                if (furnace.State == FurnaceState.Overheat)
                {
                    _graphics.DrawString("I'm overheat!", new Font("Arial", 16), new SolidBrush(Color.Red), new PointF(furnace.X, furnace.Y+50) );
                }
            }

            Drawing(100, 100, !Factory.Worker.Busy ? new Point(10, 10) : new Point(Factory.Worker.X, Factory.Worker.Y), Factory.Worker.Path);

            Drawing(100, 100, !Factory.BeltLoader.Busy ? new Point(650, 10) : new Point(Factory.BeltLoader.X, Factory.BeltLoader.Y), Paths.Belt);

            Drawing(100, 100, !Factory.BucketLoader.Busy ? new Point(650, 100) : new Point(Factory.BucketLoader.X, Factory.BucketLoader.Y),
                Paths.Bucket);

            Drawing(100, 100, !Factory.Excavator.Busy ? new Point(650, 200) : new Point(Factory.Excavator.X, Factory.Excavator.Y),
                Paths.Excavator);
        }
        
        private void Drawing(int width, int height, Point position, string path)
        {
            var size = new Size(width, height);
            var bitmap = new Bitmap(path);
            var image = new Bitmap(bitmap, size);
            var point = position;
            _graphics.DrawImage(image, point);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Factory.Furnaces.Count == 4)
            {
                return;
            }
            var f = new BlastFurnace(300, FYStart);
            FYStart += 90;
            Factory.Furnaces.Add(f);
            Factory.StartFurnace(f);
        }
    }
}
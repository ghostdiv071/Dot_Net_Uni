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
            BlastFurnace bf1 = new BlastFurnace(new Point(300, 10));
            BlastFurnace bf2 = new BlastFurnace(new Point(300, 100));
            Factory.Furnaces.Add(bf1);
            Factory.Furnaces.Add(bf2);
            Factory.StartFurnace(bf1);
            Factory.StartFurnace(bf2);
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
                Drawing(100, 100, furnace.Position, Paths.Furnace);
                if (furnace.State== FurnaceState.Empty)
                {
                    _graphics.DrawString("I'm empty!", new Font("Arial", 16), new SolidBrush(Color.Green), furnace.Position );
                }

                if (furnace.State == FurnaceState.Overheat)
                {
                    _graphics.DrawString("I'm overheat!", new Font("Arial", 16), new SolidBrush(Color.Red), new PointF(furnace.Position.X, furnace.Position.Y+50) );
                }
            }

            Drawing(100, 100, !Factory.Worker.Busy ? new Point(10, 10) : Factory.Worker.Position, Factory.Worker.Path);

            Drawing(100, 100, !Factory.BeltLoader.Busy ? new Point(650, 10) : Factory.BeltLoader.Position, Paths.Belt);

            Drawing(100, 100, !Factory.BucketLoader.Busy ? new Point(650, 100) : Factory.BucketLoader.Position,
                Paths.Bucket);

            Drawing(100, 100, !Factory.Excavator.Busy ? new Point(650, 200) : Factory.Excavator.Position,
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
    }
}
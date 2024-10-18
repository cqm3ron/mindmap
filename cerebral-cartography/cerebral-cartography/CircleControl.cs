using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cerebral_cartography
{
    public partial class CircleControl : UserControl
    {
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        public CircleControl()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            var graphics = e.Graphics;
            var pen = new Pen(Color.Black, 2);
            graphics.DrawEllipse(pen, 0, 0, this.Width - 1, this.Height - 1);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            isDragging = true;
            startPoint = e.Location;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (isDragging)
            {
                var newpos = this.Location;
                newpos.Offset(e.X - startPoint.X, e.Y - startPoint.Y);
                this.Location = newpos;
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            isDragging= false;
        }
    }
}

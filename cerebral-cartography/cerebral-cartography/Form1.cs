namespace cerebral_cartography
{
    public partial class Form1 : Form
    {
        private bool shouldDrawCircle = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddCircle_Click(object sender, EventArgs e)
        {
            var circle = new CircleControl
            {
                Size = new Size(100, 100),
                Location = new Point(10, 10)
            };
            this.Controls.Add(circle);
        }
    }
}

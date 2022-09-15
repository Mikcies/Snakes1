namespace Hadik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                panel1.Location = new Point(panel1.Location.X, panel1.Location.Y - 10);
                if (panel1.Location.Y < 0)
                {
                    panel1.Location = new Point(panel1.Location.X, this.Height);
                }
            }
            if (e.KeyCode == Keys.S)
            {
                panel1.Location = new Point(panel1.Location.X, panel1.Location.Y + 10);
                if (panel1.Location.Y >= this.Height)
                {
                    panel1.Location = new Point(panel1.Location.X, 0);
                }
            }
            if (e.KeyCode == Keys.D)
            {
               
            }
            if (e.KeyCode == Keys.A)
            {
                panel1.Location = new Point(panel1.Location.X - 10, panel1.Location.Y);
                if (panel1.Location.X < 0)
                {
                    panel1.Location = new Point(this.Width, panel1.Location.Y);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Location = new Point(panel1.Location.X + 10, panel1.Location.Y);
            if (panel1.Location.X >= this.Width)
            {
                panel1.Location = new Point(0, panel1.Location.Y);
            }
        }
    }
}
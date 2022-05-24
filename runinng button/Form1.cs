namespace runinng_button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Point point = new Point(random.Next(0, 300), random.Next(0, 300));
            button1.Location = point;
        }
    }
}
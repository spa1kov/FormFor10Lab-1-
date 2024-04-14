namespace FormFor10Lab
{
    public partial class Объём : Form
    {
        public Объём()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void Объём_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double length = Double.Parse(A.Text);
            double width = Double.Parse(B.Text);
            double height = Double.Parse(C.Text);

            double result = length * width * height;

            label1.Text = $"Объем параллелепипеда: {result}";
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
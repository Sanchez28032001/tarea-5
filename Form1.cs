namespace tarea_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double RADIO, ALTURA;
            double Basearea, Lateralarea, Totalarea;
            double Volume;
            RADIO = double.Parse(textBox1.Text);
            ALTURA = double.Parse(textBox2.Text);
            Basearea = RADIO * RADIO * Math.PI;
            Lateralarea = 2 * Math.PI * RADIO * ALTURA;
            Totalarea = 2 * Math.PI * RADIO * (ALTURA + RADIO);
            Volume = Math.PI * RADIO * RADIO * ALTURA;
            textBox3.Text = Basearea.ToString("0.##");
            textBox4.Text = Lateralarea.ToString("0.##");
            textBox5.Text = Totalarea.ToString("0.##");
            textBox6.Text = Volume.ToString("0.##");
        }
    }
}
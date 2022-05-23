namespace lab2sem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            int passlenght = (int)numericUpDown1.Value;
            /*int passquantity = (int)numericUpDown2.Value;*/

            bool numericals = checkBox1.Checked;
            bool specialsymbols = checkBox2.Checked;
            bool ruscapital = checkBox3.Checked;
            bool ruslowercase = checkBox4.Checked;
            bool engcapital = checkBox5.Checked;
            bool englowercase = checkBox6.Checked;

            Random type = new Random();
            Random rand = new Random();

            for (int i = 0; i < passlenght; i++) 
            {
                int symbol_type = (int)type.Next(0, 6);


                if (numericals == true)
                {
                    int value = (int)rand.Next(0, 9);
                    textBox1.Text += value.ToString();
                }

                /*if (specialsymbols == true)
                {
                    char value = (char)rand.Next(32, 46);
                    textBox1.Text += value.ToString();
                }

                if (ruscapital == true)
                {
                    char value = (char)rand.Next();
                    textBox1.Text += value.ToString();
                }

                if (ruslowercase == true)
                {
                    char value = (char)rand.Next();
                    textBox1.Text += value.ToString();
                }

                if (engcapital == true)
                {
                    char value = (char)rand.Next();
                    textBox1.Text += value.ToString();
                }

                if (englowercase == true)
                {
                    char value = (char)rand.Next();
                    textBox1.Text += value.ToString();
                }*/
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
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
            bool engcapital = checkBox3.Checked;
            bool englowercase = checkBox4.Checked;

            Random type = new Random();
            Random rand = new Random();

            for (int i = 0; i < passlenght; i++) 
            {
                int symbol_type = (int)type.Next(1, 5);

                if (symbol_type == 1)
                {
                    if (numericals == true)
                    {
                        int value = (int)rand.Next(0, 9);
                        textBox1.Text += value.ToString();
                        continue;
                    }
                    else i --;
                }

                if (symbol_type == 2) 
                {
                    if (specialsymbols == true)
                    {
                        char value = (char)rand.Next(33, 46);
                        textBox1.Text += value.ToString();
                        continue;
                    }
                    else i--;
                }

                if (symbol_type == 3)
                {
                    if (engcapital == true)
                    {
                        char value = (char)rand.Next(65, 90);
                        textBox1.Text += value.ToString();
                        continue;
                    }
                    else i--;
                }

                if (symbol_type == 4)
                {
                    if (englowercase == true)
                    {
                        char value = (char)rand.Next(97, 122);
                        textBox1.Text += value.ToString();
                        continue;
                    }
                    else i--;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {     
            //textBox1.Copy();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
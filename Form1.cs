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
            richTextBox1.Text = "";
            int passlenght = (int)numericUpDown1.Value;
            int passquantity = (int)numericUpDown2.Value;

            bool numericals = checkBox1.Checked;
            bool specialsymbols = checkBox2.Checked;
            bool engcapital = checkBox3.Checked;
            bool englowercase = checkBox4.Checked;

            Random type = new Random();
            Random rand = new Random();
            if (numericals == false && specialsymbols == false && engcapital == false && englowercase == false) richTextBox1.Text = "Вы не выбрали ни одного атрибута.";
            else for (int q = 0; q < passquantity; q++) 
            {
                for (int i = 0; i < passlenght; i++)
                {
                    int symbol_type = (int)type.Next(1, 5);

                    if (symbol_type == 1)
                    {
                        if (numericals == true)
                        {
                            int value = (int)rand.Next(0, 9);
                            richTextBox1.Text += value.ToString();
                            continue;
                        }
                        else i--;
                    }

                    if (symbol_type == 2)
                    {
                        if (specialsymbols == true)
                        {
                            char value = (char)rand.Next(33, 46);
                            richTextBox1.Text += value.ToString();
                            continue;
                        }
                        else i--;
                    }

                    if (symbol_type == 3)
                    {
                        if (engcapital == true)
                        {
                            char value = (char)rand.Next(65, 90);
                            richTextBox1.Text += value.ToString();
                            continue;
                        }
                        else i--;
                    }

                    if (symbol_type == 4)
                    {
                        if (englowercase == true)
                        {
                            char value = (char)rand.Next(97, 122);
                            richTextBox1.Text += value.ToString();
                            continue;
                        }
                        else i--;
                    }
                }
                richTextBox1.Text += "\n" ;
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
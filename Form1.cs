using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String var = textBox1.Text;
            String[] words = var.Split(' ');
            Regex regex = new Regex(@"^[0-9][0-9]*(([.][0-9][0-9]*)?([e][+|-][0-9][0-9]*)?)?$");
            for (int i = 0; i < words.Length; i++)
            {
                Match match = regex.Match(words[i]);
                if (match.Success)
                {
                    textBox2.Text = words[i] + " ";
                }
                else
                {
                    MessageBox.Show("invalid" + words[i]);
                }
            }
        }

      
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CountWordLengths()
        {
            string[] words = richTextBox1.Text.Split(' ');

            Dictionary<int, int> wordLengths = new Dictionary<int, int>();

            foreach (string word in words)
            {
                int length = 0;
                foreach (char c in word)
                {
                    if (char.IsLetter(c))
                    {
                        length++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (length > 0)
                {
                    if (wordLengths.ContainsKey(length))
                    {
                        wordLengths[length]++;
                    }
                    else
                    {
                        wordLengths.Add(length, 1);
                    }
                }
            }

            
            foreach (KeyValuePair<int, int> entry in wordLengths)
            {
                
                VysledekOutput.AppendText(string.Format("{0} písmen ve slově: {1}{2}", entry.Key, entry.Value, Environment.NewLine));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VysledekOutput.Text = "";
            CountWordLengths();
        }
    }

}

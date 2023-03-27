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

            int totalLength = 0;
            int totalCount = 0;

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
                    totalLength += length;
                    totalCount++;

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

            if (totalCount > 0)
            {
                double average = (double)totalLength / totalCount;
                textbox3.Text = $"Aritmetický průměr: {average:F2}{Environment.NewLine}";

                double variance = 0;
                foreach (int length in wordLengths.Keys)
                {
                    variance += Math.Pow(length - average, 2) * wordLengths[length];
                }
                variance /= totalCount;

                double smero = Math.Sqrt(variance);
                textbox4.Text = $"Směrodatná odchylka: {smero:F2}{Environment.NewLine}";
                textbox5.Text = $"Rozptyl: {variance:F2}{Environment.NewLine}";

                // Modus
                int modeCount = 0;
                int modeValue = 0;
                foreach (KeyValuePair<int, int> entry in wordLengths)
                {
                    if (entry.Value > modeCount)
                    {
                        modeCount = entry.Value;
                        modeValue = entry.Key;
                    }
                }
                textboxM.Text = $"Modus: {modeValue}{Environment.NewLine}";

                // median
                int medianIndex = totalCount / 2;
                int medianValue = 0;
                int countSoFar = 0;
                foreach (KeyValuePair<int, int> entry in wordLengths)
                {
                    countSoFar += entry.Value;
                    if (countSoFar > medianIndex || (totalCount % 2 == 0 && countSoFar == medianIndex))
                    {
                        medianValue = entry.Key;
                        break;
                    }
                }
                textboxME.Text = $"Medián: {medianValue}{Environment.NewLine}";

                double variacniKoeficient = (smero / average) * 100;

                textboxVV.Text = $"Variační koeficient(procent): {variacniKoeficient}{Environment.NewLine}";
            }

            foreach (KeyValuePair<int, int> entry in wordLengths)
            {
                VysledekOutput.AppendText(string.Format("{0} písmen ve slově: {1}{2}", entry.Key, entry.Value, Environment.NewLine));
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            VysledekOutput.Text = "";
            textbox3.Text = "";
            textbox4.Text = "";
            textbox5.Text = "";
            textboxM.Text = "";
            textboxME.Text = "";
            CountWordLengths(); 
        }
    }

}

using Backprop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamWangan_BackPropagation
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        String fileName;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(11, 20, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //initiate inputs, desired outputs and let the algorithm learn
            var data = File.ReadAllLines(fileName)
                    .Skip(1) // Skip header row
                    .Select(row => row.Split(',')) // Split rows by comma
                    .Select(row => new
                    {
                        Inputs = row.Take(row.Length - 1).Select(float.Parse).ToArray(),
                        Output = float.Parse(row.Last())
                    })
                    .ToArray();

            // Create neural network
            var numInputs = data.First().Inputs.Length;
            var numOutputs = 1;
            var numHidden = 10; // Adjust as needed
            nn = new NeuralNet(numInputs, numHidden, numOutputs);
            for (int i = 0; i < Convert.ToInt32(txtTraining.Text); i++)
            {
                foreach (var row in data)
                {
                    nn.setInputs(0, row.Inputs[0]);
                    nn.setInputs(1, row.Inputs[1]);
                    nn.setInputs(2, row.Inputs[2]);
                    nn.setInputs(3, row.Inputs[3]);
                    nn.setInputs(4, row.Inputs[4]);
                    nn.setInputs(5, row.Inputs[5]);
                    nn.setInputs(6, row.Inputs[6]);
                    nn.setInputs(7, row.Inputs[7]);
                    nn.setInputs(8, row.Inputs[8]);
                    nn.setInputs(9, row.Inputs[9]);
                    nn.setInputs(10, row.Inputs[10]);
                    nn.setDesiredOutput(0, row.Output);
                    nn.learn();
                }
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(txtInput1.Text));
            nn.setInputs(1, Convert.ToDouble(txtInput2.Text));
            nn.setInputs(2, Convert.ToDouble(txtInput3.Text));
            nn.setInputs(3, Convert.ToDouble(txtInput4.Text));
            nn.setInputs(4, Convert.ToDouble(txtInput1.Text));
            nn.setInputs(5, Convert.ToDouble(txtInput2.Text));
            nn.setInputs(6, Convert.ToDouble(txtInput3.Text));
            nn.setInputs(7, Convert.ToDouble(txtInput4.Text));
            nn.setInputs(8, Convert.ToDouble(txtInput2.Text));
            nn.setInputs(9, Convert.ToDouble(txtInput3.Text));
            nn.setInputs(10, Convert.ToDouble(txtInput4.Text));
            nn.run();
            txtResult.Text = "" + nn.getOuputData(0);

        }

    
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            fileName = openFileDialog1.FileName;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}

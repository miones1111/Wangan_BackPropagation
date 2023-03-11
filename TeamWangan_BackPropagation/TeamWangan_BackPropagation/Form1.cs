using Backprop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamWangan_BackPropagation
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(4, 10, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //initiate inputs, desired outputs and let the algorithm learn
            for (int i = 0; i < Convert.ToInt32(txtTraining.Text); i++)
            {
                nn.setInputs(0, 14.9);
                nn.setInputs(1, 22.7);
                nn.setInputs(2, 29.1);
                nn.setInputs(3, 83.7);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 15.9);
                nn.setInputs(1, 25.4);
                nn.setInputs(2, 28.3);
                nn.setInputs(3, 72.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 9.0);
                nn.setInputs(1, 21.5);
                nn.setInputs(2, 29.6);
                nn.setInputs(3, 71.2);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();
                
                nn.setInputs(0, 14.9);
                nn.setInputs(1, 16.0);
                nn.setInputs(2, 31.4);
                nn.setInputs(3, 87.5);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 14.7);
                nn.setInputs(1, 22.0);
                nn.setInputs(2, 28.2);
                nn.setInputs(3, 99.5);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 11.6);
                nn.setInputs(1, 22.3); 
                nn.setInputs(2, 30.9);
                nn.setInputs(3, 74.5);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 12.7);
                nn.setInputs(1, 19.5);
                nn.setInputs(2, 28.9);
                nn.setInputs(3, 82.1);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 12.7);
                nn.setInputs(1, 28.5);
                nn.setInputs(2, 28.2);
                nn.setInputs(3, 92.3);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 14.1);
                nn.setInputs(1, 29.7);
                nn.setInputs(2, 30.5); 
                nn.setInputs(3, 75.2);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 14.9);
                nn.setInputs(1, 25.8);
                nn.setInputs(2, 31.3);	
                nn.setInputs(3, 82.9);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 13.0);
                nn.setInputs(1, 18.3);
                nn.setInputs(2, 29.6); 
                nn.setInputs(3, 87.8);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 16.7);
                nn.setInputs(1, 27.5);
                nn.setInputs(2, 28.2);
                nn.setInputs(3, 93.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 13.4);
                nn.setInputs(1, 25.2);
                nn.setInputs(2, 30.2);
                nn.setInputs(3, 95.9);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 14.7);
                nn.setInputs(1, 28.9);
                nn.setInputs(2, 31.0);
                nn.setInputs(3, 69.8);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 15.9);
                nn.setInputs(1, 24.3);
                nn.setInputs(2, 28.7);
                nn.setInputs(3, 91.5);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 14.0);
                nn.setInputs(1, 25.5);
                nn.setInputs(2, 32.0);
                nn.setInputs(3, 81.6);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 15.9);
                nn.setInputs(1, 24.0);
                nn.setInputs(2, 27.9);
                nn.setInputs(3, 83.7);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 12.3);
                nn.setInputs(1, 21.8);
                nn.setInputs(2, 27.8);
                nn.setInputs(3, 77.9);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 15.4);
                nn.setInputs(1, 24.6);
                nn.setInputs(2, 30.1);
                nn.setInputs(3, 94.3);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 13.6);
                nn.setInputs(1, 19.3);
                nn.setInputs(2, 31.4);
                nn.setInputs(3, 78.9);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 16.5);
                nn.setInputs(1, 19.3);
                nn.setInputs(2, 29.2);
                nn.setInputs(3, 69.7);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 16.2);
                nn.setInputs(1, 17.2);
                nn.setInputs(2, 32.2);
                nn.setInputs(3, 78.4);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 6.9);
                nn.setInputs(1, 28.1);
                nn.setInputs(2, 32.5);
                nn.setInputs(3, 94.6);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 11.8);
                nn.setInputs(1, 16.3);
                nn.setInputs(2, 30.9);
                nn.setInputs(3, 78.7);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 11.0);
                nn.setInputs(1, 26.0);
                nn.setInputs(2, 32.2);
                nn.setInputs(3, 98.9);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 11.0);
                nn.setInputs(1, 25.2);	
                nn.setInputs(2, 30.9);
                nn.setInputs(3, 83.2);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 10.7);
                nn.setInputs(1, 21.3); 	
                nn.setInputs(2, 29.1);
                nn.setInputs(3, 78.7);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 14.8);
                nn.setInputs(1, 23.4);
                nn.setInputs(2, 29.2);
                nn.setInputs(3, 74.7);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 12.1);
                nn.setInputs(1, 28.3);
                nn.setInputs(2, 29.2);
                nn.setInputs(3, 99.7);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 14.7);
                nn.setInputs(1, 23.4);
                nn.setInputs(2, 29.9);
                nn.setInputs(3, 85.3);
                nn.setDesiredOutput(0, 0);
                nn.learn();
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(txtInput1.Text));
            nn.setInputs(1, Convert.ToDouble(txtInput2.Text));
            nn.setInputs(2, Convert.ToDouble(txtInput3.Text));
            nn.setInputs(3, Convert.ToDouble(txtInput4.Text));
            nn.run();
            txtResult.Text = "" + nn.getOuputData(0);

        }

        
    }
}

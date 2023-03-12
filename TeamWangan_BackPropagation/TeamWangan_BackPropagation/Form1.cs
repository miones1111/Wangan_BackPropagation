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
                nn.setInputs(0, 60.1);
                nn.setInputs(1, 28.2);
                nn.setInputs(2, 20.0);
                nn.setInputs(3, 9.6);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 31.0);
                nn.setInputs(2, 13.0);
                nn.setInputs(3, 13.8);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 32.2);
                nn.setInputs(2, 13.0);
                nn.setInputs(3, 13.4);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();
                
                nn.setInputs(0, 93.1);
                nn.setInputs(1, 30.8);
                nn.setInputs(2, 14.9);
                nn.setInputs(3, 11.3);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 31.2);
                nn.setInputs(2, 13.2);
                nn.setInputs(3, 11.5);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 31.7); 
                nn.setInputs(2, 30.9);
                nn.setInputs(3, 14.5);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 29.3);
                nn.setInputs(2, 16.2);
                nn.setInputs(3, 12.4);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 31.7);
                nn.setInputs(2, 15.2);
                nn.setInputs(3, 13.9);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 31.0);
                nn.setInputs(2, 17.9); 
                nn.setInputs(3, 12);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 29.2);
                nn.setInputs(2, 15.6);	
                nn.setInputs(3, 13.3);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 30.0);
                nn.setInputs(2, 24.6); 
                nn.setInputs(3, 6.1);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 30.2);
                nn.setInputs(2, 14.3);
                nn.setInputs(3, 13.4);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 31.0);
                nn.setInputs(2, 16.8);
                nn.setInputs(3, 10.2);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 34.6);
                nn.setInputs(2, 15.6);
                nn.setInputs(3, 9.3);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 30.4);
                nn.setInputs(2, 14.7);
                nn.setInputs(3, 12.0);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 32.1);
                nn.setInputs(2, 13.2);
                nn.setInputs(3, 14.3);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 31.6);
                nn.setInputs(2, 14.4);
                nn.setInputs(3, 13.1);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 30.8);
                nn.setInputs(2, 14.9);
                nn.setInputs(3, 11.3);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 28.8);
                nn.setInputs(2, 25.0);
                nn.setInputs(3, 9.0);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 31.6);
                nn.setInputs(2, 13.3);
                nn.setInputs(3, 15.6);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 31.4);
                nn.setInputs(2, 17.2);
                nn.setInputs(3, 12.7);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 28.9);
                nn.setInputs(2, 16.0);
                nn.setInputs(3, 9.3);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 29.8);
                nn.setInputs(2, 15.8);
                nn.setInputs(3, 10.7);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 33.5);
                nn.setInputs(2, 14.3);
                nn.setInputs(3, 11.7);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 30.2);
                nn.setInputs(2, 16.1);
                nn.setInputs(3, 11.6);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 28.8);	
                nn.setInputs(2, 22.5);
                nn.setInputs(3, 10.6);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 29.9); 	
                nn.setInputs(2, 13.5);
                nn.setInputs(3, 12.7);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 29.4);
                nn.setInputs(2, 17.7);
                nn.setInputs(3, 11.3);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 29.0);
                nn.setInputs(2, 16.3);
                nn.setInputs(3, 10.1);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                nn.setInputs(0, 93.1);
                nn.setInputs(1, 29.3);
                nn.setInputs(2, 16.2);
                nn.setInputs(3, 12.5);
                nn.setDesiredOutput(0, 1.0);
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

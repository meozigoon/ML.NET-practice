using ML_NET_연습;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ML.NET_연습
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Load sample data
                var sampleData = new PracticeModel.ModelInput()
                {
                    Col0 = InputBox.Text,
                };

                //Load model and predict output
                var result = PracticeModel.Predict(sampleData);
                label1.Text = result.PredictedLabel == 1 ? "positive" : "negative";
                label1.Text += "\n" + "1: " + result.Score[0].ToString("F2") + " / 0: " + result.Score[1].ToString("F2");
            }
        }
    }
}

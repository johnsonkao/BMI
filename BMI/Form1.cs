using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        enum LEVEL {過輕,正常,過重,輕度肥胖,中度肥胖,重度肥胖};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal bmi=0;
            decimal weight=0;
            decimal height=0;
            decimal.TryParse(txtWeight.Text, out weight);
            decimal.TryParse(txtHeight.Text, out height);

            if (height == 0)
            {
                MessageBox.Show("輸入錯誤");
                return;
            }
            height = height / 100;
            bmi = weight / (height * height);
            lblBMI.Text = bmi.ToString("#.#");
            if (bmi < 18.5m)
                lblSuggestion.Text = LEVEL.過重.ToString();
            else if (bmi >= 18.5m && bmi < 24m)
                lblSuggestion.Text = LEVEL.正常.ToString();
            else if (bmi >=24m && bmi <27m)
                lblSuggestion.Text = LEVEL.過重.ToString();
            else if (bmi >=27m && bmi < 30m)
                lblSuggestion.Text = LEVEL.輕度肥胖.ToString();
            else if (bmi >= 30m && bmi < 35m)
                lblSuggestion.Text = LEVEL.中度肥胖.ToString();
            else if (bmi >= 35m )
                lblSuggestion.Text = LEVEL.重度肥胖.ToString();
        }
    }
}

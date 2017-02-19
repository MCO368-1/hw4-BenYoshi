using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsTempConverter
{
    public partial class Form1 : Form
    {
        private double input;
        private Temp from, to;
        private double result;

        public Form1()
        {
            InitializeComponent();
            cbFrom.DataSource = Enum.GetValues(typeof(Temp));
            cbTo.DataSource = Enum.GetValues(typeof(Temp));
            this.AcceptButton = btnConvert;
        }

        private void ConvertButton1Click(object sender, EventArgs e)
        {
            input = Convert.ToDouble(txtInput.Text);
            from = (Temp)Enum.Parse(typeof(Temp), cbFrom.Text);
            to = (Temp)Enum.Parse(typeof(Temp), cbTo.Text);

            result = Utilities.ConvertTemp(from, to, input);

            labelResult.Text = result.ToString("n");
        }

        private void FromComboBox1SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ToLabel2Click(object sender, EventArgs e)
        {

        }

        private void ToComboBox2SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FromLabel1Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ResultLabel5Click(object sender, EventArgs e)
        {

        }

        private void InputTextBox1TextChanged(object sender, EventArgs e)
        {

        }

        private void InputLabel3Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ResultLabel6Click(object sender, EventArgs e)
        {

        }
    }
}

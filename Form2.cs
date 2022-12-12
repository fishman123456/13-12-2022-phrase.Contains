using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forum_12_12_2022_input_output_file
{
    public partial class Form2 : Form
    {
        public Form2( string f)
        {
            InitializeComponent();
            textBox1.Text = f;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}

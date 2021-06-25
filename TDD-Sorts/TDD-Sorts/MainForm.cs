using System;
using System.Windows.Forms;
using TDD_Sorts.Utility;

namespace TDD_Sorts
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            textBox_input.Text = SortManager.GenerateRandomArray((int)numericUpDown_length.Value, (int)numericUpDown_maxInt.Value);
        }

        private void button_sort_Click(object sender, EventArgs e)
        {
            
        }

        private void button_scramble_Click(object sender, EventArgs e)
        {

        }
    }
}

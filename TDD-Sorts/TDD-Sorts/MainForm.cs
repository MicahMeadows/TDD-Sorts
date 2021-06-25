using System;
using System.Windows.Forms;
using TDD_Sorts.Utility;
using TDD_Sorts.Sorting;

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

            int[] convertedArray = SortManager.MakeIntArray(textBox_input.Text);

            if (radioButton_bubbleSort.Checked)
                BubbleSort.Sort(convertedArray);
            else if (radioButton_insertionSort.Checked)
                InsertionSort.Sort(convertedArray);

            textBox_input.Text = SortManager.IntArrayToString(convertedArray);


        }

        private void button_scramble_Click(object sender, EventArgs e)
        {
            int[] convertedArray = SortManager.MakeIntArray(textBox_input.Text);
            int swaps = (convertedArray != null ? convertedArray.Length * 4 : 0);
            textBox_input.Text = SortManager.ScrambleArray(convertedArray, swaps);
        }
    }
}

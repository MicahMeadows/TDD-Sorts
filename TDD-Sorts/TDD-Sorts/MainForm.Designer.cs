
namespace TDD_Sorts
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButton_insertionSort = new System.Windows.Forms.RadioButton();
            this.radioButton_bubbleSort = new System.Windows.Forms.RadioButton();
            this.numericUpDown_maxInt = new System.Windows.Forms.NumericUpDown();
            this.label_maxInt = new System.Windows.Forms.Label();
            this.label_length = new System.Windows.Forms.Label();
            this.numericUpDown_length = new System.Windows.Forms.NumericUpDown();
            this.button_generate = new System.Windows.Forms.Button();
            this.button_scramble = new System.Windows.Forms.Button();
            this.button_sort = new System.Windows.Forms.Button();
            this.textBox_input = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_length)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_insertionSort
            // 
            this.radioButton_insertionSort.AutoSize = true;
            this.radioButton_insertionSort.Location = new System.Drawing.Point(439, 265);
            this.radioButton_insertionSort.Name = "radioButton_insertionSort";
            this.radioButton_insertionSort.Size = new System.Drawing.Size(87, 17);
            this.radioButton_insertionSort.TabIndex = 29;
            this.radioButton_insertionSort.TabStop = true;
            this.radioButton_insertionSort.Text = "Insertion Sort";
            this.radioButton_insertionSort.UseVisualStyleBackColor = true;
            // 
            // radioButton_bubbleSort
            // 
            this.radioButton_bubbleSort.AutoSize = true;
            this.radioButton_bubbleSort.Location = new System.Drawing.Point(439, 242);
            this.radioButton_bubbleSort.Name = "radioButton_bubbleSort";
            this.radioButton_bubbleSort.Size = new System.Drawing.Size(80, 17);
            this.radioButton_bubbleSort.TabIndex = 28;
            this.radioButton_bubbleSort.TabStop = true;
            this.radioButton_bubbleSort.Text = "Bubble Sort";
            this.radioButton_bubbleSort.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_maxInt
            // 
            this.numericUpDown_maxInt.Location = new System.Drawing.Point(290, 265);
            this.numericUpDown_maxInt.Name = "numericUpDown_maxInt";
            this.numericUpDown_maxInt.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown_maxInt.TabIndex = 27;
            this.numericUpDown_maxInt.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label_maxInt
            // 
            this.label_maxInt.AutoSize = true;
            this.label_maxInt.Location = new System.Drawing.Point(242, 267);
            this.label_maxInt.Name = "label_maxInt";
            this.label_maxInt.Size = new System.Drawing.Size(42, 13);
            this.label_maxInt.TabIndex = 26;
            this.label_maxInt.Text = "Max Int";
            // 
            // label_length
            // 
            this.label_length.AutoSize = true;
            this.label_length.Location = new System.Drawing.Point(242, 246);
            this.label_length.Name = "label_length";
            this.label_length.Size = new System.Drawing.Size(40, 13);
            this.label_length.TabIndex = 25;
            this.label_length.Text = "Length";
            // 
            // numericUpDown_length
            // 
            this.numericUpDown_length.Location = new System.Drawing.Point(290, 239);
            this.numericUpDown_length.Name = "numericUpDown_length";
            this.numericUpDown_length.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown_length.TabIndex = 24;
            this.numericUpDown_length.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(254, 291);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(75, 23);
            this.button_generate.TabIndex = 23;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = true;
            // 
            // button_scramble
            // 
            this.button_scramble.Location = new System.Drawing.Point(493, 137);
            this.button_scramble.Name = "button_scramble";
            this.button_scramble.Size = new System.Drawing.Size(65, 31);
            this.button_scramble.TabIndex = 22;
            this.button_scramble.Text = "Scramble";
            this.button_scramble.UseVisualStyleBackColor = true;
            // 
            // button_sort
            // 
            this.button_sort.Location = new System.Drawing.Point(439, 288);
            this.button_sort.Name = "button_sort";
            this.button_sort.Size = new System.Drawing.Size(75, 23);
            this.button_sort.TabIndex = 21;
            this.button_sort.Text = "Sort";
            this.button_sort.UseVisualStyleBackColor = true;
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(263, 143);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(224, 20);
            this.textBox_input.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton_insertionSort);
            this.Controls.Add(this.radioButton_bubbleSort);
            this.Controls.Add(this.numericUpDown_maxInt);
            this.Controls.Add(this.label_maxInt);
            this.Controls.Add(this.label_length);
            this.Controls.Add(this.numericUpDown_length);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.button_scramble);
            this.Controls.Add(this.button_sort);
            this.Controls.Add(this.textBox_input);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_length)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_insertionSort;
        private System.Windows.Forms.RadioButton radioButton_bubbleSort;
        private System.Windows.Forms.NumericUpDown numericUpDown_maxInt;
        private System.Windows.Forms.Label label_maxInt;
        private System.Windows.Forms.Label label_length;
        private System.Windows.Forms.NumericUpDown numericUpDown_length;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.Button button_scramble;
        private System.Windows.Forms.Button button_sort;
        private System.Windows.Forms.TextBox textBox_input;
    }
}


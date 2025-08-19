namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label5 = new Label();
            DateTimeBox = new TextBox();
            label4 = new Label();
            DecimalBox = new TextBox();
            KeyBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            ClearButton = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(DateTimeBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(DecimalBox);
            groupBox1.Controls.Add(KeyBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(ClearButton);
            groupBox1.Location = new Point(44, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(695, 151);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "検索条件";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(327, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(543, 35);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(62, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "bool値";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(420, 116);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(104, 19);
            radioButton2.TabIndex = 7;
            radioButton2.Text = "画面すべてクリア";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(294, 116);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(120, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "検索条件のみクリア";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(243, 39);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 22;
            label5.Text = "3つ以上の何か";
            // 
            // DateTimeBox
            // 
            DateTimeBox.Location = new Point(327, 65);
            DateTimeBox.Name = "DateTimeBox";
            DateTimeBox.Size = new Size(100, 23);
            DateTimeBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(265, 68);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 20;
            label4.Text = "DateTime";
            // 
            // DecimalBox
            // 
            DecimalBox.Location = new Point(99, 65);
            DecimalBox.Name = "DecimalBox";
            DecimalBox.Size = new Size(100, 23);
            DecimalBox.TabIndex = 2;
            // 
            // KeyBox
            // 
            KeyBox.Location = new Point(99, 36);
            KeyBox.Name = "KeyBox";
            KeyBox.Size = new Size(100, 23);
            KeyBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 68);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 17;
            label3.Text = "数値 (decimal)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 39);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 16;
            label2.Text = "キー値 (String)";
            // 
            // button2
            // 
            button2.Location = new Point(611, 112);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "検索";
            button2.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(530, 112);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(75, 23);
            ClearButton.TabIndex = 8;
            ClearButton.Text = "クリア";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(44, 394);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "選択";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(664, 394);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 12;
            button4.Text = "閉じる";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 183);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(695, 193);
            dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox checkBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label5;
        private TextBox DateTimeBox;
        private Label label4;
        private TextBox DecimalBox;
        private TextBox KeyBox;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button ClearButton;
        private ComboBox comboBox1;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
    }
}

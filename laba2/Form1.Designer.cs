namespace laba2
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            tabPage2 = new TabPage();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            textBox2 = new TextBox();
            button5 = new Button();
            label2 = new Label();
            button6 = new Button();
            button4 = new Button();
            textBox4 = new TextBox();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            label5 = new Label();
            dataGridView3 = new DataGridView();
            textBox5 = new TextBox();
            button7 = new Button();
            label6 = new Label();
            button8 = new Button();
            button9 = new Button();
            textBox6 = new TextBox();
            label7 = new Label();
            dataGridView4 = new DataGridView();
            textBox7 = new TextBox();
            button10 = new Button();
            label8 = new Label();
            button11 = new Button();
            button12 = new Button();
            textBox8 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(2, -2);
            tabControl1.Margin = new Padding(2, 2, 2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(820, 369);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2, 2, 2, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 2, 2, 2);
            tabPage1.Size = new Size(812, 336);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "RR";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(159, 58);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 15;
            label4.Text = "Quantum";
            label4.UseCompatibleTextRendering = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(155, 85);
            textBox3.Margin = new Padding(2, 2, 2, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(72, 27);
            textBox3.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(155, 5);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 13;
            label3.Text = "Burst Time";
            label3.UseCompatibleTextRendering = true;
            // 
            // button3
            // 
            button3.Location = new Point(311, 68);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(170, 27);
            button3.TabIndex = 4;
            button3.Text = "Вычислить параметры";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(311, 20);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(150, 27);
            button2.TabIndex = 3;
            button2.Text = "Сброс процессов";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(155, 31);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(72, 27);
            textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 146);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(803, 180);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(34, 31);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(102, 52);
            button1.TabIndex = 0;
            button1.Text = "Добавить процесс";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2, 2, 2, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 2, 2, 2);
            tabPage2.Size = new Size(812, 336);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "SJF";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(186, 66);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 25);
            label1.TabIndex = 22;
            label1.Text = "AT";
            label1.UseCompatibleTextRendering = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(5, 154);
            dataGridView2.Margin = new Padding(2, 2, 2, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(809, 180);
            dataGridView2.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(159, 93);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(72, 27);
            textBox2.TabIndex = 21;
            // 
            // button5
            // 
            button5.Location = new Point(313, 27);
            button5.Margin = new Padding(2, 2, 2, 2);
            button5.Name = "button5";
            button5.Size = new Size(150, 27);
            button5.TabIndex = 18;
            button5.Text = "Сброс процессов";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(159, 13);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 20;
            label2.Text = "Burst Time";
            label2.UseCompatibleTextRendering = true;
            // 
            // button6
            // 
            button6.Location = new Point(38, 39);
            button6.Margin = new Padding(2, 2, 2, 2);
            button6.Name = "button6";
            button6.Size = new Size(102, 52);
            button6.TabIndex = 16;
            button6.Text = "Добавить процесс";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.Location = new Point(313, 72);
            button4.Margin = new Padding(2, 2, 2, 2);
            button4.Name = "button4";
            button4.Size = new Size(170, 27);
            button4.TabIndex = 19;
            button4.Text = "Вычислить параметры";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(159, 39);
            textBox4.Margin = new Padding(2, 2, 2, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(72, 27);
            textBox4.TabIndex = 17;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(textBox5);
            tabPage3.Controls.Add(button7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(button8);
            tabPage3.Controls.Add(button9);
            tabPage3.Controls.Add(textBox6);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(2, 2, 2, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(812, 336);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "PSJF";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(dataGridView4);
            tabPage4.Controls.Add(textBox7);
            tabPage4.Controls.Add(button10);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(button11);
            tabPage4.Controls.Add(button12);
            tabPage4.Controls.Add(textBox8);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(2, 2, 2, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(812, 336);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "RR SJF";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(183, 61);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(24, 25);
            label5.TabIndex = 30;
            label5.Text = "AT";
            label5.UseCompatibleTextRendering = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(2, 149);
            dataGridView3.Margin = new Padding(2);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.RowTemplate.Height = 33;
            dataGridView3.Size = new Size(809, 180);
            dataGridView3.TabIndex = 23;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(156, 88);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(72, 27);
            textBox5.TabIndex = 29;
            // 
            // button7
            // 
            button7.Location = new Point(310, 22);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(150, 27);
            button7.TabIndex = 26;
            button7.Text = "Сброс процессов";
            button7.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(156, 8);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 28;
            label6.Text = "Burst Time";
            label6.UseCompatibleTextRendering = true;
            // 
            // button8
            // 
            button8.Location = new Point(35, 34);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(102, 52);
            button8.TabIndex = 24;
            button8.Text = "Добавить процесс";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(310, 67);
            button9.Margin = new Padding(2);
            button9.Name = "button9";
            button9.Size = new Size(170, 27);
            button9.TabIndex = 27;
            button9.Text = "Вычислить параметры";
            button9.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(156, 34);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(72, 27);
            textBox6.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(183, 61);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(24, 25);
            label7.TabIndex = 30;
            label7.Text = "AT";
            label7.UseCompatibleTextRendering = true;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(2, 149);
            dataGridView4.Margin = new Padding(2);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 62;
            dataGridView4.RowTemplate.Height = 33;
            dataGridView4.Size = new Size(809, 180);
            dataGridView4.TabIndex = 23;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(156, 88);
            textBox7.Margin = new Padding(2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(72, 27);
            textBox7.TabIndex = 29;
            // 
            // button10
            // 
            button10.Location = new Point(310, 22);
            button10.Margin = new Padding(2);
            button10.Name = "button10";
            button10.Size = new Size(150, 27);
            button10.TabIndex = 26;
            button10.Text = "Сброс процессов";
            button10.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(156, 8);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(78, 25);
            label8.TabIndex = 28;
            label8.Text = "Burst Time";
            label8.UseCompatibleTextRendering = true;
            // 
            // button11
            // 
            button11.Location = new Point(35, 34);
            button11.Margin = new Padding(2);
            button11.Name = "button11";
            button11.Size = new Size(102, 52);
            button11.TabIndex = 24;
            button11.Text = "Добавить процесс";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(310, 67);
            button12.Margin = new Padding(2);
            button12.Name = "button12";
            button12.Size = new Size(170, 27);
            button12.TabIndex = 27;
            button12.Text = "Вычислить параметры";
            button12.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(156, 34);
            textBox8.Margin = new Padding(2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(72, 27);
            textBox8.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 360);
            Controls.Add(tabControl1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private Button button3;
        private Button button2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private DataGridView dataGridView2;
        private Label label1;
        private TextBox textBox2;
        private Button button5;
        private Label label2;
        private Button button6;
        private Button button4;
        private TextBox textBox4;
        private Label label5;
        private DataGridView dataGridView3;
        private TextBox textBox5;
        private Button button7;
        private Label label6;
        private Button button8;
        private Button button9;
        private TextBox textBox6;
        private Label label7;
        private DataGridView dataGridView4;
        private TextBox textBox7;
        private Button button10;
        private Label label8;
        private Button button11;
        private Button button12;
        private TextBox textBox8;
    }
}
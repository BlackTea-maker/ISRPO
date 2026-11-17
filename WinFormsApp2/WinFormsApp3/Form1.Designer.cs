namespace WinFormsApp3
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
            label4 = new Label();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 4;
            label4.Text = "Дано";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(206, 9);
            label5.Name = "label5";
            label5.Size = new Size(206, 25);
            label5.TabIndex = 8;
            label5.Text = "Результаты вычислений";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(128, 19);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "По трём сторонам";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(165, 19);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "По двум сторонам и углу";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 72);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(165, 19);
            radioButton3.TabIndex = 12;
            radioButton3.TabStop = true;
            radioButton3.Text = "По стороне и двум углам";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(12, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 96);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вариант решения";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 47);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 14;
            label1.Text = "Значение А:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 74);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 15;
            label2.Text = "Значение В:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 104);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 16;
            label3.Text = "Значение С:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(98, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(98, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(98, 100);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(203, 47);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 20;
            label6.Text = "Сторона А:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(204, 74);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 21;
            label7.Text = "Сторона В:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(203, 103);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 22;
            label8.Text = "Сторона С:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(275, 47);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(275, 74);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(275, 103);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(343, 47);
            label12.Name = "label12";
            label12.Size = new Size(47, 15);
            label12.TabIndex = 26;
            label12.Text = "Угол А:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(344, 74);
            label13.Name = "label13";
            label13.Size = new Size(46, 15);
            label13.TabIndex = 27;
            label13.Text = "Угол В:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(344, 103);
            label14.Name = "label14";
            label14.Size = new Size(47, 15);
            label14.TabIndex = 28;
            label14.Text = "Угол С:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(396, 47);
            label15.Name = "label15";
            label15.Size = new Size(0, 15);
            label15.TabIndex = 29;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(396, 74);
            label16.Name = "label16";
            label16.Size = new Size(0, 15);
            label16.TabIndex = 30;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(396, 103);
            label17.Name = "label17";
            label17.Size = new Size(0, 15);
            label17.TabIndex = 31;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(465, 47);
            label18.Name = "label18";
            label18.Size = new Size(70, 15);
            label18.TabIndex = 32;
            label18.Text = "Высота к А:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(465, 71);
            label19.Name = "label19";
            label19.Size = new Size(69, 15);
            label19.TabIndex = 33;
            label19.Text = "Высота к В:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(465, 96);
            label20.Name = "label20";
            label20.Size = new Size(70, 15);
            label20.TabIndex = 34;
            label20.Text = "Высота к С:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(541, 47);
            label21.Name = "label21";
            label21.Size = new Size(0, 15);
            label21.TabIndex = 35;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(540, 71);
            label22.Name = "label22";
            label22.Size = new Size(0, 15);
            label22.TabIndex = 36;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(540, 96);
            label23.Name = "label23";
            label23.Size = new Size(0, 15);
            label23.TabIndex = 37;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F);
            button1.Location = new Point(275, 155);
            button1.Name = "button1";
            button1.Size = new Size(201, 74);
            button1.TabIndex = 38;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(606, 241);
            Controls.Add(button1);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Решение треугольника";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Button button1;
    }
}

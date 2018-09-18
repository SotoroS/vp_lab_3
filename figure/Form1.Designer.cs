namespace figure
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxParallelepipedV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxParallelepipedS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxParallelepipedC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxParallelepipedB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxParallelepipedA = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBallV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBallR = new System.Windows.Forms.TextBox();
            this.textBoxBallS = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxParallelepipedV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxParallelepipedS);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxParallelepipedC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxParallelepipedB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxParallelepipedA);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параллелепипед";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "V";
            // 
            // textBoxParallelepipedV
            // 
            this.textBoxParallelepipedV.Location = new System.Drawing.Point(28, 123);
            this.textBoxParallelepipedV.Name = "textBoxParallelepipedV";
            this.textBoxParallelepipedV.ReadOnly = true;
            this.textBoxParallelepipedV.Size = new System.Drawing.Size(100, 20);
            this.textBoxParallelepipedV.TabIndex = 8;
            this.textBoxParallelepipedV.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "S";
            // 
            // textBoxParallelepipedS
            // 
            this.textBoxParallelepipedS.Location = new System.Drawing.Point(28, 97);
            this.textBoxParallelepipedS.Name = "textBoxParallelepipedS";
            this.textBoxParallelepipedS.ReadOnly = true;
            this.textBoxParallelepipedS.Size = new System.Drawing.Size(100, 20);
            this.textBoxParallelepipedS.TabIndex = 6;
            this.textBoxParallelepipedS.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "h";
            // 
            // textBoxParallelepipedC
            // 
            this.textBoxParallelepipedC.Location = new System.Drawing.Point(28, 71);
            this.textBoxParallelepipedC.Name = "textBoxParallelepipedC";
            this.textBoxParallelepipedC.Size = new System.Drawing.Size(100, 20);
            this.textBoxParallelepipedC.TabIndex = 4;
            this.textBoxParallelepipedC.Text = "0";
            this.textBoxParallelepipedC.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxParallelepipedC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "b";
            // 
            // textBoxParallelepipedB
            // 
            this.textBoxParallelepipedB.Location = new System.Drawing.Point(28, 45);
            this.textBoxParallelepipedB.Name = "textBoxParallelepipedB";
            this.textBoxParallelepipedB.Size = new System.Drawing.Size(100, 20);
            this.textBoxParallelepipedB.TabIndex = 2;
            this.textBoxParallelepipedB.Text = "0";
            this.textBoxParallelepipedB.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxParallelepipedB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "a";
            // 
            // textBoxParallelepipedA
            // 
            this.textBoxParallelepipedA.Location = new System.Drawing.Point(28, 19);
            this.textBoxParallelepipedA.Name = "textBoxParallelepipedA";
            this.textBoxParallelepipedA.Size = new System.Drawing.Size(100, 20);
            this.textBoxParallelepipedA.TabIndex = 0;
            this.textBoxParallelepipedA.Text = "0";
            this.textBoxParallelepipedA.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxParallelepipedA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxBallV);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxBallR);
            this.groupBox2.Controls.Add(this.textBoxBallS);
            this.groupBox2.Location = new System.Drawing.Point(152, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 103);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Шар";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "V";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "r";
            // 
            // textBoxBallV
            // 
            this.textBoxBallV.Location = new System.Drawing.Point(28, 71);
            this.textBoxBallV.Name = "textBoxBallV";
            this.textBoxBallV.ReadOnly = true;
            this.textBoxBallV.Size = new System.Drawing.Size(100, 20);
            this.textBoxBallV.TabIndex = 12;
            this.textBoxBallV.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "S";
            // 
            // textBoxBallR
            // 
            this.textBoxBallR.Location = new System.Drawing.Point(28, 19);
            this.textBoxBallR.Name = "textBoxBallR";
            this.textBoxBallR.Size = new System.Drawing.Size(100, 20);
            this.textBoxBallR.TabIndex = 0;
            this.textBoxBallR.Text = "0";
            this.textBoxBallR.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxBallR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxBallS
            // 
            this.textBoxBallS.Location = new System.Drawing.Point(28, 45);
            this.textBoxBallS.Name = "textBoxBallS";
            this.textBoxBallS.ReadOnly = true;
            this.textBoxBallS.Size = new System.Drawing.Size(100, 20);
            this.textBoxBallS.TabIndex = 10;
            this.textBoxBallS.Text = "0";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(152, 121);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(134, 46);
            this.buttonCalc.TabIndex = 7;
            this.buttonCalc.Text = "Посчитать";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 179);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Figure";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxParallelepipedA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxParallelepipedV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxParallelepipedS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxParallelepipedC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxParallelepipedB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBallV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxBallR;
        private System.Windows.Forms.TextBox textBoxBallS;
        private System.Windows.Forms.Button buttonCalc;
    }
}


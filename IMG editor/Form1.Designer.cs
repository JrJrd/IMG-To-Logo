namespace IMG_editor
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            txtslct = new System.Windows.Forms.TextBox();
            txtsv = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtw = new System.Windows.Forms.TextBox();
            txth = new System.Windows.Forms.TextBox();
            comboBox = new System.Windows.Forms.ComboBox();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 43);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Select Image";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 94);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Save Image";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(354, 35);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(354, 85);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtslct
            // 
            txtslct.Location = new System.Drawing.Point(90, 36);
            txtslct.Name = "txtslct";
            txtslct.Size = new System.Drawing.Size(258, 23);
            txtslct.TabIndex = 4;
            // 
            // txtsv
            // 
            txtsv.Location = new System.Drawing.Point(90, 86);
            txtsv.Name = "txtsv";
            txtsv.Size = new System.Drawing.Size(258, 23);
            txtsv.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(199, 144);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(43, 15);
            label3.TabIndex = 6;
            label3.Text = "Height";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(45, 146);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Width";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(115, 202);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(31, 15);
            label5.TabIndex = 8;
            label5.Text = "Type";
            // 
            // txtw
            // 
            txtw.Location = new System.Drawing.Point(90, 136);
            txtw.Name = "txtw";
            txtw.Size = new System.Drawing.Size(100, 23);
            txtw.TabIndex = 9;
            // 
            // txth
            // 
            txth.Location = new System.Drawing.Point(248, 138);
            txth.Name = "txth";
            txth.Size = new System.Drawing.Size(100, 23);
            txth.TabIndex = 10;
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new System.Drawing.Point(161, 194);
            comboBox.Name = "comboBox";
            comboBox.Size = new System.Drawing.Size(121, 23);
            comboBox.TabIndex = 11;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(115, 247);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "Resize";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(248, 247);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(75, 23);
            button4.TabIndex = 13;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(451, 311);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(comboBox);
            Controls.Add(txth);
            Controls.Add(txtw);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtsv);
            Controls.Add(txtslct);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtslct;
        private System.Windows.Forms.TextBox txtsv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtw;
        private System.Windows.Forms.TextBox txth;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

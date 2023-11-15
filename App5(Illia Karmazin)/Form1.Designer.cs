namespace App5_Illia_Karmazin_
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
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            listBox1 = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(358, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(169, 43);
            label1.TabIndex = 0;
            label1.Text = "DataBase";
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(45, 145);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 43);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(45, 260);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(116, 43);
            label3.TabIndex = 2;
            label3.Text = "Surname";
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(45, 382);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(159, 43);
            label4.TabIndex = 3;
            label4.Text = "Date of birth";
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(45, 511);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(116, 43);
            label5.TabIndex = 4;
            label5.Text = "Gender";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(45, 209);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(271, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(45, 322);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(271, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(45, 450);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(271, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(45, 590);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(271, 27);
            textBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(366, 167);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(147, 69);
            button1.TabIndex = 9;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(553, 167);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(156, 69);
            button2.TabIndex = 10;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(734, 167);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(150, 69);
            button3.TabIndex = 11;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new System.Drawing.Point(374, 273);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(510, 344);
            listBox1.TabIndex = 12;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(917, 678);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "DataBase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

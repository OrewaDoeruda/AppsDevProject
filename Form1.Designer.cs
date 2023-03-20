namespace ACTIVITY_2
{
    partial class Form1
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
            this.wishlist = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fillButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.countOutputBox = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wishlist
            // 
            this.wishlist.FormattingEnabled = true;
            this.wishlist.Location = new System.Drawing.Point(60, 97);
            this.wishlist.Name = "wishlist";
            this.wishlist.Size = new System.Drawing.Size(175, 225);
            this.wishlist.TabIndex = 0;
            this.wishlist.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wish List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fillButton
            // 
            this.fillButton.Location = new System.Drawing.Point(271, 97);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(89, 30);
            this.fillButton.TabIndex = 2;
            this.fillButton.Text = "Fill";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // countOutputBox
            // 
            this.countOutputBox.Location = new System.Drawing.Point(271, 205);
            this.countOutputBox.Name = "countOutputBox";
            this.countOutputBox.Size = new System.Drawing.Size(89, 30);
            this.countOutputBox.TabIndex = 4;
            this.countOutputBox.Text = "Count";
            this.countOutputBox.UseVisualStyleBackColor = true;
            this.countOutputBox.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Selection:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Count:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(117, 369);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(199, 20);
            this.TextBox1.TabIndex = 8;
            this.TextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(117, 420);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(199, 20);
            this.textBox.TabIndex = 9;
            this.textBox.TextChanged += new System.EventHandler(this.CountingBox_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(271, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 30);
            this.button4.TabIndex = 10;
            this.button4.Text = "Sort";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countOutputBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fillButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wishlist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox wishlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button countOutputBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}


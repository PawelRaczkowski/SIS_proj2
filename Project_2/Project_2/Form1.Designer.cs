namespace Project_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.value_a = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.value_b = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mod_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.n_channels = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "P(x)=P0*(1+x+ax^2+bx^3)";
            // 
            // value_a
            // 
            this.value_a.Location = new System.Drawing.Point(111, 77);
            this.value_a.Name = "value_a";
            this.value_a.Size = new System.Drawing.Size(100, 23);
            this.value_a.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Value of a";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // value_b
            // 
            this.value_b.Location = new System.Drawing.Point(111, 123);
            this.value_b.Name = "value_b";
            this.value_b.Size = new System.Drawing.Size(100, 23);
            this.value_b.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Value of b";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // mod_id
            // 
            this.mod_id.Location = new System.Drawing.Point(111, 176);
            this.mod_id.Name = "mod_id";
            this.mod_id.Size = new System.Drawing.Size(100, 23);
            this.mod_id.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mod. index";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // n_channels
            // 
            this.n_channels.Location = new System.Drawing.Point(111, 238);
            this.n_channels.Name = "n_channels";
            this.n_channels.Size = new System.Drawing.Size(100, 23);
            this.n_channels.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "No of channels";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "x(t)=m*sum(cos(wi*t+phi))";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(60, 286);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(151, 45);
            this.calculate.TabIndex = 4;
            this.calculate.Text = "Calculate CSO and CTB";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // results
            // 
            this.results.FormattingEnabled = true;
            this.results.ItemHeight = 15;
            this.results.Location = new System.Drawing.Point(421, 78);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(279, 259);
            this.results.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.results);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.n_channels);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mod_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.value_b);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.value_a);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox value_a;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox value_b;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mod_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox n_channels;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.ListBox results;
        private System.Windows.Forms.Label label7;
    }
}


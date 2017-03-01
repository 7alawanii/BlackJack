namespace BlackJack
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
            this.start = new System.Windows.Forms.Button();
            this.hit = new System.Windows.Forms.Button();
            this.stand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_my = new System.Windows.Forms.TextBox();
            this.computer = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.DarkGray;
            this.start.FlatAppearance.BorderSize = 0;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.DarkRed;
            this.start.Location = new System.Drawing.Point(1, 1);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(175, 53);
            this.start.TabIndex = 0;
            this.start.Text = "Start Game";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // hit
            // 
            this.hit.BackColor = System.Drawing.Color.DarkGray;
            this.hit.FlatAppearance.BorderSize = 0;
            this.hit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hit.ForeColor = System.Drawing.Color.DarkRed;
            this.hit.Location = new System.Drawing.Point(12, 314);
            this.hit.Name = "hit";
            this.hit.Size = new System.Drawing.Size(136, 53);
            this.hit.TabIndex = 1;
            this.hit.Text = "Hit";
            this.hit.UseVisualStyleBackColor = false;
            this.hit.Click += new System.EventHandler(this.hit_Click);
            // 
            // stand
            // 
            this.stand.BackColor = System.Drawing.Color.DarkGray;
            this.stand.FlatAppearance.BorderSize = 0;
            this.stand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stand.ForeColor = System.Drawing.Color.DarkRed;
            this.stand.Location = new System.Drawing.Point(509, 314);
            this.stand.Name = "stand";
            this.stand.Size = new System.Drawing.Size(136, 53);
            this.stand.TabIndex = 2;
            this.stand.Text = "Stand";
            this.stand.UseVisualStyleBackColor = false;
            this.stand.Click += new System.EventHandler(this.stand_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(51, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "You";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(24, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your Hand";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(533, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Computer";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(506, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Computer\'s Hand";
            // 
            // txt_my
            // 
            this.txt_my.Enabled = false;
            this.txt_my.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_my.Location = new System.Drawing.Point(12, 201);
            this.txt_my.Multiline = true;
            this.txt_my.Name = "txt_my";
            this.txt_my.ReadOnly = true;
            this.txt_my.Size = new System.Drawing.Size(136, 107);
            this.txt_my.TabIndex = 7;
            // 
            // computer
            // 
            this.computer.Enabled = false;
            this.computer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computer.ForeColor = System.Drawing.Color.Black;
            this.computer.Location = new System.Drawing.Point(509, 201);
            this.computer.Multiline = true;
            this.computer.Name = "computer";
            this.computer.ReadOnly = true;
            this.computer.Size = new System.Drawing.Size(136, 107);
            this.computer.TabIndex = 8;
            // 
            // result
            // 
            this.result.Enabled = false;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(158, 314);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(345, 44);
            this.result.TabIndex = 9;
            // 
            // total
            // 
            this.total.Enabled = false;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(154, 284);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(49, 24);
            this.total.TabIndex = 10;
            this.total.TextChanged += new System.EventHandler(this.total_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(154, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(454, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dtotal
            // 
            this.dtotal.Enabled = false;
            this.dtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtotal.Location = new System.Drawing.Point(454, 284);
            this.dtotal.Name = "dtotal";
            this.dtotal.ReadOnly = true;
            this.dtotal.Size = new System.Drawing.Size(49, 24);
            this.dtotal.TabIndex = 13;
            // 
            // Form1
            // 
            this.BackgroundImage = global::BlackJack.Properties.Resources.black;
            this.ClientSize = new System.Drawing.Size(657, 370);
            this.Controls.Add(this.dtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.total);
            this.Controls.Add(this.result);
            this.Controls.Add(this.computer);
            this.Controls.Add(this.txt_my);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stand);
            this.Controls.Add(this.hit);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "BlackJack Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        public System.Windows.Forms.Button start;
        public System.Windows.Forms.Button hit;
        public System.Windows.Forms.Button stand;
        public System.Windows.Forms.TextBox computer;
        public System.Windows.Forms.TextBox txt_my;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dtotal;
    }
}


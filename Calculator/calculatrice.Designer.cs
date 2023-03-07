namespace Calculator
{
    partial class calculatrice
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.text = new System.Windows.Forms.TextBox();
            this.buttonMoins = new System.Windows.Forms.Button();
            this.buttonFois = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonEffacer = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonEgal = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.chifre7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.text);
            this.panel1.Controls.Add(this.buttonMoins);
            this.panel1.Controls.Add(this.buttonFois);
            this.panel1.Controls.Add(this.buttonDiv);
            this.panel1.Controls.Add(this.buttonEffacer);
            this.panel1.Controls.Add(this.buttonPlus);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.buttonEgal);
            this.panel1.Controls.Add(this.button0);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.chifre7);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(77, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 304);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(16, 26);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(353, 31);
            this.text.TabIndex = 12;
            this.text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonMoins
            // 
            this.buttonMoins.BackColor = System.Drawing.Color.Plum;
            this.buttonMoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoins.ForeColor = System.Drawing.Color.Black;
            this.buttonMoins.Location = new System.Drawing.Point(295, 223);
            this.buttonMoins.Name = "buttonMoins";
            this.buttonMoins.Size = new System.Drawing.Size(74, 30);
            this.buttonMoins.TabIndex = 10;
            this.buttonMoins.Text = "-";
            this.buttonMoins.UseVisualStyleBackColor = false;
            this.buttonMoins.Click += new System.EventHandler(this.buttonMoins_Click);
            // 
            // buttonFois
            // 
            this.buttonFois.BackColor = System.Drawing.Color.Plum;
            this.buttonFois.ForeColor = System.Drawing.Color.Black;
            this.buttonFois.Location = new System.Drawing.Point(295, 179);
            this.buttonFois.Name = "buttonFois";
            this.buttonFois.Size = new System.Drawing.Size(74, 30);
            this.buttonFois.TabIndex = 11;
            this.buttonFois.Text = "x";
            this.buttonFois.UseVisualStyleBackColor = false;
            this.buttonFois.Click += new System.EventHandler(this.buttonFois_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.BackColor = System.Drawing.Color.Plum;
            this.buttonDiv.ForeColor = System.Drawing.Color.Black;
            this.buttonDiv.Location = new System.Drawing.Point(295, 136);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(74, 30);
            this.buttonDiv.TabIndex = 10;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = false;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonEffacer
            // 
            this.buttonEffacer.BackColor = System.Drawing.Color.Plum;
            this.buttonEffacer.ForeColor = System.Drawing.Color.Black;
            this.buttonEffacer.Location = new System.Drawing.Point(295, 98);
            this.buttonEffacer.Name = "buttonEffacer";
            this.buttonEffacer.Size = new System.Drawing.Size(74, 30);
            this.buttonEffacer.TabIndex = 9;
            this.buttonEffacer.Text = "CE";
            this.buttonEffacer.UseVisualStyleBackColor = false;
            this.buttonEffacer.Click += new System.EventHandler(this.buttonEffacer_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.Plum;
            this.buttonPlus.ForeColor = System.Drawing.Color.Black;
            this.buttonPlus.Location = new System.Drawing.Point(199, 223);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(74, 30);
            this.buttonPlus.TabIndex = 8;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Plum;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(199, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 30);
            this.button3.TabIndex = 8;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonEgal
            // 
            this.buttonEgal.BackColor = System.Drawing.Color.Plum;
            this.buttonEgal.ForeColor = System.Drawing.Color.Black;
            this.buttonEgal.Location = new System.Drawing.Point(107, 223);
            this.buttonEgal.Name = "buttonEgal";
            this.buttonEgal.Size = new System.Drawing.Size(74, 30);
            this.buttonEgal.TabIndex = 7;
            this.buttonEgal.Text = "=";
            this.buttonEgal.UseVisualStyleBackColor = false;
            this.buttonEgal.Click += new System.EventHandler(this.buttonEgal_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.Plum;
            this.button0.ForeColor = System.Drawing.Color.Black;
            this.button0.Location = new System.Drawing.Point(17, 223);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(74, 30);
            this.button0.TabIndex = 6;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Plum;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(107, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Plum;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(17, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Plum;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(199, 136);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 30);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Plum;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(107, 136);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 30);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Plum;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(17, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Plum;
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(199, 98);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(74, 30);
            this.button9.TabIndex = 2;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Plum;
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(107, 98);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 30);
            this.button8.TabIndex = 1;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // chifre7
            // 
            this.chifre7.BackColor = System.Drawing.Color.Plum;
            this.chifre7.ForeColor = System.Drawing.Color.Black;
            this.chifre7.Location = new System.Drawing.Point(17, 98);
            this.chifre7.Name = "chifre7";
            this.chifre7.Size = new System.Drawing.Size(74, 30);
            this.chifre7.TabIndex = 0;
            this.chifre7.Text = "7";
            this.chifre7.UseVisualStyleBackColor = false;
            this.chifre7.Click += new System.EventHandler(this.chifre7_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(74, 279);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 22);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Realised by : Basma Akarmass";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // calculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 409);
            this.Controls.Add(this.panel1);
            this.Name = "calculatrice";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button chifre7;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonEgal;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonMoins;
        private System.Windows.Forms.Button buttonFois;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonEffacer;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.TextBox textBox1;
    }
}


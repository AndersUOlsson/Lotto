﻿namespace Lotto
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
            this.StartBtn = new System.Windows.Forms.Button();
            this.LottoRowLbl = new System.Windows.Forms.Label();
            this.triesLbl = new System.Windows.Forms.Label();
            this.fiveCorrectLbl = new System.Windows.Forms.Label();
            this.sixCorrectLbl = new System.Windows.Forms.Label();
            this.sevenCorrectLbl = new System.Windows.Forms.Label();
            this.textBoxValue1 = new System.Windows.Forms.TextBox();
            this.textBoxHowManyTries = new System.Windows.Forms.TextBox();
            this.textBoxHowManyFives = new System.Windows.Forms.TextBox();
            this.textBoxHowManySeventh = new System.Windows.Forms.TextBox();
            this.textBoxHowManySixth = new System.Windows.Forms.TextBox();
            this.textBoxValue2 = new System.Windows.Forms.TextBox();
            this.textBoxValue3 = new System.Windows.Forms.TextBox();
            this.textBoxValue4 = new System.Windows.Forms.TextBox();
            this.textBoxValue5 = new System.Windows.Forms.TextBox();
            this.textBoxValue6 = new System.Windows.Forms.TextBox();
            this.textBoxValue7 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Scorelbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Enabled = false;
            this.StartBtn.Location = new System.Drawing.Point(511, 181);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(92, 27);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Starta Lotto";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // LottoRowLbl
            // 
            this.LottoRowLbl.AutoSize = true;
            this.LottoRowLbl.Location = new System.Drawing.Point(3, 40);
            this.LottoRowLbl.Name = "LottoRowLbl";
            this.LottoRowLbl.Size = new System.Drawing.Size(64, 13);
            this.LottoRowLbl.TabIndex = 1;
            this.LottoRowLbl.Text = "Din lottorad:";
            // 
            // triesLbl
            // 
            this.triesLbl.AutoSize = true;
            this.triesLbl.Location = new System.Drawing.Point(259, 188);
            this.triesLbl.Name = "triesLbl";
            this.triesLbl.Size = new System.Drawing.Size(84, 13);
            this.triesLbl.TabIndex = 2;
            this.triesLbl.Text = "Antal dragningar";
            // 
            // fiveCorrectLbl
            // 
            this.fiveCorrectLbl.AutoSize = true;
            this.fiveCorrectLbl.Location = new System.Drawing.Point(154, 256);
            this.fiveCorrectLbl.Name = "fiveCorrectLbl";
            this.fiveCorrectLbl.Size = new System.Drawing.Size(34, 13);
            this.fiveCorrectLbl.TabIndex = 3;
            this.fiveCorrectLbl.Text = "5 rätt:";
            // 
            // sixCorrectLbl
            // 
            this.sixCorrectLbl.AutoSize = true;
            this.sixCorrectLbl.Location = new System.Drawing.Point(318, 256);
            this.sixCorrectLbl.Name = "sixCorrectLbl";
            this.sixCorrectLbl.Size = new System.Drawing.Size(31, 13);
            this.sixCorrectLbl.TabIndex = 4;
            this.sixCorrectLbl.Text = "6 rätt";
            // 
            // sevenCorrectLbl
            // 
            this.sevenCorrectLbl.AutoSize = true;
            this.sevenCorrectLbl.Location = new System.Drawing.Point(466, 256);
            this.sevenCorrectLbl.Name = "sevenCorrectLbl";
            this.sevenCorrectLbl.Size = new System.Drawing.Size(34, 13);
            this.sevenCorrectLbl.TabIndex = 5;
            this.sevenCorrectLbl.Text = "7 rätt:";
            // 
            // textBoxValue1
            // 
            this.textBoxValue1.Location = new System.Drawing.Point(70, 37);
            this.textBoxValue1.Name = "textBoxValue1";
            this.textBoxValue1.Size = new System.Drawing.Size(69, 20);
            this.textBoxValue1.TabIndex = 6;
            this.textBoxValue1.Leave += new System.EventHandler(this.textBoxValue1_TextChanged);
            // 
            // textBoxHowManyTries
            // 
            this.textBoxHowManyTries.Location = new System.Drawing.Point(349, 185);
            this.textBoxHowManyTries.Name = "textBoxHowManyTries";
            this.textBoxHowManyTries.Size = new System.Drawing.Size(140, 20);
            this.textBoxHowManyTries.TabIndex = 12;
            this.textBoxHowManyTries.TextChanged += new System.EventHandler(this.textBoxHowManyTries_TextChanged);
            // 
            // textBoxHowManyFives
            // 
            this.textBoxHowManyFives.Location = new System.Drawing.Point(195, 253);
            this.textBoxHowManyFives.Name = "textBoxHowManyFives";
            this.textBoxHowManyFives.Size = new System.Drawing.Size(100, 20);
            this.textBoxHowManyFives.TabIndex = 13;
            // 
            // textBoxHowManySeventh
            // 
            this.textBoxHowManySeventh.Location = new System.Drawing.Point(507, 253);
            this.textBoxHowManySeventh.Name = "textBoxHowManySeventh";
            this.textBoxHowManySeventh.Size = new System.Drawing.Size(100, 20);
            this.textBoxHowManySeventh.TabIndex = 15;
            // 
            // textBoxHowManySixth
            // 
            this.textBoxHowManySixth.Location = new System.Drawing.Point(359, 253);
            this.textBoxHowManySixth.Name = "textBoxHowManySixth";
            this.textBoxHowManySixth.Size = new System.Drawing.Size(100, 20);
            this.textBoxHowManySixth.TabIndex = 16;
            // 
            // textBoxValue2
            // 
            this.textBoxValue2.Location = new System.Drawing.Point(145, 37);
            this.textBoxValue2.Name = "textBoxValue2";
            this.textBoxValue2.Size = new System.Drawing.Size(69, 20);
            this.textBoxValue2.TabIndex = 17;
            this.textBoxValue2.Leave += new System.EventHandler(this.textBoxValue2_TextChanged);
            // 
            // textBoxValue3
            // 
            this.textBoxValue3.Location = new System.Drawing.Point(220, 37);
            this.textBoxValue3.Name = "textBoxValue3";
            this.textBoxValue3.Size = new System.Drawing.Size(69, 20);
            this.textBoxValue3.TabIndex = 18;
            this.textBoxValue3.Leave += new System.EventHandler(this.textBoxValue3_TextChanged);
            // 
            // textBoxValue4
            // 
            this.textBoxValue4.Location = new System.Drawing.Point(295, 37);
            this.textBoxValue4.Name = "textBoxValue4";
            this.textBoxValue4.Size = new System.Drawing.Size(69, 20);
            this.textBoxValue4.TabIndex = 19;
            this.textBoxValue4.Leave += new System.EventHandler(this.textBoxValue4_TextChanged);
            // 
            // textBoxValue5
            // 
            this.textBoxValue5.Location = new System.Drawing.Point(370, 37);
            this.textBoxValue5.Name = "textBoxValue5";
            this.textBoxValue5.Size = new System.Drawing.Size(69, 20);
            this.textBoxValue5.TabIndex = 20;
            this.textBoxValue5.Leave += new System.EventHandler(this.textBoxValue5_TextChanged);
            // 
            // textBoxValue6
            // 
            this.textBoxValue6.Location = new System.Drawing.Point(445, 37);
            this.textBoxValue6.Name = "textBoxValue6";
            this.textBoxValue6.Size = new System.Drawing.Size(69, 20);
            this.textBoxValue6.TabIndex = 21;
            this.textBoxValue6.Leave += new System.EventHandler(this.textBoxValue6_TextChanged);
            // 
            // textBoxValue7
            // 
            this.textBoxValue7.Location = new System.Drawing.Point(520, 37);
            this.textBoxValue7.Name = "textBoxValue7";
            this.textBoxValue7.Size = new System.Drawing.Size(69, 20);
            this.textBoxValue7.TabIndex = 22;
            this.textBoxValue7.Leave += new System.EventHandler(this.textBoxValue7_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LottoRowLbl);
            this.panel1.Controls.Add(this.textBoxValue7);
            this.panel1.Controls.Add(this.textBoxValue1);
            this.panel1.Controls.Add(this.textBoxValue6);
            this.panel1.Controls.Add(this.textBoxValue2);
            this.panel1.Controls.Add(this.textBoxValue5);
            this.panel1.Controls.Add(this.textBoxValue3);
            this.panel1.Controls.Add(this.textBoxValue4);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 99);
            this.panel1.TabIndex = 23;
            // 
            // Scorelbl
            // 
            this.Scorelbl.AutoSize = true;
            this.Scorelbl.Location = new System.Drawing.Point(531, 234);
            this.Scorelbl.Name = "Scorelbl";
            this.Scorelbl.Size = new System.Drawing.Size(74, 13);
            this.Scorelbl.TabIndex = 24;
            this.Scorelbl.Text = "Score counter";
            this.Scorelbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 290);
            this.Controls.Add(this.Scorelbl);
            this.Controls.Add(this.textBoxHowManySixth);
            this.Controls.Add(this.textBoxHowManySeventh);
            this.Controls.Add(this.textBoxHowManyFives);
            this.Controls.Add(this.textBoxHowManyTries);
            this.Controls.Add(this.sevenCorrectLbl);
            this.Controls.Add(this.sixCorrectLbl);
            this.Controls.Add(this.fiveCorrectLbl);
            this.Controls.Add(this.triesLbl);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Lotto";
            this.Leave += new System.EventHandler(this.textBoxValue1_TextChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label LottoRowLbl;
        private System.Windows.Forms.Label triesLbl;
        private System.Windows.Forms.Label fiveCorrectLbl;
        private System.Windows.Forms.Label sixCorrectLbl;
        private System.Windows.Forms.Label sevenCorrectLbl;
        private System.Windows.Forms.TextBox textBoxValue1;
        private System.Windows.Forms.TextBox textBoxHowManyTries;
        private System.Windows.Forms.TextBox textBoxHowManyFives;
        private System.Windows.Forms.TextBox textBoxHowManySeventh;
        private System.Windows.Forms.TextBox textBoxHowManySixth;
        private System.Windows.Forms.TextBox textBoxValue2;
        private System.Windows.Forms.TextBox textBoxValue3;
        private System.Windows.Forms.TextBox textBoxValue4;
        private System.Windows.Forms.TextBox textBoxValue5;
        private System.Windows.Forms.TextBox textBoxValue6;
        private System.Windows.Forms.TextBox textBoxValue7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Scorelbl;
    }
}


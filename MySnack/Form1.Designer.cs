using System;
using System.Windows.Forms;

namespace MySnack
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblintrodustion = new System.Windows.Forms.Label();
            this.lblguide = new System.Windows.Forms.Label();
            this.btnplay = new System.Windows.Forms.Button();
            this.btnlv3 = new System.Windows.Forms.Button();
            this.btnlv2 = new System.Windows.Forms.Button();
            this.btnlv1 = new System.Windows.Forms.Button();
            this.lblpause = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumberscore = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblintrodustion);
            this.groupBox1.Controls.Add(this.lblguide);
            this.groupBox1.Controls.Add(this.btnplay);
            this.groupBox1.Controls.Add(this.btnlv3);
            this.groupBox1.Controls.Add(this.btnlv2);
            this.groupBox1.Controls.Add(this.btnlv1);
            this.groupBox1.Controls.Add(this.lblpause);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNumberscore);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Location = new System.Drawing.Point(483, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 315);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblintrodustion
            // 
            this.lblintrodustion.AutoSize = true;
            this.lblintrodustion.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblintrodustion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblintrodustion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblintrodustion.Location = new System.Drawing.Point(12, 182);
            this.lblintrodustion.Name = "lblintrodustion";
            this.lblintrodustion.Size = new System.Drawing.Size(119, 24);
            this.lblintrodustion.TabIndex = 19;
            this.lblintrodustion.Text = "Introdustion";
            this.lblintrodustion.Click += new System.EventHandler(this.lblintrodustion_Click);
            // 
            // lblguide
            // 
            this.lblguide.AutoSize = true;
            this.lblguide.BackColor = System.Drawing.Color.SpringGreen;
            this.lblguide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblguide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblguide.Location = new System.Drawing.Point(19, 144);
            this.lblguide.Name = "lblguide";
            this.lblguide.Size = new System.Drawing.Size(108, 24);
            this.lblguide.TabIndex = 18;
            this.lblguide.Text = "---Guide---";
            this.lblguide.Click += new System.EventHandler(this.lblguide_Click);
            // 
            // btnplay
            // 
            this.btnplay.BackColor = System.Drawing.Color.Aqua;
            this.btnplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplay.ForeColor = System.Drawing.Color.Coral;
            this.btnplay.Location = new System.Drawing.Point(9, 48);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(122, 38);
            this.btnplay.TabIndex = 17;
            this.btnplay.Text = "Play";
            this.btnplay.UseVisualStyleBackColor = false;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // btnlv3
            // 
            this.btnlv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnlv3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlv3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlv3.Location = new System.Drawing.Point(99, 247);
            this.btnlv3.Name = "btnlv3";
            this.btnlv3.Size = new System.Drawing.Size(37, 31);
            this.btnlv3.TabIndex = 15;
            this.btnlv3.Text = "3";
            this.btnlv3.UseVisualStyleBackColor = false;
            this.btnlv3.Click += new System.EventHandler(this.btnlv3_Click);
            // 
            // btnlv2
            // 
            this.btnlv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnlv2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlv2.Location = new System.Drawing.Point(54, 247);
            this.btnlv2.Name = "btnlv2";
            this.btnlv2.Size = new System.Drawing.Size(39, 31);
            this.btnlv2.TabIndex = 14;
            this.btnlv2.Text = "2";
            this.btnlv2.UseVisualStyleBackColor = false;
            this.btnlv2.Click += new System.EventHandler(this.btnlv2_Click);
            // 
            // btnlv1
            // 
            this.btnlv1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnlv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnlv1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlv1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnlv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlv1.Location = new System.Drawing.Point(9, 247);
            this.btnlv1.Name = "btnlv1";
            this.btnlv1.Size = new System.Drawing.Size(39, 31);
            this.btnlv1.TabIndex = 13;
            this.btnlv1.TabStop = false;
            this.btnlv1.Text = "1";
            this.btnlv1.UseVisualStyleBackColor = false;
            this.btnlv1.Click += new System.EventHandler(this.btnlv1_Click);
            this.btnlv1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // lblpause
            // 
            this.lblpause.AutoSize = true;
            this.lblpause.BackColor = System.Drawing.Color.Coral;
            this.lblpause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblpause.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblpause.Location = new System.Drawing.Point(19, 102);
            this.lblpause.Name = "lblpause";
            this.lblpause.Size = new System.Drawing.Size(110, 24);
            this.lblpause.TabIndex = 10;
            this.lblpause.Text = "---Pause---";
            this.lblpause.Click += new System.EventHandler(this.lblpause_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.05F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mod by Trọng Đức";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Lv:";
            // 
            // lblNumberscore
            // 
            this.lblNumberscore.AutoSize = true;
            this.lblNumberscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberscore.Location = new System.Drawing.Point(96, 292);
            this.lblNumberscore.Name = "lblNumberscore";
            this.lblNumberscore.Size = new System.Drawing.Size(17, 17);
            this.lblNumberscore.TabIndex = 1;
            this.lblNumberscore.Text = "0";
            this.lblNumberscore.Click += new System.EventHandler(this.lblNumberscore_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(633, 324);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SNACK TRỌNG ĐỨC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        private void lblNumberscore_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumberscore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Label lblpause;
        private Button btnlv3;
        private Button btnlv2;
        private Button btnlv1;
        private Button btnplay;
        private Label lblguide;
        private Label lblintrodustion;
    }
}


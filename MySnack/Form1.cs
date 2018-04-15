using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySnack
{
	public partial class Form1 : Form
	{

		private int score = 0;
		private readonly Random _Random = new Random();
		private readonly Food Snackfood;

		Graphics paper;
		Snackkhuc snack = new Snackkhuc();

		private Boolean right = false, left = false, up = false, down = false;

		public Form1()
		{
			InitializeComponent();
			Snackfood = new Food(_Random);
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			paper = e.Graphics;
			snack.Drawsnack(paper);
			Snackfood.Drawfood(paper);
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Up && down == false)
			{
				up = true;
				down = left = right = false;
			}

			if (e.KeyData == Keys.Down && up == false)
			{

				down = true;
				up = left = right = false;
			}

			if (e.KeyData == Keys.Right && left == false)
			{

				right = true;
				down = left = up = false;
			}

			if (e.KeyData == Keys.Left && right == false)
			{

				left = true;
				down = up = right = false;
			}
		}

		private void btnplay_Click(object sender, EventArgs e)
		{

			btnplay.Enabled = false;
			btnlv1.Enabled = false;
			btnlv2.Enabled = false;
			btnlv3.Enabled = false;

			MessageBox.Show(@"Giờ Chỉ Cần Điều Chỉnh Rắn Là Chơi Thôi!!", @"Trọng Đức Thông báo điều này");
			timer1.Enabled = true;
			down = left = right = up = false;
			timer1_Tick(sender, e);

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (down)
			{
				snack.movedown();
			}
			if (up)
			{
				snack.moveup();
			}
			if (right)
			{
				snack.moveright();
			}
			if (left)
			{
				snack.moveleft();
			}
			Invalidate();


			if (die())
			{
				DialogResult dlR = MessageBox.Show("Bạn có muốn chơi lại!!", @"Thông Báo", MessageBoxButtons.YesNoCancel,                    MessageBoxIcon.Question);
				if (dlR == DialogResult.Yes)
				{
					score = 0;
					snack = new Snackkhuc();
					btnplay.Enabled = true;

				}
				if (dlR == DialogResult.Cancel || dlR == DialogResult.No)
				{
					Application.Exit();
				}
			}
			lblNumberscore.Text = (score.ToString());
			btnplay.BackColor = btnplay.Enabled == false ? Color.Gray : Color.Aqua;

			foreach (Rectangle t in snack.Snackrec)
			{
				if (t.IntersectsWith(Snackfood.FoodRec))
				{
					score++;
					if (score == 10)
					{
						timer1.Interval -= 20;
					}
					if (score == 20)
					{
						timer1.Interval -= 30;
					}
					if (score == 30)
					{
						timer1.Interval -= 50;
					}

					snack.GrowSnack();
					Snackfood.Foodlocation(_Random);
				}
			}
		}

		int i = 0;
		private void lblpause_Click(object sender, EventArgs e)
		{
			i++;
			if (i % 2 != 0)
			{
				timer1.Stop();
				//timer1.Enabled = false;
				lblpause.Text = "--Resume--";
				btnlv1.Enabled = true;
				btnlv2.Enabled = true;
				btnlv3.Enabled = true;
			}
			else
			{
				timer1.Start();
				lblpause.Text = "---Pause---";
				btnlv1.Enabled = false;
				btnlv2.Enabled = false;
				btnlv3.Enabled = false;
			}
		}

		private void lblintrodustion_Click(object sender, EventArgs e)
		{
			MessageBox.Show(@"GAME SNACK!! MOD BY TRỌNG ĐỨC", @"Trọng Đức");

		}

		private void lblguide_Click(object sender, EventArgs e)
		{
			MessageBox.Show(@"Chào Mừng Bạn Tới Tựa Game của Trọng Đức!! Để chơi rất đơn giản bạn chỉ cần nhấn vào nút
		 Play rồi dùng các phím lên xuống trái phải để điều chỉnh
		 rắn nhé!! ^^", @"Trọng Đức ");


		}

		private void btnlv1_Click(object sender, EventArgs e)
		{
			timer1.Interval = 300;
		}

		private void btnlv2_Click(object sender, EventArgs e)
		{
			timer1.Interval = 150;
		}

		private void btnlv3_Click(object sender, EventArgs e)
		{
			timer1.Interval = 100;
		}

		private bool die()
		{

			for (int i = 1;  i < snack.Snackrec.Length; i++)
			{
				if (snack.Snackrec[0] == snack.Snackrec[i])
				{
					timer1.Stop();
					MessageBox.Show("Đâm vào đít chết mịa !! ^^");
					return true;
				}
			}
			if (snack.Snackrec[0].X <= 0 || snack.Snackrec[0].Y <= 0 || snack.Snackrec[0].X > 465 || snack.Snackrec[0].Y > 300)
			{
				timer1.Stop();
				MessageBox.Show("Đâm vào tường chết mịa !! ^^");
				return true;
			}
			return false;
		}
	}
}

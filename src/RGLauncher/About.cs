using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RGBuilder_Launcher_Csharp
{
	public class About : Form
	{
		public const int WM_NCLBUTTONDOWN = 161;

		public const int HT_CAPTION = 2;

		private int currentName;

		private int currentCharacter;

		private int countback;

		private int pause;

		private int mode;

		private int grow;

		private string[] names = new string[]
		{
			"Tydye81",
			"Stoker25",
			"M0j0j0_j0",
			"XDK",
			"Juggahax0r",
			"Evil0ne",
			"RF1911",
			"Deathlok",
			"Mustache",
			"iCEQB",
			"spandaman"
		};

		private string[] thanks = new string[]
		{
			"[C0z]",
			"Natelx",
			"IceKiller",
			"Team-Xecuter",
			"Tortuga-Cove",
            "Xe_CREATURE"
        };

		private string[] thanksWhy = new string[]
		{
			"Being generally awesome",
			"Supporting and debugging",
			"Supporting and debugging",
			"Sponsoring our devs",
			"Providing us with a home",
            "Unofficial updates"
        };

		private IContainer components;

		private Timer timer1;

		private Label lblDevs;

		private PictureBox picThanks;

		private Label lblThanksWhy;

		private PictureBox picLilMini;

		private PictureBox picLilExit;

		public About()
		{
			this.InitializeComponent();
		}

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		private void About_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				About.ReleaseCapture();
				About.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		private void About_CrsMouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				About.ReleaseCapture();
				About.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			switch (this.mode)
			{
			case 0:
			{
				if (base.Height != 315)
				{
					base.Height = 315;
				}
				if (this.currentCharacter >= this.names[this.currentName].Length)
				{
					if (this.pause != 8)
					{
						this.pause++;
						return;
					}
					this.timer1.Interval = 50;
					if (this.pause != 8 || this.countback != this.names[this.currentName].Length)
					{
						this.countback++;
						this.lblDevs.Text = this.names[this.currentName].Substring(0, this.names[this.currentName].Length - this.countback);
						return;
					}
					this.currentCharacter = 0;
					this.countback = 0;
					this.currentName++;
					this.pause = 0;
					this.timer1.Interval = 125;
					if (this.currentName >= this.names.Length)
					{
						this.currentName = 0;
						this.mode = 1;
						return;
					}
				}
				this.currentCharacter++;
				Label expr_13F = this.lblDevs;
				expr_13F.Text += this.names[this.currentName].Substring(this.currentCharacter - 1, 1);
				return;
			}
			case 1:
				this.picThanks.Visible = true;
				if (this.grow == 0)
				{
					this.timer1.Interval = 10;
					if (base.Height < 400)
					{
						base.Height += 5;
						return;
					}
					this.grow = 1;
					return;
				}
				else
				{
					if (this.grow == 1)
					{
						if (base.Height != 400)
						{
							base.Height = 400;
						}
						this.timer1.Interval = 125;
						if (this.currentCharacter >= this.thanks[this.currentName].Length)
						{
							if (this.pause != 8)
							{
								this.pause++;
								return;
							}
							this.timer1.Interval = 50;
							if (this.pause != 8 || this.countback != this.thanks[this.currentName].Length)
							{
								this.countback++;
								this.lblDevs.Text = this.thanks[this.currentName].Substring(0, this.thanks[this.currentName].Length - this.countback);
								return;
							}
							this.currentCharacter = 0;
							this.countback = 0;
							this.currentName++;
							this.pause = 0;
							this.timer1.Interval = 125;
							if (this.currentName >= this.thanks.Length)
							{
								this.currentName = 0;
								this.grow = 2;
								return;
							}
						}
						this.lblThanksWhy.Text = this.thanksWhy[this.currentName];
						this.currentCharacter++;
						Label expr_30A = this.lblDevs;
						expr_30A.Text += this.thanks[this.currentName].Substring(this.currentCharacter - 1, 1);
						return;
					}
					this.timer1.Interval = 10;
					if (base.Height > 315)
					{
						base.Height -= 5;
						return;
					}
					this.grow = 0;
					this.mode = 0;
					this.picThanks.Visible = false;
					this.timer1.Interval = 125;
					return;
				}
			default:
				return;
			}
		}

		private void About_Load(object sender, EventArgs e)
		{
			this.timer1.Enabled = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void picLilMini_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void picLilExit_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDevs = new System.Windows.Forms.Label();
            this.picThanks = new System.Windows.Forms.PictureBox();
            this.lblThanksWhy = new System.Windows.Forms.Label();
            this.picLilMini = new System.Windows.Forms.PictureBox();
            this.picLilExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picThanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLilMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLilExit)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 125;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDevs
            // 
            this.lblDevs.BackColor = System.Drawing.Color.Transparent;
            this.lblDevs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevs.ForeColor = System.Drawing.Color.Black;
            this.lblDevs.Location = new System.Drawing.Point(68, 238);
            this.lblDevs.Name = "lblDevs";
            this.lblDevs.Size = new System.Drawing.Size(173, 36);
            this.lblDevs.TabIndex = 0;
            this.lblDevs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picThanks
            // 
            this.picThanks.Image = global::AboutRes.picThanks;
            this.picThanks.Location = new System.Drawing.Point(62, 194);
            this.picThanks.Name = "picThanks";
            this.picThanks.Size = new System.Drawing.Size(185, 37);
            this.picThanks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThanks.TabIndex = 3;
            this.picThanks.TabStop = false;
            this.picThanks.Visible = false;
            // 
            // lblThanksWhy
            // 
            this.lblThanksWhy.BackColor = System.Drawing.Color.Transparent;
            this.lblThanksWhy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanksWhy.ForeColor = System.Drawing.Color.Black;
            this.lblThanksWhy.Location = new System.Drawing.Point(29, 345);
            this.lblThanksWhy.Name = "lblThanksWhy";
            this.lblThanksWhy.Size = new System.Drawing.Size(254, 33);
            this.lblThanksWhy.TabIndex = 4;
            this.lblThanksWhy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLilMini
            // 
            this.picLilMini.BackColor = System.Drawing.Color.Transparent;
            this.picLilMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLilMini.Image = global::SharedRes.picLilMini;
            this.picLilMini.Location = new System.Drawing.Point(272, 1);
            this.picLilMini.Name = "picLilMini";
            this.picLilMini.Size = new System.Drawing.Size(20, 20);
            this.picLilMini.TabIndex = 25;
            this.picLilMini.TabStop = false;
            this.picLilMini.Click += new System.EventHandler(this.picLilMini_Click);
            // 
            // picLilExit
            // 
            this.picLilExit.BackColor = System.Drawing.Color.Transparent;
            this.picLilExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLilExit.Image = global::SharedRes.picLilExit;
            this.picLilExit.Location = new System.Drawing.Point(289, 1);
            this.picLilExit.Name = "picLilExit";
            this.picLilExit.Size = new System.Drawing.Size(20, 20);
            this.picLilExit.TabIndex = 24;
            this.picLilExit.TabStop = false;
            this.picLilExit.Click += new System.EventHandler(this.picLilExit_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AboutRes.picBackground;
            this.ClientSize = new System.Drawing.Size(310, 315);
            this.Controls.Add(this.picLilMini);
            this.Controls.Add(this.picLilExit);
            this.Controls.Add(this.lblThanksWhy);
            this.Controls.Add(this.picThanks);
            this.Controls.Add(this.lblDevs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "Credits";
            this.Load += new System.EventHandler(this.About_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.About_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picThanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLilMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLilExit)).EndInit();
            this.ResumeLayout(false);

		}
	}
}

using IniParser;
using Form1SubPage;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RGBuilder_Launcher_Csharp
{
	public class Form1 : Form
	{
		public const int WM_NCLBUTTONDOWN = 161;

		public const int HT_CAPTION = 2;

		private IContainer components;

		private TextBox txtCpu;

		private PictureBox picBuilder;

		private PictureBox picEditor;

		private PictureBox picExit;

		private RadioButton radHackJTAG;

		private RadioButton radHackRGH;

		private Panel pnlHack;

		private Panel pnlVersion;

		private TextBox txtNandLoc;

		private OpenFileDialog openFileDialog1;

		private PictureBox picNand;

		private PictureBox picRead;

		private PictureBox picAbout;

		private PictureBox picLilExit;

		private PictureBox picLilMini;

		private RadioButton radHackRGH2;

		private Label txtRglVersion;

		private PictureBox picDonate;

		private CheckedListBox kernelCheckedBox;

		private Image picTemp;

        public IContainer Components { get => components; set => components = value; }

        protected override void Dispose(bool disposing)
		{
			if (disposing && this.Components != null)
			{
				this.Components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtCpu = new System.Windows.Forms.TextBox();
            this.picBuilder = new System.Windows.Forms.PictureBox();
            this.picEditor = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.radHackJTAG = new System.Windows.Forms.RadioButton();
            this.radHackRGH = new System.Windows.Forms.RadioButton();
            this.pnlHack = new System.Windows.Forms.Panel();
            this.radHackRGH2 = new System.Windows.Forms.RadioButton();
            this.pnlVersion = new System.Windows.Forms.Panel();
            this.kernelCheckedBox = new System.Windows.Forms.CheckedListBox();
            this.txtNandLoc = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picNand = new System.Windows.Forms.PictureBox();
            this.picRead = new System.Windows.Forms.PictureBox();
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.picLilExit = new System.Windows.Forms.PictureBox();
            this.picLilMini = new System.Windows.Forms.PictureBox();
            this.txtRglVersion = new System.Windows.Forms.Label();
            this.picDonate = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBuilder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.pnlHack.SuspendLayout();
            this.pnlVersion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLilExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLilMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDonate)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCpu
            // 
            this.txtCpu.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCpu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpu.ForeColor = System.Drawing.Color.Black;
            this.txtCpu.Location = new System.Drawing.Point(108, 277);
            this.txtCpu.Name = "txtCpu";
            this.txtCpu.Size = new System.Drawing.Size(275, 13);
            this.txtCpu.TabIndex = 4;
            this.txtCpu.Text = "00000000000000000000000000000000";
            this.txtCpu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picBuilder
            // 
            this.picBuilder.BackColor = System.Drawing.Color.Transparent;
            this.picBuilder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBuilder.Image = global::Form1Res1.picBuilder;
            this.picBuilder.Location = new System.Drawing.Point(30, 360);
            this.picBuilder.Name = "picBuilder";
            this.picBuilder.Size = new System.Drawing.Size(121, 26);
            this.picBuilder.TabIndex = 5;
            this.picBuilder.TabStop = false;
            this.picBuilder.Click += new System.EventHandler(this.picBuilder_Click);
            this.picBuilder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBuilder_MouseDown);
            this.picBuilder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBuilder_MouseUp);
            // 
            // picEditor
            // 
            this.picEditor.BackColor = System.Drawing.Color.Transparent;
            this.picEditor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEditor.Image = global::Form1Res1.picEditor;
            this.picEditor.Location = new System.Drawing.Point(151, 360);
            this.picEditor.Name = "picEditor";
            this.picEditor.Size = new System.Drawing.Size(130, 26);
            this.picEditor.TabIndex = 6;
            this.picEditor.TabStop = false;
            this.picEditor.Click += new System.EventHandler(this.picGUI_Click);
            this.picEditor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picGUI_MouseDown);
            this.picEditor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picGUI_MouseUp);
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = global::Form1Res1.picExit;
            this.picExit.Location = new System.Drawing.Point(565, 360);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(58, 26);
            this.picExit.TabIndex = 7;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            this.picExit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picExit_MouseDown);
            this.picExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picExit_MouseUp);
            // 
            // radHackJTAG
            // 
            this.radHackJTAG.AutoSize = true;
            this.radHackJTAG.BackColor = System.Drawing.Color.Transparent;
            this.radHackJTAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.radHackJTAG.ForeColor = System.Drawing.Color.Black;
            this.radHackJTAG.Location = new System.Drawing.Point(6, 1);
            this.radHackJTAG.Name = "radHackJTAG";
            this.radHackJTAG.Size = new System.Drawing.Size(56, 17);
            this.radHackJTAG.TabIndex = 8;
            this.radHackJTAG.TabStop = true;
            this.radHackJTAG.Text = "JTAG";
            this.radHackJTAG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radHackJTAG.UseMnemonic = false;
            this.radHackJTAG.UseVisualStyleBackColor = false;
            // 
            // radHackRGH
            // 
            this.radHackRGH.AutoSize = true;
            this.radHackRGH.BackColor = System.Drawing.Color.Transparent;
            this.radHackRGH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.radHackRGH.ForeColor = System.Drawing.Color.Black;
            this.radHackRGH.Location = new System.Drawing.Point(6, 18);
            this.radHackRGH.Name = "radHackRGH";
            this.radHackRGH.Size = new System.Drawing.Size(52, 17);
            this.radHackRGH.TabIndex = 9;
            this.radHackRGH.TabStop = true;
            this.radHackRGH.Text = "RGH";
            this.radHackRGH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radHackRGH.UseVisualStyleBackColor = false;
            // 
            // pnlHack
            // 
            this.pnlHack.BackColor = System.Drawing.Color.Transparent;
            this.pnlHack.Controls.Add(this.radHackRGH2);
            this.pnlHack.Controls.Add(this.radHackRGH);
            this.pnlHack.Controls.Add(this.radHackJTAG);
            this.pnlHack.Location = new System.Drawing.Point(411, 284);
            this.pnlHack.Name = "pnlHack";
            this.pnlHack.Size = new System.Drawing.Size(85, 56);
            this.pnlHack.TabIndex = 15;
            // 
            // radHackRGH2
            // 
            this.radHackRGH2.AutoSize = true;
            this.radHackRGH2.BackColor = System.Drawing.Color.Transparent;
            this.radHackRGH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.radHackRGH2.ForeColor = System.Drawing.Color.Black;
            this.radHackRGH2.Location = new System.Drawing.Point(6, 35);
            this.radHackRGH2.Name = "radHackRGH2";
            this.radHackRGH2.Size = new System.Drawing.Size(59, 17);
            this.radHackRGH2.TabIndex = 10;
            this.radHackRGH2.TabStop = true;
            this.radHackRGH2.Text = "RGH2";
            this.radHackRGH2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radHackRGH2.UseVisualStyleBackColor = false;
            // 
            // pnlVersion
            // 
            this.pnlVersion.BackColor = System.Drawing.Color.Transparent;
            this.pnlVersion.Controls.Add(this.kernelCheckedBox);
            this.pnlVersion.ForeColor = System.Drawing.Color.Transparent;
            this.pnlVersion.Location = new System.Drawing.Point(523, 282);
            this.pnlVersion.Name = "pnlVersion";
            this.pnlVersion.Size = new System.Drawing.Size(112, 58);
            this.pnlVersion.TabIndex = 16;
            // 
            // kernelCheckedBox
            // 
            this.kernelCheckedBox.FormattingEnabled = true;
            this.kernelCheckedBox.Items.AddRange(new object[] {
            "17150",
            "17489"});
            this.kernelCheckedBox.Location = new System.Drawing.Point(0, 3);
            this.kernelCheckedBox.Name = "kernelCheckedBox";
            this.kernelCheckedBox.Size = new System.Drawing.Size(109, 49);
            this.kernelCheckedBox.TabIndex = 0;
            this.kernelCheckedBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // txtNandLoc
            // 
            this.txtNandLoc.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNandLoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNandLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtNandLoc.ForeColor = System.Drawing.Color.Black;
            this.txtNandLoc.Location = new System.Drawing.Point(92, 320);
            this.txtNandLoc.Name = "txtNandLoc";
            this.txtNandLoc.ReadOnly = true;
            this.txtNandLoc.Size = new System.Drawing.Size(291, 13);
            this.txtNandLoc.TabIndex = 17;
            this.txtNandLoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "bin";
            this.openFileDialog1.FileName = "nand.bin";
            this.openFileDialog1.Filter = "Nand Bin File|*.bin|Nand ECC File|*.ecc|All Files|*.**";
            this.openFileDialog1.ShowReadOnly = true;
            this.openFileDialog1.Title = "Go Fetch Your Nand! Slut!";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // picNand
            // 
            this.picNand.BackColor = System.Drawing.Color.Transparent;
            this.picNand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNand.Image = global::Form1Res1.picNand;
            this.picNand.Location = new System.Drawing.Point(20, 314);
            this.picNand.Name = "picNand";
            this.picNand.Size = new System.Drawing.Size(68, 26);
            this.picNand.TabIndex = 19;
            this.picNand.TabStop = false;
            this.picNand.Click += new System.EventHandler(this.picNand_Click);
            this.picNand.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picNand_MouseDown);
            this.picNand.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picNand_MouseUp);
            // 
            // picRead
            // 
            this.picRead.BackColor = System.Drawing.Color.Transparent;
            this.picRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRead.Image = global::Form1Res1.picRead;
            this.picRead.Location = new System.Drawing.Point(281, 360);
            this.picRead.Name = "picRead";
            this.picRead.Size = new System.Drawing.Size(93, 26);
            this.picRead.TabIndex = 20;
            this.picRead.TabStop = false;
            this.picRead.Click += new System.EventHandler(this.picHow_Click);
            this.picRead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picHow_MouseDown);
            this.picRead.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picHow_MouseUp);
            // 
            // picAbout
            // 
            this.picAbout.BackColor = System.Drawing.Color.Transparent;
            this.picAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAbout.Image = global::Form1Res1.picAbout;
            this.picAbout.Location = new System.Drawing.Point(374, 360);
            this.picAbout.Name = "picAbout";
            this.picAbout.Size = new System.Drawing.Size(102, 26);
            this.picAbout.TabIndex = 21;
            this.picAbout.TabStop = false;
            this.picAbout.Click += new System.EventHandler(this.picAbout_Click);
            this.picAbout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picAbout_MouseDown);
            this.picAbout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picAbout_MouseUp);
            // 
            // picLilExit
            // 
            this.picLilExit.BackColor = System.Drawing.Color.Transparent;
            this.picLilExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLilExit.Image = global::SharedRes.picLilExit;
            this.picLilExit.Location = new System.Drawing.Point(640, 0);
            this.picLilExit.Name = "picLilExit";
            this.picLilExit.Size = new System.Drawing.Size(20, 20);
            this.picLilExit.TabIndex = 22;
            this.picLilExit.TabStop = false;
            this.picLilExit.Click += new System.EventHandler(this.picLilExit_Click);
            // 
            // picLilMini
            // 
            this.picLilMini.BackColor = System.Drawing.Color.Transparent;
            this.picLilMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLilMini.Image = global::SharedRes.picLilMini;
            this.picLilMini.Location = new System.Drawing.Point(620, 0);
            this.picLilMini.Name = "picLilMini";
            this.picLilMini.Size = new System.Drawing.Size(20, 20);
            this.picLilMini.TabIndex = 23;
            this.picLilMini.TabStop = false;
            this.picLilMini.Click += new System.EventHandler(this.picLilMini_Click);
            // 
            // txtRglVersion
            // 
            this.txtRglVersion.AutoSize = true;
            this.txtRglVersion.BackColor = System.Drawing.Color.Transparent;
            this.txtRglVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRglVersion.ForeColor = System.Drawing.Color.DarkGray;
            this.txtRglVersion.Location = new System.Drawing.Point(571, 218);
            this.txtRglVersion.Name = "txtRglVersion";
            this.txtRglVersion.Size = new System.Drawing.Size(64, 24);
            this.txtRglVersion.TabIndex = 24;
            this.txtRglVersion.Text = "0v000";
            // 
            // picDonate
            // 
            this.picDonate.BackColor = System.Drawing.Color.Transparent;
            this.picDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDonate.Image = global::Form1Res1.picDonate;
            this.picDonate.Location = new System.Drawing.Point(476, 360);
            this.picDonate.Name = "picDonate";
            this.picDonate.Size = new System.Drawing.Size(89, 26);
            this.picDonate.TabIndex = 25;
            this.picDonate.TabStop = false;
            this.picDonate.Click += new System.EventHandler(this.picDonate_Click);
            this.picDonate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picDonate_MouseDown);
            this.picDonate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picDonate_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Form1Res1.picBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(660, 400);
            this.Controls.Add(this.picDonate);
            this.Controls.Add(this.txtRglVersion);
            this.Controls.Add(this.picLilMini);
            this.Controls.Add(this.picLilExit);
            this.Controls.Add(this.picAbout);
            this.Controls.Add(this.picRead);
            this.Controls.Add(this.picNand);
            this.Controls.Add(this.txtNandLoc);
            this.Controls.Add(this.pnlVersion);
            this.Controls.Add(this.pnlHack);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.picEditor);
            this.Controls.Add(this.picBuilder);
            this.Controls.Add(this.txtCpu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XDK Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picBuilder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.pnlHack.ResumeLayout(false);
            this.pnlHack.PerformLayout();
            this.pnlVersion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLilExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLilMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDonate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		public Form1()
		{
			this.InitializeComponent();
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.AssemblyResolve += new ResolveEventHandler(this.currentDomain_AssemblyResolve);
			this.load_INI();
		}

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Form1.ReleaseCapture();
				Form1.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		private bool ValidateLocation()
		{
			string path = Variables.LocalPath + "\\rgbuild\\rgbuild.exe";
			if (!File.Exists(path))
			{
				MessageBox.Show("The Launcher is not installed correctly!\nPlease make sure RGBuild.exe is located at \\rgbuild\\rgbuild.exe");
				return false;
			}
			return true;
		}

		public new bool Validate()
		{
			Variables.CPUkey = this.txtCpu.Text;
			string text = this.txtNandLoc.Text;
			//Variables.LocalPath + "\\rgbuild\\rgbuild.exe";
			if (Variables.CPUkey.ToUpper().Equals("PORKCHOPS") || Variables.CPUkey.ToUpper().Equals("PORKCHOP") || Variables.CPUkey.Equals("BACON"))
			{
				MessageBox.Show("May the bacon gods bless you." + Environment.NewLine + "But no, Invalid CPUKey");
				return false;
			}
			if (Variables.CPUkey.Equals("00000000000000000000000000000000"))
			{
				MessageBox.Show("Please enter a valid CPU Key");
				return false;
			}
			if (Variables.CPUkey.Count<char>() != 32)
			{
				MessageBox.Show("Please enter a valid CPU Key");
				return false;
			}
			if (!this.ValidateLocation())
			{
				MessageBox.Show("The builder is not present or this file is not in the appropriate location." + Environment.NewLine + "Refer to readme");
				return false;
			}
			if (text.Equals("Please Select Your Nand Location"))
			{
				MessageBox.Show("Specify your nand image location!");
				return false;
			}
			if (!File.Exists(text))
			{
				MessageBox.Show("Please make sure nand.bin is properly located.");
				return false;
			}
			return true;
		}

		private Assembly currentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
		{
			string text = "";
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			AssemblyName[] referencedAssemblies = executingAssembly.GetReferencedAssemblies();
			AssemblyName[] array = referencedAssemblies;
			for (int i = 0; i < array.Length; i++)
			{
				AssemblyName assemblyName = array[i];
				if (assemblyName.FullName.Substring(0, assemblyName.FullName.IndexOf(",")) == args.Name.Substring(0, args.Name.IndexOf(",")))
				{
					text = Path.GetDirectoryName(Application.ExecutablePath);
					if (text.EndsWith("\\"))
					{
						text += "\\";
					}
					if (args.Name.Substring(0, args.Name.IndexOf(",")) == "INIFileParser" || args.Name.Substring(0, args.Name.IndexOf(",")) == "irrKlang.NET4")
					{
						text += "\\rgbuild\\";
					}
					text = text + args.Name.Substring(0, args.Name.IndexOf(",")) + ".dll";
					break;
				}
			}
			return Assembly.LoadFrom(text);
		}

		private void load_INI()
		{
			IniData iniData = null;
			try
			{
				FileIniDataParser fileIniDataParser = new FileIniDataParser();
				iniData = fileIniDataParser.LoadFile(Variables.LocalPath + "\\options.ini");
			}
			catch
			{
				return;
			}
			if (!string.IsNullOrEmpty(iniData["RGLauncher"]["CPU_Key"]))
			{
				this.txtCpu.Text = iniData["RGLauncher"]["CPU_Key"];
			}
			if (!string.IsNullOrEmpty(iniData["RGLauncher"]["exploit"]))
			{
				string a = iniData["RGLauncher"]["exploit"];
				if (a == this.radHackJTAG.Text)
				{
					this.radHackJTAG.Checked = true;
				}
				else if (a == this.radHackRGH.Text)
				{
					this.radHackRGH.Checked = true;
				}
				else if (a == this.radHackRGH2.Text)
				{
					this.radHackRGH2.Checked = true;
				}
			}
			if (!string.IsNullOrEmpty(iniData["RGLauncher"]["nand_location"]))
			{
				this.txtNandLoc.Text = iniData["RGLauncher"]["nand_location"];
			}
			if (!string.IsNullOrEmpty(iniData["RGLauncher"]["kernel"]))
			{
				string b = iniData["RGLauncher"]["kernel"];
				int i = 0;
				while (i < this.kernelCheckedBox.Items.Count)
				{
					if (this.kernelCheckedBox.Items[i].ToString() == b)
					{
						int num = this.kernelCheckedBox.Items.IndexOf(this.kernelCheckedBox.Items[i]);
						if (num > 0)
						{
							this.kernelCheckedBox.SetSelected(num, true);
							this.kernelCheckedBox.SetItemChecked(num, true);
							break;
						}
						break;
					}
					else
					{
						i++;
					}
				}
			}
			if (!string.IsNullOrEmpty(iniData["RGLauncher"]["rglversion"]))
			{
				this.txtRglVersion.Text = iniData["RGLauncher"]["rglversion"];
			}
		}

		private void save_INI()
		{
			FileIniDataParser fileIniDataParser = null;
			IniData iniData = null;
			try
			{
				fileIniDataParser = new FileIniDataParser();
				iniData = fileIniDataParser.LoadFile(Variables.LocalPath + "\\options.ini");
			}
			catch
			{
				return;
			}
			if (this.txtCpu.Text.Count<char>() == 32)
			{
				iniData["RGLauncher"]["CPU_Key"] = this.txtCpu.Text;
			}
			if (!this.txtNandLoc.Text.Equals("Please Select Your Nand Location"))
			{
				iniData["RGLauncher"]["nand_location"] = this.txtNandLoc.Text;
			}
			if (this.radHackJTAG.Checked)
			{
				iniData["RGLauncher"]["exploit"] = "JTAG";
			}
			else if (this.radHackRGH.Checked)
			{
				iniData["RGLauncher"]["exploit"] = "RGH";
			}
			else if (this.radHackRGH2.Checked)
			{
				iniData["RGLauncher"]["exploit"] = "RGH2";
			}
			if (!string.IsNullOrEmpty(iniData["RGLauncher"]["kernel"]))
			{
				string arg_13D_0 = iniData["RGLauncher"]["kernel"];
                IEnumerator enumerator = this.kernelCheckedBox.CheckedItems.GetEnumerator();
				{
					if (enumerator.MoveNext())
					{
						object current = enumerator.Current;
						iniData["RGLauncher"]["kernel"] = this.kernelCheckedBox.GetItemText(current);
					}
				}
			}
			try
			{
				fileIniDataParser.SaveFile(Variables.LocalPath + "\\options.ini", iniData);
			}
			catch
			{
			}
		}

		private void picBuilder_Click(object sender, EventArgs e)
		{
			if (this.Validate())
			{
				this.save_INI();
				Variables.CPUkey = this.txtCpu.Text;
				string text = "/cpu:" + Variables.CPUkey;
				string text2 = "/guided \"" + this.txtNandLoc.Text + "\"";
				string fileName = Variables.LocalPath + "\\rgbuild\\rgbuild.exe";
				string workingDirectory = Variables.LocalPath + "\\rgbuild";
				string text3 = "/hack:";
				string text4 = "/kernel:";
				if (this.radHackJTAG.Checked)
				{
					text3 += "JTAG";
				}
				else if (this.radHackRGH.Checked)
				{
					text3 += "RGH";
				}
				else if (this.radHackRGH2.Checked)
				{
					text3 += "RGH2";
				}
				else
				{
					MessageBox.Show("Invalid hack selection", "Error");
				}
				if (this.kernelCheckedBox.CheckedItems.Count == 1)
				{
                    IEnumerator enumerator2 = this.kernelCheckedBox.CheckedItems.GetEnumerator();
					{
						if (enumerator2.MoveNext())
						{
							object current = enumerator2.Current;
							text4 += this.kernelCheckedBox.GetItemText(current);
						}
						goto IL_159;
					}
				}
				MessageBox.Show("Invalid kernel selection", "Error");
				IL_159:
				Process.Start(new ProcessStartInfo
				{
					FileName = fileName,
					Arguments = string.Concat(new string[]
					{
						"/1bl:DD88AD0C9ED669E7B56794FB68563EFA ",
						text,
						" ",
						text3,
						" ",
						text4,
						" ",
						text2
					}),
					WorkingDirectory = workingDirectory
				});
				Environment.Exit(1);
			}
		}

		private void picGUI_Click(object sender, EventArgs e)
		{
			if (this.ValidateLocation())
			{
				string text = Variables.LocalPath;
				text += "\\rgbuild\\rgbuild.exe";
				if (this.ValidateLocation())
				{
					Process.Start(text, "-ui");
					this.save_INI();
					Environment.Exit(1);
				}
			}
		}

		private void picExit_Click(object sender, EventArgs e)
		{
			this.save_INI();
			Application.Exit();
		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{
			this.save_INI();
		}

		private void rad13599_CheckedChanged(object sender, EventArgs e)
		{
			this.save_INI();
		}

		private void rad14719_CheckedChanged(object sender, EventArgs e)
		{
			this.save_INI();
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
		}

		private void picNand_Click(object sender, EventArgs e)
		{
			this.save_INI();
			DialogResult dialogResult = this.openFileDialog1.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				string fileName = this.openFileDialog1.FileName;
				this.txtNandLoc.Text = fileName;
				Variables.NandPath = this.txtNandLoc.Text;
				this.openFileDialog1.Dispose();
				this.save_INI();
			}
			Directory.SetCurrentDirectory(Variables.LocalPath);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.load_INI();
			IniData iniData = null;
			try
			{
				FileIniDataParser fileIniDataParser = new FileIniDataParser();
				iniData = fileIniDataParser.LoadFile("options.ini");
			}
			catch
			{
				return;
			}
			if (string.IsNullOrEmpty(iniData["RGLauncher"]["nand_location"]) || !File.Exists(iniData["RGLauncher"]["nand_location"]))
			{
				string text = Variables.LocalPath + "\\nand.bin";
				string text2 = Variables.LocalPath + "\\nand1.bin";
				string text3 = Variables.LocalPath + "\\nand2.bin";
				if (File.Exists(text))
				{
					this.txtNandLoc.Text = text;
				}
				else if (File.Exists(text2))
				{
					this.txtNandLoc.Text = text2;
				}
				else if (File.Exists(text3))
				{
					this.txtNandLoc.Text = text3;
				}
				else
				{
					this.txtNandLoc.Text = "Please Select Your Nand Location";
				}
				if (!this.txtNandLoc.Text.Equals("Please Select Your Nand Location"))
				{
					this.save_INI();
				}
			}
		}

		private void picLilExit_Click(object sender, EventArgs e)
		{
			this.save_INI();
			Application.Exit();
		}

		private void picLilMini_Click(object sender, EventArgs e)
		{
			this.save_INI();
			base.WindowState = FormWindowState.Minimized;
		}

		private void picAbout_Click(object sender, EventArgs e)
		{
			About about = new About();
			about.Show();
		}

		private void picHow_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("Readme.txt");
			}
			catch
			{
				MessageBox.Show("Readme.txt file has been moved or deleted \n Please return it to its location");
			}
		}

		private void picDonate_Click(object sender, EventArgs e)
		{
			string text = "";
			string text2 = "rgloader.dev@gmail.com";
			string text3 = "Donation";
			string text4 = "US";
			string text5 = "USD";
			string text6 = text;
			text = string.Concat(new string[]
			{
				text6,
				"https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=",
				text2,
				"&lc=",
				text4,
				"&item_name=",
				text3,
				"&currency_code=",
				text5,
				"&bn=PP%2dDonationsBF"
			});
			Process.Start(text);
		}

		private void picHow_MouseDown(object sender, MouseEventArgs e)
		{
			this.picTemp = this.picRead.Image;
			this.picRead.Image = Resource.ReadMeButtonDown;
		}

		private void picHow_MouseUp(object sender, MouseEventArgs e)
		{
			this.picRead.Image = this.picTemp;
		}

		private void picAbout_MouseDown(object sender, MouseEventArgs e)
		{
			this.picTemp = this.picAbout.Image;
			this.picAbout.Image = Resource.AboutUsButtonDown;
		}

		private void picAbout_MouseUp(object sender, MouseEventArgs e)
		{
			this.picAbout.Image = this.picTemp;
		}

		private void picNand_MouseDown(object sender, MouseEventArgs e)
		{
			this.picTemp = this.picNand.Image;
			this.picNand.Image = Resource.NandButtonDown;
		}

		private void picNand_MouseUp(object sender, MouseEventArgs e)
		{
			this.picNand.Image = this.picTemp;
		}

		private void picExit_MouseDown(object sender, MouseEventArgs e)
		{
			this.picTemp = this.picExit.Image;
			this.picExit.Image = Resource.ExitButtonDown;
		}

		private void picExit_MouseUp(object sender, MouseEventArgs e)
		{
			this.picExit.Image = this.picTemp;
		}

		private void picGUI_MouseDown(object sender, MouseEventArgs e)
		{
			this.picTemp = this.picEditor.Image;
			this.picEditor.Image = Resource.ImageEditorButtonDown;
		}

		private void picGUI_MouseUp(object sender, MouseEventArgs e)
		{
			this.picEditor.Image = this.picTemp;
		}

		private void picBuilder_MouseDown(object sender, MouseEventArgs e)
		{
			this.picTemp = this.picBuilder.Image;
			this.picBuilder.Image = Resource.RGBButtonDown;
		}

		private void picBuilder_MouseUp(object sender, MouseEventArgs e)
		{
			this.picBuilder.Image = this.picTemp;
		}

		private void picDonate_MouseDown(object sender, MouseEventArgs e)
		{
			this.picTemp = this.picDonate.Image;
			this.picDonate.Image = Resource.DonateButtonDown;
		}

		private void picDonate_MouseUp(object sender, MouseEventArgs e)
		{
			this.picDonate.Image = this.picTemp;
		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			int selectedIndex = this.kernelCheckedBox.SelectedIndex;
			for (int i = 0; i < this.kernelCheckedBox.Items.Count; i++)
			{
				this.kernelCheckedBox.SetItemChecked(i, false);
			}
			this.kernelCheckedBox.SetItemChecked(selectedIndex, true);
		}
	}
}

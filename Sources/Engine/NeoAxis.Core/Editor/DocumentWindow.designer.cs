﻿#if !DEPLOY
namespace NeoAxis.Editor
{
	partial class DocumentWindow
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// DocumentWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Name = "DocumentWindow";
			this.Load += new System.EventHandler(this.DocumentWindow_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DocumentWindow_KeyDown);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DocumentWindow_MouseUp);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer timer1;
	}
}

#endif
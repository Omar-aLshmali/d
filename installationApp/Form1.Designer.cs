namespace installationApp
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.allProgramsList = new System.Windows.Forms.ListBox();
			this.checkList = new System.Windows.Forms.ListView();
			this.btnInstal = new System.Windows.Forms.Button();
			this.toInstall = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.allProgramsList.FormattingEnabled = true;
			this.allProgramsList.HorizontalScrollbar = true;
			this.allProgramsList.Location = new System.Drawing.Point(491, 32);
			this.allProgramsList.Name = "listBox1";
			this.allProgramsList.Size = new System.Drawing.Size(260, 225);
			this.allProgramsList.TabIndex = 0;
			// 
			// checkList
			// 
			this.checkList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkList.GridLines = true;
			this.checkList.HideSelection = false;
			this.checkList.Location = new System.Drawing.Point(3, 32);
			this.checkList.Margin = new System.Windows.Forms.Padding(6);
			this.checkList.Name = "checkList";
			this.checkList.Size = new System.Drawing.Size(198, 220);
			this.checkList.TabIndex = 5;
			this.checkList.UseCompatibleStateImageBehavior = false;
			this.checkList.View = System.Windows.Forms.View.List;
			// 
			// btnInstal
			// 
			this.btnInstal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInstal.Location = new System.Drawing.Point(207, 62);
			this.btnInstal.Name = "btnInstal";
			this.btnInstal.Size = new System.Drawing.Size(110, 23);
			this.btnInstal.TabIndex = 6;
			this.btnInstal.Text = "Installieren";
			this.btnInstal.UseVisualStyleBackColor = true;
			this.btnInstal.Click += new System.EventHandler(this.BtnInstal_Click);
			// 
			// toInstall
			// 
			this.toInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toInstall.FormattingEnabled = true;
			this.toInstall.Location = new System.Drawing.Point(207, 32);
			this.toInstall.Name = "toInstall";
			this.toInstall.Size = new System.Drawing.Size(278, 24);
			this.toInstall.TabIndex = 7;
			this.toInstall.Text = "Applikation auswählen";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(488, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(195, 16);
			this.label1.TabIndex = 9;
			this.label1.Text = "Alle installierte Programme";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(0, -1);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(178, 30);
			this.label2.TabIndex = 10;
			this.label2.Text = "Programme, die installiert \r\nwerden müssen:";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(3, 261);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(198, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "List aktualisieren";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Refresh_Button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1037, 591);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.toInstall);
			this.Controls.Add(this.btnInstal);
			this.Controls.Add(this.checkList);
			this.Controls.Add(this.allProgramsList);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox allProgramsList;
		private System.Windows.Forms.ListView checkList;
		private System.Windows.Forms.Button btnInstal;
		private System.Windows.Forms.ComboBox toInstall;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
	}
}


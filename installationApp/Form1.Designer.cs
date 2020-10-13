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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.result = new System.Windows.Forms.Label();
			this.BtnControl_Install = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.checkList = new System.Windows.Forms.ListView();
			this.btnInstal = new System.Windows.Forms.Button();
			this.toInstall = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(543, 164);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(245, 277);
			this.listBox1.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(537, 2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(165, 20);
			this.textBox1.TabIndex = 1;
			// 
			// result
			// 
			this.result.AutoSize = true;
			this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.result.Location = new System.Drawing.Point(624, 44);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(0, 20);
			this.result.TabIndex = 2;
			// 
			// BtnControl_Install
			// 
			this.BtnControl_Install.Location = new System.Drawing.Point(725, 0);
			this.BtnControl_Install.Name = "BtnControl_Install";
			this.BtnControl_Install.Size = new System.Drawing.Size(75, 23);
			this.BtnControl_Install.TabIndex = 3;
			this.BtnControl_Install.Text = "Überprüfen";
			this.BtnControl_Install.UseVisualStyleBackColor = true;
			this.BtnControl_Install.Click += new System.EventHandler(this.Button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(539, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Ergebnis:";
			// 
			// checkList
			// 
			this.checkList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkList.GridLines = true;
			this.checkList.HideSelection = false;
			this.checkList.Location = new System.Drawing.Point(0, 2);
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
			this.btnInstal.Location = new System.Drawing.Point(207, 32);
			this.btnInstal.Name = "btnInstal";
			this.btnInstal.Size = new System.Drawing.Size(110, 23);
			this.btnInstal.TabIndex = 6;
			this.btnInstal.Text = "Install ";
			this.btnInstal.UseVisualStyleBackColor = true;
			this.btnInstal.Click += new System.EventHandler(this.BtnInstal_Click);
			// 
			// toInstall
			// 
			this.toInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toInstall.FormattingEnabled = true;
			this.toInstall.Location = new System.Drawing.Point(207, 2);
			this.toInstall.Name = "toInstall";
			this.toInstall.Size = new System.Drawing.Size(183, 24);
			this.toInstall.TabIndex = 7;
			this.toInstall.Text = "Applikation auswählen";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 428);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "TEST LABLE";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.toInstall);
			this.Controls.Add(this.btnInstal);
			this.Controls.Add(this.checkList);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BtnControl_Install);
			this.Controls.Add(this.result);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.listBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label result;
		private System.Windows.Forms.Button BtnControl_Install;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView checkList;
		private System.Windows.Forms.Button btnInstal;
		private System.Windows.Forms.ComboBox toInstall;
		private System.Windows.Forms.Label label2;
	}
}


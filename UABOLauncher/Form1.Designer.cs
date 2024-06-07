namespace UABOLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.launchButton = new System.Windows.Forms.Button();
            this.storeNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countryCode = new System.Windows.Forms.TextBox();
            this.closeAfterLaunch = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // launchButton
            // 
            this.launchButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.launchButton.Location = new System.Drawing.Point(14, 81);
            this.launchButton.Margin = new System.Windows.Forms.Padding(4);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(187, 28);
            this.launchButton.TabIndex = 2;
            this.launchButton.Text = "Launch BO";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchBO_Click);
            // 
            // storeNumber
            // 
            this.storeNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storeNumber.Location = new System.Drawing.Point(72, 47);
            this.storeNumber.Margin = new System.Windows.Forms.Padding(4);
            this.storeNumber.Name = "storeNumber";
            this.storeNumber.Size = new System.Drawing.Size(129, 22);
            this.storeNumber.TabIndex = 0;
            this.storeNumber.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.storeNumber_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Store";
            // 
            // countryCode
            // 
            this.countryCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countryCode.Location = new System.Drawing.Point(72, 12);
            this.countryCode.Margin = new System.Windows.Forms.Padding(10, 4, 4, 4);
            this.countryCode.Name = "countryCode";
            this.countryCode.Size = new System.Drawing.Size(129, 22);
            this.countryCode.TabIndex = 1;
            this.countryCode.Text = "UA";
            this.countryCode.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // closeAfterLaunch
            // 
            this.closeAfterLaunch.AutoSize = true;
            this.closeAfterLaunch.Location = new System.Drawing.Point(14, 117);
            this.closeAfterLaunch.Name = "closeAfterLaunch";
            this.closeAfterLaunch.Size = new System.Drawing.Size(159, 20);
            this.closeAfterLaunch.TabIndex = 3;
            this.closeAfterLaunch.Text = "Close after BO started";
            this.closeAfterLaunch.UseVisualStyleBackColor = true;
            this.closeAfterLaunch.CheckedChanged += new System.EventHandler(this.closeAfterLaunch_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 143);
            this.Controls.Add(this.closeAfterLaunch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countryCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.storeNumber);
            this.Controls.Add(this.launchButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GK BO Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.TextBox storeNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countryCode;
        private System.Windows.Forms.CheckBox closeAfterLaunch;
    }
}


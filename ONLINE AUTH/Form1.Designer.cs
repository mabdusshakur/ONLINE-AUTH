namespace ONLINE_AUTH
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
            this.License_TB = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.Active_BTN = new Siticone.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // License_TB
            // 
            this.License_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.License_TB.DefaultText = "";
            this.License_TB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.License_TB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.License_TB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.License_TB.DisabledState.Parent = this.License_TB;
            this.License_TB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.License_TB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.License_TB.FocusedState.Parent = this.License_TB;
            this.License_TB.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.License_TB.HoveredState.Parent = this.License_TB;
            this.License_TB.Location = new System.Drawing.Point(72, 89);
            this.License_TB.Name = "License_TB";
            this.License_TB.PasswordChar = '\0';
            this.License_TB.PlaceholderText = "License";
            this.License_TB.SelectedText = "";
            this.License_TB.ShadowDecoration.Parent = this.License_TB;
            this.License_TB.Size = new System.Drawing.Size(377, 36);
            this.License_TB.TabIndex = 0;
            // 
            // Active_BTN
            // 
            this.Active_BTN.BorderColor = System.Drawing.Color.Silver;
            this.Active_BTN.BorderThickness = 2;
            this.Active_BTN.CheckedState.Parent = this.Active_BTN;
            this.Active_BTN.CustomImages.Parent = this.Active_BTN;
            this.Active_BTN.FillColor = System.Drawing.Color.White;
            this.Active_BTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Active_BTN.ForeColor = System.Drawing.Color.Black;
            this.Active_BTN.HoveredState.Parent = this.Active_BTN;
            this.Active_BTN.Location = new System.Drawing.Point(168, 147);
            this.Active_BTN.Name = "Active_BTN";
            this.Active_BTN.ShadowDecoration.Parent = this.Active_BTN;
            this.Active_BTN.Size = new System.Drawing.Size(127, 44);
            this.Active_BTN.TabIndex = 1;
            this.Active_BTN.Text = "ACTIVE";
            this.Active_BTN.Click += new System.EventHandler(this.Active_TB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 276);
            this.Controls.Add(this.Active_BTN);
            this.Controls.Add(this.License_TB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneMaterialTextBox License_TB;
        private Siticone.UI.WinForms.SiticoneButton Active_BTN;
    }
}



namespace AddressBookApp
{
    partial class viewForm
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
            this.viewPhoneTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.viewAddressTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.viewLastNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.viewFirstNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // viewPhoneTxt
            // 
            this.viewPhoneTxt.Enabled = false;
            this.viewPhoneTxt.Location = new System.Drawing.Point(144, 173);
            this.viewPhoneTxt.Name = "viewPhoneTxt";
            this.viewPhoneTxt.ReadOnly = true;
            this.viewPhoneTxt.Size = new System.Drawing.Size(165, 23);
            this.viewPhoneTxt.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Phone Number";
            // 
            // viewAddressTxt
            // 
            this.viewAddressTxt.Enabled = false;
            this.viewAddressTxt.Location = new System.Drawing.Point(144, 124);
            this.viewAddressTxt.Name = "viewAddressTxt";
            this.viewAddressTxt.ReadOnly = true;
            this.viewAddressTxt.Size = new System.Drawing.Size(165, 23);
            this.viewAddressTxt.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Address";
            // 
            // viewLastNameTxt
            // 
            this.viewLastNameTxt.Enabled = false;
            this.viewLastNameTxt.Location = new System.Drawing.Point(144, 77);
            this.viewLastNameTxt.Name = "viewLastNameTxt";
            this.viewLastNameTxt.ReadOnly = true;
            this.viewLastNameTxt.Size = new System.Drawing.Size(165, 23);
            this.viewLastNameTxt.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Last Name";
            // 
            // viewFirstNameTxt
            // 
            this.viewFirstNameTxt.Enabled = false;
            this.viewFirstNameTxt.Location = new System.Drawing.Point(144, 27);
            this.viewFirstNameTxt.Name = "viewFirstNameTxt";
            this.viewFirstNameTxt.ReadOnly = true;
            this.viewFirstNameTxt.Size = new System.Drawing.Size(165, 23);
            this.viewFirstNameTxt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name";
            // 
            // viewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 218);
            this.Controls.Add(this.viewPhoneTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.viewAddressTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.viewLastNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viewFirstNameTxt);
            this.Controls.Add(this.label1);
            this.Name = "viewForm";
            this.Text = "View Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox viewPhoneTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox viewAddressTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox viewLastNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox viewFirstNameTxt;
        private System.Windows.Forms.Label label1;
    }
}
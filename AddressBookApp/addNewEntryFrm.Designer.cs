
namespace AddressBookApp
{
    partial class addNewEntryFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addEntryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(149, 51);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(165, 23);
            this.firstNameTxt.TabIndex = 1;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(149, 101);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(165, 23);
            this.lastNameTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(149, 148);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(165, 23);
            this.addressTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(149, 197);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(165, 23);
            this.phoneTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone Number";
            // 
            // addEntryBtn
            // 
            this.addEntryBtn.Location = new System.Drawing.Point(104, 269);
            this.addEntryBtn.Name = "addEntryBtn";
            this.addEntryBtn.Size = new System.Drawing.Size(141, 55);
            this.addEntryBtn.TabIndex = 8;
            this.addEntryBtn.Text = "Add New Entry";
            this.addEntryBtn.UseVisualStyleBackColor = true;
            this.addEntryBtn.Click += new System.EventHandler(this.addEntryBtn_Click);
            // 
            // addNewEntryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 384);
            this.Controls.Add(this.addEntryBtn);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.label1);
            this.Name = "addNewEntryFrm";
            this.Text = "addNewEntryFrm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.addNewEntryFrm_FormClosed);
            this.Load += new System.EventHandler(this.addNewEntryFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addEntryBtn;
    }
}
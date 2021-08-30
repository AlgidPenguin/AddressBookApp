
namespace AddressBookApp
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newEntryBtn = new System.Windows.Forms.Button();
            this.editEntryBtn = new System.Windows.Forms.Button();
            this.nameLbx = new System.Windows.Forms.ListBox();
            this.viewEntryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newEntryBtn
            // 
            this.newEntryBtn.Location = new System.Drawing.Point(305, 39);
            this.newEntryBtn.Name = "newEntryBtn";
            this.newEntryBtn.Size = new System.Drawing.Size(101, 39);
            this.newEntryBtn.TabIndex = 0;
            this.newEntryBtn.Text = "New Entry";
            this.newEntryBtn.UseVisualStyleBackColor = true;
            this.newEntryBtn.Click += new System.EventHandler(this.newEntryBtn_Click);
            // 
            // editEntryBtn
            // 
            this.editEntryBtn.Location = new System.Drawing.Point(305, 98);
            this.editEntryBtn.Name = "editEntryBtn";
            this.editEntryBtn.Size = new System.Drawing.Size(101, 39);
            this.editEntryBtn.TabIndex = 1;
            this.editEntryBtn.Text = "Edit Entry";
            this.editEntryBtn.UseVisualStyleBackColor = true;
            this.editEntryBtn.Click += new System.EventHandler(this.editEntryBtn_Click);
            // 
            // nameLbx
            // 
            this.nameLbx.FormattingEnabled = true;
            this.nameLbx.ItemHeight = 15;
            this.nameLbx.Location = new System.Drawing.Point(27, 25);
            this.nameLbx.Name = "nameLbx";
            this.nameLbx.Size = new System.Drawing.Size(236, 469);
            this.nameLbx.TabIndex = 2;
            // 
            // viewEntryBtn
            // 
            this.viewEntryBtn.Location = new System.Drawing.Point(305, 162);
            this.viewEntryBtn.Name = "viewEntryBtn";
            this.viewEntryBtn.Size = new System.Drawing.Size(101, 39);
            this.viewEntryBtn.TabIndex = 3;
            this.viewEntryBtn.Text = "View Entry Info";
            this.viewEntryBtn.UseVisualStyleBackColor = true;
            this.viewEntryBtn.Click += new System.EventHandler(this.viewEntryBtn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 522);
            this.Controls.Add(this.viewEntryBtn);
            this.Controls.Add(this.nameLbx);
            this.Controls.Add(this.editEntryBtn);
            this.Controls.Add(this.newEntryBtn);
            this.Name = "mainForm";
            this.Text = "Address Book";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newEntryBtn;
        private System.Windows.Forms.Button editEntryBtn;
        private System.Windows.Forms.ListBox nameLbx;
        private System.Windows.Forms.Button viewEntryBtn;
    }
}


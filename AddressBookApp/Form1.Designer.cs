﻿
namespace AddressBookApp
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nameLbx = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "New Entry";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Edit Entry";
            this.button2.UseVisualStyleBackColor = true;
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(325, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "View Entry Info";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 522);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.nameLbx);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox nameLbx;
        private System.Windows.Forms.Button button3;
    }
}

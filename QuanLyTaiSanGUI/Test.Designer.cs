﻿namespace PTB_GUI
{
    partial class Test
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
            this.button1 = new System.Windows.Forms.Button();
            this.ucThemSuaXoaButton1 = new PTB_GUI.MyUC.ucThemSuaXoaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.EnabledChanged += new System.EventHandler(this.button1_EnabledChanged);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucThemSuaXoaButton1
            // 
            this.ucThemSuaXoaButton1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ucThemSuaXoaButton1.Appearance.Options.UseBackColor = true;
            this.ucThemSuaXoaButton1.Location = new System.Drawing.Point(12, 12);
            this.ucThemSuaXoaButton1.Name = "ucThemSuaXoaButton1";
            this.ucThemSuaXoaButton1.Size = new System.Drawing.Size(84, 32);
            this.ucThemSuaXoaButton1.TabIndex = 0;
            this.ucThemSuaXoaButton1.ButtonThemClick += new PTB_GUI.MyUC.MyEventHandler(this.ucThemSuaXoaButton1_ButtonThemClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 322);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ucThemSuaXoaButton1);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyUC.ucThemSuaXoaButton ucThemSuaXoaButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
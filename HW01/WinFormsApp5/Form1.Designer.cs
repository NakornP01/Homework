﻿namespace WinFormsApp5
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
            textBoxMain = new TextBox();
            btnokMain = new Button();
            btnclear = new Button();
            SuspendLayout();
            // 
            // textBoxMain
            // 
            textBoxMain.Location = new Point(348, 191);
            textBoxMain.Name = "textBoxMain";
            textBoxMain.Size = new Size(100, 23);
            textBoxMain.TabIndex = 0;
            // 
            // btnokMain
            // 
            btnokMain.Location = new Point(300, 240);
            btnokMain.Name = "btnokMain";
            btnokMain.Size = new Size(75, 23);
            btnokMain.TabIndex = 1;
            btnokMain.Text = "Ok";
            btnokMain.UseVisualStyleBackColor = true;
            btnokMain.Click += btnokMain_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(415, 240);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(75, 23);
            btnclear.TabIndex = 2;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnclear);
            Controls.Add(btnokMain);
            Controls.Add(textBoxMain);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMain;
        private Button btnokMain;
        private Button btnclear;
    }
}

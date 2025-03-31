namespace WinFormsApp5
{
    partial class Form2
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
            btnok2 = new Button();
            btncancel = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // btnok2
            // 
            btnok2.Location = new Point(277, 265);
            btnok2.Name = "btnok2";
            btnok2.Size = new Size(75, 23);
            btnok2.TabIndex = 0;
            btnok2.Text = "Ok";
            btnok2.UseVisualStyleBackColor = true;
            btnok2.Click += btnok2_Click;
            // 
            // btncancel
            // 
            btncancel.Location = new Point(405, 265);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(75, 23);
            btncancel.TabIndex = 1;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // textBox1
            // 
            textBox2.Location = new Point(332, 189);
            textBox2.Name = "textBox1";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(btncancel);
            Controls.Add(btnok2);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnok2;
        private Button btncancel;
        private TextBox textBox2;
    }
}
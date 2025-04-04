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
            btnokSecond = new Button();
            btncancel = new Button();
            textBoxSecond = new TextBox();
            pictureBoxsecond = new PictureBox();
            btnuploadsecond = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxsecond).BeginInit();
            SuspendLayout();
            // 
            // btnokSecond
            // 
            btnokSecond.Location = new Point(277, 265);
            btnokSecond.Name = "btnokSecond";
            btnokSecond.Size = new Size(75, 23);
            btnokSecond.TabIndex = 0;
            btnokSecond.Text = "Ok";
            btnokSecond.UseVisualStyleBackColor = true;
            btnokSecond.Click += btnokSecond_Click;
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
            // textBoxSecond
            // 
            textBoxSecond.Location = new Point(332, 189);
            textBoxSecond.Name = "textBoxSecond";
            textBoxSecond.Size = new Size(100, 23);
            textBoxSecond.TabIndex = 2;
            // 
            // pictureBoxsecond
            // 
            pictureBoxsecond.Location = new Point(41, 31);
            pictureBoxsecond.Name = "pictureBoxsecond";
            pictureBoxsecond.Size = new Size(207, 203);
            pictureBoxsecond.TabIndex = 3;
            pictureBoxsecond.TabStop = false;
            // 
            // btnuploadsecond
            // 
            btnuploadsecond.Location = new Point(91, 262);
            btnuploadsecond.Name = "btnuploadsecond";
            btnuploadsecond.Size = new Size(75, 23);
            btnuploadsecond.TabIndex = 4;
            btnuploadsecond.Text = "upload";
            btnuploadsecond.UseVisualStyleBackColor = true;
            btnuploadsecond.Click += btnuploadsecond_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnuploadsecond);
            Controls.Add(pictureBoxsecond);
            Controls.Add(textBoxSecond);
            Controls.Add(btncancel);
            Controls.Add(btnokSecond);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBoxsecond).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnokSecond;
        private Button btncancel;
        private TextBox textBoxSecond;
        private PictureBox pictureBoxsecond;
        private Button btnuploadsecond;
    }
}
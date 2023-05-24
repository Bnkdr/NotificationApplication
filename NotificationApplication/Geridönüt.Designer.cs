namespace NotificationApplication
{
    partial class Geridönüt
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
            this.rtxt_feedback = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxt_feedback
            // 
            this.rtxt_feedback.Location = new System.Drawing.Point(186, 57);
            this.rtxt_feedback.Name = "rtxt_feedback";
            this.rtxt_feedback.Size = new System.Drawing.Size(300, 159);
            this.rtxt_feedback.TabIndex = 0;
            this.rtxt_feedback.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lütfen geri dönütünüzü giriniz: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Geridönüt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 316);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxt_feedback);
            this.Name = "Geridönüt";
            this.Text = "Geridönüt";
            this.Load += new System.EventHandler(this.Geridönüt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxt_feedback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
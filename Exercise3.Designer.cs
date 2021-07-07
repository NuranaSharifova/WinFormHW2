
namespace WinFormHW2
{
    partial class Exercise3
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
            this.Filename = new System.Windows.Forms.TextBox();
            this.Downloadbutton = new System.Windows.Forms.Button();
            this.Editbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Filename
            // 
            this.Filename.Location = new System.Drawing.Point(80, 131);
            this.Filename.Name = "Filename";
            this.Filename.ReadOnly = true;
            this.Filename.Size = new System.Drawing.Size(341, 20);
            this.Filename.TabIndex = 0;
            // 
            // Downloadbutton
            // 
            this.Downloadbutton.Location = new System.Drawing.Point(80, 178);
            this.Downloadbutton.Name = "Downloadbutton";
            this.Downloadbutton.Size = new System.Drawing.Size(124, 40);
            this.Downloadbutton.TabIndex = 1;
            this.Downloadbutton.Text = "Download";
            this.Downloadbutton.UseVisualStyleBackColor = true;
            this.Downloadbutton.Click += new System.EventHandler(this.Downloadbutton_Click);
            // 
            // Editbutton
            // 
            this.Editbutton.Location = new System.Drawing.Point(288, 178);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(133, 40);
            this.Editbutton.TabIndex = 2;
            this.Editbutton.Text = "Edit";
            this.Editbutton.UseVisualStyleBackColor = true;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // Exercise3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 350);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.Downloadbutton);
            this.Controls.Add(this.Filename);
            this.Name = "Exercise3";
            this.Text = "Exercise3";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox Filename;
        private System.Windows.Forms.Button Downloadbutton;
        private System.Windows.Forms.Button Editbutton;
    }
}
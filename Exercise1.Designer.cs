
namespace WinFormHW2
{
    partial class Exercise1
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
            this.Open = new System.Windows.Forms.Button();
            this.Extension = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(125, 84);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(175, 57);
            this.Open.TabIndex = 0;
            this.Open.Text = "OpenFolders";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Extension
            // 
            this.Extension.Location = new System.Drawing.Point(125, 187);
            this.Extension.Name = "Extension";
            this.Extension.Size = new System.Drawing.Size(175, 20);
            this.Extension.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(125, 241);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(175, 57);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Exercise1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 369);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Extension);
            this.Controls.Add(this.Open);
            this.Name = "Exercise1";
            this.Text = "Exercise1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.TextBox Extension;
        private System.Windows.Forms.Button Search;
    }
}
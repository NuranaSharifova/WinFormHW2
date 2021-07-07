
namespace WinFormHW2
{
    partial class Exercise2
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
            this.Productlist = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Totalbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Productlist
            // 
            this.Productlist.FormattingEnabled = true;
            this.Productlist.Location = new System.Drawing.Point(39, 76);
            this.Productlist.Name = "Productlist";
            this.Productlist.Size = new System.Drawing.Size(228, 21);
            this.Productlist.TabIndex = 0;
            this.Productlist.SelectedIndexChanged += new System.EventHandler(this.Productlist_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(39, 127);
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Size = new System.Drawing.Size(228, 20);
            this.Price.TabIndex = 2;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(192, 187);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(359, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(339, 134);
            this.listBox1.TabIndex = 4;
            // 
            // Totalbutton
            // 
            this.Totalbutton.Location = new System.Drawing.Point(623, 226);
            this.Totalbutton.Name = "Totalbutton";
            this.Totalbutton.Size = new System.Drawing.Size(75, 23);
            this.Totalbutton.TabIndex = 5;
            this.Totalbutton.Text = "Total";
            this.Totalbutton.UseVisualStyleBackColor = true;
            this.Totalbutton.Click += new System.EventHandler(this.Totalbutton_Click);
            // 
            // Exercise2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 281);
            this.Controls.Add(this.Totalbutton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Productlist);
            this.Name = "Exercise2";
            this.Text = "Exercise2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Productlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Button Add;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Totalbutton;
    }
}
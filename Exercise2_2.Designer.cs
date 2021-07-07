
namespace WinFormHW2
{
    partial class Exercise2_2
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
            this.ProductName = new System.Windows.Forms.Label();
            this.Nametextbox = new System.Windows.Forms.TextBox();
            this.Propertiestextbox = new System.Windows.Forms.TextBox();
            this.Descriptiontextbox = new System.Windows.Forms.TextBox();
            this.ProductProperties = new System.Windows.Forms.Label();
            this.ProductDescription = new System.Windows.Forms.Label();
            this.Editbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Location = new System.Drawing.Point(36, 51);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(78, 13);
            this.ProductName.TabIndex = 0;
            this.ProductName.Text = "Product_Name";
            // 
            // Nametextbox
            // 
            this.Nametextbox.Location = new System.Drawing.Point(39, 77);
            this.Nametextbox.Name = "Nametextbox";
            this.Nametextbox.Size = new System.Drawing.Size(178, 20);
            this.Nametextbox.TabIndex = 1;
            // 
            // Propertiestextbox
            // 
            this.Propertiestextbox.Location = new System.Drawing.Point(39, 150);
            this.Propertiestextbox.Name = "Propertiestextbox";
            this.Propertiestextbox.Size = new System.Drawing.Size(178, 20);
            this.Propertiestextbox.TabIndex = 2;
            // 
            // Descriptiontextbox
            // 
            this.Descriptiontextbox.Location = new System.Drawing.Point(39, 216);
            this.Descriptiontextbox.Name = "Descriptiontextbox";
            this.Descriptiontextbox.Size = new System.Drawing.Size(178, 20);
            this.Descriptiontextbox.TabIndex = 3;
            // 
            // ProductProperties
            // 
            this.ProductProperties.AutoSize = true;
            this.ProductProperties.Location = new System.Drawing.Point(36, 120);
            this.ProductProperties.Name = "ProductProperties";
            this.ProductProperties.Size = new System.Drawing.Size(94, 13);
            this.ProductProperties.TabIndex = 4;
            this.ProductProperties.Text = "Product Properties";
            // 
            // ProductDescription
            // 
            this.ProductDescription.AutoSize = true;
            this.ProductDescription.Location = new System.Drawing.Point(36, 190);
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.Size = new System.Drawing.Size(100, 13);
            this.ProductDescription.TabIndex = 5;
            this.ProductDescription.Text = "Product Description";
            // 
            // Editbutton
            // 
            this.Editbutton.Location = new System.Drawing.Point(36, 273);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(75, 23);
            this.Editbutton.TabIndex = 6;
            this.Editbutton.Text = "Edit";
            this.Editbutton.UseVisualStyleBackColor = true;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // Exercise2_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 379);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.ProductDescription);
            this.Controls.Add(this.ProductProperties);
            this.Controls.Add(this.Descriptiontextbox);
            this.Controls.Add(this.Propertiestextbox);
            this.Controls.Add(this.Nametextbox);
            this.Controls.Add(this.ProductName);
            this.Name = "Exercise2_2";
            this.Text = "Exercise2_2";
         
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.TextBox Nametextbox;
        private System.Windows.Forms.TextBox Propertiestextbox;
        private System.Windows.Forms.TextBox Descriptiontextbox;
        private System.Windows.Forms.Label ProductProperties;
        private System.Windows.Forms.Label ProductDescription;
        private System.Windows.Forms.Button Editbutton;
    }
}
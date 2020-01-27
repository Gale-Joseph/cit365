namespace MegaDesk_Gale
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.AddQuoteButton = new System.Windows.Forms.Button();
            this.ViewAllQuotesButton = new System.Windows.Forms.Button();
            this.SearchQuotesButton = new System.Windows.Forms.Button();
            this.closeApp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddQuoteButton
            // 
            this.AddQuoteButton.Font = new System.Drawing.Font("Poly", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuoteButton.Location = new System.Drawing.Point(12, 12);
            this.AddQuoteButton.Name = "AddQuoteButton";
            this.AddQuoteButton.Size = new System.Drawing.Size(287, 105);
            this.AddQuoteButton.TabIndex = 0;
            this.AddQuoteButton.Text = "Add A Quote";
            this.AddQuoteButton.UseVisualStyleBackColor = true;
            this.AddQuoteButton.Click += new System.EventHandler(this.AddQuoteButton_Click);
            // 
            // ViewAllQuotesButton
            // 
            this.ViewAllQuotesButton.Font = new System.Drawing.Font("Poly", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllQuotesButton.Location = new System.Drawing.Point(12, 150);
            this.ViewAllQuotesButton.Name = "ViewAllQuotesButton";
            this.ViewAllQuotesButton.Size = new System.Drawing.Size(287, 105);
            this.ViewAllQuotesButton.TabIndex = 2;
            this.ViewAllQuotesButton.Text = "View Quotes";
            this.ViewAllQuotesButton.UseVisualStyleBackColor = true;
            this.ViewAllQuotesButton.Click += new System.EventHandler(this.ViewAllQuotesButton_Click);
            // 
            // SearchQuotesButton
            // 
            this.SearchQuotesButton.Font = new System.Drawing.Font("Poly", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQuotesButton.Location = new System.Drawing.Point(12, 292);
            this.SearchQuotesButton.Name = "SearchQuotesButton";
            this.SearchQuotesButton.Size = new System.Drawing.Size(287, 105);
            this.SearchQuotesButton.TabIndex = 3;
            this.SearchQuotesButton.Text = "Search Quotes";
            this.SearchQuotesButton.UseVisualStyleBackColor = true;
            this.SearchQuotesButton.Click += new System.EventHandler(this.SearchQuotesButton_Click);
            // 
            // closeApp
            // 
            this.closeApp.Font = new System.Drawing.Font("Poly", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeApp.Location = new System.Drawing.Point(12, 444);
            this.closeApp.Name = "closeApp";
            this.closeApp.Size = new System.Drawing.Size(287, 105);
            this.closeApp.TabIndex = 4;
            this.closeApp.Text = "Exit MegaDesk";
            this.closeApp.UseVisualStyleBackColor = true;
            this.closeApp.Click += new System.EventHandler(this.closeApp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(344, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 362);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closeApp);
            this.Controls.Add(this.SearchQuotesButton);
            this.Controls.Add(this.ViewAllQuotesButton);
            this.Controls.Add(this.AddQuoteButton);
            this.Name = "MainMenu";
            this.Text = "MegaDesk - Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddQuoteButton;
        private System.Windows.Forms.Button ViewAllQuotesButton;
        private System.Windows.Forms.Button SearchQuotesButton;
        private System.Windows.Forms.Button closeApp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


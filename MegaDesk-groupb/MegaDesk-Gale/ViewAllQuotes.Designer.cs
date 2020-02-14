namespace MegaDesk_Gale
{
    partial class ViewAllQuotes
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
            this.viewQuoteExitButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.allQuotesGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.allQuotesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewQuoteExitButton
            // 
            this.viewQuoteExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuoteExitButton.Location = new System.Drawing.Point(561, 513);
            this.viewQuoteExitButton.Name = "viewQuoteExitButton";
            this.viewQuoteExitButton.Size = new System.Drawing.Size(111, 36);
            this.viewQuoteExitButton.TabIndex = 0;
            this.viewQuoteExitButton.Text = "Exit";
            this.viewQuoteExitButton.UseVisualStyleBackColor = true;
            this.viewQuoteExitButton.Click += new System.EventHandler(this.viewQuoteExitButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poly", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 29);
            this.label8.TabIndex = 53;
            this.label8.Text = "Quotes";
            // 
            // allQuotesGridView
            // 
            this.allQuotesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allQuotesGridView.Location = new System.Drawing.Point(41, 76);
            this.allQuotesGridView.Name = "allQuotesGridView";
            this.allQuotesGridView.Size = new System.Drawing.Size(518, 413);
            this.allQuotesGridView.TabIndex = 56;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.allQuotesGridView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.viewQuoteExitButton);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.allQuotesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewQuoteExitButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView allQuotesGridView;
    }
}
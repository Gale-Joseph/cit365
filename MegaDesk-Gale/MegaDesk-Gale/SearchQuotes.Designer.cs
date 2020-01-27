namespace MegaDesk_Gale
{
    partial class SearchQuotes
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
            this.materialSelect = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // viewQuoteExitButton
            // 
            this.viewQuoteExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuoteExitButton.Location = new System.Drawing.Point(561, 513);
            this.viewQuoteExitButton.Name = "viewQuoteExitButton";
            this.viewQuoteExitButton.Size = new System.Drawing.Size(111, 36);
            this.viewQuoteExitButton.TabIndex = 1;
            this.viewQuoteExitButton.Text = "Exit";
            this.viewQuoteExitButton.UseVisualStyleBackColor = true;
            this.viewQuoteExitButton.Click += new System.EventHandler(this.viewQuoteExitButton_Click);
            // 
            // materialSelect
            // 
            this.materialSelect.FormattingEnabled = true;
            this.materialSelect.ItemHeight = 13;
            this.materialSelect.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.materialSelect.Location = new System.Drawing.Point(17, 65);
            this.materialSelect.Name = "materialSelect";
            this.materialSelect.Size = new System.Drawing.Size(150, 21);
            this.materialSelect.TabIndex = 2;
            this.materialSelect.Text = "Select a material";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poly", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(283, 29);
            this.label8.TabIndex = 54;
            this.label8.Text = "Search quotes by material";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.materialSelect);
            this.Controls.Add(this.viewQuoteExitButton);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewQuoteExitButton;
        private System.Windows.Forms.ComboBox materialSelect;
        private System.Windows.Forms.Label label8;
    }
}
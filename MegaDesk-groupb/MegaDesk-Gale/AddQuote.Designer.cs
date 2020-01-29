namespace MegaDesk_Gale
{
    partial class AddQuote
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
            this.exitButton = new System.Windows.Forms.Button();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.fnBox = new System.Windows.Forms.TextBox();
            this.lnBox = new System.Windows.Forms.TextBox();
            this.depthBox = new System.Windows.Forms.TextBox();
            this.drawerBox = new System.Windows.Forms.TextBox();
            this.materialBox = new System.Windows.Forms.ListBox();
            this.rushBox = new System.Windows.Forms.ListBox();
            this.submitQuote = new System.Windows.Forms.Button();
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.depthE = new System.Windows.Forms.Label();
            this.widthE = new System.Windows.Forms.Label();
            this.drawerE = new System.Windows.Forms.Label();
            this.materialE = new System.Windows.Forms.Label();
            this.rushE = new System.Windows.Forms.Label();
            this.submitE = new System.Windows.Forms.Label();
            this.firstNameE = new System.Windows.Forms.Label();
            this.lastNameE = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.exitAddQuote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(713, 415);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // widthBox
            // 
            this.widthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthBox.Location = new System.Drawing.Point(189, 172);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(100, 26);
            this.widthBox.TabIndex = 4;
            this.widthBox.Leave += new System.EventHandler(this.widthBox_Validate);
            // 
            // fnBox
            // 
            this.fnBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnBox.Location = new System.Drawing.Point(189, 92);
            this.fnBox.Name = "fnBox";
            this.fnBox.Size = new System.Drawing.Size(100, 26);
            this.fnBox.TabIndex = 2;
            this.fnBox.Leave += new System.EventHandler(this.firstName_Validate);
            // 
            // lnBox
            // 
            this.lnBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnBox.Location = new System.Drawing.Point(189, 118);
            this.lnBox.Name = "lnBox";
            this.lnBox.Size = new System.Drawing.Size(100, 26);
            this.lnBox.TabIndex = 3;
            this.lnBox.Leave += new System.EventHandler(this.lastName_Validate);
            // 
            // depthBox
            // 
            this.depthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthBox.Location = new System.Drawing.Point(189, 198);
            this.depthBox.Name = "depthBox";
            this.depthBox.Size = new System.Drawing.Size(100, 26);
            this.depthBox.TabIndex = 5;
            this.depthBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.depthBox_KeyDown);
            this.depthBox.Leave += new System.EventHandler(this.depthBox_Validate);
            // 
            // drawerBox
            // 
            this.drawerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerBox.Location = new System.Drawing.Point(189, 224);
            this.drawerBox.Name = "drawerBox";
            this.drawerBox.Size = new System.Drawing.Size(100, 26);
            this.drawerBox.TabIndex = 6;
            this.drawerBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.drawerBox_KeyDown);
            this.drawerBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.drawerBox_KeyDown);
            this.drawerBox.Leave += new System.EventHandler(this.drawerBox_Validate);
            // 
            // materialBox
            // 
            this.materialBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialBox.FormattingEnabled = true;
            this.materialBox.ItemHeight = 20;
            this.materialBox.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.materialBox.Location = new System.Drawing.Point(189, 262);
            this.materialBox.Name = "materialBox";
            this.materialBox.Size = new System.Drawing.Size(100, 64);
            this.materialBox.TabIndex = 7;
            this.materialBox.Leave += new System.EventHandler(this.materialBox_Validate);
            // 
            // rushBox
            // 
            this.rushBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushBox.FormattingEnabled = true;
            this.rushBox.ItemHeight = 20;
            this.rushBox.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "0"});
            this.rushBox.Location = new System.Drawing.Point(189, 348);
            this.rushBox.Name = "rushBox";
            this.rushBox.Size = new System.Drawing.Size(100, 44);
            this.rushBox.TabIndex = 8;
            this.rushBox.Leave += new System.EventHandler(this.deliveryBox_Validate);
            // 
            // submitQuote
            // 
            this.submitQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitQuote.Location = new System.Drawing.Point(188, 446);
            this.submitQuote.Name = "submitQuote";
            this.submitQuote.Size = new System.Drawing.Size(101, 35);
            this.submitQuote.TabIndex = 9;
            this.submitQuote.Text = "Submit";
            this.submitQuote.UseVisualStyleBackColor = true;
            this.submitQuote.Click += new System.EventHandler(this.submitQuote_Click);
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(93, 95);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(90, 20);
            this.firstName.TabIndex = 10;
            this.firstName.Text = "First Name:";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(93, 121);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(90, 20);
            this.lastName.TabIndex = 11;
            this.lastName.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Desk Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Desk Depth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Material:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Rush Delivery:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Number of Drawers:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Quote Date:";
            // 
            // depthE
            // 
            this.depthE.Location = new System.Drawing.Point(306, 208);
            this.depthE.Name = "depthE";
            this.depthE.Size = new System.Drawing.Size(312, 13);
            this.depthE.TabIndex = 0;
            // 
            // widthE
            // 
            this.widthE.Location = new System.Drawing.Point(306, 182);
            this.widthE.Name = "widthE";
            this.widthE.Size = new System.Drawing.Size(312, 13);
            this.widthE.TabIndex = 19;
            // 
            // drawerE
            // 
            this.drawerE.Location = new System.Drawing.Point(306, 234);
            this.drawerE.Name = "drawerE";
            this.drawerE.Size = new System.Drawing.Size(312, 13);
            this.drawerE.TabIndex = 20;
            // 
            // materialE
            // 
            this.materialE.Location = new System.Drawing.Point(306, 270);
            this.materialE.Name = "materialE";
            this.materialE.Size = new System.Drawing.Size(312, 13);
            this.materialE.TabIndex = 21;
            // 
            // rushE
            // 
            this.rushE.Location = new System.Drawing.Point(306, 355);
            this.rushE.Name = "rushE";
            this.rushE.Size = new System.Drawing.Size(312, 13);
            this.rushE.TabIndex = 22;
            // 
            // submitE
            // 
            this.submitE.Location = new System.Drawing.Point(306, 446);
            this.submitE.Name = "submitE";
            this.submitE.Size = new System.Drawing.Size(312, 13);
            this.submitE.TabIndex = 23;
            // 
            // firstNameE
            // 
            this.firstNameE.Location = new System.Drawing.Point(306, 99);
            this.firstNameE.Name = "firstNameE";
            this.firstNameE.Size = new System.Drawing.Size(312, 13);
            this.firstNameE.TabIndex = 24;
            // 
            // lastNameE
            // 
            this.lastNameE.Location = new System.Drawing.Point(306, 125);
            this.lastNameE.Name = "lastNameE";
            this.lastNameE.Size = new System.Drawing.Size(312, 13);
            this.lastNameE.TabIndex = 25;
            // 
            // dateBox
            // 
            this.dateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBox.Location = new System.Drawing.Point(189, 64);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(270, 26);
            this.dateBox.TabIndex = 1;
            this.dateBox.Leave += new System.EventHandler(this.dateBox_Leave);
            // 
            // exitAddQuote
            // 
            this.exitAddQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitAddQuote.Location = new System.Drawing.Point(571, 514);
            this.exitAddQuote.Name = "exitAddQuote";
            this.exitAddQuote.Size = new System.Drawing.Size(101, 35);
            this.exitAddQuote.TabIndex = 26;
            this.exitAddQuote.Text = "Exit";
            this.exitAddQuote.UseVisualStyleBackColor = true;
            this.exitAddQuote.Click += new System.EventHandler(this.exitAddQuote_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.exitAddQuote);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.lastNameE);
            this.Controls.Add(this.firstNameE);
            this.Controls.Add(this.submitE);
            this.Controls.Add(this.rushE);
            this.Controls.Add(this.materialE);
            this.Controls.Add(this.drawerE);
            this.Controls.Add(this.widthE);
            this.Controls.Add(this.depthE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.submitQuote);
            this.Controls.Add(this.rushBox);
            this.Controls.Add(this.materialBox);
            this.Controls.Add(this.drawerBox);
            this.Controls.Add(this.depthBox);
            this.Controls.Add(this.lnBox);
            this.Controls.Add(this.fnBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.exitButton);
            this.Name = "AddQuote";
            this.Text = "MegaDesk - Add Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.TextBox fnBox;
        private System.Windows.Forms.TextBox lnBox;
        private System.Windows.Forms.TextBox depthBox;
        private System.Windows.Forms.TextBox drawerBox;
        private System.Windows.Forms.ListBox materialBox;
        private System.Windows.Forms.ListBox rushBox;
        private System.Windows.Forms.Button submitQuote;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label depthE;
        private System.Windows.Forms.Label widthE;
        private System.Windows.Forms.Label drawerE;
        private System.Windows.Forms.Label materialE;
        private System.Windows.Forms.Label rushE;
        private System.Windows.Forms.Label submitE;
        private System.Windows.Forms.Label firstNameE;
        private System.Windows.Forms.Label lastNameE;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.Button exitAddQuote;
    }
}
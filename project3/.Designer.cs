namespace project3
{
    partial class Assigment3
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
            this.customarInformationLevel = new System.Windows.Forms.Label();
            this.customerNameLevel = new System.Windows.Forms.Label();
            this.contactNoLevel = new System.Windows.Forms.Label();
            this.addressLevel = new System.Windows.Forms.Label();
            this.orderLavel = new System.Windows.Forms.Label();
            this.quantityLavel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // customarInformationLevel
            // 
            this.customarInformationLevel.AutoSize = true;
            this.customarInformationLevel.Location = new System.Drawing.Point(52, 27);
            this.customarInformationLevel.Name = "customarInformationLevel";
            this.customarInformationLevel.Size = new System.Drawing.Size(106, 13);
            this.customarInformationLevel.TabIndex = 0;
            this.customarInformationLevel.Text = "Customer Information\r\n";
            // 
            // customerNameLevel
            // 
            this.customerNameLevel.AutoSize = true;
            this.customerNameLevel.Location = new System.Drawing.Point(72, 57);
            this.customerNameLevel.Name = "customerNameLevel";
            this.customerNameLevel.Size = new System.Drawing.Size(82, 13);
            this.customerNameLevel.TabIndex = 1;
            this.customerNameLevel.Text = "Customer Name";
            // 
            // contactNoLevel
            // 
            this.contactNoLevel.AutoSize = true;
            this.contactNoLevel.Location = new System.Drawing.Point(72, 102);
            this.contactNoLevel.Name = "contactNoLevel";
            this.contactNoLevel.Size = new System.Drawing.Size(61, 13);
            this.contactNoLevel.TabIndex = 2;
            this.contactNoLevel.Text = "Contact No";
            // 
            // addressLevel
            // 
            this.addressLevel.AutoSize = true;
            this.addressLevel.Location = new System.Drawing.Point(72, 145);
            this.addressLevel.Name = "addressLevel";
            this.addressLevel.Size = new System.Drawing.Size(45, 13);
            this.addressLevel.TabIndex = 3;
            this.addressLevel.Text = "Address";
            // 
            // orderLavel
            // 
            this.orderLavel.AutoSize = true;
            this.orderLavel.Location = new System.Drawing.Point(72, 217);
            this.orderLavel.Name = "orderLavel";
            this.orderLavel.Size = new System.Drawing.Size(33, 13);
            this.orderLavel.TabIndex = 4;
            this.orderLavel.Text = "Order";
            // 
            // quantityLavel
            // 
            this.quantityLavel.AutoSize = true;
            this.quantityLavel.Location = new System.Drawing.Point(72, 254);
            this.quantityLavel.Name = "quantityLavel";
            this.quantityLavel.Size = new System.Drawing.Size(46, 13);
            this.quantityLavel.TabIndex = 5;
            this.quantityLavel.Text = "Quantity";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(229, 50);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(94, 20);
            this.customerNameTextBox.TabIndex = 7;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(229, 95);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(92, 20);
            this.contactTextBox.TabIndex = 8;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(229, 145);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(92, 20);
            this.addressTextBox.TabIndex = 9;
            // 
            // orderComboBox
            // 
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Reguler"});
            this.orderComboBox.Location = new System.Drawing.Point(231, 209);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(92, 21);
            this.orderComboBox.TabIndex = 10;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(231, 251);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(92, 20);
            this.quantityTextBox.TabIndex = 11;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(229, 299);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(65, 20);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.Location = new System.Drawing.Point(398, 50);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.Size = new System.Drawing.Size(227, 255);
            this.resultRichTextBox.TabIndex = 13;
            this.resultRichTextBox.Text = "";
            // 
            // Assigment3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 413);
            this.Controls.Add(this.resultRichTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.orderComboBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.quantityLavel);
            this.Controls.Add(this.orderLavel);
            this.Controls.Add(this.addressLevel);
            this.Controls.Add(this.contactNoLevel);
            this.Controls.Add(this.customerNameLevel);
            this.Controls.Add(this.customarInformationLevel);
            this.Name = "Assigment3";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customarInformationLevel;
        private System.Windows.Forms.Label customerNameLevel;
        private System.Windows.Forms.Label contactNoLevel;
        private System.Windows.Forms.Label addressLevel;
        private System.Windows.Forms.Label orderLavel;
        private System.Windows.Forms.Label quantityLavel;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.ComboBox orderComboBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RichTextBox resultRichTextBox;
    }
}


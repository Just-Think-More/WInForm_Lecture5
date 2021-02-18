using System.ComponentModel;

namespace Lecture5_2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.editGroupBox = new System.Windows.Forms.GroupBox();
            this.editButton = new System.Windows.Forms.Button();
            this.editSpecificationsTextBox = new System.Windows.Forms.TextBox();
            this.editDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.editPriceTextBox = new System.Windows.Forms.TextBox();
            this.editNameTextBox = new System.Windows.Forms.TextBox();
            this.editTypeTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.editSpecificationsLabel = new System.Windows.Forms.Label();
            this.editDescriptionLabel = new System.Windows.Forms.Label();
            this.editPriceLabel = new System.Windows.Forms.Label();
            this.editNameLabel = new System.Windows.Forms.Label();
            this.editTypeLabel = new System.Windows.Forms.Label();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.addSpecificationsTextBox = new System.Windows.Forms.TextBox();
            this.addDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.addPriceTextBox = new System.Windows.Forms.TextBox();
            this.addNameTextBox = new System.Windows.Forms.TextBox();
            this.addTypeTextBox = new System.Windows.Forms.TextBox();
            this.addSpecificationsLabel = new System.Windows.Forms.Label();
            this.addDescriptionLabel = new System.Windows.Forms.Label();
            this.addPriceLabel = new System.Windows.Forms.Label();
            this.addNameLabel = new System.Windows.Forms.Label();
            this.addTypeLabel = new System.Windows.Forms.Label();
            this.editGroupBox.SuspendLayout();
            this.addGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // editGroupBox
            // 
            this.editGroupBox.Controls.Add(this.editButton);
            this.editGroupBox.Controls.Add(this.editSpecificationsTextBox);
            this.editGroupBox.Controls.Add(this.editDescriptionTextBox);
            this.editGroupBox.Controls.Add(this.editPriceTextBox);
            this.editGroupBox.Controls.Add(this.editNameTextBox);
            this.editGroupBox.Controls.Add(this.editTypeTextBox);
            this.editGroupBox.Controls.Add(this.comboBox1);
            this.editGroupBox.Controls.Add(this.editSpecificationsLabel);
            this.editGroupBox.Controls.Add(this.editDescriptionLabel);
            this.editGroupBox.Controls.Add(this.editPriceLabel);
            this.editGroupBox.Controls.Add(this.editNameLabel);
            this.editGroupBox.Controls.Add(this.editTypeLabel);
            this.editGroupBox.Location = new System.Drawing.Point(12, 12);
            this.editGroupBox.Name = "editGroupBox";
            this.editGroupBox.Size = new System.Drawing.Size(281, 337);
            this.editGroupBox.TabIndex = 0;
            this.editGroupBox.TabStop = false;
            this.editGroupBox.Text = "Edit";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(0, 313);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(280, 22);
            this.editButton.TabIndex = 12;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // editSpecificationsTextBox
            // 
            this.editSpecificationsTextBox.Location = new System.Drawing.Point(95, 213);
            this.editSpecificationsTextBox.Multiline = true;
            this.editSpecificationsTextBox.Name = "editSpecificationsTextBox";
            this.editSpecificationsTextBox.Size = new System.Drawing.Size(186, 89);
            this.editSpecificationsTextBox.TabIndex = 11;
            // 
            // editDescriptionTextBox
            // 
            this.editDescriptionTextBox.Location = new System.Drawing.Point(95, 117);
            this.editDescriptionTextBox.Multiline = true;
            this.editDescriptionTextBox.Name = "editDescriptionTextBox";
            this.editDescriptionTextBox.Size = new System.Drawing.Size(186, 90);
            this.editDescriptionTextBox.TabIndex = 10;
            // 
            // editPriceTextBox
            // 
            this.editPriceTextBox.Location = new System.Drawing.Point(95, 96);
            this.editPriceTextBox.Name = "editPriceTextBox";
            this.editPriceTextBox.Size = new System.Drawing.Size(186, 20);
            this.editPriceTextBox.TabIndex = 9;
            // 
            // editNameTextBox
            // 
            this.editNameTextBox.Location = new System.Drawing.Point(95, 75);
            this.editNameTextBox.Name = "editNameTextBox";
            this.editNameTextBox.Size = new System.Drawing.Size(186, 20);
            this.editNameTextBox.TabIndex = 8;
            // 
            // editTypeTextBox
            // 
            this.editTypeTextBox.Location = new System.Drawing.Point(95, 54);
            this.editTypeTextBox.Name = "editTypeTextBox";
            this.editTypeTextBox.Size = new System.Drawing.Size(186, 20);
            this.editTypeTextBox.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(273, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // editSpecificationsLabel
            // 
            this.editSpecificationsLabel.Location = new System.Drawing.Point(8, 216);
            this.editSpecificationsLabel.Name = "editSpecificationsLabel";
            this.editSpecificationsLabel.Size = new System.Drawing.Size(81, 21);
            this.editSpecificationsLabel.TabIndex = 5;
            this.editSpecificationsLabel.Text = "Specifications:";
            // 
            // editDescriptionLabel
            // 
            this.editDescriptionLabel.Location = new System.Drawing.Point(8, 120);
            this.editDescriptionLabel.Name = "editDescriptionLabel";
            this.editDescriptionLabel.Size = new System.Drawing.Size(81, 21);
            this.editDescriptionLabel.TabIndex = 4;
            this.editDescriptionLabel.Text = "Description:";
            // 
            // editPriceLabel
            // 
            this.editPriceLabel.Location = new System.Drawing.Point(8, 99);
            this.editPriceLabel.Name = "editPriceLabel";
            this.editPriceLabel.Size = new System.Drawing.Size(81, 21);
            this.editPriceLabel.TabIndex = 3;
            this.editPriceLabel.Text = "Price:";
            // 
            // editNameLabel
            // 
            this.editNameLabel.Location = new System.Drawing.Point(8, 78);
            this.editNameLabel.Name = "editNameLabel";
            this.editNameLabel.Size = new System.Drawing.Size(81, 21);
            this.editNameLabel.TabIndex = 2;
            this.editNameLabel.Text = "Name:";
            // 
            // editTypeLabel
            // 
            this.editTypeLabel.Location = new System.Drawing.Point(8, 57);
            this.editTypeLabel.Name = "editTypeLabel";
            this.editTypeLabel.Size = new System.Drawing.Size(81, 21);
            this.editTypeLabel.TabIndex = 1;
            this.editTypeLabel.Text = "Type:";
            // 
            // addGroupBox
            // 
            this.addGroupBox.Controls.Add(this.addButton);
            this.addGroupBox.Controls.Add(this.addSpecificationsTextBox);
            this.addGroupBox.Controls.Add(this.addDescriptionTextBox);
            this.addGroupBox.Controls.Add(this.addPriceTextBox);
            this.addGroupBox.Controls.Add(this.addNameTextBox);
            this.addGroupBox.Controls.Add(this.addTypeTextBox);
            this.addGroupBox.Controls.Add(this.addSpecificationsLabel);
            this.addGroupBox.Controls.Add(this.addDescriptionLabel);
            this.addGroupBox.Controls.Add(this.addPriceLabel);
            this.addGroupBox.Controls.Add(this.addNameLabel);
            this.addGroupBox.Controls.Add(this.addTypeLabel);
            this.addGroupBox.Location = new System.Drawing.Point(299, 12);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(281, 337);
            this.addGroupBox.TabIndex = 1;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Add";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(2, 313);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(278, 22);
            this.addButton.TabIndex = 22;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addSpecificationsTextBox
            // 
            this.addSpecificationsTextBox.Location = new System.Drawing.Point(89, 213);
            this.addSpecificationsTextBox.Multiline = true;
            this.addSpecificationsTextBox.Name = "addSpecificationsTextBox";
            this.addSpecificationsTextBox.Size = new System.Drawing.Size(186, 89);
            this.addSpecificationsTextBox.TabIndex = 21;
            // 
            // addDescriptionTextBox
            // 
            this.addDescriptionTextBox.Location = new System.Drawing.Point(89, 117);
            this.addDescriptionTextBox.Multiline = true;
            this.addDescriptionTextBox.Name = "addDescriptionTextBox";
            this.addDescriptionTextBox.Size = new System.Drawing.Size(186, 90);
            this.addDescriptionTextBox.TabIndex = 20;
            // 
            // addPriceTextBox
            // 
            this.addPriceTextBox.Location = new System.Drawing.Point(89, 96);
            this.addPriceTextBox.Name = "addPriceTextBox";
            this.addPriceTextBox.Size = new System.Drawing.Size(186, 20);
            this.addPriceTextBox.TabIndex = 19;
            // 
            // addNameTextBox
            // 
            this.addNameTextBox.Location = new System.Drawing.Point(89, 75);
            this.addNameTextBox.Name = "addNameTextBox";
            this.addNameTextBox.Size = new System.Drawing.Size(186, 20);
            this.addNameTextBox.TabIndex = 18;
            // 
            // addTypeTextBox
            // 
            this.addTypeTextBox.Location = new System.Drawing.Point(89, 54);
            this.addTypeTextBox.Name = "addTypeTextBox";
            this.addTypeTextBox.Size = new System.Drawing.Size(186, 20);
            this.addTypeTextBox.TabIndex = 17;
            // 
            // addSpecificationsLabel
            // 
            this.addSpecificationsLabel.Location = new System.Drawing.Point(2, 216);
            this.addSpecificationsLabel.Name = "addSpecificationsLabel";
            this.addSpecificationsLabel.Size = new System.Drawing.Size(81, 21);
            this.addSpecificationsLabel.TabIndex = 16;
            this.addSpecificationsLabel.Text = "Specifications:";
            // 
            // addDescriptionLabel
            // 
            this.addDescriptionLabel.Location = new System.Drawing.Point(2, 120);
            this.addDescriptionLabel.Name = "addDescriptionLabel";
            this.addDescriptionLabel.Size = new System.Drawing.Size(81, 21);
            this.addDescriptionLabel.TabIndex = 15;
            this.addDescriptionLabel.Text = "Description:";
            // 
            // addPriceLabel
            // 
            this.addPriceLabel.Location = new System.Drawing.Point(2, 99);
            this.addPriceLabel.Name = "addPriceLabel";
            this.addPriceLabel.Size = new System.Drawing.Size(81, 21);
            this.addPriceLabel.TabIndex = 14;
            this.addPriceLabel.Text = "Price:";
            // 
            // addNameLabel
            // 
            this.addNameLabel.Location = new System.Drawing.Point(2, 78);
            this.addNameLabel.Name = "addNameLabel";
            this.addNameLabel.Size = new System.Drawing.Size(81, 21);
            this.addNameLabel.TabIndex = 13;
            this.addNameLabel.Text = "Name:";
            // 
            // addTypeLabel
            // 
            this.addTypeLabel.Location = new System.Drawing.Point(2, 57);
            this.addTypeLabel.Name = "addTypeLabel";
            this.addTypeLabel.Size = new System.Drawing.Size(81, 21);
            this.addTypeLabel.TabIndex = 12;
            this.addTypeLabel.Text = "Type:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 350);
            this.Controls.Add(this.addGroupBox);
            this.Controls.Add(this.editGroupBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.editGroupBox.ResumeLayout(false);
            this.editGroupBox.PerformLayout();
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;

        private System.Windows.Forms.Label addDescriptionLabel;
        private System.Windows.Forms.Label addNameLabel;
        private System.Windows.Forms.Label addPriceLabel;
        private System.Windows.Forms.Label addSpecificationsLabel;
        private System.Windows.Forms.Label addTypeLabel;
        private System.Windows.Forms.TextBox addTypeTextBox;
        private System.Windows.Forms.TextBox addSpecificationsTextBox;
        private System.Windows.Forms.TextBox addDescriptionTextBox;
        private System.Windows.Forms.TextBox addPriceTextBox;
        private System.Windows.Forms.TextBox addNameTextBox;

        private System.Windows.Forms.TextBox editTypeTextBox;
        private System.Windows.Forms.TextBox editNameTextBox;
        private System.Windows.Forms.TextBox editPriceTextBox;
        private System.Windows.Forms.TextBox editDescriptionTextBox;
        private System.Windows.Forms.TextBox editSpecificationsTextBox;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.GroupBox editGroupBox;
        private System.Windows.Forms.Label editTypeLabel;
        private System.Windows.Forms.Label editNameLabel;
        private System.Windows.Forms.Label editPriceLabel;
        private System.Windows.Forms.Label editDescriptionLabel;
        private System.Windows.Forms.Label editSpecificationsLabel;

        #endregion
    }
}
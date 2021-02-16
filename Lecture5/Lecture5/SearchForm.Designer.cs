using System.ComponentModel;

namespace Lecture5
{
    partial class SearchForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.@select = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.upLabel = new System.Windows.Forms.Label();
            this.mask = new System.Windows.Forms.TextBox();
            this.maskLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(27, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(369, 147);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // select
            // 
            this.@select.Location = new System.Drawing.Point(27, 223);
            this.@select.Name = "select";
            this.@select.Size = new System.Drawing.Size(369, 45);
            this.@select.TabIndex = 1;
            this.@select.Text = "Выбрать";
            this.@select.UseVisualStyleBackColor = true;
            this.@select.Click += new System.EventHandler(this.select_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.Location = new System.Drawing.Point(27, 192);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(368, 18);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "Путь";
            // 
            // upLabel
            // 
            this.upLabel.Location = new System.Drawing.Point(27, 6);
            this.upLabel.Name = "upLabel";
            this.upLabel.Size = new System.Drawing.Size(29, 26);
            this.upLabel.TabIndex = 3;
            this.upLabel.Text = "Up";
            this.upLabel.Click += new System.EventHandler(this.upLabel_Click);
            // 
            // mask
            // 
            this.mask.Location = new System.Drawing.Point(281, 7);
            this.mask.Name = "mask";
            this.mask.Size = new System.Drawing.Size(113, 20);
            this.mask.TabIndex = 4;
            // 
            // maskLabel
            // 
            this.maskLabel.Location = new System.Drawing.Point(167, 7);
            this.maskLabel.Name = "maskLabel";
            this.maskLabel.Size = new System.Drawing.Size(99, 20);
            this.maskLabel.TabIndex = 5;
            this.maskLabel.Text = "Критерии поиска:";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 280);
            this.Controls.Add(this.maskLabel);
            this.Controls.Add(this.mask);
            this.Controls.Add(this.upLabel);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.@select);
            this.Controls.Add(this.listBox1);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox mask;
        private System.Windows.Forms.Label maskLabel;

        private System.Windows.Forms.Label upLabel;

        private System.Windows.Forms.Label pathLabel;

        private System.Windows.Forms.Button @select;

        private System.Windows.Forms.ListBox listBox1;

        #endregion
    }
}
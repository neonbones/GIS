namespace GIS
{
    partial class Info
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
            this.InfoFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.картаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.объектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoListBox = new System.Windows.Forms.ListBox();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.InfoFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoFormMenuStrip
            // 
            this.InfoFormMenuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InfoFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.картаToolStripMenuItem});
            this.InfoFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.InfoFormMenuStrip.Name = "InfoFormMenuStrip";
            this.InfoFormMenuStrip.Size = new System.Drawing.Size(427, 24);
            this.InfoFormMenuStrip.TabIndex = 2;
            this.InfoFormMenuStrip.Text = "infoFormMenuStrip";
            // 
            // картаToolStripMenuItem
            // 
            this.картаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.объектыToolStripMenuItem});
            this.картаToolStripMenuItem.Name = "картаToolStripMenuItem";
            this.картаToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.картаToolStripMenuItem.Text = "Информация";
            // 
            // объектыToolStripMenuItem
            // 
            this.объектыToolStripMenuItem.Name = "объектыToolStripMenuItem";
            this.объектыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.объектыToolStripMenuItem.Text = "Закрыть";
            this.объектыToolStripMenuItem.Click += new System.EventHandler(this.объектыToolStripMenuItem_Click);
            // 
            // infoListBox
            // 
            this.infoListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoListBox.FormattingEnabled = true;
            this.infoListBox.Location = new System.Drawing.Point(12, 27);
            this.infoListBox.Name = "infoListBox";
            this.infoListBox.Size = new System.Drawing.Size(149, 147);
            this.infoListBox.TabIndex = 3;
            this.infoListBox.SelectedIndexChanged += new System.EventHandler(this.infoListBox_SelectedIndexChanged);
            // 
            // infoTextBox
            // 
            this.infoTextBox.Enabled = false;
            this.infoTextBox.Location = new System.Drawing.Point(167, 27);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(248, 147);
            this.infoTextBox.TabIndex = 4;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(427, 185);
            this.ControlBox = false;
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.infoListBox);
            this.Controls.Add(this.InfoFormMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Info";
            this.Text = "Info";
            this.InfoFormMenuStrip.ResumeLayout(false);
            this.InfoFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip InfoFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem картаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem объектыToolStripMenuItem;
        private System.Windows.Forms.ListBox infoListBox;
        private System.Windows.Forms.TextBox infoTextBox;
    }
}
namespace autopainter
{
    partial class main
    {
        //-----------------------------------------------------------------
        //
        //-----------------------------------------------------------------
        private System.ComponentModel.IContainer components = null;

        //-----------------------------------------------------------------
        //
        //-----------------------------------------------------------------
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }       

        //-----------------------------------------------------------------
        //
        //-----------------------------------------------------------------
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Colors = new System.Windows.Forms.DataGridView();
            this.RefColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCode = new System.Windows.Forms.TextBox();
            this.butFind = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Colors)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1366, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileItem
            // 
            this.fileItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitItem});
            this.fileItem.Name = "fileItem";
            this.fileItem.Size = new System.Drawing.Size(35, 20);
            this.fileItem.Text = "File";
            // 
            // exitItem
            // 
            this.exitItem.Name = "exitItem";
            this.exitItem.Size = new System.Drawing.Size(152, 22);
            this.exitItem.Text = "Exit";
            this.exitItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Colors
            // 
            this.Colors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Colors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RefColor,
            this.Manufactor,
            this.ColorCode,
            this.ColorName,
            this.ColorGroup,
            this.StockCode});
            this.Colors.Location = new System.Drawing.Point(29, 155);
            this.Colors.Name = "Colors";
            this.Colors.Size = new System.Drawing.Size(989, 150);
            this.Colors.TabIndex = 1;
            // 
            // RefColor
            // 
            this.RefColor.HeaderText = "RefColor";
            this.RefColor.Name = "RefColor";
            this.RefColor.ReadOnly = true;
            // 
            // Manufactor
            // 
            this.Manufactor.HeaderText = "Manufactor";
            this.Manufactor.Name = "Manufactor";
            this.Manufactor.ReadOnly = true;
            // 
            // ColorCode
            // 
            this.ColorCode.HeaderText = "ColorCode";
            this.ColorCode.Name = "ColorCode";
            this.ColorCode.ReadOnly = true;
            // 
            // ColorName
            // 
            this.ColorName.HeaderText = "ColorName";
            this.ColorName.Name = "ColorName";
            this.ColorName.ReadOnly = true;
            // 
            // ColorGroup
            // 
            this.ColorGroup.HeaderText = "ColorGroup";
            this.ColorGroup.Name = "ColorGroup";
            this.ColorGroup.ReadOnly = true;
            // 
            // StockCode
            // 
            this.StockCode.HeaderText = "StockCode";
            this.StockCode.Name = "StockCode";
            this.StockCode.ReadOnly = true;
            // 
            // CCode
            // 
            this.CCode.Location = new System.Drawing.Point(365, 119);
            this.CCode.Name = "CCode";
            this.CCode.Size = new System.Drawing.Size(143, 20);
            this.CCode.TabIndex = 2;
            // 
            // butFind
            // 
            this.butFind.Location = new System.Drawing.Point(646, 116);
            this.butFind.Name = "butFind";
            this.butFind.Size = new System.Drawing.Size(75, 23);
            this.butFind.TabIndex = 3;
            this.butFind.Text = "Find";
            this.butFind.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.butFind);
            this.Controls.Add(this.CCode);
            this.Controls.Add(this.Colors);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "main";
            this.Text = "Auto Painter";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Colors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileItem;
        private System.Windows.Forms.ToolStripMenuItem exitItem;
        private System.Windows.Forms.DataGridView Colors;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockCode;
        private System.Windows.Forms.TextBox CCode;
        private System.Windows.Forms.Button butFind;       
    }
}


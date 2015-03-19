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
            this.CCode = new System.Windows.Forms.TextBox();
            this.butFind = new System.Windows.Forms.Button();
            this.CName = new System.Windows.Forms.TextBox();
            this.Manufactur = new System.Windows.Forms.TextBox();
            this.ManLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RefColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscribe = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.exitItem.Size = new System.Drawing.Size(103, 22);
            this.exitItem.Text = "Exit";
            this.exitItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Colors
            // 
            this.Colors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Colors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RefColor,
            this.Manufacturer,
            this.ColorCode,
            this.ColorName,
            this.ColorGroup,
            this.StockCode,
            this.subscribe});
            this.Colors.Location = new System.Drawing.Point(29, 155);
            this.Colors.Name = "Colors";
            this.Colors.Size = new System.Drawing.Size(989, 150);
            this.Colors.TabIndex = 1;
            // 
            // CCode
            // 
            this.CCode.Location = new System.Drawing.Point(442, 113);
            this.CCode.Name = "CCode";
            this.CCode.Size = new System.Drawing.Size(143, 20);
            this.CCode.TabIndex = 2;
            // 
            // butFind
            // 
            this.butFind.Location = new System.Drawing.Point(943, 113);
            this.butFind.Name = "butFind";
            this.butFind.Size = new System.Drawing.Size(75, 23);
            this.butFind.TabIndex = 3;
            this.butFind.Text = "Find";
            this.butFind.UseVisualStyleBackColor = true;
            this.butFind.Click += new System.EventHandler(this.butFind_Click);
            // 
            // CName
            // 
            this.CName.Location = new System.Drawing.Point(731, 113);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(143, 20);
            this.CName.TabIndex = 4;
            // 
            // Manufactur
            // 
            this.Manufactur.Location = new System.Drawing.Point(156, 113);
            this.Manufactur.Name = "Manufactur";
            this.Manufactur.Size = new System.Drawing.Size(143, 20);
            this.Manufactur.TabIndex = 5;
            // 
            // ManLabel
            // 
            this.ManLabel.AutoSize = true;
            this.ManLabel.Location = new System.Drawing.Point(80, 116);
            this.ManLabel.Name = "ManLabel";
            this.ManLabel.Size = new System.Drawing.Size(70, 13);
            this.ManLabel.TabIndex = 6;
            this.ManLabel.Text = "Manufacturer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Color Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Color Name";
            // 
            // RefColor
            // 
            this.RefColor.HeaderText = "RefColor";
            this.RefColor.Name = "RefColor";
            this.RefColor.ReadOnly = true;
            // 
            // Manufacturer
            // 
            this.Manufacturer.HeaderText = "Manufacturer";
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.ReadOnly = true;
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
            // subscribe
            // 
            this.subscribe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subscribe.HeaderText = "";
            this.subscribe.Name = "subscribe";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 753);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManLabel);
            this.Controls.Add(this.Manufactur);
            this.Controls.Add(this.CName);
            this.Controls.Add(this.butFind);
            this.Controls.Add(this.CCode);
            this.Controls.Add(this.Colors);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "main";
            this.Text = "Auto Painter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
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
        private System.Windows.Forms.TextBox CCode;
        private System.Windows.Forms.Button butFind;
        private System.Windows.Forms.TextBox CName;
        private System.Windows.Forms.TextBox Manufactur;
        private System.Windows.Forms.Label ManLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscribe;       
    }
}


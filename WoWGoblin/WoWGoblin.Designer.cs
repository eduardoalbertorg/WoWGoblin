namespace WoWGoblin {
    partial class WoWGoblinFrm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.itemsDgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEMNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARKETVALUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WoWGoblinTab = new System.Windows.Forms.TabControl();
            this.itemsTab = new System.Windows.Forms.TabPage();
            this.SpecificItemsTab = new System.Windows.Forms.TabPage();
            this.WoWGoblinMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MINBUYOUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitableTab = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDgv)).BeginInit();
            this.WoWGoblinTab.SuspendLayout();
            this.itemsTab.SuspendLayout();
            this.WoWGoblinMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemsDgv
            // 
            this.itemsDgv.AllowUserToAddRows = false;
            this.itemsDgv.AllowUserToDeleteRows = false;
            this.itemsDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ITEMNAME,
            this.MARKETVALUE,
            this.MINBUYOUT});
            this.itemsDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsDgv.Location = new System.Drawing.Point(4, 6);
            this.itemsDgv.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.itemsDgv.Name = "itemsDgv";
            this.itemsDgv.ReadOnly = true;
            this.itemsDgv.Size = new System.Drawing.Size(879, 553);
            this.itemsDgv.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ITEMNAME
            // 
            this.ITEMNAME.HeaderText = "Name";
            this.ITEMNAME.Name = "ITEMNAME";
            this.ITEMNAME.ReadOnly = true;
            // 
            // MARKETVALUE
            // 
            this.MARKETVALUE.HeaderText = "Market value";
            this.MARKETVALUE.Name = "MARKETVALUE";
            this.MARKETVALUE.ReadOnly = true;
            // 
            // WoWGoblinTab
            // 
            this.WoWGoblinTab.Controls.Add(this.itemsTab);
            this.WoWGoblinTab.Controls.Add(this.SpecificItemsTab);
            this.WoWGoblinTab.Controls.Add(this.profitableTab);
            this.WoWGoblinTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.WoWGoblinTab.Location = new System.Drawing.Point(0, 27);
            this.WoWGoblinTab.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.WoWGoblinTab.Name = "WoWGoblinTab";
            this.WoWGoblinTab.SelectedIndex = 0;
            this.WoWGoblinTab.Size = new System.Drawing.Size(895, 600);
            this.WoWGoblinTab.TabIndex = 3;
            // 
            // itemsTab
            // 
            this.itemsTab.Controls.Add(this.itemsDgv);
            this.itemsTab.Location = new System.Drawing.Point(4, 31);
            this.itemsTab.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.itemsTab.Name = "itemsTab";
            this.itemsTab.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.itemsTab.Size = new System.Drawing.Size(887, 565);
            this.itemsTab.TabIndex = 0;
            this.itemsTab.Text = "All Items";
            this.itemsTab.UseVisualStyleBackColor = true;
            // 
            // SpecificItemsTab
            // 
            this.SpecificItemsTab.Location = new System.Drawing.Point(4, 31);
            this.SpecificItemsTab.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SpecificItemsTab.Name = "SpecificItemsTab";
            this.SpecificItemsTab.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SpecificItemsTab.Size = new System.Drawing.Size(887, 565);
            this.SpecificItemsTab.TabIndex = 1;
            this.SpecificItemsTab.Text = "Specific items";
            this.SpecificItemsTab.UseVisualStyleBackColor = true;
            // 
            // WoWGoblinMenu
            // 
            this.WoWGoblinMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.WoWGoblinMenu.Location = new System.Drawing.Point(0, 0);
            this.WoWGoblinMenu.Name = "WoWGoblinMenu";
            this.WoWGoblinMenu.Padding = new System.Windows.Forms.Padding(9, 4, 0, 4);
            this.WoWGoblinMenu.Size = new System.Drawing.Size(895, 27);
            this.WoWGoblinMenu.TabIndex = 4;
            this.WoWGoblinMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.configurationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateToolStripMenuItem.Text = "&Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.configurationToolStripMenuItem.Text = "&Configuration";
            // 
            // MINBUYOUT
            // 
            this.MINBUYOUT.HeaderText = "Min Buyout";
            this.MINBUYOUT.Name = "MINBUYOUT";
            this.MINBUYOUT.ReadOnly = true;
            // 
            // profitableTab
            // 
            this.profitableTab.Location = new System.Drawing.Point(4, 31);
            this.profitableTab.Name = "profitableTab";
            this.profitableTab.Padding = new System.Windows.Forms.Padding(3);
            this.profitableTab.Size = new System.Drawing.Size(887, 565);
            this.profitableTab.TabIndex = 2;
            this.profitableTab.Text = "Profitable items";
            this.profitableTab.UseVisualStyleBackColor = true;
            // 
            // WoWGoblinFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 738);
            this.Controls.Add(this.WoWGoblinTab);
            this.Controls.Add(this.WoWGoblinMenu);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.WoWGoblinMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "WoWGoblinFrm";
            this.Text = "WoW Goblin";
            ((System.ComponentModel.ISupportInitialize)(this.itemsDgv)).EndInit();
            this.WoWGoblinTab.ResumeLayout(false);
            this.itemsTab.ResumeLayout(false);
            this.WoWGoblinMenu.ResumeLayout(false);
            this.WoWGoblinMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView itemsDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEMNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARKETVALUE;
        private System.Windows.Forms.TabControl WoWGoblinTab;
        private System.Windows.Forms.TabPage itemsTab;
        private System.Windows.Forms.TabPage SpecificItemsTab;
        private System.Windows.Forms.MenuStrip WoWGoblinMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MINBUYOUT;
        private System.Windows.Forms.TabPage profitableTab;
    }
}


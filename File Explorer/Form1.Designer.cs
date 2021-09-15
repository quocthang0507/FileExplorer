namespace File_Explorer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tvExplorer = new System.Windows.Forms.TreeView();
            this.smallImageList = new System.Windows.Forms.ImageList(this.components);
            this.lvExplorer = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colModify = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.details = new System.Windows.Forms.ToolStripMenuItem();
            this.list = new System.Windows.Forms.ToolStripMenuItem();
            this.tile = new System.Windows.Forms.ToolStripMenuItem();
            this.largeImageList = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.status1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tvExplorer);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.lvExplorer);
            this.splitContainer.Size = new System.Drawing.Size(500, 336);
            this.splitContainer.SplitterDistance = 150;
            this.splitContainer.TabIndex = 0;
            // 
            // tvExplorer
            // 
            this.tvExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvExplorer.ImageIndex = 0;
            this.tvExplorer.ImageList = this.smallImageList;
            this.tvExplorer.Location = new System.Drawing.Point(0, 0);
            this.tvExplorer.Name = "tvExplorer";
            this.tvExplorer.SelectedImageIndex = 0;
            this.tvExplorer.Size = new System.Drawing.Size(150, 336);
            this.tvExplorer.TabIndex = 0;
            this.tvExplorer.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.TvExplorer_AfterCollapse);
            this.tvExplorer.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TvExplorer_AfterExpand);
            this.tvExplorer.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TvExplorer_NodeMouseClick);
            // 
            // smallImageList
            // 
            this.smallImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.smallImageList.ImageSize = new System.Drawing.Size(20, 20);
            this.smallImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lvExplorer
            // 
            this.lvExplorer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colType,
            this.colModify});
            this.lvExplorer.ContextMenuStrip = this.contextMenuStrip;
            this.lvExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvExplorer.GridLines = true;
            this.lvExplorer.HideSelection = false;
            this.lvExplorer.Location = new System.Drawing.Point(0, 0);
            this.lvExplorer.MultiSelect = false;
            this.lvExplorer.Name = "lvExplorer";
            this.lvExplorer.ShowItemToolTips = true;
            this.lvExplorer.Size = new System.Drawing.Size(346, 336);
            this.lvExplorer.TabIndex = 0;
            this.lvExplorer.UseCompatibleStateImageBehavior = false;
            this.lvExplorer.View = System.Windows.Forms.View.Details;
            this.lvExplorer.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.LvExplorer_ItemMouseHover);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            // 
            // colType
            // 
            this.colType.Text = "Type";
            // 
            // colModify
            // 
            this.colModify.Text = "Last Modified";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.viewtoolStripMenuItem1,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip.Size = new System.Drawing.Size(104, 92);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem1_Click);
            // 
            // viewtoolStripMenuItem1
            // 
            this.viewtoolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconToolStripMenuItem,
            this.smallIconToolStripMenuItem,
            this.detailsToolStripMenuItem,
            this.listToolStripMenuItem,
            this.tileToolStripMenuItem});
            this.viewtoolStripMenuItem1.Name = "viewtoolStripMenuItem1";
            this.viewtoolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.viewtoolStripMenuItem1.Text = "View";
            // 
            // largeIconToolStripMenuItem
            // 
            this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.largeIconToolStripMenuItem.Text = "Large Icon";
            this.largeIconToolStripMenuItem.Click += new System.EventHandler(this.LargeIcon_Click);
            // 
            // smallIconToolStripMenuItem
            // 
            this.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
            this.smallIconToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.smallIconToolStripMenuItem.Text = "Small Icon";
            this.smallIconToolStripMenuItem.Click += new System.EventHandler(this.SmallIcon_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.Details_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.List_Click);
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.tileToolStripMenuItem.Text = "Tile";
            this.tileToolStripMenuItem.Click += new System.EventHandler(this.Tile_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(500, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallIcon,
            this.largeIcon,
            this.details,
            this.list,
            this.tile});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.DropDownClosed += new System.EventHandler(this.ViewToolStripMenuItem_DropDownClosed);
            this.viewToolStripMenuItem.MouseLeave += new System.EventHandler(this.ViewToolStripMenuItem_MouseLeave);
            // 
            // smallIcon
            // 
            this.smallIcon.Name = "smallIcon";
            this.smallIcon.Size = new System.Drawing.Size(129, 22);
            this.smallIcon.Text = "Small Icon";
            // 
            // largeIcon
            // 
            this.largeIcon.Name = "largeIcon";
            this.largeIcon.Size = new System.Drawing.Size(129, 22);
            this.largeIcon.Text = "Large Icon";
            this.largeIcon.Click += new System.EventHandler(this.LargeIcon_Click);
            // 
            // details
            // 
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(129, 22);
            this.details.Text = "Details";
            this.details.Click += new System.EventHandler(this.Details_Click);
            // 
            // list
            // 
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(129, 22);
            this.list.Text = "List";
            this.list.Click += new System.EventHandler(this.List_Click);
            // 
            // tile
            // 
            this.tile.Name = "tile";
            this.tile.Size = new System.Drawing.Size(129, 22);
            this.tile.Text = "Tile";
            this.tile.Click += new System.EventHandler(this.Tile_Click);
            // 
            // largeImageList
            // 
            this.largeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.largeImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.largeImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status1,
            this.status2});
            this.statusStrip.Location = new System.Drawing.Point(0, 338);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(500, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // status1
            // 
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(0, 17);
            // 
            // status2
            // 
            this.status2.Name = "status2";
            this.status2.Size = new System.Drawing.Size(0, 17);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 26);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(99, 22);
            this.toolStripMenuItem2.Text = "View";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "Large Icon";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.LargeIcon_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem4.Text = "Small Icon";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.SmallIcon_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem5.Text = "Details";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.Details_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem6.Text = "List";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.List_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem7.Text = "Tile";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.Tile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 360);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "File Explorer (D:\\) - La Quốc Thắng ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView tvExplorer;
        private System.Windows.Forms.ListView lvExplorer;
        private System.Windows.Forms.ImageList smallImageList;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colModify;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem smallIcon;
		private System.Windows.Forms.ToolStripMenuItem largeIcon;
		private System.Windows.Forms.ToolStripMenuItem details;
		private System.Windows.Forms.ToolStripMenuItem list;
		private System.Windows.Forms.ToolStripMenuItem tile;
		private System.Windows.Forms.ImageList largeImageList;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel status1;
        private System.Windows.Forms.ToolStripStatusLabel status2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewtoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
    }
}


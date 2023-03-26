namespace Notepad
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tsslRowCol = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslZoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCoding = new System.Windows.Forms.ToolStripStatusLabel();
            this.separatorUpside = new System.Windows.Forms.Panel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmicUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmicRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmicCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmicCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmicPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmicSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiShow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDefaultZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.textField = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.separatorDownside = new System.Windows.Forms.Panel();
            this.statusStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsslRowCol
            // 
            this.tsslRowCol.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslRowCol.Name = "tsslRowCol";
            this.tsslRowCol.Size = new System.Drawing.Size(76, 19);
            this.tsslRowCol.Text = "Row 1, Col 1";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslRowCol,
            this.tsslZoom,
            this.tsslCoding});
            this.statusStrip.Location = new System.Drawing.Point(0, 426);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip.Size = new System.Drawing.Size(800, 24);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "Status Strip";
            // 
            // tsslZoom
            // 
            this.tsslZoom.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslZoom.Name = "tsslZoom";
            this.tsslZoom.Size = new System.Drawing.Size(39, 19);
            this.tsslZoom.Text = "100%";
            // 
            // tsslCoding
            // 
            this.tsslCoding.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslCoding.Name = "tsslCoding";
            this.tsslCoding.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsslCoding.Size = new System.Drawing.Size(42, 19);
            this.tsslCoding.Text = "UTF-8";
            // 
            // separatorUpside
            // 
            this.separatorUpside.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorUpside.BackColor = System.Drawing.SystemColors.Control;
            this.separatorUpside.Location = new System.Drawing.Point(0, 20);
            this.separatorUpside.Name = "separatorUpside";
            this.separatorUpside.Size = new System.Drawing.Size(800, 2);
            this.separatorUpside.TabIndex = 3;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmicUndo,
            this.tsmicRedo,
            this.toolStripSeparator2,
            this.tsmicCut,
            this.tsmicCopy,
            this.tsmicPaste,
            this.toolStripSeparator4,
            this.tsmicSelectAll});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(163, 148);
            // 
            // tsmicUndo
            // 
            this.tsmicUndo.Name = "tsmicUndo";
            this.tsmicUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmicUndo.Size = new System.Drawing.Size(162, 22);
            this.tsmicUndo.Text = "Undo";
            this.tsmicUndo.Click += new System.EventHandler(this.Undo);
            // 
            // tsmicRedo
            // 
            this.tsmicRedo.Name = "tsmicRedo";
            this.tsmicRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.tsmicRedo.Size = new System.Drawing.Size(162, 22);
            this.tsmicRedo.Text = "Redo";
            this.tsmicRedo.Click += new System.EventHandler(this.Redo);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            // 
            // tsmicCut
            // 
            this.tsmicCut.Name = "tsmicCut";
            this.tsmicCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmicCut.Size = new System.Drawing.Size(162, 22);
            this.tsmicCut.Text = "Cut";
            this.tsmicCut.Click += new System.EventHandler(this.Cut);
            // 
            // tsmicCopy
            // 
            this.tsmicCopy.Name = "tsmicCopy";
            this.tsmicCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmicCopy.Size = new System.Drawing.Size(162, 22);
            this.tsmicCopy.Text = "Copy";
            this.tsmicCopy.Click += new System.EventHandler(this.Copy);
            // 
            // tsmicPaste
            // 
            this.tsmicPaste.Name = "tsmicPaste";
            this.tsmicPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmicPaste.Size = new System.Drawing.Size(162, 22);
            this.tsmicPaste.Text = "Paste";
            this.tsmicPaste.Click += new System.EventHandler(this.Paste);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(159, 6);
            // 
            // tsmicSelectAll
            // 
            this.tsmicSelectAll.Name = "tsmicSelectAll";
            this.tsmicSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmicSelectAll.Size = new System.Drawing.Size(162, 22);
            this.tsmicSelectAll.Text = "Select all";
            this.tsmicSelectAll.Click += new System.EventHandler(this.SelectAll);
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiOpen,
            this.tsmiSave,
            this.tsmiSaveAs,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tsmiFile.Size = new System.Drawing.Size(33, 20);
            this.tsmiFile.Text = "File";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiNew.Size = new System.Drawing.Size(193, 22);
            this.tsmiNew.Text = "New";
            this.tsmiNew.Click += new System.EventHandler(this.New);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOpen.Size = new System.Drawing.Size(193, 22);
            this.tsmiOpen.Text = "Open...";
            this.tsmiOpen.Click += new System.EventHandler(this.Open);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(193, 22);
            this.tsmiSave.Text = "Save";
            this.tsmiSave.Click += new System.EventHandler(this.Save);
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmiSaveAs.Size = new System.Drawing.Size(193, 22);
            this.tsmiSaveAs.Text = "Save as...";
            this.tsmiSaveAs.Click += new System.EventHandler(this.SaveAs);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(193, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.Exit);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUndo,
            this.tsmiRedo,
            this.toolStripSeparator3,
            this.tsmiCut,
            this.tsmiCopy,
            this.tsmiPaste,
            this.toolStripSeparator5,
            this.tsmiSelectAll});
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tsmiEdit.Size = new System.Drawing.Size(35, 20);
            this.tsmiEdit.Text = "Edit";
            // 
            // tsmiUndo
            // 
            this.tsmiUndo.Name = "tsmiUndo";
            this.tsmiUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmiUndo.Size = new System.Drawing.Size(180, 22);
            this.tsmiUndo.Text = "Undo";
            this.tsmiUndo.Click += new System.EventHandler(this.Undo);
            // 
            // tsmiRedo
            // 
            this.tsmiRedo.Name = "tsmiRedo";
            this.tsmiRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.tsmiRedo.Size = new System.Drawing.Size(180, 22);
            this.tsmiRedo.Text = "Redo";
            this.tsmiRedo.Click += new System.EventHandler(this.Redo);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiCut
            // 
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiCut.Size = new System.Drawing.Size(180, 22);
            this.tsmiCut.Text = "Cut";
            this.tsmiCut.Click += new System.EventHandler(this.Cut);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiCopy.Size = new System.Drawing.Size(180, 22);
            this.tsmiCopy.Text = "Copy";
            this.tsmiCopy.Click += new System.EventHandler(this.Copy);
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmiPaste.Size = new System.Drawing.Size(180, 22);
            this.tsmiPaste.Text = "Paste";
            this.tsmiPaste.Click += new System.EventHandler(this.Paste);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmiSelectAll.Size = new System.Drawing.Size(180, 22);
            this.tsmiSelectAll.Text = "Select all";
            this.tsmiSelectAll.Click += new System.EventHandler(this.SelectAll);
            // 
            // tsmiFormat
            // 
            this.tsmiFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFont});
            this.tsmiFormat.Name = "tsmiFormat";
            this.tsmiFormat.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tsmiFormat.Size = new System.Drawing.Size(53, 20);
            this.tsmiFormat.Text = "Format";
            // 
            // tsmiFont
            // 
            this.tsmiFont.Name = "tsmiFont";
            this.tsmiFont.Size = new System.Drawing.Size(180, 22);
            this.tsmiFont.Text = "Font...";
            this.tsmiFont.Click += new System.EventHandler(this.ChangeFont);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowHelp,
            this.toolStripSeparator6,
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tsmiHelp.Size = new System.Drawing.Size(40, 20);
            this.tsmiHelp.Text = "Help";
            // 
            // tsmiShowHelp
            // 
            this.tsmiShowHelp.Name = "tsmiShowHelp";
            this.tsmiShowHelp.Size = new System.Drawing.Size(180, 22);
            this.tsmiShowHelp.Text = "Show help";
            this.tsmiShowHelp.Click += new System.EventHandler(this.Help);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(180, 22);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.About);
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit,
            this.tsmiFormat,
            this.tsmiShow,
            this.tsmiHelp});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip.Size = new System.Drawing.Size(800, 20);
            this.menuStrip.TabIndex = 0;
            // 
            // tsmiShow
            // 
            this.tsmiShow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiZoom,
            this.tsmiStatusBar});
            this.tsmiShow.Name = "tsmiShow";
            this.tsmiShow.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tsmiShow.Size = new System.Drawing.Size(44, 20);
            this.tsmiShow.Text = "Show";
            // 
            // tsmiZoom
            // 
            this.tsmiZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiZoomIn,
            this.tsmiZoomOut,
            this.tsmiDefaultZoom});
            this.tsmiZoom.Name = "tsmiZoom";
            this.tsmiZoom.Size = new System.Drawing.Size(180, 22);
            this.tsmiZoom.Text = "Zoom";
            // 
            // tsmiZoomIn
            // 
            this.tsmiZoomIn.Name = "tsmiZoomIn";
            this.tsmiZoomIn.Size = new System.Drawing.Size(199, 22);
            this.tsmiZoomIn.Text = "Zoom in";
            this.tsmiZoomIn.Click += new System.EventHandler(this.ZoomIn);
            // 
            // tsmiZoomOut
            // 
            this.tsmiZoomOut.Name = "tsmiZoomOut";
            this.tsmiZoomOut.Size = new System.Drawing.Size(199, 22);
            this.tsmiZoomOut.Text = "Zoom out";
            this.tsmiZoomOut.Click += new System.EventHandler(this.ZoomOut);
            // 
            // tsmiDefaultZoom
            // 
            this.tsmiDefaultZoom.Name = "tsmiDefaultZoom";
            this.tsmiDefaultZoom.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.NumPad0)));
            this.tsmiDefaultZoom.Size = new System.Drawing.Size(199, 22);
            this.tsmiDefaultZoom.Text = "Default";
            this.tsmiDefaultZoom.Click += new System.EventHandler(this.DefaultZoom);
            // 
            // tsmiStatusBar
            // 
            this.tsmiStatusBar.Checked = true;
            this.tsmiStatusBar.CheckOnClick = true;
            this.tsmiStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiStatusBar.Name = "tsmiStatusBar";
            this.tsmiStatusBar.Size = new System.Drawing.Size(180, 22);
            this.tsmiStatusBar.Text = "Status bar";
            this.tsmiStatusBar.CheckedChanged += new System.EventHandler(this.StatusBar);
            // 
            // textField
            // 
            this.textField.AcceptsTab = true;
            this.textField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textField.ContextMenuStrip = this.contextMenuStrip;
            this.textField.DetectUrls = false;
            this.textField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textField.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textField.HideSelection = false;
            this.textField.Location = new System.Drawing.Point(0, 20);
            this.textField.Name = "textField";
            this.textField.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.textField.Size = new System.Drawing.Size(800, 406);
            this.textField.TabIndex = 5;
            this.textField.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "*.txt";
            this.openFileDialog.Filter = "Text (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialog.Title = "Open text file";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFileDialog.Title = "Save text file";
            // 
            // fontDialog
            // 
            this.fontDialog.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // separatorDownside
            // 
            this.separatorDownside.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorDownside.BackColor = System.Drawing.Color.Gainsboro;
            this.separatorDownside.Location = new System.Drawing.Point(0, 427);
            this.separatorDownside.Name = "separatorDownside";
            this.separatorDownside.Size = new System.Drawing.Size(800, 1);
            this.separatorDownside.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.separatorUpside);
            this.Controls.Add(this.textField);
            this.Controls.Add(this.separatorDownside);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripStatusLabel tsslRowCol;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel separatorUpside;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiFormat;
        private System.Windows.Forms.ToolStripMenuItem tsmiFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslCoding;
        private System.Windows.Forms.ToolStripMenuItem tsmiRedo;
        private System.Windows.Forms.ToolStripMenuItem tsmiShow;
        private System.Windows.Forms.ToolStripMenuItem tsmiStatusBar;
        private System.Windows.Forms.ToolStripMenuItem tsmiZoom;
        private System.Windows.Forms.ToolStripMenuItem tsmiZoomIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiZoomOut;
        private System.Windows.Forms.ToolStripMenuItem tsmiDefaultZoom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmicUndo;
        private System.Windows.Forms.ToolStripMenuItem tsmicRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmicCut;
        private System.Windows.Forms.ToolStripMenuItem tsmicCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmicPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmicSelectAll;
        private System.Windows.Forms.RichTextBox textField;
        private System.Windows.Forms.ToolStripStatusLabel tsslZoom;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Panel separatorDownside;
    }
}


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
            this.tsslLineCol = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslZoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCoding = new System.Windows.Forms.ToolStripStatusLabel();
            this.separatorDownside = new System.Windows.Forms.Panel();
            this.separatorUpside = new System.Windows.Forms.Panel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmicUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmicRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmicCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmicCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmicPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmicDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmicSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveTo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemShow = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDefaultZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorDown = new System.Windows.Forms.Panel();
            this.textField = new System.Windows.Forms.RichTextBox();
            this.statusStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsslLineCol
            // 
            this.tsslLineCol.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslLineCol.Name = "tsslLineCol";
            this.tsslLineCol.Size = new System.Drawing.Size(66, 19);
            this.tsslLineCol.Text = "Ln 1, Col 1";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslLineCol,
            this.tsslZoom,
            this.tsslCoding});
            this.statusStrip.Location = new System.Drawing.Point(0, 387);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip.Size = new System.Drawing.Size(784, 24);
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
            // separatorDownside
            // 
            this.separatorDownside.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorDownside.BackColor = System.Drawing.Color.Gainsboro;
            this.separatorDownside.Location = new System.Drawing.Point(0, 388);
            this.separatorDownside.Name = "separatorDownside";
            this.separatorDownside.Size = new System.Drawing.Size(784, 1);
            this.separatorDownside.TabIndex = 4;
            // 
            // separatorUpside
            // 
            this.separatorUpside.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorUpside.BackColor = System.Drawing.SystemColors.Control;
            this.separatorUpside.Location = new System.Drawing.Point(0, 20);
            this.separatorUpside.Name = "separatorUpside";
            this.separatorUpside.Size = new System.Drawing.Size(784, 2);
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
            this.tsmicDelete,
            this.toolStripSeparator4,
            this.tsmicSelectAll});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(159, 170);
            // 
            // tsmicUndo
            // 
            this.tsmicUndo.Name = "tsmicUndo";
            this.tsmicUndo.Size = new System.Drawing.Size(158, 22);
            this.tsmicUndo.Text = "Desfazer";
            this.tsmicUndo.Click += new System.EventHandler(this.Undo);
            // 
            // tsmicRedo
            // 
            this.tsmicRedo.Name = "tsmicRedo";
            this.tsmicRedo.Size = new System.Drawing.Size(158, 22);
            this.tsmicRedo.Text = "Refazer";
            this.tsmicRedo.Click += new System.EventHandler(this.Redo);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(155, 6);
            // 
            // tsmicCut
            // 
            this.tsmicCut.Name = "tsmicCut";
            this.tsmicCut.Size = new System.Drawing.Size(158, 22);
            this.tsmicCut.Text = "Recortar";
            this.tsmicCut.Click += new System.EventHandler(this.Cut);
            // 
            // tsmicCopy
            // 
            this.tsmicCopy.Name = "tsmicCopy";
            this.tsmicCopy.Size = new System.Drawing.Size(158, 22);
            this.tsmicCopy.Text = "Copiar";
            this.tsmicCopy.Click += new System.EventHandler(this.Copy);
            // 
            // tsmicPaste
            // 
            this.tsmicPaste.Name = "tsmicPaste";
            this.tsmicPaste.Size = new System.Drawing.Size(158, 22);
            this.tsmicPaste.Text = "Colar";
            this.tsmicPaste.Click += new System.EventHandler(this.Paste);
            // 
            // tsmicDelete
            // 
            this.tsmicDelete.Name = "tsmicDelete";
            this.tsmicDelete.Size = new System.Drawing.Size(158, 22);
            this.tsmicDelete.Text = "Excluir";
            this.tsmicDelete.Click += new System.EventHandler(this.Delete);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(155, 6);
            // 
            // tsmicSelectAll
            // 
            this.tsmicSelectAll.Name = "tsmicSelectAll";
            this.tsmicSelectAll.Size = new System.Drawing.Size(158, 22);
            this.tsmicSelectAll.Text = "Selecionar Tudo";
            this.tsmicSelectAll.Click += new System.EventHandler(this.SelectAll);
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiOpen,
            this.tsmiSave,
            this.tsmiSaveTo,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItemFile.Text = "Arquivo";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiNew.Size = new System.Drawing.Size(222, 22);
            this.tsmiNew.Text = "Novo";
            this.tsmiNew.Click += new System.EventHandler(this.New);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOpen.Size = new System.Drawing.Size(222, 22);
            this.tsmiOpen.Text = "Abrir...";
            this.tsmiOpen.Click += new System.EventHandler(this.Open);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(222, 22);
            this.tsmiSave.Text = "Salvar";
            this.tsmiSave.Click += new System.EventHandler(this.Save);
            // 
            // tsmiSaveTo
            // 
            this.tsmiSaveTo.Name = "tsmiSaveTo";
            this.tsmiSaveTo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmiSaveTo.Size = new System.Drawing.Size(222, 22);
            this.tsmiSaveTo.Text = "Salvar Como...";
            this.tsmiSaveTo.Click += new System.EventHandler(this.SaveTo);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(222, 22);
            this.tsmiExit.Text = "Sair";
            this.tsmiExit.Click += new System.EventHandler(this.Exit);
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUndo,
            this.tsmiRedo,
            this.toolStripSeparator3,
            this.tsmiCut,
            this.tsmiCopy,
            this.tsmiPaste,
            this.tsmiDel,
            this.toolStripSeparator5,
            this.tsmiSelectAll});
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(45, 20);
            this.toolStripMenuItemEdit.Text = "Editar";
            // 
            // tsmiUndo
            // 
            this.tsmiUndo.Name = "tsmiUndo";
            this.tsmiUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmiUndo.Size = new System.Drawing.Size(200, 22);
            this.tsmiUndo.Text = "Desfazer";
            this.tsmiUndo.Click += new System.EventHandler(this.Undo);
            // 
            // tsmiRedo
            // 
            this.tsmiRedo.Name = "tsmiRedo";
            this.tsmiRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.tsmiRedo.Size = new System.Drawing.Size(200, 22);
            this.tsmiRedo.Text = "Refazer";
            this.tsmiRedo.Click += new System.EventHandler(this.Redo);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(197, 6);
            // 
            // tsmiCut
            // 
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiCut.Size = new System.Drawing.Size(200, 22);
            this.tsmiCut.Text = "Recortar";
            this.tsmiCut.Click += new System.EventHandler(this.Cut);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiCopy.Size = new System.Drawing.Size(200, 22);
            this.tsmiCopy.Text = "Copiar";
            this.tsmiCopy.Click += new System.EventHandler(this.Copy);
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmiPaste.Size = new System.Drawing.Size(200, 22);
            this.tsmiPaste.Text = "Colar";
            this.tsmiPaste.Click += new System.EventHandler(this.Paste);
            // 
            // tsmiDel
            // 
            this.tsmiDel.Name = "tsmiDel";
            this.tsmiDel.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tsmiDel.Size = new System.Drawing.Size(200, 22);
            this.tsmiDel.Text = "Excluir";
            this.tsmiDel.Click += new System.EventHandler(this.Delete);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(197, 6);
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmiSelectAll.Size = new System.Drawing.Size(200, 22);
            this.tsmiSelectAll.Text = "Selecionar Tudo";
            this.tsmiSelectAll.Click += new System.EventHandler(this.SelectAll);
            // 
            // toolStripMenuItemFormat
            // 
            this.toolStripMenuItemFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFont});
            this.toolStripMenuItemFormat.Name = "toolStripMenuItemFormat";
            this.toolStripMenuItemFormat.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toolStripMenuItemFormat.Size = new System.Drawing.Size(63, 20);
            this.toolStripMenuItemFormat.Text = "Formatar";
            // 
            // tsmiFont
            // 
            this.tsmiFont.Name = "tsmiFont";
            this.tsmiFont.Size = new System.Drawing.Size(113, 22);
            this.tsmiFont.Text = "Fonte...";
            this.tsmiFont.Click += new System.EventHandler(this.Font);
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowHelp,
            this.toolStripSeparator6,
            this.tsmiAbout});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItemHelp.Text = "Ajuda";
            // 
            // tsmiShowHelp
            // 
            this.tsmiShowHelp.Name = "tsmiShowHelp";
            this.tsmiShowHelp.Size = new System.Drawing.Size(197, 22);
            this.tsmiShowHelp.Text = "Exibir Ajuda";
            this.tsmiShowHelp.Click += new System.EventHandler(this.Help);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(194, 6);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(197, 22);
            this.tsmiAbout.Text = "Sobre o Bloco de Notas";
            this.tsmiAbout.Click += new System.EventHandler(this.About);
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemEdit,
            this.toolStripMenuItemFormat,
            this.toolStripMenuItemShow,
            this.toolStripMenuItemHelp});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip.Size = new System.Drawing.Size(784, 20);
            this.menuStrip.TabIndex = 0;
            // 
            // toolStripMenuItemShow
            // 
            this.toolStripMenuItemShow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.tsmiStatusBar});
            this.toolStripMenuItemShow.Name = "toolStripMenuItemShow";
            this.toolStripMenuItemShow.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toolStripMenuItemShow.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItemShow.Text = "Exibir";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiZoomIn,
            this.tsmiZoomOut,
            this.tsmiDefaultZoom});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // tsmiZoomIn
            // 
            this.tsmiZoomIn.Name = "tsmiZoomIn";
            this.tsmiZoomIn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.tsmiZoomIn.Size = new System.Drawing.Size(285, 22);
            this.tsmiZoomIn.Text = "Ampliar";
            this.tsmiZoomIn.Click += new System.EventHandler(this.ZoomIn);
            // 
            // tsmiZoomOut
            // 
            this.tsmiZoomOut.Name = "tsmiZoomOut";
            this.tsmiZoomOut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.tsmiZoomOut.Size = new System.Drawing.Size(285, 22);
            this.tsmiZoomOut.Text = "Reduzir";
            this.tsmiZoomOut.Click += new System.EventHandler(this.ZoomOut);
            // 
            // tsmiDefaultZoom
            // 
            this.tsmiDefaultZoom.Name = "tsmiDefaultZoom";
            this.tsmiDefaultZoom.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.NumPad0)));
            this.tsmiDefaultZoom.Size = new System.Drawing.Size(285, 22);
            this.tsmiDefaultZoom.Text = "Restaurar Zoom Padrão";
            this.tsmiDefaultZoom.Click += new System.EventHandler(this.DefaultZoom);
            // 
            // tsmiStatusBar
            // 
            this.tsmiStatusBar.Checked = true;
            this.tsmiStatusBar.CheckOnClick = true;
            this.tsmiStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiStatusBar.Name = "tsmiStatusBar";
            this.tsmiStatusBar.Size = new System.Drawing.Size(152, 22);
            this.tsmiStatusBar.Text = "Barra de Status";
            this.tsmiStatusBar.CheckedChanged += new System.EventHandler(this.StatusBar);
            // 
            // separatorDown
            // 
            this.separatorDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.separatorDown.Location = new System.Drawing.Point(0, 388);
            this.separatorDown.Name = "separatorDown";
            this.separatorDown.Size = new System.Drawing.Size(784, 1);
            this.separatorDown.TabIndex = 6;
            // 
            // textField
            // 
            this.textField.AcceptsTab = true;
            this.textField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textField.ContextMenuStrip = this.contextMenuStrip;
            this.textField.DetectUrls = false;
            this.textField.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textField.HideSelection = false;
            this.textField.Location = new System.Drawing.Point(0, 22);
            this.textField.Name = "textField";
            this.textField.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.textField.Size = new System.Drawing.Size(784, 366);
            this.textField.TabIndex = 5;
            this.textField.Text = "";
            this.textField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextField_KeyPress);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.separatorUpside);
            this.Controls.Add(this.separatorDown);
            this.Controls.Add(this.textField);
            this.Controls.Add(this.separatorDownside);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "Sem título - Editor de texto";
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
        private System.Windows.Forms.ToolStripStatusLabel tsslLineCol;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel separatorDownside;
        private System.Windows.Forms.Panel separatorUpside;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveTo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFormat;
        private System.Windows.Forms.ToolStripMenuItem tsmiFont;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Panel separatorDown;
        private System.Windows.Forms.ToolStripStatusLabel tsslCoding;
        private System.Windows.Forms.ToolStripMenuItem tsmiRedo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShow;
        private System.Windows.Forms.ToolStripMenuItem tsmiStatusBar;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem tsmicDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmicSelectAll;
        private System.Windows.Forms.RichTextBox textField;
        private System.Windows.Forms.ToolStripStatusLabel tsslZoom;
    }
}


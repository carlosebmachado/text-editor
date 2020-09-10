using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Notepad.Control;

namespace Notepad
{
    public partial class Main : Form
    {
        private const string DEFAULT_FILE_NAME = "Sem título";
        private const string SEPARATOR = " - ";
        private const string CHANGE_NOTICE = "*";
        private const string DEFAULT_TEXT = DEFAULT_FILE_NAME + SEPARATOR + Program.NAME;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Text = DEFAULT_TEXT;
            //textField.ContextMenu = TextFieldContextMenu.Create(this);
        }

        // Arquivo
        private void New(object sender, EventArgs e)
        {
            Text = DEFAULT_TEXT;
            textField.Clear();
            textField.ClearUndo();
            textField.Focus();
        }

        private void Open(object sender, EventArgs e)
        {

        }

        private void Save(object sender, EventArgs e)
        {

        }

        private void SaveTo(object sender, EventArgs e)
        {

        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Editar
        public void Undo(object sender, EventArgs e)
        {
            textField.Undo();
            if (!textField.CanUndo)
            {
                Text = DEFAULT_TEXT;
            }
        }
        public void Redo(object sender, EventArgs e)
        {
            textField.Redo();
        }
        public void Cut(object sender, EventArgs e)
        {
            textField.Cut();
        }

        public void Copy(object sender, EventArgs e)
        {
            textField.Copy();
        }

        public void Paste(object sender, EventArgs e)
        {
            textField.Paste();
        }

        public void Delete(object sender, EventArgs e)
        {

        }

        public void SelectAll(object sender, EventArgs e)
        {
            textField.SelectAll();
        }

        // Formatar
        private void Font(object sender, EventArgs e)
        {

        }

        // Exibir
        private void ZoomIn(object sender, EventArgs e)
        {
            if (textField.ZoomFactor < 5F)
            {
                AddZoom(0.1F);
            }
        }

        private void ZoomOut(object sender, EventArgs e)
        {
            if (textField.ZoomFactor > 0.15F)
            {
                AddZoom(-0.1F);
            }
        }

        private void DefaultZoom(object sender, EventArgs e)
        {
            textField.ZoomFactor = 1;
            tsslZoom.Text = "100%";
        }

        private void StatusBar(object sender, EventArgs e)
        {
            if (tsmiStatusBar.Checked)
            {
                statusStrip.Visible = true;
                separatorDown.Visible = true;
                textField.Dock = DockStyle.None;
                textField.Width = Width - 16;
                textField.Height = Height - 82;
                textField.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            }
            else
            {
                statusStrip.Visible = false;
                separatorDown.Visible = false;
                textField.Dock = DockStyle.Fill;
            }
        }

        // Ajuda
        private void Help(object sender, EventArgs e)
        {

        }

        private void About(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        // Funcionamento
        private void TextField_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar > 31 && e.KeyChar < 255)
            {
                if (textField.CanUndo)
                {
                    Text = CHANGE_NOTICE + DEFAULT_TEXT;
                }
            }
        }

        private void AddZoom(float a)
        {
            textField.ZoomFactor += a;
            if (textField.ZoomFactor < 0.2F)
            {
                textField.ZoomFactor = 0.1F;
            }
            if (textField.ZoomFactor > 4.9F)
            {
                textField.ZoomFactor = 5F;
            }
            tsslZoom.Text = ((int)(textField.ZoomFactor * 100)).ToString() + "%";
        }
    }
}

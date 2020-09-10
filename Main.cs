using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Main : Form
    {
        private const string PROGRAM_NAME = "Text Editor";
        private const string DEFAULT_FILE_NAME = "untitled";
        private const string SEPARATOR = " - ";
        private const string CHANGE_NOTICE = "*";
        private const string DEFAULT_TEXT = DEFAULT_FILE_NAME + SEPARATOR + PROGRAM_NAME;

        private int _zoomFactor = 100;
        private string _curFileName = DEFAULT_FILE_NAME;
        private string _curFilePath = null;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            Text = DEFAULT_TEXT;
        }

        // Arquivo
        private void New(object sender, EventArgs e)
        {
            if (textField.CanUndo)
            {
                DefaultSaveMessage();
            }
            Clean();
        }

        private void Clean()
        {
            Text = DEFAULT_TEXT;
            textField.Clear();
            textField.ClearUndo();
            textField.Focus();
            _curFileName = DEFAULT_FILE_NAME;
            _curFilePath = null;
        }

        private void Open(object sender, EventArgs e)
        {
            if (textField.CanUndo)
            {
                DefaultSaveMessage();
            }
            Open();
        }

        private void Open()
        {
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                _curFilePath = openFileDialog.FileNames[0];
                try
                {
                    var file = new StreamReader(_curFilePath);
                    textField.Text = file.ReadToEnd();
                    var fileName = _curFilePath.Split('\\');
                    _curFileName = fileName[fileName.Length - 1];
                    Text = _curFileName + SEPARATOR + PROGRAM_NAME;
                    file.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void DefaultSaveMessage()
        {
            DialogResult dr = MessageBox.Show(
                    "Do you want to save changes in " + _curFileName + "?",
                    "Text Editor",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

            switch (dr)
            {
                case DialogResult.Yes:
                    Save(new object(), new EventArgs());
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    break;
            }
        }

        private void Save(object sender, EventArgs e)
        {
            if (_curFilePath == null)
            {
                SaveAs(sender, e);
            }
            else
            {
                var file = new StreamWriter(_curFilePath);
                file.Write(textField.Text);
                file.Close();
                Text = _curFileName + SEPARATOR + PROGRAM_NAME;
            }
        }

        private void SaveAs(object sender, EventArgs e)
        {
            saveFileDialog.FileName = _curFileName;
            DialogResult dr = saveFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                _curFilePath = saveFileDialog.FileNames[0];
                try
                {
                    var file = new StreamWriter(_curFilePath);
                    file.Write(textField.Text);
                    var fileName = _curFilePath.Split('\\');
                    _curFileName = fileName[fileName.Length - 1];
                    Text = _curFileName + SEPARATOR + PROGRAM_NAME;
                    file.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void Exit(object sender, EventArgs e)
        {
            if (textField.CanUndo)
            {
                DefaultSaveMessage();
            }
            Application.Exit();
        }

        //Editar
        public void Undo(object sender, EventArgs e)
        {
            textField.Undo();
            if (!textField.CanUndo)
            {
                Text = _curFileName + SEPARATOR + PROGRAM_NAME;
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
        private void ChangeFont(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
        }

        // Exibir
        private void ZoomIn(object sender, EventArgs e)
        {
            if (_zoomFactor < 500)
            {
                AddZoom(10);
            }
        }

        private void ZoomOut(object sender, EventArgs e)
        {
            if (_zoomFactor > 10)
            {
                AddZoom(-10);
            }
        }

        private void DefaultZoom(object sender, EventArgs e)
        {
            textField.ZoomFactor = 1;
            _zoomFactor = 100;
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
            
        }

        // Funcionamento
        private void TextField_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar > 31 && e.KeyChar < 255)
            {
                if (textField.CanUndo)
                {
                    Text = CHANGE_NOTICE + _curFileName + SEPARATOR + PROGRAM_NAME;
                }
            }
        }

        private void AddZoom(int amt)
        {
            _zoomFactor += amt;
            textField.ZoomFactor = (float)_zoomFactor / 100;
            tsslZoom.Text = _zoomFactor.ToString() + "%";
        }
    }
}

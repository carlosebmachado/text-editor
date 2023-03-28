using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
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
        private const int DEFAULT_ZOOM_FACTOR = 100;

        private int _zoomFactor;
        private string _curFileName;
        private string _curFilePath;
        private Encoding _encoding;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            tsmiZoomIn.ShortcutKeys = Keys.Control | Keys.Add;
            tsmiZoomOut.ShortcutKeys = Keys.Control | Keys.Subtract;

            textField.TextChanged += TextField_TextChanged;
            textField.SelectionChanged += TextField_SelectionChanged;

            Clean();
        }


        // File

        private void New(object sender, EventArgs e)
        {
            if (textField.CanUndo)
            {
                var dr = DefaultSaveMessage();
                switch (dr)
                {
                    case DialogResult.Yes:
                        Save(new object(), new EventArgs());
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        return;
                    default:
                        break;
                }
            }
            Clean();
        }

        private void Open(object sender, EventArgs e)
        {
            if (textField.CanUndo)
            {
                var dr = DefaultSaveMessage();
                switch (dr)
                {
                    case DialogResult.Yes:
                        Save(new object(), new EventArgs());
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        return;
                    default:
                        break;
                }
            }
            Open();
        }

        private void Open()
        {
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Clean();
                _curFilePath = openFileDialog.FileNames[0];
                try
                {
                    var file = new StreamReader(_curFilePath);
                    _encoding = file.CurrentEncoding;
                    SetEncodingStatus();
                    textField.Text = file.ReadToEnd();
                    var fileName = _curFilePath.Split('\\');
                    _curFileName = fileName[fileName.Length - 1];
                    Text = GetCurrentProgramTitle();
                    file.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
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
                var file = new StreamWriter(_curFilePath, false, _encoding);
                file.Write(textField.Text);
                file.Close();
                Text = GetCurrentProgramTitle();
                textField.ClearUndo();
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
                    var file = new StreamWriter(_curFilePath, false, _encoding);
                    file.Write(textField.Text);
                    var fileName = _curFilePath.Split('\\');
                    _curFileName = fileName[fileName.Length - 1];
                    Text = GetCurrentProgramTitle();
                    file.Close();
                    textField.ClearUndo();
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
                var dr = DefaultSaveMessage();
                switch (dr)
                {
                    case DialogResult.Yes:
                        Save(new object(), new EventArgs());
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        return;
                    default:
                        break;
                }
            }
            Application.Exit();
        }


        //Edit

        public void Undo(object sender, EventArgs e)
        {
            textField.Undo();
            CheckCanUndo();
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

        public void SelectAll(object sender, EventArgs e)
        {
            textField.SelectAll();
        }


        // Format

        private void ChangeFont(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                textField.Font = fontDialog.Font;
            }
        }


        // Show

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
            DefaultZoom();
        }

        private void StatusBar(object sender, EventArgs e)
        {
            statusStrip.Visible = tsmiStatusBar.Checked;
            separatorDownside.Visible = tsmiStatusBar.Checked;
        }


        // Help

        private void Help(object sender, EventArgs e)
        {
            Process.Start("https://github.com/carlosebmachado/text-editor");
        }

        private void About(object sender, EventArgs e)
        {
            MessageBox.Show("A simple text editor software.", 
                "About Text Editor",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }


        // Working Functions

        private void TextField_TextChanged(object sender, EventArgs e)
        {
            CheckCanUndo();
        }

        private void TextField_SelectionChanged(object sender, EventArgs e)
        {
            SetRowColStatus();
        }

        private void CheckCanUndo()
        {
            Text = (textField.CanUndo ? CHANGE_NOTICE : "") + GetCurrentProgramTitle();
        }

        private void SetZoomFactorStatus()
        {
            tsslZoom.Text = _zoomFactor.ToString() + "%";
        }

        private void SetRowColStatus()
        {
            tsslRowCol.Text = "Row " + GetTextFieldRow() + ", Col " + GetTextFieldCol();
        }

        private void SetEncodingStatus()
        {
            tsslCoding.Text = _encoding.HeaderName.ToUpper();
        }

        private void SetTextFieldZoomFactor()
        {
            textField.ZoomFactor = (float)_zoomFactor / 100;
        }

        private void AddZoom(int amt)
        {
            _zoomFactor += amt;
            SetTextFieldZoomFactor();
            SetZoomFactorStatus();
        }

        private int GetRawTextFieldRow()
        {
            return textField.GetLineFromCharIndex(textField.SelectionStart);
        }

        private int GetRawTextFieldCol()
        {
            return textField.SelectionStart - textField.GetFirstCharIndexFromLine(GetRawTextFieldRow());
        }

        private int GetTextFieldRow()
        {
            return GetRawTextFieldRow() + 1;
        }

        private int GetTextFieldCol()
        {
            return GetRawTextFieldCol() + 1;
        }

        private string GetCurrentProgramTitle()
        {
            return _curFileName + SEPARATOR + PROGRAM_NAME;
        }

        private void DefaultZoom()
        {
            _zoomFactor = DEFAULT_ZOOM_FACTOR;
            SetTextFieldZoomFactor();
            SetZoomFactorStatus();
        }

        private void DefaultEncoding()
        {
            _encoding = Encoding.UTF8;
            SetEncodingStatus();
        }

        private void DeafultTextField()
        {
            textField.Clear();
            textField.ClearUndo();
            textField.Focus();
            SetRowColStatus();
        }

        private void Clean()
        {
            Text = DEFAULT_TEXT;
            _curFileName = DEFAULT_FILE_NAME;
            _curFilePath = null;
            DeafultTextField();
            DefaultEncoding();
            DefaultZoom();
        }

        private DialogResult DefaultSaveMessage()
        {
            return MessageBox.Show(
                    "Do you want to save changes in " + _curFileName + "?",
                    "Text Editor",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
        }
    }
}

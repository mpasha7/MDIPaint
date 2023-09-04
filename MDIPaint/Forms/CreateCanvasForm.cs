using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace MDIPaint.Forms
{
    public partial class CreateCanvasForm : Form, INotifyPropertyChanged
    {
        private Color canvasColor = Color.White;
        public Color CanvasColor 
        { 
            get => canvasColor;
            set
            {
                if (canvasColor != value)
                {
                    canvasColor = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string str = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(str));
        }

        public CreateCanvasForm()
        {
            InitializeComponent();
            txtWidth.Text = "300";
            txtHeight.Text = "200";
            txtBackColor.DataBindings.Add(new Binding("Text", this, "CanvasColor"));////////////////////////
        }

        private void txtCanvasColor_MouseDown(object sender, MouseEventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                CanvasColor = dialog.Color;
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            if (int.TryParse(txtWidth.Text, out int width)
                && int.TryParse(txtHeight.Text, out int height))
            {
                (MdiParent as MainForm).CreateNewDocument(width, height, CanvasColor);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void PressKey(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(Char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }
    }
}

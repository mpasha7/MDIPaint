using System;
using System.Windows.Forms;

namespace MDIPaint.Forms
{
    public partial class CanvasSizeForm : Form
    {
        public CanvasSizeForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            if (int.TryParse(txtWidth.Text, out int width) && int.TryParse(txtHeight.Text, out int height))
            {
                (MdiParent as MainForm).ChangeCanvasSize(width, height, chbxScale.Checked);
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

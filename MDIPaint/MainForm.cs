using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using MDIPaint.Forms;
using System.IO;
using System.Xml.Linq;
using PluginInterface;
using System.Collections.Generic;
using System.Reflection;

namespace MDIPaint
{
    public partial class MainForm : Form
    {
        private static int count = 1;
        public static Color BrushColor { get; set; } = Color.Black;
        public static Color TmpColor { get; set; }
        public static bool Flag { get; set; } = false;
        public static Tool Tool { get; set; } = new Tool();
        public static DocumentForm tmpDocument;
        private Dictionary<string, IPlugin> plugins = new Dictionary<string, IPlugin>();

        public MainForm()
        {
            InitializeComponent();
            FillCmbxBrushWidth();
            FillCmbxToolType();
            FillCmbxVerticesNumber();
            cmbxBrushWidth.ComboBox.DataBindings.Add("Text", Tool, "BrushWidth", false, 
                DataSourceUpdateMode.OnPropertyChanged);
            cmbxToolType.ComboBox.DataBindings.Add("Text", Tool, "ToolType", false, 
                DataSourceUpdateMode.OnPropertyChanged);
            cmbxVerticesNumber.ComboBox.DataBindings.Add("Text", Tool, "VerticesNumber", false, 
                DataSourceUpdateMode.OnPropertyChanged);
            FindPlugins();
            CreatePluginsMenu();
        }

        private void FillCmbxBrushWidth()
        {
            for (int i = 1; i <= 10; i++)
            {
                cmbxBrushWidth.Items.Add(i);
            }
            for (int i = 12; i <= 20; i += 2)
            {
                cmbxBrushWidth.Items.Add(i);
            }
            for (int i = 25; i <= 40; i += 5)
            {
                cmbxBrushWidth.Items.Add(i);
            }
            cmbxBrushWidth.SelectedIndex = 2;
        }

        private void FillCmbxToolType()
        {
            var tools = (ToolType[])Enum.GetValues(typeof(ToolType));
            foreach (var tool in tools)
            {
                cmbxToolType.Items.Add(tool);
            }
            cmbxToolType.SelectedIndex = 0;
        }
        
        private void FillCmbxVerticesNumber()
        {
            for (int i = 3; i <= 10; i++)
            {
                cmbxVerticesNumber.Items.Add(i);
            }
            cmbxVerticesNumber.SelectedIndex = 2;
        }

        private void File_ToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            FileSave_ToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
            FileSaveAs_ToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
        }

        private void FileNew_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCanvasForm createForm = new CreateCanvasForm();
            createForm.MdiParent = this;
            createForm.Show();
        }

        public void CreateNewDocument(int width, int height, Color color)
        {
            DocumentForm document = new DocumentForm();
            document.MdiParent = this;
            document.CreateNewDocument(width, height, color);
            document.Text = $"Document {count}";
            count++;
            document.Show();
        }

        private void FileOpen_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "WindowsBitmap (*.bmp)|*.bmp| Файлы JPEG (*.jpg, *.jpeg)|*.jpg;*.jpeg| " +
                "Все файлы (*.*)|*.*";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                DocumentForm document = new DocumentForm();
                document.MdiParent = this;
                Bitmap bitmap = new Bitmap(openDialog.FileName);
                document.Bitmap = new Bitmap(bitmap, new Size(bitmap.Width, bitmap.Height));
                document.FilePath = openDialog.FileName;
                document.Text = Path.GetFileNameWithoutExtension(openDialog.FileName);  //Своя функция???
                document.pictureBox1.Image = document.Bitmap;
                document.Show();
            }
        }

        private void FileSave_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocumentForm child = ActiveMdiChild as DocumentForm;/////////////////////////////
            if (string.IsNullOrWhiteSpace(child?.FilePath))
            {
                SaveNewFile(); // если нет имени файла, то через SaveFileDialog()
            }
            else
            {
                string extension = Path.GetExtension(child?.FilePath); // если есть, сохраняем в него
                ImageFormat format = null;
                switch (extension)
                {
                    case ".bmp":
                        format = ImageFormat.Bmp; break;
                    case ".jpg":
                    case ".jpeg":
                        format = ImageFormat.Jpeg; break;
                    default: break;
                }
                Bitmap bitmap = new Bitmap(child.Bitmap, new Size(child.Bitmap.Width, child.Bitmap.Height));
                bitmap.Save(child?.FilePath, format);
            }
            child.ChangedFlag = false;
        }

        private void FileSaveAs_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveNewFile();  // всегда через SaveFileDialog()
        }

        private void SaveNewFile()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.AddExtension = true;
            saveDialog.Filter = "WindowsBitmap (*.bmp)|*.bmp| Файлы JPEG (*.jpg)|*.jpg";
            ImageFormat[] formats = { ImageFormat.Bmp, ImageFormat.Jpeg };
            DocumentForm child = this.ActiveMdiChild as DocumentForm;
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(child?.Bitmap, new Size(child.Bitmap.Width, child.Bitmap.Height));
                bitmap.Save(saveDialog.FileName, formats[saveDialog.FilterIndex - 1]);
                child.FilePath = saveDialog.FileName;
                child.Text = Path.GetFileNameWithoutExtension(saveDialog.FileName);  //???
            }
            child.ChangedFlag = false;
        }

        private void FileQuit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Draw_ToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            DrawCanvasSize_ToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
        }

        private void ChangeCanvasSize_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CanvasSizeForm sizeForm = new CanvasSizeForm();
            tmpDocument = ActiveMdiChild as DocumentForm;
            sizeForm.MdiParent = this;
            sizeForm.txtWidth.Text = tmpDocument.Bitmap.Width.ToString();
            sizeForm.txtHeight.Text = tmpDocument.Bitmap.Height.ToString();
            sizeForm.Show();
        }

        public void ChangeCanvasSize(int width, int height, bool scale)
        {
            DocumentForm child = tmpDocument;
            if (scale == true)
            {
                child.Bitmap = new Bitmap(child.Bitmap, new Size(width, height));
                child.Refresh();
            }
            else
            {
                // TODO: Найти другой метод перерисовки
                Bitmap newBitmap = new Bitmap(width, height);
                for (int i = 0; i < width; i++)
                {
                    if (i < child.Bitmap.Width)
                        for (int j = 0; j < height; j++)
                        {
                            if (j < child.Bitmap.Height)
                                newBitmap.SetPixel(i, j, child.Bitmap.GetPixel(i, j));
                            else
                                newBitmap.SetPixel(i, j, child.CanvasColor);
                        }
                    else
                        for (int j = 0; j < height; j++)
                        {
                            newBitmap.SetPixel(i, j, child.CanvasColor);
                        }
                }
                child.Bitmap = newBitmap;
                child.Refresh();
            }
            child.pictureBox1.Image = child.Bitmap;
        }

        private void WindowCascade_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void WindowLeftToRight_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void WindowTopDown_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void WindowArrangeIcons_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void ReferenceAboutProgram_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.MdiParent = this;
            aboutForm.Show();
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrushColor = Color.Black;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrushColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrushColor = Color.Blue;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrushColor = Color.Green;
        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                BrushColor = dialog.Color;
        }

        private void cmbxToolType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tool.ToolType = (ToolType)cmbxToolType.SelectedItem;
        }

        private void PressKey(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(Char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void FindPlugins()
        {
            string folderPath = AppDomain.CurrentDomain.BaseDirectory;
            string[] filePaths = Directory.GetFiles(folderPath, "*.dll");
            foreach (var file in filePaths)
            {
                try
                {
                    Assembly assembly = Assembly.LoadFile(file);
                    foreach (var type in assembly.GetTypes())
                    {
                        Type iFace = type.GetInterface("PluginInterface.IPlugin");
                        if (iFace != null)
                        {
                            IPlugin plugin = (IPlugin)Activator.CreateInstance(type);
                            plugins[plugin.Name] = plugin;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки плагина\n" + ex.Message);
                }
            }
        }

        private void CreatePluginsMenu()
        {
            foreach (var pair in plugins)
            {
                ToolStripItem item = фильтрыToolStripMenuItem.DropDownItems.Add(pair.Value.Name);
                item.Click += OnPluginClick;
            }
        }

        private void OnPluginClick(object sender, EventArgs e)
        {
            IPlugin plugin = plugins[((ToolStripMenuItem)sender).Text];
            DocumentForm child = ActiveMdiChild as DocumentForm;
            //Bitmap bmp = (Bitmap)child.Bitmap.Clone();
            //child.pictureBox1.Image = plugin.Transform(child.Bitmap);       // TODO: Invalidate()
            child.pictureBox1.Image = plugin.Transform((Bitmap)child.pictureBox1.Image);
            Invalidate();
        }
    }
}

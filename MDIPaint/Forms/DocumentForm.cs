using MDIPaint.Forms;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace MDIPaint
{
    public partial class DocumentForm : Form
    {
        private int X;
        private int Y;
        public Bitmap Bitmap { get; set; }
        public Bitmap BitmapTmp { get; set; }
        public string FilePath { get; set; } = "";
        public Color CanvasColor { get; set; }
        private Graphics graphics;
        private PointF[] points;
        private PointF[] points2;
        public bool ChangedFlag { get; set; } = false;

        public DocumentForm()
        {
            InitializeComponent();
            CanvasColor = Color.White;
        }

        public void CreateNewDocument(int width, int height, Color color)
        {
            this.Bitmap = new Bitmap(width, height);
            this.CanvasColor = color;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    this.Bitmap.SetPixel(i, j, this.CanvasColor);
                }
            }
            pictureBox1.Image = Bitmap;
        }

        private void DocumentForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (MainForm.Tool.ToolType == ToolType.Eraser)
            {
                MainForm.BrushColor = this.CanvasColor;
            }
            this.X = e.X;
            this.Y = e.Y;
        }

        private void DocumentForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Pen pen = new Pen(MainForm.BrushColor, MainForm.Tool.BrushWidth);
                switch (MainForm.Tool.ToolType)
                {
                    case ToolType.Brush:
                    case ToolType.Eraser:
                        pen.StartCap = LineCap.Round;
                        pen.EndCap = LineCap.Round;
                        graphics = Graphics.FromImage(Bitmap);
                        graphics.DrawLine(pen, X, Y, e.X, e.Y);
                        this.X = e.X;
                        this.Y = e.Y;
                        break;
                    case ToolType.Line:
                        Refresh();
                        BitmapTmp = (Bitmap)Bitmap.Clone();
                        graphics = Graphics.FromImage(BitmapTmp);
                        graphics.DrawLine(pen, X, Y, e.X, e.Y);
                        pictureBox1.Image = BitmapTmp;
                        break;
                    case ToolType.Ellipse:
                        Refresh();
                        BitmapTmp = (Bitmap)Bitmap.Clone();
                        graphics = Graphics.FromImage(BitmapTmp);
                        graphics.DrawEllipse(pen, X, Y, e.X - X, e.Y - Y);
                        pictureBox1.Image = BitmapTmp;
                        break;
                    case ToolType.Polygon:
                        Refresh();
                        BitmapTmp = (Bitmap)Bitmap.Clone();
                        graphics = Graphics.FromImage(BitmapTmp);
                        points = GetPoints(X, Y, e.X, e.Y, MainForm.Tool.VerticesNumber);
                        graphics.DrawPolygon(pen, points);
                        pictureBox1.Image = BitmapTmp;
                        break;
                    case ToolType.Star:
                        Refresh();
                        BitmapTmp = (Bitmap)Bitmap.Clone();
                        graphics = Graphics.FromImage(BitmapTmp);
                        points = GetPoints(X, Y, e.X, e.Y, MainForm.Tool.VerticesNumber);
                        if (points.Length % 2 != 0)
                        {
                            ReorderPoints();
                            graphics.DrawPolygon(pen, points);
                        }
                        else
                        {
                            ReorderPoints2();
                            graphics.DrawPolygon(pen, points);
                            graphics.DrawPolygon(pen, points2);
                        }
                        pictureBox1.Image = BitmapTmp;
                        break;
                    default:
                        break;
                }
                pictureBox1.Invalidate();
                ChangedFlag = true;
                pen.Dispose();
            }
        }

        private void DocumentForm_MouseUp(object sender, MouseEventArgs e)
        {
            if ((int)MainForm.Tool.ToolType >=2 )
            {
                Bitmap = BitmapTmp;
            }
        }

        private PointF[] GetPoints(int x1, int y1, int x2, int y2, int n)
        {
            PointF[] points = new PointF[n];
            float x0 = (x1+x2) / 2, y0 = (y1+y2) / 2;   // центр эллипса
            float a = (x2-x1) / 2, b = (y2-y1) / 2;     // полуоси эллипса
            float angle = 2 * (float)Math.PI / n;       // угол между вершинами
            points[0] = new PointF(x0, y1);            
            for (int i = 1; i <= n-1; i++)
            {
                points[i] = new PointF(x0 + a*(float)Math.Sin(i*angle), y0 - b*(float)Math.Cos(i*angle));
            }
            return points;
        }
        
        private void ReorderPoints()
        {
            PointF[] newPoints = new PointF[points.Length];
            int i = 0, j = 0;
            int step = (points.Length - 1) / 2;
            do
            {
                newPoints[i] = points[j];
                i++;
                j += step;
                j %= points.Length;
            } while (i < points.Length);
            points = newPoints;
        }

        private void ReorderPoints2()
        {
            PointF[] newPoints = new PointF[points.Length/2];
            for (int i = 0, j = 0; i < points.Length/2; i++, j += 2)
            {
                newPoints[i] = points[j];
            }
            PointF[] newPoints2 = new PointF[points.Length/2];
            for (int i = 0, j = 1; i < points.Length/2; i++, j += 2)
            {
                newPoints2[i] = points[j];
            }
            points = newPoints;
            points2 = newPoints2;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawImage(Bitmap, 0, 0);
        }

        private void DocumentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ChangedFlag == true)
            {
                DialogResult result = MessageBox.Show($"Сохранить рисунок {Text} перед закрытием?", "Сохранение",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(FilePath))
                    {
                        SaveNewFile(); // если нет имени файла, то через SaveFileDialog()
                    }
                    else
                    {
                        SaveFile();
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void SaveNewFile()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.AddExtension = true;
            saveDialog.Filter = "WindowsBitmap (*.bmp)|*.bmp| Файлы JPEG (*.jpg)|*.jpg";
            ImageFormat[] formats = { ImageFormat.Bmp, ImageFormat.Jpeg };
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(Bitmap, new Size(Bitmap.Width, Bitmap.Height));
                bitmap.Save(saveDialog.FileName, formats[saveDialog.FilterIndex - 1]);
                FilePath = saveDialog.FileName;
                Text = Path.GetFileNameWithoutExtension(saveDialog.FileName);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void SaveFile()
        {
            string extension = Path.GetExtension(FilePath);
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
            Bitmap bitmap = new Bitmap(Bitmap, new Size(Bitmap.Width, Bitmap.Height));
            bitmap.Save(FilePath, format);
        }
    }
}

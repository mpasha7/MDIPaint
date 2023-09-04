namespace MDIPaint
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileNew_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpen_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FileSave_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveAs_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FileQuit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Draw_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawCanvasSize_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Window_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowCascade_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowLeftToRight_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowTopDown_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowArrangeIcons_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Reference_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReferenceAboutProgram_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dropDownButton_Colors = new System.Windows.Forms.ToolStripDropDownButton();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lblBrush = new System.Windows.Forms.ToolStripLabel();
            this.cmbxBrushWidth = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lblToolType = new System.Windows.Forms.ToolStripLabel();
            this.cmbxToolType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.lblVerticesNumber = new System.Windows.Forms.ToolStripLabel();
            this.cmbxVerticesNumber = new System.Windows.Forms.ToolStripComboBox();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_ToolStripMenuItem,
            this.Draw_ToolStripMenuItem,
            this.Window_ToolStripMenuItem,
            this.фильтрыToolStripMenuItem,
            this.Reference_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.Window_ToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File_ToolStripMenuItem
            // 
            this.File_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileNew_ToolStripMenuItem,
            this.FileOpen_ToolStripMenuItem,
            this.toolStripSeparator1,
            this.FileSave_ToolStripMenuItem,
            this.FileSaveAs_ToolStripMenuItem,
            this.toolStripSeparator2,
            this.FileQuit_ToolStripMenuItem});
            this.File_ToolStripMenuItem.Name = "File_ToolStripMenuItem";
            this.File_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.File_ToolStripMenuItem.ShowShortcutKeys = false;
            this.File_ToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.File_ToolStripMenuItem.Text = "&Файл";
            this.File_ToolStripMenuItem.DropDownOpening += new System.EventHandler(this.File_ToolStripMenuItem_DropDownOpening);
            // 
            // FileNew_ToolStripMenuItem
            // 
            this.FileNew_ToolStripMenuItem.Name = "FileNew_ToolStripMenuItem";
            this.FileNew_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.FileNew_ToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.FileNew_ToolStripMenuItem.Text = "Новый";
            this.FileNew_ToolStripMenuItem.Click += new System.EventHandler(this.FileNew_ToolStripMenuItem_Click);
            // 
            // FileOpen_ToolStripMenuItem
            // 
            this.FileOpen_ToolStripMenuItem.Name = "FileOpen_ToolStripMenuItem";
            this.FileOpen_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.FileOpen_ToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.FileOpen_ToolStripMenuItem.Text = "Открыть...";
            this.FileOpen_ToolStripMenuItem.Click += new System.EventHandler(this.FileOpen_ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // FileSave_ToolStripMenuItem
            // 
            this.FileSave_ToolStripMenuItem.Name = "FileSave_ToolStripMenuItem";
            this.FileSave_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.FileSave_ToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.FileSave_ToolStripMenuItem.Text = "Сохранить";
            this.FileSave_ToolStripMenuItem.Click += new System.EventHandler(this.FileSave_ToolStripMenuItem_Click);
            // 
            // FileSaveAs_ToolStripMenuItem
            // 
            this.FileSaveAs_ToolStripMenuItem.Name = "FileSaveAs_ToolStripMenuItem";
            this.FileSaveAs_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.FileSaveAs_ToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.FileSaveAs_ToolStripMenuItem.Text = "Сохранить как...";
            this.FileSaveAs_ToolStripMenuItem.Click += new System.EventHandler(this.FileSaveAs_ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
            // 
            // FileQuit_ToolStripMenuItem
            // 
            this.FileQuit_ToolStripMenuItem.Name = "FileQuit_ToolStripMenuItem";
            this.FileQuit_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.FileQuit_ToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.FileQuit_ToolStripMenuItem.Text = "Выход";
            this.FileQuit_ToolStripMenuItem.Click += new System.EventHandler(this.FileQuit_ToolStripMenuItem_Click);
            // 
            // Draw_ToolStripMenuItem
            // 
            this.Draw_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DrawCanvasSize_ToolStripMenuItem});
            this.Draw_ToolStripMenuItem.Name = "Draw_ToolStripMenuItem";
            this.Draw_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.Draw_ToolStripMenuItem.ShowShortcutKeys = false;
            this.Draw_ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.Draw_ToolStripMenuItem.Text = "&Рисунок";
            this.Draw_ToolStripMenuItem.DropDownOpening += new System.EventHandler(this.Draw_ToolStripMenuItem_DropDownOpening);
            // 
            // DrawCanvasSize_ToolStripMenuItem
            // 
            this.DrawCanvasSize_ToolStripMenuItem.Name = "DrawCanvasSize_ToolStripMenuItem";
            this.DrawCanvasSize_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.DrawCanvasSize_ToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.DrawCanvasSize_ToolStripMenuItem.Text = "Размер холста...";
            this.DrawCanvasSize_ToolStripMenuItem.Click += new System.EventHandler(this.ChangeCanvasSize_ToolStripMenuItem_Click);
            // 
            // Window_ToolStripMenuItem
            // 
            this.Window_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WindowCascade_ToolStripMenuItem,
            this.WindowLeftToRight_ToolStripMenuItem,
            this.WindowTopDown_ToolStripMenuItem,
            this.WindowArrangeIcons_ToolStripMenuItem});
            this.Window_ToolStripMenuItem.Name = "Window_ToolStripMenuItem";
            this.Window_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.J)));
            this.Window_ToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.Window_ToolStripMenuItem.Text = "&Окно";
            // 
            // WindowCascade_ToolStripMenuItem
            // 
            this.WindowCascade_ToolStripMenuItem.Name = "WindowCascade_ToolStripMenuItem";
            this.WindowCascade_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.WindowCascade_ToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.WindowCascade_ToolStripMenuItem.Text = "Каскадом";
            this.WindowCascade_ToolStripMenuItem.Click += new System.EventHandler(this.WindowCascade_ToolStripMenuItem_Click);
            // 
            // WindowLeftToRight_ToolStripMenuItem
            // 
            this.WindowLeftToRight_ToolStripMenuItem.Name = "WindowLeftToRight_ToolStripMenuItem";
            this.WindowLeftToRight_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.WindowLeftToRight_ToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.WindowLeftToRight_ToolStripMenuItem.Text = "По горизонтали";
            this.WindowLeftToRight_ToolStripMenuItem.Click += new System.EventHandler(this.WindowLeftToRight_ToolStripMenuItem_Click);
            // 
            // WindowTopDown_ToolStripMenuItem
            // 
            this.WindowTopDown_ToolStripMenuItem.Name = "WindowTopDown_ToolStripMenuItem";
            this.WindowTopDown_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.WindowTopDown_ToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.WindowTopDown_ToolStripMenuItem.Text = "По вертикали";
            this.WindowTopDown_ToolStripMenuItem.Click += new System.EventHandler(this.WindowTopDown_ToolStripMenuItem_Click);
            // 
            // WindowArrangeIcons_ToolStripMenuItem
            // 
            this.WindowArrangeIcons_ToolStripMenuItem.Name = "WindowArrangeIcons_ToolStripMenuItem";
            this.WindowArrangeIcons_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.WindowArrangeIcons_ToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.WindowArrangeIcons_ToolStripMenuItem.Text = "Упорядочить значки";
            this.WindowArrangeIcons_ToolStripMenuItem.Click += new System.EventHandler(this.WindowArrangeIcons_ToolStripMenuItem_Click);
            // 
            // Reference_ToolStripMenuItem
            // 
            this.Reference_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReferenceAboutProgram_ToolStripMenuItem});
            this.Reference_ToolStripMenuItem.Name = "Reference_ToolStripMenuItem";
            this.Reference_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.Reference_ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.Reference_ToolStripMenuItem.Text = "&Справка";
            // 
            // ReferenceAboutProgram_ToolStripMenuItem
            // 
            this.ReferenceAboutProgram_ToolStripMenuItem.Name = "ReferenceAboutProgram_ToolStripMenuItem";
            this.ReferenceAboutProgram_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ReferenceAboutProgram_ToolStripMenuItem.Text = "О &программе";
            this.ReferenceAboutProgram_ToolStripMenuItem.Click += new System.EventHandler(this.ReferenceAboutProgram_ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dropDownButton_Colors,
            this.toolStripSeparator3,
            this.lblBrush,
            this.cmbxBrushWidth,
            this.toolStripSeparator4,
            this.lblToolType,
            this.cmbxToolType,
            this.toolStripSeparator5,
            this.lblVerticesNumber,
            this.cmbxVerticesNumber});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(796, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dropDownButton_Colors
            // 
            this.dropDownButton_Colors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dropDownButton_Colors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackToolStripMenuItem,
            this.redToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.dropDownButton_Colors.Image = global::MDIPaint.Properties.Resources.цвет;
            this.dropDownButton_Colors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropDownButton_Colors.Name = "dropDownButton_Colors";
            this.dropDownButton_Colors.Size = new System.Drawing.Size(29, 22);
            this.dropDownButton_Colors.Text = "Colors";
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Image = global::MDIPaint.Properties.Resources.Black;
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.blackToolStripMenuItem.Text = "Черный";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Image = global::MDIPaint.Properties.Resources.Red;
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.redToolStripMenuItem.Text = "Красный";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Image = global::MDIPaint.Properties.Resources.Blue;
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.blueToolStripMenuItem.Text = "Синий";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Image = global::MDIPaint.Properties.Resources.Green;
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.greenToolStripMenuItem.Text = "Зеленый";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.otherToolStripMenuItem.Text = "Другой";
            this.otherToolStripMenuItem.Click += new System.EventHandler(this.otherToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // lblBrush
            // 
            this.lblBrush.Name = "lblBrush";
            this.lblBrush.Size = new System.Drawing.Size(84, 22);
            this.lblBrush.Text = "Размер кисти:";
            // 
            // cmbxBrushWidth
            // 
            this.cmbxBrushWidth.Name = "cmbxBrushWidth";
            this.cmbxBrushWidth.Size = new System.Drawing.Size(75, 25);
            this.cmbxBrushWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressKey);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // lblToolType
            // 
            this.lblToolType.Name = "lblToolType";
            this.lblToolType.Size = new System.Drawing.Size(77, 22);
            this.lblToolType.Text = "Инструмент:";
            // 
            // cmbxToolType
            // 
            this.cmbxToolType.Name = "cmbxToolType";
            this.cmbxToolType.Size = new System.Drawing.Size(75, 25);
            this.cmbxToolType.SelectedIndexChanged += new System.EventHandler(this.cmbxToolType_SelectedIndexChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // lblVerticesNumber
            // 
            this.lblVerticesNumber.Name = "lblVerticesNumber";
            this.lblVerticesNumber.Size = new System.Drawing.Size(79, 22);
            this.lblVerticesNumber.Text = "К-во вершин";
            // 
            // cmbxVerticesNumber
            // 
            this.cmbxVerticesNumber.Name = "cmbxVerticesNumber";
            this.cmbxVerticesNumber.Size = new System.Drawing.Size(75, 25);
            this.cmbxVerticesNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressKey);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MDIPaint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileNew_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileOpen_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem FileSave_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileSaveAs_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem FileQuit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Draw_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DrawCanvasSize_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Window_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowCascade_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowLeftToRight_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowTopDown_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowArrangeIcons_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Reference_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReferenceAboutProgram_ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton dropDownButton_Colors;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel lblBrush;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel lblToolType;
        private System.Windows.Forms.ToolStripComboBox cmbxToolType;
        private System.Windows.Forms.ToolStripComboBox cmbxBrushWidth;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel lblVerticesNumber;
        private System.Windows.Forms.ToolStripComboBox cmbxVerticesNumber;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
    }
}


namespace Paint
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearField = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.invertPic = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAs = new System.Windows.Forms.ToolStripMenuItem();
            this.leftMenu = new System.Windows.Forms.ToolStrip();
            this.tsbPen = new System.Windows.Forms.ToolStripButton();
            this.tsbLine = new System.Windows.Forms.ToolStripButton();
            this.tsbCircle = new System.Windows.Forms.ToolStripButton();
            this.tsbRectangle = new System.Windows.Forms.ToolStripButton();
            this.tsbThickness = new System.Windows.Forms.ToolStripButton();
            this.tsbColor = new System.Windows.Forms.ToolStripButton();
            this.tsbFill = new System.Windows.Forms.ToolStripButton();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.topMenu.SuspendLayout();
            this.leftMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenu
            // 
            this.topMenu.BackColor = System.Drawing.SystemColors.Window;
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutAs});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.MaximumSize = new System.Drawing.Size(250, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(250, 24);
            this.topMenu.TabIndex = 0;
            this.topMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFile,
            this.openFile,
            this.toolStripMenuItem1,
            this.saveFile});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFile
            // 
            this.newFile.Name = "newFile";
            this.newFile.Size = new System.Drawing.Size(180, 22);
            this.newFile.Text = "New File";
            this.newFile.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(180, 22);
            this.openFile.Text = "Open File";
            this.openFile.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // saveFile
            // 
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(180, 22);
            this.saveFile.Text = "Save File";
            this.saveFile.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearField,
            this.toolStripMenuItem2,
            this.invertPic});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearField
            // 
            this.clearField.Name = "clearField";
            this.clearField.Size = new System.Drawing.Size(180, 22);
            this.clearField.Text = "Clear";
            this.clearField.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // invertPic
            // 
            this.invertPic.Name = "invertPic";
            this.invertPic.Size = new System.Drawing.Size(180, 22);
            this.invertPic.Text = "Invert drawing";
            this.invertPic.ToolTipText = "invert picture";
            this.invertPic.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // aboutAs
            // 
            this.aboutAs.AutoToolTip = true;
            this.aboutAs.Name = "aboutAs";
            this.aboutAs.Size = new System.Drawing.Size(67, 20);
            this.aboutAs.Text = "About us";
            this.aboutAs.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // leftMenu
            // 
            this.leftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.leftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.leftMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.leftMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPen,
            this.tsbLine,
            this.tsbCircle,
            this.tsbRectangle,
            this.tsbThickness,
            this.tsbColor,
            this.tsbFill});
            this.leftMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.leftMenu.Location = new System.Drawing.Point(0, 24);
            this.leftMenu.Margin = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.leftMenu.Name = "leftMenu";
            this.leftMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.leftMenu.Size = new System.Drawing.Size(51, 560);
            this.leftMenu.TabIndex = 1;
            this.leftMenu.Text = "toolStrip1";
            // 
            // tsbPen
            // 
            this.tsbPen.AutoSize = false;
            this.tsbPen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPen.Image = ((System.Drawing.Image)(resources.GetObject("tsbPen.Image")));
            this.tsbPen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPen.Name = "tsbPen";
            this.tsbPen.Size = new System.Drawing.Size(50, 50);
            this.tsbPen.Text = "toolStripButton1";
            this.tsbPen.ToolTipText = "Pencil";
            this.tsbPen.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // tsbLine
            // 
            this.tsbLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLine.Image = ((System.Drawing.Image)(resources.GetObject("tsbLine.Image")));
            this.tsbLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLine.Name = "tsbLine";
            this.tsbLine.Size = new System.Drawing.Size(48, 20);
            this.tsbLine.Text = "toolStripButton2";
            this.tsbLine.ToolTipText = "Line";
            this.tsbLine.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // tsbCircle
            // 
            this.tsbCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCircle.Image = ((System.Drawing.Image)(resources.GetObject("tsbCircle.Image")));
            this.tsbCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCircle.Name = "tsbCircle";
            this.tsbCircle.Size = new System.Drawing.Size(48, 20);
            this.tsbCircle.Text = "toolStripButton3";
            this.tsbCircle.ToolTipText = "Ellipse";
            this.tsbCircle.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // tsbRectangle
            // 
            this.tsbRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRectangle.Image = ((System.Drawing.Image)(resources.GetObject("tsbRectangle.Image")));
            this.tsbRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRectangle.Name = "tsbRectangle";
            this.tsbRectangle.Size = new System.Drawing.Size(48, 20);
            this.tsbRectangle.Text = "toolStripButton1";
            this.tsbRectangle.ToolTipText = "Rectangle";
            this.tsbRectangle.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // tsbThickness
            // 
            this.tsbThickness.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbThickness.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbThickness.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.tsbThickness.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThickness.Name = "tsbThickness";
            this.tsbThickness.Size = new System.Drawing.Size(48, 23);
            this.tsbThickness.Text = "7";
            this.tsbThickness.ToolTipText = "Line Thickness";
            this.tsbThickness.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // tsbColor
            // 
            this.tsbColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbColor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsbColor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsbColor.Image = ((System.Drawing.Image)(resources.GetObject("tsbColor.Image")));
            this.tsbColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbColor.Name = "tsbColor";
            this.tsbColor.Size = new System.Drawing.Size(48, 23);
            this.tsbColor.Text = "Color";
            this.tsbColor.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // tsbFill
            // 
            this.tsbFill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbFill.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsbFill.ForeColor = System.Drawing.SystemColors.Control;
            this.tsbFill.Image = ((System.Drawing.Image)(resources.GetObject("tsbFill.Image")));
            this.tsbFill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFill.Name = "tsbFill";
            this.tsbFill.Size = new System.Drawing.Size(48, 23);
            this.tsbFill.Text = "Fill";
            this.tsbFill.ToolTipText = "Fill figure";
            this.tsbFill.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "PFSOFT Paint";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(984, 584);
            this.Controls.Add(this.leftMenu);
            this.Controls.Add(this.topMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.topMenu;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.leftMenu.ResumeLayout(false);
            this.leftMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFile;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveFile;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem invertPic;
        private System.Windows.Forms.ToolStripMenuItem aboutAs;
        private System.Windows.Forms.ToolStrip leftMenu;
        private System.Windows.Forms.ToolStripButton tsbPen;
        private System.Windows.Forms.ToolStripButton tsbLine;
        private System.Windows.Forms.ToolStripButton tsbCircle;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripButton tsbThickness;
        private System.Windows.Forms.ToolStripButton tsbRectangle;
        private System.Windows.Forms.ToolStripMenuItem clearField;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripButton tsbColor;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripButton tsbFill;
    }
}


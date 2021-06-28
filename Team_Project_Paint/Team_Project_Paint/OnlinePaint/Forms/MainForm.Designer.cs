namespace Team_Project_Paint
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DotButton = new System.Windows.Forms.ToolStripButton();
            this.LineButton = new System.Windows.Forms.ToolStripButton();
            this.CurveButton = new System.Windows.Forms.ToolStripButton();
            this.RectangleButton = new System.Windows.Forms.ToolStripButton();
            this.EllipseButton = new System.Windows.Forms.ToolStripButton();
            this.TriangleButton = new System.Windows.Forms.ToolStripButton();
            this.RoundingRectButton = new System.Windows.Forms.ToolStripButton();
            this.HexagonButtom = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.CurrentColorButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opentoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRemoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRemoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.moveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.selectBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.ChengeColorButton = new System.Windows.Forms.Button();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.statsBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.spMainFormSplit = new System.Windows.Forms.SplitContainer();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spMainFormSplit)).BeginInit();
            this.spMainFormSplit.Panel1.SuspendLayout();
            this.spMainFormSplit.Panel2.SuspendLayout();
            this.spMainFormSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DotButton,
            this.LineButton,
            this.CurveButton,
            this.RectangleButton,
            this.EllipseButton,
            this.TriangleButton,
            this.RoundingRectButton,
            this.HexagonButtom});
            this.toolStrip1.Location = new System.Drawing.Point(2, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(433, 114);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // DotButton
            // 
            this.DotButton.AutoSize = false;
            this.DotButton.CheckOnClick = true;
            this.DotButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DotButton.Image = global::Team_Project_Paint.Properties.Resources.dot;
            this.DotButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DotButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(50, 50);
            this.DotButton.Text = "Dot";
            this.DotButton.Click += new System.EventHandler(this.DotButton_Click);
            // 
            // LineButton
            // 
            this.LineButton.AutoSize = false;
            this.LineButton.CheckOnClick = true;
            this.LineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineButton.Image = global::Team_Project_Paint.Properties.Resources.line;
            this.LineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(50, 50);
            this.LineButton.Text = "Line";
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // CurveButton
            // 
            this.CurveButton.AutoSize = false;
            this.CurveButton.CheckOnClick = true;
            this.CurveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CurveButton.Image = global::Team_Project_Paint.Properties.Resources.curve;
            this.CurveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CurveButton.Name = "CurveButton";
            this.CurveButton.Size = new System.Drawing.Size(50, 50);
            this.CurveButton.Text = "Curve";
            this.CurveButton.Click += new System.EventHandler(this.CurveButton_Click);
            // 
            // RectangleButton
            // 
            this.RectangleButton.AutoSize = false;
            this.RectangleButton.CheckOnClick = true;
            this.RectangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RectangleButton.Image = global::Team_Project_Paint.Properties.Resources.rect;
            this.RectangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(50, 50);
            this.RectangleButton.Text = "Rectangle";
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // EllipseButton
            // 
            this.EllipseButton.AutoSize = false;
            this.EllipseButton.CheckOnClick = true;
            this.EllipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EllipseButton.Image = global::Team_Project_Paint.Properties.Resources.ellipse;
            this.EllipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EllipseButton.Name = "EllipseButton";
            this.EllipseButton.Size = new System.Drawing.Size(50, 50);
            this.EllipseButton.Text = "Ellipse";
            this.EllipseButton.Click += new System.EventHandler(this.EllipseButton_Click);
            // 
            // TriangleButton
            // 
            this.TriangleButton.AutoSize = false;
            this.TriangleButton.CheckOnClick = true;
            this.TriangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TriangleButton.Image = global::Team_Project_Paint.Properties.Resources.triangle;
            this.TriangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TriangleButton.Name = "TriangleButton";
            this.TriangleButton.Size = new System.Drawing.Size(50, 50);
            this.TriangleButton.Text = "Triangle";
            this.TriangleButton.Click += new System.EventHandler(this.TriangleButton_Click);
            // 
            // RoundingRectButton
            // 
            this.RoundingRectButton.AutoSize = false;
            this.RoundingRectButton.BackColor = System.Drawing.Color.Transparent;
            this.RoundingRectButton.CheckOnClick = true;
            this.RoundingRectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RoundingRectButton.Image = global::Team_Project_Paint.Properties.Resources.roundrect;
            this.RoundingRectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RoundingRectButton.Name = "RoundingRectButton";
            this.RoundingRectButton.Size = new System.Drawing.Size(50, 50);
            this.RoundingRectButton.Text = "Rounding Rectangle";
            this.RoundingRectButton.Click += new System.EventHandler(this.RoundingRectButton_Click);
            // 
            // HexagonButtom
            // 
            this.HexagonButtom.AutoSize = false;
            this.HexagonButtom.BackColor = System.Drawing.Color.Transparent;
            this.HexagonButtom.CheckOnClick = true;
            this.HexagonButtom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HexagonButtom.Image = global::Team_Project_Paint.Properties.Resources.hexagon1;
            this.HexagonButtom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HexagonButtom.Name = "HexagonButtom";
            this.HexagonButtom.Size = new System.Drawing.Size(50, 50);
            this.HexagonButtom.Text = "Hexagon";
            this.HexagonButtom.Click += new System.EventHandler(this.HexagonButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(490, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(521, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(490, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 25);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // CurrentColorButton
            // 
            this.CurrentColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentColorButton.BackColor = System.Drawing.Color.Black;
            this.CurrentColorButton.Location = new System.Drawing.Point(449, 53);
            this.CurrentColorButton.Name = "CurrentColorButton";
            this.CurrentColorButton.Size = new System.Drawing.Size(35, 35);
            this.CurrentColorButton.TabIndex = 6;
            this.CurrentColorButton.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.Yellow;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(552, 53);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 25);
            this.button6.TabIndex = 7;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackColor = System.Drawing.Color.Green;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(552, 82);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(25, 25);
            this.button8.TabIndex = 9;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.BackColor = System.Drawing.Color.Purple;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Location = new System.Drawing.Point(521, 82);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(25, 25);
            this.button9.TabIndex = 10;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Current";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Colors";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Change";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(658, 43);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(144, 45);
            this.trackBar1.TabIndex = 17;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.BrushSizeTrackBar_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.ClearBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opentoolStripMenuItem,
            this.openRemoteToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveRemoteToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.файлToolStripMenuItem.Text = "File";
            // 
            // opentoolStripMenuItem
            // 
            this.opentoolStripMenuItem.Name = "opentoolStripMenuItem";
            this.opentoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opentoolStripMenuItem.Text = "Open...";
            this.opentoolStripMenuItem.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // openRemoteToolStripMenuItem
            // 
            this.openRemoteToolStripMenuItem.Name = "openRemoteToolStripMenuItem";
            this.openRemoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openRemoteToolStripMenuItem.Text = "Open Remote...";
            this.openRemoteToolStripMenuItem.Click += new System.EventHandler(this.openRemoteToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save As...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // saveRemoteToolStripMenuItem
            // 
            this.saveRemoteToolStripMenuItem.Name = "saveRemoteToolStripMenuItem";
            this.saveRemoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveRemoteToolStripMenuItem.Text = "Save Remote...";
            this.saveRemoteToolStripMenuItem.Click += new System.EventHandler(this.saveRemoteToolStripMenuItem_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(46, 20);
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "jpg";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown2.Location = new System.Drawing.Point(369, 90);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.ReadOnly = true;
            this.numericUpDown2.Size = new System.Drawing.Size(34, 20);
            this.numericUpDown2.TabIndex = 20;
            this.numericUpDown2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.CornesNumeric_ValueChanged);
            // 
            // moveBtn
            // 
            this.moveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moveBtn.Enabled = false;
            this.moveBtn.Location = new System.Drawing.Point(835, 65);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(75, 45);
            this.moveBtn.TabIndex = 21;
            this.moveBtn.Text = "MOVE OFF";
            this.moveBtn.UseVisualStyleBackColor = true;
            this.moveBtn.Click += new System.EventHandler(this.MoveBtn_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(769, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "20px";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(714, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "10px";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(661, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "1px";
            // 
            // selectBtn
            // 
            this.selectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectBtn.Location = new System.Drawing.Point(835, 15);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(76, 43);
            this.selectBtn.TabIndex = 27;
            this.selectBtn.Text = "SELECT OFF";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Location = new System.Drawing.Point(931, 15);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 95);
            this.deleteBtn.TabIndex = 28;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ChengeColorButton
            // 
            this.ChengeColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChengeColorButton.Image = global::Team_Project_Paint.Properties.Resources._2;
            this.ChengeColorButton.Location = new System.Drawing.Point(583, 53);
            this.ChengeColorButton.Name = "ChengeColorButton";
            this.ChengeColorButton.Size = new System.Drawing.Size(35, 35);
            this.ChengeColorButton.TabIndex = 8;
            this.ChengeColorButton.UseVisualStyleBackColor = true;
            this.ChengeColorButton.Click += new System.EventHandler(this.ChangeColorButton_Click);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.White;
            this.pictureBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMain.Image = global::Team_Project_Paint.Properties.Resources.line1;
            this.pictureBoxMain.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(1029, 469);
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseClick);
            this.pictureBoxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseDown);
            this.pictureBoxMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseMove);
            this.pictureBoxMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseUp);
            // 
            // statsBtn
            // 
            this.statsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statsBtn.Location = new System.Drawing.Point(641, 4);
            this.statsBtn.Name = "statsBtn";
            this.statsBtn.Size = new System.Drawing.Size(75, 23);
            this.statsBtn.TabIndex = 29;
            this.statsBtn.Text = "Statistics";
            this.statsBtn.UseVisualStyleBackColor = true;
            this.statsBtn.Click += new System.EventHandler(this.statsBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutBtn.Location = new System.Drawing.Point(724, 4);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(75, 23);
            this.logOutBtn.TabIndex = 30;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserInfo.Location = new System.Drawing.Point(426, 4);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(209, 23);
            this.lblUserInfo.TabIndex = 31;
            this.lblUserInfo.Text = "lblUserInfo";
            this.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.lblUserInfo);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.logOutBtn);
            this.panel1.Controls.Add(this.selectBtn);
            this.panel1.Controls.Add(this.statsBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CurrentColorButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ChengeColorButton);
            this.panel1.Controls.Add(this.moveBtn);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 114);
            this.panel1.TabIndex = 32;
            // 
            // spMainFormSplit
            // 
            this.spMainFormSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spMainFormSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spMainFormSplit.Location = new System.Drawing.Point(0, 0);
            this.spMainFormSplit.Name = "spMainFormSplit";
            this.spMainFormSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spMainFormSplit.Panel1
            // 
            this.spMainFormSplit.Panel1.Controls.Add(this.panel1);
            this.spMainFormSplit.Panel1.Controls.Add(this.menuStrip1);
            // 
            // spMainFormSplit.Panel2
            // 
            this.spMainFormSplit.Panel2.Controls.Add(this.pictureBoxMain);
            this.spMainFormSplit.Size = new System.Drawing.Size(1029, 613);
            this.spMainFormSplit.SplitterDistance = 140;
            this.spMainFormSplit.TabIndex = 33;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1029, 613);
            this.Controls.Add(this.spMainFormSplit);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1045, 0);
            this.Name = "MainForm";
            this.Text = "Paint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.VisibleChanged += new System.EventHandler(this.MainForm_VisibleChanged);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.spMainFormSplit.Panel1.ResumeLayout(false);
            this.spMainFormSplit.Panel1.PerformLayout();
            this.spMainFormSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spMainFormSplit)).EndInit();
            this.spMainFormSplit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton DotButton;
        private System.Windows.Forms.ToolStripButton LineButton;
        private System.Windows.Forms.ToolStripButton CurveButton;
        private System.Windows.Forms.ToolStripButton RectangleButton;
        private System.Windows.Forms.ToolStripButton EllipseButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button CurrentColorButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button ChengeColorButton;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem opentoolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton TriangleButton;
        private System.Windows.Forms.ToolStripButton HexagonButtom;
        private System.Windows.Forms.ToolStripButton RoundingRectButton;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button moveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ToolStripMenuItem ClearBtn;
        private System.Windows.Forms.Button statsBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.ToolStripMenuItem openRemoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveRemoteToolStripMenuItem;
        private System.Windows.Forms.Label lblUserInfo;
        public System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer spMainFormSplit;
    }
}


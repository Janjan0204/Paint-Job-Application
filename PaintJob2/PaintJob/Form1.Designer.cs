namespace PaintJob
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.open = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.saveAs = new System.Windows.Forms.Button();
            this.import = new System.Windows.Forms.Button();
            this.menuShow = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sizingPanel = new System.Windows.Forms.Panel();
            this.sizeLbl = new System.Windows.Forms.Label();
            this.sizeBar = new System.Windows.Forms.TrackBar();
            this.changeablePanel = new System.Windows.Forms.Panel();
            this.shapesOption = new System.Windows.Forms.Panel();
            this.circleButton = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.colorPicker = new System.Windows.Forms.PictureBox();
            this.ZoomOutBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ZoomInBtn = new System.Windows.Forms.Button();
            this.textButton = new System.Windows.Forms.Button();
            this.shapesButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.gridButton = new System.Windows.Forms.Button();
            this.eraserButton = new System.Windows.Forms.Button();
            this.brushButton = new System.Windows.Forms.Button();
            this.redoButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.mainCanvas = new System.Windows.Forms.PictureBox();
            this.verticalScroll = new System.Windows.Forms.VScrollBar();
            this.menuSlide = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.menuImport = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuSave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuExport = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.menuOpen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.horizontalScroll = new System.Windows.Forms.HScrollBar();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.controlPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.sizingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBar)).BeginInit();
            this.changeablePanel.SuspendLayout();
            this.shapesOption.SuspendLayout();
            this.colorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).BeginInit();
            this.menuSlide.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.header.Controls.Add(this.pictureBox1);
            this.header.Controls.Add(this.controlPanel);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(4);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1368, 36);
            this.header.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 62);
            this.pictureBox1.Size = new System.Drawing.Size(1218, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // controlPanel
            // 
            this.controlPanel.AutoSize = true;
            this.controlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.controlPanel.Controls.Add(this.exitButton);
            this.controlPanel.Controls.Add(this.maximizeButton);
            this.controlPanel.Controls.Add(this.minimizeButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlPanel.Location = new System.Drawing.Point(1218, 0);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(4);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(148, 34);
            this.controlPanel.TabIndex = 3;
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.exitButton.Location = new System.Drawing.Point(117, 4);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(27, 25);
            this.exitButton.TabIndex = 2;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.AutoSize = true;
            this.maximizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maximizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maximizeButton.BackgroundImage")));
            this.maximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maximizeButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.maximizeButton.Location = new System.Drawing.Point(63, 4);
            this.maximizeButton.Margin = new System.Windows.Forms.Padding(4);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(27, 25);
            this.maximizeButton.TabIndex = 1;
            this.maximizeButton.UseVisualStyleBackColor = false;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.AutoSize = true;
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minimizeButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.minimizeButton.Location = new System.Drawing.Point(4, 4);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(27, 25);
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuPanel.Controls.Add(this.open);
            this.menuPanel.Controls.Add(this.save);
            this.menuPanel.Controls.Add(this.saveAs);
            this.menuPanel.Controls.Add(this.import);
            this.menuPanel.Controls.Add(this.menuShow);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 36);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1368, 37);
            this.menuPanel.TabIndex = 1;
            // 
            // open
            // 
            this.open.BackColor = System.Drawing.Color.Transparent;
            this.open.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("open.BackgroundImage")));
            this.open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.open.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.open.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.open.FlatAppearance.BorderSize = 0;
            this.open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open.Location = new System.Drawing.Point(241, 6);
            this.open.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(51, 37);
            this.open.TabIndex = 18;
            this.open.UseVisualStyleBackColor = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save.BackgroundImage")));
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(129, 6);
            this.save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(51, 37);
            this.save.TabIndex = 16;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // saveAs
            // 
            this.saveAs.BackColor = System.Drawing.Color.Transparent;
            this.saveAs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveAs.BackgroundImage")));
            this.saveAs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveAs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveAs.FlatAppearance.BorderSize = 0;
            this.saveAs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveAs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAs.Location = new System.Drawing.Point(185, 6);
            this.saveAs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(51, 37);
            this.saveAs.TabIndex = 17;
            this.saveAs.UseVisualStyleBackColor = false;
            this.saveAs.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // import
            // 
            this.import.BackColor = System.Drawing.Color.Transparent;
            this.import.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("import.BackgroundImage")));
            this.import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.import.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.import.FlatAppearance.BorderSize = 0;
            this.import.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.import.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.import.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.import.Location = new System.Drawing.Point(73, 6);
            this.import.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(51, 37);
            this.import.TabIndex = 2;
            this.import.UseVisualStyleBackColor = false;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // menuShow
            // 
            this.menuShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuShow.BackgroundImage")));
            this.menuShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuShow.FlatAppearance.BorderSize = 0;
            this.menuShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuShow.Location = new System.Drawing.Point(9, 6);
            this.menuShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuShow.Name = "menuShow";
            this.menuShow.Size = new System.Drawing.Size(52, 34);
            this.menuShow.TabIndex = 1;
            this.menuShow.UseVisualStyleBackColor = true;
            this.menuShow.Click += new System.EventHandler(this.menuShow_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.sizingPanel);
            this.mainPanel.Controls.Add(this.changeablePanel);
            this.mainPanel.Controls.Add(this.colorPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainPanel.Location = new System.Drawing.Point(1191, 73);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(177, 697);
            this.mainPanel.TabIndex = 2;
            // 
            // sizingPanel
            // 
            this.sizingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sizingPanel.Controls.Add(this.sizeLbl);
            this.sizingPanel.Controls.Add(this.sizeBar);
            this.sizingPanel.Location = new System.Drawing.Point(-1, 375);
            this.sizingPanel.Margin = new System.Windows.Forms.Padding(4);
            this.sizingPanel.Name = "sizingPanel";
            this.sizingPanel.Size = new System.Drawing.Size(175, 102);
            this.sizingPanel.TabIndex = 2;
            // 
            // sizeLbl
            // 
            this.sizeLbl.AutoSize = true;
            this.sizeLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sizeLbl.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLbl.Location = new System.Drawing.Point(0, 0);
            this.sizeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sizeLbl.Name = "sizeLbl";
            this.sizeLbl.Size = new System.Drawing.Size(141, 18);
            this.sizeLbl.TabIndex = 1;
            this.sizeLbl.Text = "Size of Brush/Eraser";
            // 
            // sizeBar
            // 
            this.sizeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sizeBar.Location = new System.Drawing.Point(4, 27);
            this.sizeBar.Margin = new System.Windows.Forms.Padding(4);
            this.sizeBar.Maximum = 20;
            this.sizeBar.Name = "sizeBar";
            this.sizeBar.Size = new System.Drawing.Size(165, 56);
            this.sizeBar.TabIndex = 0;
            this.sizeBar.Scroll += new System.EventHandler(this.sizeBar_Scroll);
            // 
            // changeablePanel
            // 
            this.changeablePanel.AutoSize = true;
            this.changeablePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changeablePanel.Controls.Add(this.shapesOption);
            this.changeablePanel.Location = new System.Drawing.Point(0, 148);
            this.changeablePanel.Margin = new System.Windows.Forms.Padding(4);
            this.changeablePanel.Name = "changeablePanel";
            this.changeablePanel.Size = new System.Drawing.Size(186, 228);
            this.changeablePanel.TabIndex = 1;
            // 
            // shapesOption
            // 
            this.shapesOption.BackColor = System.Drawing.Color.Transparent;
            this.shapesOption.Controls.Add(this.circleButton);
            this.shapesOption.Controls.Add(this.squareButton);
            this.shapesOption.Controls.Add(this.rectangleButton);
            this.shapesOption.Location = new System.Drawing.Point(7, 1);
            this.shapesOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shapesOption.Name = "shapesOption";
            this.shapesOption.Size = new System.Drawing.Size(157, 223);
            this.shapesOption.TabIndex = 0;
            this.shapesOption.Visible = false;
            // 
            // circleButton
            // 
            this.circleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circleButton.BackgroundImage")));
            this.circleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.circleButton.FlatAppearance.BorderSize = 0;
            this.circleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton.Location = new System.Drawing.Point(65, 117);
            this.circleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(68, 66);
            this.circleButton.TabIndex = 3;
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // squareButton
            // 
            this.squareButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("squareButton.BackgroundImage")));
            this.squareButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.squareButton.FlatAppearance.BorderSize = 0;
            this.squareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.squareButton.Location = new System.Drawing.Point(0, 3);
            this.squareButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(80, 72);
            this.squareButton.TabIndex = 2;
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // rectangleButton
            // 
            this.rectangleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rectangleButton.BackgroundImage")));
            this.rectangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectangleButton.FlatAppearance.BorderSize = 0;
            this.rectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangleButton.Location = new System.Drawing.Point(86, 11);
            this.rectangleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(64, 57);
            this.rectangleButton.TabIndex = 0;
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel.Controls.Add(this.colorPicker);
            this.colorPanel.Location = new System.Drawing.Point(0, 0);
            this.colorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(175, 147);
            this.colorPanel.TabIndex = 0;
            // 
            // colorPicker
            // 
            this.colorPicker.BackColor = System.Drawing.Color.Transparent;
            this.colorPicker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("colorPicker.BackgroundImage")));
            this.colorPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.colorPicker.InitialImage = ((System.Drawing.Image)(resources.GetObject("colorPicker.InitialImage")));
            this.colorPicker.Location = new System.Drawing.Point(0, -1);
            this.colorPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(172, 149);
            this.colorPicker.TabIndex = 1;
            this.colorPicker.TabStop = false;
            this.colorPicker.Click += new System.EventHandler(this.colorPicker_Click);
            // 
            // ZoomOutBtn
            // 
            this.ZoomOutBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ZoomOutBtn.BackgroundImage")));
            this.ZoomOutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ZoomOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ZoomOutBtn.FlatAppearance.BorderSize = 0;
            this.ZoomOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZoomOutBtn.Location = new System.Drawing.Point(0, 520);
            this.ZoomOutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ZoomOutBtn.Name = "ZoomOutBtn";
            this.ZoomOutBtn.Size = new System.Drawing.Size(43, 38);
            this.ZoomOutBtn.TabIndex = 10;
            this.ZoomOutBtn.UseVisualStyleBackColor = true;
            this.ZoomOutBtn.Click += new System.EventHandler(this.ZoomOutBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ZoomOutBtn);
            this.panel1.Controls.Add(this.ZoomInBtn);
            this.panel1.Controls.Add(this.textButton);
            this.panel1.Controls.Add(this.shapesButton);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.gridButton);
            this.panel1.Controls.Add(this.eraserButton);
            this.panel1.Controls.Add(this.brushButton);
            this.panel1.Controls.Add(this.redoButton);
            this.panel1.Controls.Add(this.undoButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1149, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(42, 697);
            this.panel1.TabIndex = 3;
            // 
            // ZoomInBtn
            // 
            this.ZoomInBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ZoomInBtn.BackgroundImage")));
            this.ZoomInBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ZoomInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ZoomInBtn.FlatAppearance.BorderSize = 0;
            this.ZoomInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZoomInBtn.Location = new System.Drawing.Point(-1, 462);
            this.ZoomInBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ZoomInBtn.Name = "ZoomInBtn";
            this.ZoomInBtn.Size = new System.Drawing.Size(43, 38);
            this.ZoomInBtn.TabIndex = 9;
            this.ZoomInBtn.UseVisualStyleBackColor = true;
            this.ZoomInBtn.Click += new System.EventHandler(this.ZoomInBtn_Click);
            // 
            // textButton
            // 
            this.textButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textButton.BackgroundImage")));
            this.textButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.textButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textButton.FlatAppearance.BorderSize = 0;
            this.textButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textButton.Location = new System.Drawing.Point(0, 338);
            this.textButton.Margin = new System.Windows.Forms.Padding(4);
            this.textButton.Name = "textButton";
            this.textButton.Size = new System.Drawing.Size(41, 37);
            this.textButton.TabIndex = 7;
            this.textButton.UseVisualStyleBackColor = true;
            this.textButton.Click += new System.EventHandler(this.textButton_Click);
            // 
            // shapesButton
            // 
            this.shapesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shapesButton.BackgroundImage")));
            this.shapesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.shapesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shapesButton.FlatAppearance.BorderSize = 0;
            this.shapesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shapesButton.Location = new System.Drawing.Point(-1, 281);
            this.shapesButton.Margin = new System.Windows.Forms.Padding(4);
            this.shapesButton.Name = "shapesButton";
            this.shapesButton.Size = new System.Drawing.Size(43, 39);
            this.shapesButton.TabIndex = 6;
            this.shapesButton.UseVisualStyleBackColor = true;
            this.shapesButton.Click += new System.EventHandler(this.shapesButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearButton.BackgroundImage")));
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Location = new System.Drawing.Point(-2, 403);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(40, 37);
            this.clearButton.TabIndex = 5;
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // gridButton
            // 
            this.gridButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gridButton.BackgroundImage")));
            this.gridButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gridButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gridButton.FlatAppearance.BorderSize = 0;
            this.gridButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gridButton.Location = new System.Drawing.Point(-1, 236);
            this.gridButton.Margin = new System.Windows.Forms.Padding(4);
            this.gridButton.Name = "gridButton";
            this.gridButton.Size = new System.Drawing.Size(41, 37);
            this.gridButton.TabIndex = 4;
            this.gridButton.UseVisualStyleBackColor = true;
            this.gridButton.Click += new System.EventHandler(this.gridButton_Click_1);
            // 
            // eraserButton
            // 
            this.eraserButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eraserButton.BackgroundImage")));
            this.eraserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eraserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eraserButton.FlatAppearance.BorderSize = 0;
            this.eraserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraserButton.Location = new System.Drawing.Point(-1, 182);
            this.eraserButton.Margin = new System.Windows.Forms.Padding(4);
            this.eraserButton.Name = "eraserButton";
            this.eraserButton.Size = new System.Drawing.Size(41, 37);
            this.eraserButton.TabIndex = 3;
            this.eraserButton.UseVisualStyleBackColor = true;
            this.eraserButton.Click += new System.EventHandler(this.eraserButton_Click);
            // 
            // brushButton
            // 
            this.brushButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brushButton.BackgroundImage")));
            this.brushButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.brushButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brushButton.FlatAppearance.BorderSize = 0;
            this.brushButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brushButton.Location = new System.Drawing.Point(0, 121);
            this.brushButton.Margin = new System.Windows.Forms.Padding(4);
            this.brushButton.Name = "brushButton";
            this.brushButton.Size = new System.Drawing.Size(40, 37);
            this.brushButton.TabIndex = 2;
            this.brushButton.UseVisualStyleBackColor = true;
            this.brushButton.Click += new System.EventHandler(this.brushButton_Click);
            // 
            // redoButton
            // 
            this.redoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("redoButton.BackgroundImage")));
            this.redoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.redoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redoButton.FlatAppearance.BorderSize = 0;
            this.redoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redoButton.Location = new System.Drawing.Point(0, 62);
            this.redoButton.Margin = new System.Windows.Forms.Padding(4);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(40, 37);
            this.redoButton.TabIndex = 1;
            this.redoButton.UseVisualStyleBackColor = true;
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.AutoSize = true;
            this.undoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("undoButton.BackgroundImage")));
            this.undoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.undoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.undoButton.FlatAppearance.BorderSize = 0;
            this.undoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undoButton.Location = new System.Drawing.Point(0, 6);
            this.undoButton.Margin = new System.Windows.Forms.Padding(4);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(40, 37);
            this.undoButton.TabIndex = 0;
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // mainCanvas
            // 
            this.mainCanvas.BackColor = System.Drawing.Color.White;
            this.mainCanvas.Location = new System.Drawing.Point(0, 102);
            this.mainCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.mainCanvas.Name = "mainCanvas";
            this.mainCanvas.Size = new System.Drawing.Size(1081, 626);
            this.mainCanvas.TabIndex = 4;
            this.mainCanvas.TabStop = false;
            this.mainCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.mainCanvas_Paint);
            this.mainCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainCanvas_MouseDown);
            this.mainCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainCanvas_MouseMove);
            this.mainCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainCanvas_MouseUp);
            // 
            // verticalScroll
            // 
            this.verticalScroll.Dock = System.Windows.Forms.DockStyle.Right;
            this.verticalScroll.LargeChange = 15;
            this.verticalScroll.Location = new System.Drawing.Point(1127, 73);
            this.verticalScroll.Name = "verticalScroll";
            this.verticalScroll.Size = new System.Drawing.Size(22, 697);
            this.verticalScroll.TabIndex = 6;
            this.verticalScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.verticalScroll_Scroll);
            // 
            // menuSlide
            // 
            this.menuSlide.BackColor = System.Drawing.Color.Silver;
            this.menuSlide.Controls.Add(this.panel3);
            this.menuSlide.Controls.Add(this.panel6);
            this.menuSlide.Controls.Add(this.panel5);
            this.menuSlide.Controls.Add(this.panel4);
            this.menuSlide.Controls.Add(this.panel7);
            this.menuSlide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuSlide.Location = new System.Drawing.Point(0, 73);
            this.menuSlide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuSlide.MaximumSize = new System.Drawing.Size(200, 572);
            this.menuSlide.MinimumSize = new System.Drawing.Size(61, 572);
            this.menuSlide.Name = "menuSlide";
            this.menuSlide.Size = new System.Drawing.Size(200, 572);
            this.menuSlide.TabIndex = 15;
            this.menuSlide.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.menuButton);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            // 
            // menuButton
            // 
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(3, 28);
            this.menuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(59, 50);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.menuImport);
            this.panel6.Location = new System.Drawing.Point(3, 102);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 46);
            this.panel6.TabIndex = 10;
            // 
            // menuImport
            // 
            this.menuImport.BackColor = System.Drawing.Color.White;
            this.menuImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuImport.Location = new System.Drawing.Point(7, -2);
            this.menuImport.Margin = new System.Windows.Forms.Padding(0);
            this.menuImport.Name = "menuImport";
            this.menuImport.Size = new System.Drawing.Size(183, 46);
            this.menuImport.TabIndex = 0;
            this.menuImport.Text = "IMPORT";
            this.menuImport.UseVisualStyleBackColor = false;
            this.menuImport.Click += new System.EventHandler(this.menuImport_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.menuSave);
            this.panel5.Location = new System.Drawing.Point(3, 152);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 46);
            this.panel5.TabIndex = 10;
            // 
            // menuSave
            // 
            this.menuSave.BackColor = System.Drawing.Color.White;
            this.menuSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSave.Location = new System.Drawing.Point(7, 0);
            this.menuSave.Margin = new System.Windows.Forms.Padding(0);
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(183, 46);
            this.menuSave.TabIndex = 0;
            this.menuSave.Text = "SAVE";
            this.menuSave.UseVisualStyleBackColor = false;
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.menuExport);
            this.panel4.Location = new System.Drawing.Point(3, 202);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 46);
            this.panel4.TabIndex = 9;
            // 
            // menuExport
            // 
            this.menuExport.BackColor = System.Drawing.Color.White;
            this.menuExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuExport.Location = new System.Drawing.Point(7, 0);
            this.menuExport.Margin = new System.Windows.Forms.Padding(0);
            this.menuExport.Name = "menuExport";
            this.menuExport.Size = new System.Drawing.Size(183, 46);
            this.menuExport.TabIndex = 0;
            this.menuExport.Text = "SAVE AS";
            this.menuExport.UseVisualStyleBackColor = false;
            this.menuExport.Click += new System.EventHandler(this.menuExport_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.menuOpen);
            this.panel7.Location = new System.Drawing.Point(3, 252);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 46);
            this.panel7.TabIndex = 12;
            // 
            // menuOpen
            // 
            this.menuOpen.BackColor = System.Drawing.Color.White;
            this.menuOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuOpen.Location = new System.Drawing.Point(7, 0);
            this.menuOpen.Margin = new System.Windows.Forms.Padding(0);
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(183, 46);
            this.menuOpen.TabIndex = 0;
            this.menuOpen.Text = "OPEN";
            this.menuOpen.UseVisualStyleBackColor = false;
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.horizontalScroll);
            this.panel2.Controls.Add(this.mainCanvas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1368, 770);
            this.panel2.TabIndex = 16;
            // 
            // horizontalScroll
            // 
            this.horizontalScroll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.horizontalScroll.Location = new System.Drawing.Point(0, 748);
            this.horizontalScroll.Name = "horizontalScroll";
            this.horizontalScroll.Size = new System.Drawing.Size(1368, 22);
            this.horizontalScroll.TabIndex = 0;
            this.horizontalScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.horizontalScroll_Scroll_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1368, 770);
            this.Controls.Add(this.menuSlide);
            this.Controls.Add(this.verticalScroll);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.header);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.sizingPanel.ResumeLayout(false);
            this.sizingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBar)).EndInit();
            this.changeablePanel.ResumeLayout(false);
            this.shapesOption.ResumeLayout(false);
            this.colorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainCanvas)).EndInit();
            this.menuSlide.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox mainCanvas;
        private System.Windows.Forms.VScrollBar verticalScroll;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Button textButton;
        private System.Windows.Forms.Button shapesButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button gridButton;
        private System.Windows.Forms.Button eraserButton;
        private System.Windows.Forms.Button brushButton;
        private System.Windows.Forms.Button redoButton;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Panel changeablePanel;
        private System.Windows.Forms.Panel sizingPanel;
        private System.Windows.Forms.Label sizeLbl;
        private System.Windows.Forms.TrackBar sizeBar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox colorPicker;
        private System.Windows.Forms.Button menuShow;
        private System.Windows.Forms.FlowLayoutPanel menuSlide;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button menuImport;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button menuSave;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button menuExport;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button menuOpen;
        private System.Windows.Forms.Panel shapesOption;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button ZoomInBtn;
        private System.Windows.Forms.Button ZoomOutBtn;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button saveAs;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.HScrollBar horizontalScroll;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.LinkLabel;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PaintJob
{

    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            SetSize();
            SetSizeEraser();
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.WindowState = FormWindowState.Maximized;
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            mainCanvas.Image = bm;
            imageStates.Add(bm); // Initial state
            currentState = 0;
            this.Resize += Form1_Resize;
        }

        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black,2);
        Pen eraser = new Pen(Color.White,2);
        int index;
        bool fillShape = false;
        Brush brush = Brushes.Transparent;
        List<Bitmap> imageStates = new List<Bitmap>();        // List to store image states
        int currentState = -1;                                // Index of current state
        Rectangle rectangle = Rectangle.Empty;                // Rectangle variable to store the drawn rectangle
        List<Rectangle> rectangles = new List<Rectangle>();   // List to store rectangles
        private Rectangle square;                              // Define a rectangle variable to store the square
        List<Rectangle> squares = new List<Rectangle>();      // List to store squares
        private Rectangle currentCircle;                       // Variable to store the current circle being drawn
        List <Rectangle> circles = new List<Rectangle>();
        private float zoomFactor = 1.0f;

        private Panel textBoxContainer;
        private bool isDragging;
        private Point mouseOffset;
        private const int ResizeHandleSize = 6;
        private bool isResizing;
        private Point resizeStart;
        private Size resizeStartSize;
        private Color new_color;
        private System.Windows.Forms.TextBox textBox; // Declare the textBox variable at the class level
        private Point startPoint; // Starting point of the triangle
        private Point currentPoint; // Current mouse position

      
        int clickCount = 0; 

        private Bitmap ResizeImage(Image image, int width, int height)
        {
            // Create a new Bitmap with the desired size
            Bitmap resizedImage = new Bitmap(width, height);

            // Create a Graphics object from the resized image
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                // Set the interpolation mode to high quality for better resizing
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                // Draw the original image onto the resized image with the new size
                g.DrawImage(image, 0, 0, width, height);
            }

            return resizedImage;
        }
        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            bm = new Bitmap (rectangle.Width, rectangle.Height);
            g = Graphics.FromImage (bm);

            mainCanvas.BackColor = Color.LightGray; // Set the background color of the main canvas

            p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            p.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // Add the code snippet here
            int canvasHeight = mainCanvas.Height;
            int visibleHeight = Height / mainCanvas.Height; // Adjust if there are other controls above the canvas

           
            verticalScroll.Maximum = Math.Max(0, canvasHeight - visibleHeight);
            verticalScroll.Minimum = Math.Min(-500, canvasHeight + visibleHeight);
            verticalScroll.LargeChange = 250;
            verticalScroll.SmallChange = 0; // Adjust the scrolling speed

            int canvasWidth = mainCanvas.Width;
            int visibleWidth = Width / mainCanvas.Width;

            horizontalScroll.Maximum = Math.Max(0, canvasWidth - visibleWidth);
            horizontalScroll.Minimum = Math.Min(-700,  canvasWidth- visibleWidth);
            horizontalScroll.LargeChange = 250;
            horizontalScroll.SmallChange = 0;
        }

        private void SetSizeEraser()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            bm = new Bitmap(rectangle.Width, rectangle.Height);
            g = Graphics.FromImage(bm);

            eraser.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            eraser.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void mainCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            if (index == 3) // Rectangle
            {
                rectangle.Location = py;
            }
            if (index == 5) // Circle
            {
                currentCircle = new Rectangle(py.X, py.Y, 0, 0);
            }
            
        }
        private void mainCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
     

            if (index == 3) // Rectangle
            {
                rectangles.Add(rectangle);
                rectangle = Rectangle.Empty;
            }
            if (index == 4) // Square
            {
                squares.Add(square);
                square = Rectangle.Empty;
            }
            else if (index == 5) // Circle
            {
                currentCircle.Width = e.Location.X - currentCircle.X;
                currentCircle.Height = e.Location.Y - currentCircle.Y;
                circles.Add(currentCircle);
                currentCircle = Rectangle.Empty;
            }
           

            StoreCurrentState();
        }

        private void mainCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
               if(index == 1) // Mag Paint Function
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;

                }
               else if (index == 2) // Eraser 
                {
                    px = e.Location;
                    g.DrawLine(eraser, px, py);
                    py = px;
                }
                else if (index == 3) // Rectangle
                {
                    px = e.Location;
                    int width = px.X - py.X;
                    int height = px.Y - py.Y;
                    rectangle.Size = new Size(width, height);

                }
                else if (index == 4) // Square
                {
                    px = e.Location;
                    int width = px.X - py.X;
                    int height = px.Y - py.Y;
                    int size = Math.Min(width, height); // Square size based on the smaller dimension
                    int x = px.X < py.X ? py.X - size : py.X; // Adjust X coordinate based on the smaller dimension
                    int y = px.Y < py.Y ? py.Y - size : py.Y; // Adjust Y coordinate based on the smaller dimension
                    square = new Rectangle(x, y, size, size);
                    mainCanvas.Refresh();
                }
                else if (index == 5) // Circle
                {
                    px = e.Location;
                    mainCanvas.Refresh();
                }
               
            }
            mainCanvas.Refresh();
       
        }
        private void mainCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (showGrid)
            {
                int gridSize = 45; // Adjust the size of the grid cells as needed
                Pen gridPen = new Pen(Color.SkyBlue);
                Opacity = 50;
                

                // Draw vertical grid lines
                for (int x = gridSize; x < mainCanvas.Width; x += gridSize)
                {
                    e.Graphics.DrawLine(gridPen, x, 0, x, mainCanvas.Height);
                }

                // Draw horizontal grid lines
                for (int y = gridSize; y < mainCanvas.Height; y += gridSize)
                {
                    e.Graphics.DrawLine(gridPen, 0, y, mainCanvas.Width, y);
                }
            }
            if (index == 3 && paint)
            {
                int width = px.X - py.X;
                int height = px.Y - py.Y;
                rectangle = new Rectangle(py.X, py.Y, width, height);
            }
            if (rectangle != null)
            {
                //e.Graphics.FillRectangle(brush, rectangle);
                e.Graphics.DrawRectangle(p, rectangle);
                foreach (Rectangle rect in rectangles)
                {
                    //e.Graphics.FillRectangle(brush, rect);
                    e.Graphics.DrawRectangle(p, rect);
                }
            }
            
            if (square != null)
            {
                //e.Graphics.FillRectangle(brush, square);
                e.Graphics.DrawRectangle(p, square);
                foreach (Rectangle square in squares)
                {
                    //e.Graphics.FillRectangle(brush, square);
                    e.Graphics.DrawRectangle(p, square);
                }
            }
            
            if (currentCircle != null)
            {
                //e.Graphics.FillEllipse(brush, currentCircle);
                e.Graphics.DrawEllipse(p, currentCircle);
                foreach (Rectangle circle in circles)
                {
                    //e.Graphics.FillEllipse(brush, circle);
                    e.Graphics.DrawEllipse(p, circle);
                }
            }
           

        }

        private void StoreCurrentState()
        {
            // Create a copy of the current bitmap and add it to the states list
            Bitmap currentState = (Bitmap)bm.Clone();
            imageStates.Add(currentState);

            // Update the current state index
            this.currentState = imageStates.Count - 1;

            // Enable/disable undo and redo buttons
            undoButton.Enabled = true;
            redoButton.Enabled = false;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to close the application? " , "Exit Messages", MessageBoxButtons.YesNo ,MessageBoxIcon.Question ) == DialogResult.Yes)
                Application.Exit();

        }
        private void sizeBar_Scroll(object sender, EventArgs e)
        {
            p.Width = sizeBar.Value;
            eraser.Width = sizeBar.Value;
        }
        private void brushButton_Click(object sender, EventArgs e)
        {
           
            clickCount += 1;
            if (clickCount == 1)
            {
                // Clear the main canvas
                mainCanvas.Image = null;
                bm = new Bitmap(mainCanvas.Width, mainCanvas.Height);
                g = Graphics.FromImage(bm);
                g.Clear(Color.White);
                mainCanvas.Image = bm;

                // Clear the image states and reset the current state
                imageStates.Clear();
                imageStates.Add(bm);
                currentState = 0;
                // Clear the squares and rectangles lists
                squares.Clear();
                rectangles.Clear();
                circles.Clear();



                // Disable the undo and redo buttons
                undoButton.Enabled = false;
                redoButton.Enabled = false;
            }
            else
            {
                index = 1;
            }
        }
        private void undoButton_Click(object sender, EventArgs e)
        {
            if (currentState > 0)
            {
                currentState--;
                bm = (Bitmap)imageStates[currentState].Clone();
                g = Graphics.FromImage(bm);
                mainCanvas.Image = bm;

                undoButton.Enabled = (currentState > 0);
                redoButton.Enabled = true;

            }
        }
        private void redoButton_Click(object sender, EventArgs e)
        {
            if (currentState < imageStates.Count - 1)
            {
                currentState++;
                bm = (Bitmap)imageStates[currentState].Clone();
                g = Graphics.FromImage(bm);
                mainCanvas.Image = bm;

                undoButton.Enabled = true;
                redoButton.Enabled = (currentState < imageStates.Count - 1);

            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Z))
            {
                Undo();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.Y))
            {
                Redo();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void Undo()
        {
            if (currentState > 0)
            {
                currentState--;
                bm = (Bitmap)imageStates[currentState].Clone();
                g = Graphics.FromImage(bm);
                mainCanvas.Image = bm;

                undoButton.Enabled = (currentState > 0);
                redoButton.Enabled = true;
            }
        }
        private void Redo()
        {
            if (currentState < imageStates.Count - 1)
            {
                currentState++;
                bm = (Bitmap)imageStates[currentState].Clone();
                g = Graphics.FromImage(bm);
                mainCanvas.Image = bm;

                undoButton.Enabled = true;
                redoButton.Enabled = (currentState < imageStates.Count - 1);
            }
        }
        private void colorPicker_Click(object sender, EventArgs e) // Pili ka ng kulay beh 
        {
            ColorDialog colorDialog = new ColorDialog();
            // Show the color dialog and get the selected color
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;

                // Do something with the selected color (e.g., set it as the background color of a control)
                p.Color = selectedColor;
            }
        }

        private void menuShow_Click(object sender, EventArgs e)  // To show the menu panel 
        {
            if (menuSlide.Visible != true)
            {
                menuSlide.Show();
            }
            else
            { menuSlide.Hide(); }
        }

        private void menuImport_Click(object sender, EventArgs e) // Import any image file type 
        {
            import:
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    // Process the selected file
                    // Load the image from the selected file
                    Image selectedImage = Image.FromFile(filePath);

                    // Assign the image to the main canvas PictureBox
                    mainCanvas.Image = selectedImage;
                }
            }
            catch
            {
                MessageBox.Show("Please import jpeg, png , and bitmap files only!!! ", "Unsupported File Selected");
                goto import;
            }
        }
        private void menuSave_Click(object sender, EventArgs e) // Save the work in the canvas but only in bitmap format
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Bitmap Image|*.bmp";
            saveFileDialog.Title = "Save Image";
            saveFileDialog.InitialDirectory = @"D:\FP\PaintJob2\Art Works"; // Save the image in specific folder inside the program

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                mainCanvas.Image.Save(filePath, ImageFormat.Bmp);
            }
        }

        private void menuExport_Click(object sender, EventArgs e) // Save as or Export the image in any format 
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg;*.jpeg|BMP Image|*.bmp";
            saveFileDialog.Title = "Save Image";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                string fileExtension = Path.GetExtension(filePath).ToLower();

                ImageFormat imageFormat = ImageFormat.Png;
                if (fileExtension == ".jpg" || fileExtension == ".jpeg")
                    imageFormat = ImageFormat.Jpeg;
                else if (fileExtension == ".bmp")
                    imageFormat = ImageFormat.Bmp;

                Bitmap bitmap = new Bitmap(mainCanvas.Width, mainCanvas.Height);
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    graphics.DrawImage(mainCanvas.Image, new Rectangle(0, 0, mainCanvas.Width, mainCanvas.Height));
                }
                bitmap.Save(filePath, imageFormat);
            }
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {  open:
            try
            {

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = @"D:\FP\PaintJob2\Art Works"; ; // Set the initial directory to the desired folder

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    Image selectedImage = Image.FromFile(filePath);

                    // Assign the image to the main canvas PictureBox
                    mainCanvas.Image = selectedImage;
                }
            }
            catch
            {
                MessageBox.Show("Please select jpeg, png , and bitmap files only!!!" , "Unsupported File Selected");
                goto open;
            }
        }
        private void import_Click(object sender, EventArgs e)
        {
        import:
            try
            {   OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    Image selectedImage = Image.FromFile(filePath);   
                    mainCanvas.Image = selectedImage;
                }
            }
            catch
            {    MessageBox.Show("Please import jpeg, png , and bitmap files only!!! " , "Unsupported File Selected");
                 goto import;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Bitmap Image|*.bmp";
            saveFileDialog.Title = "Save Image";
            saveFileDialog.InitialDirectory = @"D:\FP\PaintJob2\Art Works"; // Save the image in specific folder inside the program

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                mainCanvas.Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Bmp);
            }
        }

        private void saveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg;*.jpeg|BMP Image|*.bmp"; // Choices in saving 
            saveFileDialog.Title = "Save Image";


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                Image imageToSave = mainCanvas.Image;

                if (imageToSave != null)
                {
                    // Choices in imageFormat 
                    string fileExtension = Path.GetExtension(filePath);
                    if (fileExtension.Equals(".jpeg", StringComparison.OrdinalIgnoreCase))
                    {
                        imageToSave.Save(filePath, ImageFormat.Jpeg);
                    }
                    else if (fileExtension.Equals(".jpg", StringComparison.OrdinalIgnoreCase))
                    {
                        imageToSave.Save(filePath, ImageFormat.Jpeg);
                    }
                    else if (fileExtension.Equals(".bmp", StringComparison.OrdinalIgnoreCase))
                    {
                        imageToSave.Save(filePath, ImageFormat.Bmp);
                    }
                    else if (fileExtension.Equals(".png", StringComparison.OrdinalIgnoreCase))
                    {
                        imageToSave.Save(filePath, ImageFormat.Png);
                    }
                }
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
        open:
            try // When the user try to open different type of file 
            {OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = @"D:\FP\PaintJob2\Art Works"; ; // Set the initial directory to the desired folder

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    Image selectedImage = Image.FromFile(filePath);
                    mainCanvas.Image = selectedImage;
                }
            }
            catch // Go back in choosing again 
            {
                MessageBox.Show("Please select jpeg, png , and bitmap files only!!!", "Unsupported File Selected");
                goto open;
            }
        }

        private bool showGrid = false; 

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the main canvas
            mainCanvas.Image = null;
            bm = new Bitmap(mainCanvas.Width, mainCanvas.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            mainCanvas.Image = bm;

            // Clear the image states and reset the current state
            imageStates.Clear();
            imageStates.Add(bm);
            currentState = 0;
            // Clear the squares and rectangles lists
            squares.Clear();
            rectangles.Clear();
            circles.Clear();



            // Disable the undo and redo buttons
            undoButton.Enabled = false;
            redoButton.Enabled = false;
        }

        private void shapesButton_Click(object sender, EventArgs e)
        {
            if (shapesOption.Visible)
            {
                shapesOption.Hide();
            }
            else
            { shapesOption.Show(); }    
        }
        private void eraserButton_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            index = 5; 
        }

       

        private void ZoomInBtn_Click(object sender, EventArgs e)
        {   
            zoomFactor += 0.1f;                  // Increase the zoom factor
            ApplyZoom();
        }

        private void ZoomOutBtn_Click(object sender, EventArgs e)
        {
            zoomFactor -=  0.1f;    // Decrease the zoom factor
            if (zoomFactor < 0.1f)              // Limit the minimum zoom factor
                zoomFactor = 0.1f;
            ApplyZoom();
        }
        private void ApplyZoom()
        {
            try {            // When the user is clicking too fast the system errors 
                if (mainCanvas.Image != null)
                {
                    int newWidth = (int)(mainCanvas.Image.Width * zoomFactor);  // Adjust the size
                    int newHeight = (int)(mainCanvas.Image.Height * zoomFactor);
                    Bitmap zoomedBitmap = new Bitmap(newWidth, newHeight);   // Update size 
                    Graphics graphics = Graphics.FromImage(zoomedBitmap);
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.DrawImage(mainCanvas.Image, new Rectangle(0, 0, newWidth, newHeight));
                    mainCanvas.Image = zoomedBitmap; // Implementing 
                    graphics.Dispose();
                    bm = zoomedBitmap;
                    g = Graphics.FromImage(bm);
                    mainCanvas.Refresh();
                }
            }
            catch // Back to the form before zooming in or out 
            {
                MessageBox.Show("Invalid Action!");
                Undo();
            }
        }

        private void Form1_Resize(object sender, EventArgs e) // Resizing the controls in full screen 
        {
            int buttonWidth = (int)(mainCanvas.Width * 0.03);  // 20% of the canvas width
            int buttonHeight = (int)(mainCanvas.Height * 0.04);  // 10% of the canvas height
            int buttonSpacing = 10;  // Set the desired vertical spacing between buttons
                                     // Optionally, adjust the position of buttons and panels
            int buttonLeft = (mainCanvas.Width - buttonWidth) / 2;
            int buttonTop = (mainCanvas.Height - (buttonHeight * 2) - (buttonSpacing * 3)) / 2; // Adjusted buttonTop calculation

            // Get the size of the screen
            Screen screen = Screen.FromControl(this);
            int screenWidth = screen.Bounds.Width;
            int screenHeight = screen.Bounds.Height;

            // Adjust the size of the canvas based on the screen size
            int canvasWidth = (int)(screenWidth * 0.8);  // 80% of the screen width
            int canvasHeight = (int)(screenHeight * 0.8);  // 80% of the screen height

            // Set the size of the canvas
            mainCanvas.Width = canvasWidth;
            mainCanvas.Height = canvasHeight;

            // Adjust the size of the bitmap
            bm = new Bitmap(mainCanvas.Width, mainCanvas.Height);

            // Optionally, center the canvas on the form
            int canvasLeft = (this.ClientSize.Width - mainCanvas.Width) / 4;
            int canvasTop = (this.ClientSize.Height + mainCanvas.Height) / 14;
            mainCanvas.Location = new Point(canvasLeft, canvasTop);


            //// Set the size of buttons
            undoButton.Width = buttonWidth;
            undoButton.Height = buttonHeight;
           

            redoButton.Width = buttonWidth;
            redoButton.Height = buttonHeight;
           

            brushButton.Width = buttonWidth;
            brushButton.Height = buttonHeight;

            gridButton.Width = buttonWidth;
            gridButton.Height = buttonHeight;

            eraserButton.Width = buttonWidth;
            eraserButton.Height = buttonHeight;

            shapesButton.Width = buttonWidth;
            shapesButton.Height = buttonHeight;

            textButton.Width = buttonWidth;
            textButton.Height = buttonHeight;

           

            clearButton.Width = buttonWidth;
            clearButton.Height = buttonHeight;

            ZoomInBtn.Width = buttonWidth;
            ZoomInBtn.Height = buttonHeight;

            ZoomOutBtn.Width = buttonWidth;
            ZoomOutBtn.Height = buttonHeight;

            //// Set the size of panels
            panel1.Width = (int) (canvasWidth * 0.04);
            panel1.Height = (int)(canvasHeight * 0.04);  // 15% of the canvas height
            header.Width = (int)(canvasWidth * 0.05);
            header.Height = (int)(canvasHeight * 0.05);
            menuPanel.Width = (int)(canvasWidth * 0.05);
            menuPanel.Height = (int)(canvasHeight * 0.05);

            int panelTop = mainCanvas.Bottom + 10;  // Place panels below the canvas
            panel1.Width = (int)(canvasWidth * 0.03);
        }

        private void verticalScroll_Scroll(object sender, ScrollEventArgs e) // Vertical scroll up and down 
        {
            mainCanvas.Location = new Point(mainCanvas.Location.X, - verticalScroll.Value);
        }

        private void textButton_Click(object sender, EventArgs e) // Add the txt box
        {
            AddResizableTextBox();
        }
        private void InitializeTextBoxContainer() // Panel that contains txt box because pic box can't store txt box
        {
            textBoxContainer = new Panel();
            textBoxContainer.BackColor = Color.Transparent;
            textBoxContainer.Dock = DockStyle.Fill;
            textBoxContainer.AutoScroll = true;
            this.Controls.Add(textBoxContainer);
        }

        private void AddResizableTextBox() // For adding many textbox as you like 
        {
            TextBox textBox = new TextBox();
            textBox.Multiline = true;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Font = new Font(FontFamily.GenericSansSerif, 12);
            textBox.MouseDown += TextBox_MouseDown;
            textBox.MouseUp += TextBox_MouseUp;
            textBox.MouseMove += TextBox_MouseMove;
            textBox.Size = new Size(textBox.Width = 200, textBox.Height = 50); 
            mainCanvas.Controls.Add(textBox);
        }

        private void TextBox_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseOffset = new Point(e.X, e.Y);
                isResizing = true;
                resizeStart = e.Location;
                resizeStartSize = textBox.Size;
                textBox.Capture = true;
            }
        }

        private void TextBox_MouseUp(object sender, MouseEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (e.Button == MouseButtons.Left)
            {
                isResizing = false;
                isDragging = false;
                textBox.Capture = false;
            }
        }
        private void TextBox_MouseMove(object sender, MouseEventArgs e) 
        {
            TextBox textBox = (TextBox)sender;
            if (isDragging && e.Button == MouseButtons.Left) // To drag the textbox anywhere the canvas 
            {
                Point mousePos = mainCanvas.PointToClient(Control.MousePosition);
                textBox.Left = mousePos.X - mouseOffset.X;
                textBox.Top = mousePos.Y - mouseOffset.Y;
            }
            if (isResizing && e.Button == MouseButtons.Left) // To resize the textbox but still not working hihi
            {
                int deltaX = e.X - resizeStart.X;
                int deltaY = e.Y - resizeStart.Y;
                int newWidth = resizeStartSize.Width + deltaX;
                int newHeight = resizeStartSize.Height + deltaY;
                textBox.Size = new Size(newWidth, newHeight);
            }
        }
        private void TextBox_Resize(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int handleSize = ResizeHandleSize;
            int textBoxWidth = textBox.ClientSize.Width;
            int textBoxHeight = textBox.ClientSize.Height;

            // Set the position and size of the resizing handle
            textBox.Controls[0].SetBounds(textBoxWidth - handleSize, textBoxHeight - handleSize, handleSize, handleSize);
        }
        private void mainCanvas_Resize(object sender, EventArgs e)
        {
            foreach (Control control in mainCanvas.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Height = Math.Max(textBox.Height, textBox.Font.Height + 6);
                    TextBox_Resize(textBox, EventArgs.Empty);
                }
            }
        }
        private void mainCanvas_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control is TextBox textBox)
            {
                // Rezing the Controls 
                Panel resizeHandle = new Panel();
                resizeHandle.BackColor = Color.Black;
                resizeHandle.Cursor = Cursors.SizeNWSE;
                resizeHandle.MouseDown += TextBox_MouseDown;
                resizeHandle.MouseUp += TextBox_MouseUp;
                resizeHandle.MouseMove += TextBox_MouseMove;
                textBox.Controls.Add(resizeHandle);
                TextBox_Resize(textBox, EventArgs.Empty);
            }
        }
        private void horizontalScroll_Scroll_1(object sender, ScrollEventArgs e) // Horizontal Scroll 
        {
            mainCanvas.Location = new Point(-horizontalScroll.Value, mainCanvas.Location.Y);
        }

      

        

        private void gridButton_Click_1(object sender, EventArgs e)
        {
            showGrid = !showGrid; // Visibilty 
            // Refresh the canvas to redraw the grid
            mainCanvas.Refresh();
        }
    }
}
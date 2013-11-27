using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace Imageviewer
{
    public partial class Form1 : Form
     
{
    [DllImport("Shell32.dll")]
    public extern static int ExtractIconEx(string libName, int iconIndex, IntPtr[] largeIcon, IntPtr[] smallIcon, int nIcons);
    IntPtr[] LargeIcons;

    int selectedIndex = 0;
    Image imgIcon;
    string filename = "";
        
        public Form1()
            {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("Property", Convert.ToInt32(listView1.Width * 50 / 100));
            listView1.Columns.Add("Value", Convert.ToInt32(listView1.Width * 45 / 100));
            listView1.GridLines = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "JPG (*.jpg)|*.jpg| Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPEG (*.jpeg)|*.jpeg|PNG (*.png)|*.png|TIFF (*.tif)|*.tif|All Files (*.*)|*.*";
            fileDialog.ShowDialog(this);

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            imageFile = fileDialog.FileName;
            if (imageFile == string.Empty) return;
            pictureBox2.Image = Image.FromFile(imageFile);
            bitmapImage = new Bitmap(imageFile);
            fetchImageProperties();
        }

        public static string GetSizeReadable(long i)
        {
            string sign = (i < 0 ? "-" : "");
            double readable = (i < 0 ? -i : i);
            string suffix;
            if (i >= 0x1000000000000000) // Exabyte
            {
                suffix = "EB";
                readable = (double)(i >> 50);
            }
            else if (i >= 0x4000000000000) // Petabyte
            {
                suffix = "PB";
                readable = (double)(i >> 40);
            }
            else if (i >= 0x10000000000) // Terabyte
            {
                suffix = "TB";
                readable = (double)(i >> 30);
            }
            else if (i >= 0x40000000) // Gigabyte
            {
                suffix = "GB";
                readable = (double)(i >> 20);
            }
            else if (i >= 0x100000) // Megabyte
            {
                suffix = "MB";
                readable = (double)(i >> 10);
            }
            else if (i >= 0x400) // Kilobyte
            {
                suffix = "KB";
                readable = (double)i;
            }
            else
            {
                return i.ToString(sign + "0 B"); // Byte
            }
            readable = readable / 1024;

            return sign + readable.ToString("0.### ") + suffix;
        }

        private void fetchImageProperties()
        {
            listView1.Items.Clear();
            if (bitmapImage != null)
            {
                listView1.Items.Add(new ListViewItem(new string[] { "Name", System.IO.Path.GetFileNameWithoutExtension(imageFile) }));
                listView1.Items.Add(new ListViewItem(new string[] { "Type", System.IO.Path.GetExtension(imageFile) }));
                listView1.Items.Add(new ListViewItem(new string[] { "Size", new System.IO.FileInfo(imageFile).Length.ToString() + " Bytes" }));
                listView1.Items.Add(new ListViewItem(new string[] { "Width", bitmapImage.Width.ToString() + " Pixels" }));
                listView1.Items.Add(new ListViewItem(new string[] { "Height", bitmapImage.Height.ToString() + " Pixels" }));
                listView1.Items.Add(new ListViewItem(new string[] { "Vertical Resolution", bitmapImage.VerticalResolution.ToString() + " Pixels/Inch" }));
                listView1.Items.Add(new ListViewItem(new string[] { "Horizontal Resolution", bitmapImage.HorizontalResolution.ToString() + " Pixels/Inch" }));
                listView1.Items.Add(new ListViewItem(new string[] { "Pixel Format", bitmapImage.PixelFormat.ToString() }));
                listView1.Items.Add(new ListViewItem(new string[] { "Palette Flags", bitmapImage.Palette.Flags.ToString() }));
            }
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "JPG (*.jpg)|*.jpg| Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPEG (*.jpeg)|*.jpeg|PNG (*.png)|*.png|TIFF (*.tif)|*.tif|All Files (*.*)|*.*";
            fileDialog.ShowDialog(this);

            imageFile = fileDialog.FileName;
            if (imageFile == string.Empty) return;
            pictureBox2.Image = Image.FromFile(imageFile);
            bitmapImage = new Bitmap(imageFile);
            fetchImageProperties();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Splash screen

            //this.Hide();
            //Splash frmSplash = new Splash();
            //frmSplash.Show();
            //frmSplash.Update();
            //Thread.Sleep(2000);
            //frmSplash.Close();
            //this.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog(); // Create an instance of the save file dialog
            sfd.Filter = "Gif | *.gif|Jpeg | *.jpg|Png |*.png"; // Filter property used for the "save as type"
            sfd.ShowDialog(); // Show the dialog
            filename = sfd.FileName; // Get the filename entered by user


            int filterIndex = sfd.FilterIndex; // Get the index of the selected "save as type". 
            try
            {
                // If index is 1, save the file as a gif image
                if (filterIndex == 1)
                {
                    imgIcon.Save(filename, ImageFormat.Gif);
                }

                // If index is 2, save the file as a jpeg image
                if (filterIndex == 2)
                {
                    imgIcon.Save(filename, ImageFormat.Jpeg);
                }

                // If the index is 3, save the file as a png image
                if (filterIndex == 3)
                {
                    imgIcon.Save(filename, ImageFormat.Png);
                }

                if (filterIndex == 4)
                {
                    imgIcon.Save(filename, ImageFormat.Bmp);
                }

                if (filterIndex == 5)
                {
                    imgIcon.Save(filename, ImageFormat.Tiff);
                }
                //You may include other image formats such as Bmp and Tiff here.
            }
            catch (Exception er)
            {
                Console.Write(er.Message);
            }
        }
        public void ExtractIcon()
        {
            try
            {
                // Get total number of icons in the selected file.
                int iconCount = ExtractIconEx(filename, 0, null, null, 0);

                // If the iconCount variable is 0, this indicates there are no icons in the
                // selected file. Display a message to the user.

                if (iconCount <= 0)
                {
                    MessageBox.Show("The selected file does not have icons.", "No Icons", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Create a pointer array for large icons
                    LargeIcons = new IntPtr[iconCount];

                    // Fill the pointer array with icons
                    ExtractIconEx(filename, 0, LargeIcons, null, iconCount);

                    // Create an image list.
                    ImageList il = new ImageList();
                    il.ImageSize = new System.Drawing.Size(32, 32); // Set the size of the icon to display in the list view control

                    // Add the icons from the array pointer to the image list using a for loop
                    for (int imgCount = 0; imgCount < iconCount; imgCount++)
                    {
                        il.Images.Add(Icon.FromHandle(LargeIcons[imgCount]));
                    }

                    // Set the list view LargeImageList property to the image list
                    listView1.LargeImageList = il;

                    // Add the icons from the image list to the list view control using a for loop
                    for (int itemCount = 0; itemCount < iconCount; itemCount++)
                    {
                        listView1.Items.Add("", itemCount);
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("An error occured.");
                Console.Write(er.Message);
            }
        }

        public string imageFile { get; set; }

        public Bitmap bitmapImage { get; set; }
}
}
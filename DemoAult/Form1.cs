using DemoAult.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace DemoAult
{
    public partial class Form1 : Form
    {
        private List<ProcessModel> listProcess = new List<ProcessModel>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAutoRun_Click(object sender, EventArgs e)
        {
            if (buttonAutoRun.Text == "Auto Run")
            {
                timerAutoRun.Start();
                buttonAutoRun.Text = "Stop";
            }
            else
            {
                timerAutoRun.Stop();
                buttonAutoRun.Text = "Auto Run";
            }
        }

        private void buttonCapture_Click(object sender, EventArgs e)
        {
            Image image;
            Rectangle rcSelect;
            this.Hide();
            Thread.Sleep(1000);
            if (SnippingTool.Snip(out image, out rcSelect))
            {
                DialogResult dr;
                ConditionForm conForm = new ConditionForm(rcSelect);
                dr = conForm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    ProcessModel data = conForm.getResultData();

                    listProcess.Add(data);
                    listBoxCapture.Items.Add(string.Format("{0},threshold:{1}, operation:{2},action:{3}", rcSelect, data.threshold, data.operaion.Value, data.action.Value));
                    if (image != null)
                    {
                        pictureBoxFirstSnip.Image = image;
                    }
                    if (checkBoxShowRealTimeSnip.Checked)
                    {
                        pictureBoxRealtimeSnip.Image = SpecificSnap.Snip(rcSelect);
                    }
                }
                this.Show();
            }
        }

        private void buttonDeleteCapture_Click(object sender, EventArgs e)
        {
            if (listBoxCapture.SelectedIndex >= 0)
            {
                listProcess.RemoveAt(listBoxCapture.SelectedIndex);
                listBoxCapture.Items.RemoveAt(listBoxCapture.SelectedIndex);
            }
        }

        private void timerAutoRun_Tick(object sender, EventArgs e)
        {
            foreach (ProcessModel data in listProcess)
            {
                Image image = SpecificSnap.Snip(data.rect);
                if (checkBoxShowRealTimeSnip.Checked)
                {
                    pictureBoxRealtimeSnip.Image = image;
                }
                avoidObstacles(image, data);
            }
        }
        bool darkMode = false;
        private bool avoidObstacles(Image image, ProcessModel data)
        {
            //double avgColor = avgGrayScaleColor(image);
            //lblconsole.Text = "avgColor  =" + avgColor;
            //if (data.operaion.Value == OperationModel.LessThan.Value)
            //{
            //    //lblconsole.Text = "This LessThan =" + avgColor;
            //    if (avgColor < data.threshold)
            //    {
            //        SendKeys.Send(data.action.Value);
            //        return true;
            //    }
            //}
            //else if (data.operaion.Value == OperationModel.GreaterThan.Value)
            //{
            //    //lblconsole.Text = "This GreaterThan =" + avgColor;
            //    if (avgColor > data.threshold)
            //    {
            //        SendKeys.Send(data.action.Value);
            //        return true;
            //    }
            //}


            //Method 2
            double avgColor2 = avgGrayScaleColor2(image);
            lblconsole2.Text = "avgColor2 =  " + avgColor2;
            lblconsole.Text = "Mode  =" + (darkMode ? "ดึก" : "เช้า");
            if (data.operaion.Value == OperationModel.LessThan.Value)
            {
                //lblconsole.Text = "This LessThan =" + avgColor;
                if (avgColor2 < data.threshold)
                {
                    SendKeys.Send(data.action.Value);
                    return true;
                }

            }
            else if (data.operaion.Value == OperationModel.GreaterThan.Value)
            {
                //lblconsole.Text = "This GreaterThan =" + avgColor;

                if (avgColor2 == 0)
                {
                    darkMode = true;
                }
                if (avgColor2 == 15)
                {
                    darkMode = false;
                }
                if (darkMode == false)
                {
                    if (avgColor2 > data.threshold)
                    {
                        SendKeys.Send(data.action.Value);
                        return true;
                    }
                }
                else
                {
                    if (avgColor2 > 0)
                    {
                        SendKeys.Send(data.action.Value);
                        return true;
                    }
                }
            }
            return false;
        }

        private double avgGrayScaleColor(Image image)
        {
            Bitmap bmpImage = (Bitmap)image;
            double totalGrayScaleColor = 0;
            double avgGrayScaleColor;
            for (int x = 0; x < bmpImage.Width; x++)
            {
                for (int y = 0; y < bmpImage.Height; y++)
                {
                    Color originalColor = ((Bitmap)image).GetPixel(x, y);
                    // convert RGB to Gray.
                    int grayScale = (int)((originalColor.R * .3) + (originalColor.G * .59) + (originalColor.B * .11));
                    totalGrayScaleColor += grayScale;
                }
            }
            //calculate the average of GrayScale picture.
            avgGrayScaleColor = (totalGrayScaleColor) / (bmpImage.Width * bmpImage.Height);
            return avgGrayScaleColor;
        }

        public double avgGrayScaleColor2(Image image)
        {
            // Convert the image to grayscale
            //Image grayImage = ConvertToGrayscale(image);

            Image grayImage = image;

            // Get the pixel data from the grayscale image
            Bitmap bitmap = new Bitmap(grayImage);
            BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, grayImage.Width, grayImage.Height),
                                                     ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);

            // Calculate the average grayscale color
            double sum = 0;
            int pixelCount = grayImage.Width * grayImage.Height;

            unsafe
            {
                byte* scan0 = (byte*)bitmapData.Scan0.ToPointer();

                for (int y = 0; y < grayImage.Height; y++)
                {
                    for (int x = 0; x < grayImage.Width; x++)
                    {
                        sum += scan0[y * bitmapData.Stride + x];
                    }
                }
            }

            double avgGray = sum / pixelCount;

            // Release the pixel data
            bitmap.UnlockBits(bitmapData);

            // Return the average grayscale color
            return avgGray;
        }

        public static Image ConvertToGrayscale(Image image)
        {
            if (image.PixelFormat == PixelFormat.Format1bppIndexed ||
                image.PixelFormat == PixelFormat.Format4bppIndexed ||
                image.PixelFormat == PixelFormat.Format8bppIndexed)
            {
                // Convert indexed pixel format to non-indexed pixel format
                Bitmap nonIndexedBitmap = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppArgb);
                using (Graphics g = Graphics.FromImage(nonIndexedBitmap))
                {
                    g.DrawImage(image, 0, 0);
                }

                // Convert non-indexed pixel format to grayscale
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(new ColorMatrix(
                    new float[][]{
                new float[]{0.299f, 0.299f, 0.299f, 0, 0},
                new float[]{0.587f, 0.587f, 0.587f, 0, 0},
                new float[]{0.114f, 0.114f, 0.114f, 0, 0},
                new float[]{0, 0, 0, 1, 0},
                new float[]{0, 0, 0, 0, 1}}));
                Bitmap grayscaleBitmap = new Bitmap(image.Width, image.Height);
                using (Graphics g = Graphics.FromImage(grayscaleBitmap))
                {
                    g.DrawImage(nonIndexedBitmap, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
                }

                return grayscaleBitmap;
            }
            else
            {
                // Convert non-indexed pixel format to grayscale
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(new ColorMatrix(
                    new float[][]{
                new float[]{0.299f, 0.299f, 0.299f, 0, 0},
                new float[]{0.587f, 0.587f, 0.587f, 0, 0},
                new float[]{0.114f, 0.114f, 0.114f, 0, 0},
                new float[]{0, 0, 0, 1, 0},
                new float[]{0, 0, 0, 0, 1}}));
                Bitmap grayscaleBitmap = new Bitmap(image.Width, image.Height);
                using (Graphics g = Graphics.FromImage(grayscaleBitmap))
                {
                    g.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
                }

                return grayscaleBitmap;
            }
        }

    }
}
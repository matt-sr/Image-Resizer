using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace Image_Resizer
{
    /// <summary>
    /// Contains methods for manipulating and processing internal program objects.
    /// </summary>
    public static class Logic
    {

        /// <summary>
        /// Insert (ImageObject)s into an imageObject List with properties taken from each element of a string array containing image paths.
        /// </summary>
        /// <param name="ImagePathArray"></param>
        /// <param name="ImageObjectList"></param>
        public static void PopulateImageObjectList(string[] ImagePathArray, List<ImageObject> ImageObjectList)
        {
            // Loop through each imagePath in the ImagePathArray and add an ImageObject object
            // into the ImageObjList List with properties extracted from the imagePath
            foreach (string imagePath in ImagePathArray)
            {
                ImageObjectList.Add(new ImageObject(imagePath, Path.GetFileName(imagePath)));
            }
        }

        /// <summary>
        /// Remove ImageObject from ImageObject List at specified index.
        /// </summary>
        /// <param name="List"></param>
        /// <param name="index"></param>
        public static void RemoveItemFromObjectListByIndex(List<ImageObject> List, int index)
        {
            //Removes item from List based on the supplied 'index' parameter
            List.Remove(List[index]);
        }

        /// <summary>
        /// Clear the ImageObject List.
        /// </summary>
        /// <param name="List"></param>
        public static void ClearItemsFromObjectList(List<ImageObject> List)
        {
            //Removes all items from List
            List.Clear();
        }

        /// <summary>
        /// Pad image with whitespace and re-size it to specified dimensions, then save it to specified destination.
        /// </summary>
        /// <param name="Image"></param>
        /// <param name="size"></param>
        /// <param name="destination"></param>
        public static void ProcessImage(ImageObject Image, int size, string destination)
        {
            try
            {
                using (Bitmap BitmapImage = new Bitmap(Image.FileLocation))
                {
                    // Initialize variables
                    int sourceWidth = BitmapImage.Width;
                    int sourceHeight = BitmapImage.Height;
                    int sourceX = 0;
                    int sourceY = 0;
                    int destX = 0;
                    int destY = 0;
                    float nPercent = 0;
                    float nPercentW = 0;
                    float nPercentH = 0;

                    // Calculate the percentage source Width of the image compared to the desired Width
                    nPercentW = ((float)size / sourceWidth);

                    // Calculate the percentage source Height of the image compared to the desired Height
                    nPercentH = ((float)size / sourceHeight);

                    // Test which dimension percentage is smaller 
                    if (nPercentH < nPercentW)
                    {
                        // Assign smaller dimension percentage to nPercent
                        nPercent = nPercentH;

                        // If the smaller dimension is height, calculate how many pixels the image has to be shifted down to center it
                        // Then, assign the value to the destX variable
                        destX = Convert.ToInt16((size - (sourceWidth * nPercent)) / 2);
                    }
                    else
                    {
                        // Assign smaller dimension percentage to nPercent
                        nPercent = nPercentW;

                        // If the smaller dimension is width, calculate how many pixels the image has to be shifted to the right to center it
                        // Then, assign the value to the destY variable
                        destY = Convert.ToInt16((size - (sourceHeight * nPercent)) / 2);
                    }

                    // Calculate and assign the destination width and height of the original image inside the desired size Bitmap
                    int destWidth = (int)(sourceWidth * nPercent);
                    int destHeight = (int)(sourceHeight * nPercent);

                    // Initialise imageEncoder object from GetImageEncoders method
                    // Later the JPEG encoder is taken from this object to save the image with
                    ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();

                    // Initialize encoderParameters with highest quality possible and save the image using this encoder
                    EncoderParameters encoderParameters = new EncoderParameters(1);
                    encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, 100L);

                    // Create blank bitmap to draw to with the specified destination size
                    using (Bitmap bmPhoto = new Bitmap(size, size, PixelFormat.Format24bppRgb))
                    {

                        // Set resolution of Bitmap equal to the source resolution of original image
                        bmPhoto.SetResolution(BitmapImage.VerticalResolution, BitmapImage.HorizontalResolution);

                        // Initilialise graphics object that will be used to draw the final image
                        using (Graphics grPhoto = Graphics.FromImage(bmPhoto))
                        {

                            // Clear the image and set the background color to white
                            grPhoto.Clear(Color.White);

                            // Specify graphics object properties for highest quality Image manipulation
                            grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            grPhoto.SmoothingMode = SmoothingMode.HighQuality;
                            grPhoto.PixelOffsetMode = PixelOffsetMode.HighQuality;
                            grPhoto.CompositingQuality = CompositingQuality.HighQuality;

                            // Draw original image onto the Graphics, offset by either height or width co-ordinates
                            grPhoto.DrawImage(BitmapImage,
                                new Rectangle(destX, destY, destWidth, destHeight),
                                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                                GraphicsUnit.Pixel);

                            // Save the manipulated Bitmap to the specified destination with the Jpeg encoder, with highest quality encoder parameters
                            bmPhoto.Save(destination + "\\" + Image.FileName, imageEncoders[1], encoderParameters);
                        }
                    }
                }
            }
            catch (OutOfMemoryException)
            {
                // Catch an OOM exception if the created Bitmap is too large for the system, then gracefully exit the program.

                PresetMessageBox.OutOfMemoryError();
                Application.Exit();
            }

        }

        /// <summary>
        /// Saves settings with supplied values for mainDestination and thumbDestination.
        /// </summary>
        /// <param name="mainDestination"></param>
        /// <param name="thumbDestination"></param>
        public static void SaveSettings(string mainDestination, string thumbDestination)
        {
            if (Validation.IsNotEmpty(mainDestination))
            {
                Properties.Settings.Default.MainDestination = mainDestination;
                Properties.Settings.Default.Save();
            }
            if (Validation.IsNotEmpty(thumbDestination))
            {
                Properties.Settings.Default.ThumbDestination = thumbDestination;
                Properties.Settings.Default.Save();
            }            
        }

    } // End of Class Logic

} // End of Namespace Image_Resizer



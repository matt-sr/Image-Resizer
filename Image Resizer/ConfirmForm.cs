using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Image_Resizer
{
    public partial class ConfirmForm : Form
    {
        // Declare Objects that we need to reference from MainForm inside ConfirmForm
        List<ImageObject> ImageObjectList;
        ListView lvItemList;

        public ConfirmForm(List<ImageObject> objectlist, ListView listview)
        {
            InitializeComponent();
            
            // Assign values from provided objectlist and listview to previously declared Objects
            ImageObjectList = objectlist;
            lvItemList = listview;
            
            // Update the Image Count Label with a count of ImageObjects inside ImageObjectList
            lblCount.Text = "Image Count : " + ImageObjectList.Count();

            // Set the value of Destination Directory TextBoxes to the saved settings' value
            tbDestinationMain.Text = Properties.Settings.Default.MainDestination;
            tbDestinationThumb.Text = Properties.Settings.Default.ThumbDestination;
        }
        
        /// <summary>
        /// Event handler method for the 'Start' button click action, performs validation and processes images, then saves them.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStart_Click(object sender, EventArgs e)
        {
            // Assign a true or false value to a variable that's evaluated to check if size textBoxes can be parsed as integers 
            bool successfullyParsed = int.TryParse(tbTargetSizeMain.Text, out int mainSize);
            successfullyParsed = int.TryParse(tbTargetSizeThumb.Text, out int thumbNailSize);

            // If both size textBoxes values can be parsed as integers, go forward
            if (successfullyParsed)
            {
                // Initialize strings for mainDestination and thumbDestination directories, and a counter variable
                string mainDestination = tbDestinationMain.Text;
                string thumbDestination = tbDestinationThumb.Text;
                int i = 0;

                // Test if all textBoxes have a value
                if (Validation.IsNotEmpty(mainSize) && Validation.IsNotEmpty(thumbNailSize) && Validation.IsNotEmpty(mainDestination) && Validation.IsNotEmpty(thumbDestination))
                {
                    // Initialize a string variable that will hold the returned validation message. For readability reasons.
                    string validationMessage = Validation.AreValidDirectories(mainDestination, thumbDestination);

                    // If AreValidDirectories returns the string "valid", go forward
                    if (validationMessage == "valid")
                    {
                        // Loop through each ImageObject Object in ImageObjectList and attempt to call ProcessImage for each one.
                        foreach (ImageObject Image in ImageObjectList)
                        {
                            try
                            {
                                // Attempt to process each ImageObject
                                Logic.ProcessImage(Image, mainSize, mainDestination);
                                Logic.ProcessImage(Image, thumbNailSize, thumbDestination);
                            }
                            catch (ArgumentException)
                            {
                                // If ArgumentException is thrown, show which file caused the issue and continue with next image.
                                PresetMessageBox.ErrorWithFile(Image.FileLocation, Image.FileName);
                                continue;
                            }

                            // Increment the counter, update the "Images Processed" counter label, then refresh the label after each image is processed
                            i++;
                            lblProcessed.Text = "Images Processed : " + i;
                            lblProcessed.Refresh();
                        }

                        // Once all possible images are processed, clear the ListView and ImageObjectList of items and display a "Processing Finished" MessageBox
                        Logic.ClearItemsFromObjectList(ImageObjectList);
                        View.ClearItemsFromListView(lvItemList);
                        PresetMessageBox.ProcessingFinished();

                        // Close the form once all possible images are processed
                        ActiveForm.Close();
                    }
                    // If there is an issue with the supplied directories, AreValidDirectories will return a string with more details that's passed to the DirectoryError MessageBox
                    else { PresetMessageBox.DirectoryError(validationMessage); }
                }
                // If one or more TextBoxes have a missing value, display the "Missing Parameters" MessageBox
                else { PresetMessageBox.MissingParametersError(); }
            }
            // If the size TextBoxes couldn't be parsed, display a "Parameter Error" MessageBox
            else { PresetMessageBox.ParameterError(); }
        }

        /// <summary>
        /// Event handler method for the 'Get Thumbnail Destination Directory' ('...') button click action, opens FolderBrowserDialog and assigns selection to TextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGetThumbDestination_Click(object sender, EventArgs e)
        {
            // Open a FolderBrowserDialog to select a destination folder for Thumbnail Sizes
            using (var selectFileDestination = new FolderBrowserDialog())
            {
                if (selectFileDestination.ShowDialog() == DialogResult.OK)
                {
                    // Update the DestinationThumb TextBox value with the selected path
                    tbDestinationThumb.Text = selectFileDestination.SelectedPath;

                    // Save the selected path to the settings so that the same path will show after restarting the program
                    Logic.SaveSettings("", selectFileDestination.SelectedPath);
                }
            }
        }

        /// <summary>
        /// Event handler method for the 'Get Main Size Destination Directory' ('...') button click action, opens FolderBrowserDialog and assigns selection to TextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGetMainDestination_Click(object sender, EventArgs e)
        {
            // Open a FolderBrowserDialog to select a destination folder for Main Sizes
            using (var selectFileDestination = new FolderBrowserDialog())
            {
                if (selectFileDestination.ShowDialog() == DialogResult.OK)
                {
                    // Update the DestinationMain TextBox value with the selected path
                    tbDestinationMain.Text = selectFileDestination.SelectedPath;

                    // Save the selected path to the settings so that the same path will show after restarting the program
                    Logic.SaveSettings(selectFileDestination.SelectedPath, "");
                }
            }
        }

        /// <summary>
        /// Event handler method for the 'Thumbnail Size' TextBox KeyPress action, performs validation and processes keystroke if valid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbTargetSizeThumb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Keystroke is Handled if KeypressIsNumericOrBackspace returns true
            e.Handled = Validation.KeypressIsNumericOrBackspace(e);
        }

        /// <summary>
        /// Event handler method for the 'Main Size' TextBox KeyPress action, performs validation and processes keystroke if valid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbTargetSizeMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Keystroke is Handled if KeypressIsNumericOrBackspace returns true
            e.Handled = Validation.KeypressIsNumericOrBackspace(e);
        }
    }
}

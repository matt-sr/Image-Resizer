using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Image_Resizer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Bind DragEnter and DragDrop properties with their event handler methods
            DragEnter += new DragEventHandler(MainForm_DragEnter);
            DragDrop += new DragEventHandler(MainForm_DragDrop);
        }

        // Create a blank List for the ImageObject Object
        List<ImageObject> ImageObjectList = new List<ImageObject>();

        /// <summary>
        /// Event handler method for the DragEnter action.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        
        /// <summary>
        /// Event handler method for the DragDrop action, performs validation and imports image properties into program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            // Create a string array that contains complete file paths to the imported files

            string[] itemArray = (string[])e.Data.GetData(DataFormats.FileDrop);

            // Validate the imported items with the AreAllImageFiles method
            if (Validation.AreAllImageFiles(itemArray))
            {
                // If the array is successfully validated, try to clear any existing items in the 
                // ListView and ImageObjectList and then populate them with new values
                try
                {
                    Logic.ClearItemsFromObjectList(ImageObjectList);
                    View.ClearItemsFromListView(lvItemList);

                    Logic.PopulateImageObjectList(itemArray, ImageObjectList);
                    View.PopulateListView(ImageObjectList, lvItemList);
                }
                catch (ArgumentException)
                {
                    // Display an 'unexpected error' MessageBox when an ArgumentException is thrown
                    PresetMessageBox.UnexpectedError("");
                }
            }
            else
            {
                // Display a 'File Type Error' MessageBox when the array is not validated successfully
                PresetMessageBox.FileTypeError();
            }
        }

        /// <summary>
        /// Event handler method for the 'Process Images' button click action, performs validation and opens ConfirmForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnProcessImages_Click(object sender, EventArgs e)
        {
            // Validate the existence of items in the ListView
            if (Validation.ListViewContainsAtLeastOneItem(lvItemList))
            {
                // If ListView contains at least one item, show the ConfirmDialog
                new ConfirmForm(ImageObjectList, lvItemList).ShowDialog();
            }
            else
            {
                // Display an 'Empty List' MessageBox when there aren't any items in the list
                PresetMessageBox.EmptyListError();
            }
        }

        /// <summary>
        /// Event handler method for the 'Process Images' button click action, performs validation and opens ConfirmForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnImportImages_Click(object sender, EventArgs e)
        {
            // Initialize an OpenFileDialog object to let user select files
            using (OpenFileDialog importImagesDialog = new OpenFileDialog())
            {
                // Set the MultiSelect property of OpenFileDialog to true to allow selecting multiple images in one import
                importImagesDialog.Multiselect = true;

                // Show dialog and check if the result is 'OK'
                if (importImagesDialog.ShowDialog() == DialogResult.OK)
                {
                    // Create a string array that contains complete file paths to the imported files selected in OpenFileDialog
                    string[] itemsFilePaths = importImagesDialog.FileNames;

                    // Validate the imported items with the AreAllImageFiles method 
                    if (Validation.AreAllImageFiles(itemsFilePaths))
                    {
                        try
                        {
                            // If the array is successfully validated, try to clear any existing items in the
                            // ListView and ImageObjectList and then populate them with new values
                            Logic.ClearItemsFromObjectList(ImageObjectList);
                            View.ClearItemsFromListView(lvItemList);

                            Logic.PopulateImageObjectList(itemsFilePaths, ImageObjectList);
                            View.PopulateListView(ImageObjectList, lvItemList);
                        }
                        catch (ArgumentException)
                        {
                            // Display an 'unexpected error' MessageBox when an ArgumentException is thrown
                            PresetMessageBox.UnexpectedError("");
                        }
                    }
                    else
                    {
                        // Display a 'File Type Error' MessageBox when the array is not validated successfully
                        PresetMessageBox.FileTypeError();
                    }
                }
            }
        }

        /// <summary>
        /// Event handler method for the 'Clear List' button click action, performs validation and clears the ListView and ImageObjectList of ImageObjects.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClearList_Click(object sender, EventArgs e)
        {
            // Validate the existence of items in the ListView
            if (Validation.ListViewContainsAtLeastOneItem(lvItemList))
            {
                // If at least one item exists in the list, clear all ImageObject Objects from ImageObjectList and all items from the ListView
                Logic.ClearItemsFromObjectList(ImageObjectList);
                View.ClearItemsFromListView(lvItemList);
            }
            else
            {
                // Display an 'Empty List' MessageBox when there aren't any items in the list
                PresetMessageBox.EmptyListError();
            }
        }

        /// <summary>
        /// Event handler method for the 'Delete Selected' button click action, performs validation and deletes selected items from ListView and ImageObjectList.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDeleteSelected_Click(object sender, EventArgs e)
        {
            // Validate the selection of at least one item
            if (Validation.AtLeastOneItemIsSelected(lvItemList))
            {
                // Loop through each item in the ListView SelectedItems collection and 
                // attempt to remove them form the ListView and ImageObjectList using the current item's index
                foreach (ListViewItem item in lvItemList.SelectedItems)
                {
                    try
                    {
                        int index = item.Index;
                        // Remove item(s) from ListView and ImageObjectList by index
                        View.RemoveItemFromListViewByIndex(lvItemList, index);
                        Logic.RemoveItemFromObjectListByIndex(ImageObjectList, index);
                    }
                    catch (NullReferenceException)
                    {
                        // Display an 'Unexpected Error' MessageBox when a NullReferenceException is thrown, then clear all items from the ImageObjectList and ListView
                        PresetMessageBox.UnexpectedError("All imported images will be wiped from memory to ensure stability.");
                        View.ClearItemsFromListView(lvItemList);
                        Logic.ClearItemsFromObjectList(ImageObjectList);
                    }
                }
            }
            else
            {
                // If nothing is selected, display a 'Nothing Selected' MessageBox
                PresetMessageBox.NothingSelectedError();
            }
        }
    } // End of Class MainForm
} // End of Namespace Image_Resizer

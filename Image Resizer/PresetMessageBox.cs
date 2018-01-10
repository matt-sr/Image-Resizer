using System.Windows.Forms;

namespace Image_Resizer
{
    /// <summary>
    /// Contains pre-written MessageBox messages for displaying information or errors.
    /// </summary>
    static class PresetMessageBox
    {
        /// <summary>
        /// Displays a MessageBox with the supplied text in the body and title.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="title"></param>
        private static void DisplayMessageBox(string text, string title, bool isError)
        {
            if (isError)
            {
                // Display MessageBox object with error, if supplied isError bool is true
                MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Display MessageBox object
                MessageBox.Show(text, title, MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Displays an "Unexpected Error" MessageBox with option for displaying extra details to the user.
        /// </summary>
        /// <param name="extraDetails"></param>
        public static void UnexpectedError(string extraDetails)
        {
            string text = "An unexpected error occured. " + extraDetails;
            string title = "ERROR";
            DisplayMessageBox(text, title, true);
        }

        /// <summary>
        /// Displays an "Image files only" MessageBox.
        /// </summary>
        public static void FileTypeError()
        {
            string text = "The program can only process image files.";
            string title = "Non-image file detected";
            DisplayMessageBox(text, title, true);
        }

        /// <summary>
        /// Displays a "No items found" MessageBox.
        /// </summary>
        public static void EmptyListError()
        {
            string text = "There are no items in the list.";
            string title = "No files found";
            DisplayMessageBox(text, title, true);
        }

        /// <summary>
        /// Displays a "Please select files" MessageBox.
        /// </summary>
        public static void NothingSelectedError()
        {
            string text = "Please select files that you want to remove from the list and try again.";
            string title = "Nothing is selected";
            DisplayMessageBox(text, title, true);
        }

        /// <summary>
        /// Displays an "Error with directories" MessageBox, with "See below for details" followed by supplied details string.
        /// </summary>
        /// <param name="details"></param>
        public static void DirectoryError(string details)
        {
            string text = "There is an error with the supplied destination directories. Please see below for details: \n" + details;
            string title = "Directory Error";
            DisplayMessageBox(text, title, true);
        }

        /// <summary>
        /// Displays a "Parameters not found" MessageBox.
        /// </summary>
        public static void MissingParametersError()
        {
            string text = "One or more parameters could not be found. Please ensure that you have: \n - A unique destination directory for thumbnail and main images with write permissions \n - Valid numeric sizes for output between the values of 1 and 99999";
            string title = "Missing paramater(s)";
            DisplayMessageBox(text, title, true);
        }

        /// <summary>
        /// Displays an "Error with Parameters" MessageBox.
        /// </summary>
        public static void ParameterError()
        {
            string text = "There's an issue with the parameters specified. Please ensure the desired sizes are numeric, the destination directory valid and that neither are blank.";
            string title = "Bad values";
            DisplayMessageBox(text, title, true);
        }

        /// <summary>
        /// Displays an "Error with file" Messagebox, specifying which filename caused the error and its file path.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="fileName"></param>
        public static void ErrorWithFile(string filePath, string fileName)
        {
            string text = "An error has occured with a file. \n File name = " + fileName + " \n File path = " + filePath + " \n The program will skip this file and attempt to continue its current process";
            string title = "Error with file";
            DisplayMessageBox(text, title, true);
        }

        /// <summary>
        /// Displays an "Out of memory" MessageBox.
        /// </summary>
        public static void OutOfMemoryError()
        {
            string text = "The program has run out of memory attempting the current process. The program will now close.";
            string title = "Program has run out of memory";
            DisplayMessageBox(text, title, true);
        }

        /// <summary>
        /// Displays an "All images processed" MessageBox.
        /// </summary>
        public static void ProcessingFinished()
        {
            string text = "All images have been processed.";
            string title = "Success";
            DisplayMessageBox(text, title, false);
        }
    }
}

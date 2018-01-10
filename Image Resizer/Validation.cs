using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;

namespace Image_Resizer
{
    /// <summary>
    /// Contains validation methods specific to the image resizer utility program.
    /// </summary>
    public static class Validation
    {

        private enum FileTypes {
            // The FileTypes enum contains all the image file extensions that are allowed to be processed

            jpg, jpeg, png, gif, bmp
        };

        /// <summary>
        /// Test if supplied ListView contains at least one item.
        /// </summary>
        /// <param name="ListViewName"></param>
        /// <returns></returns>
        public static bool ListViewContainsAtLeastOneItem(ListView ListViewName)
        {
            // Test if ListView contains more than 0 items

            // Return true if more than 0
            // Return false if 0

            return ListViewName.Items.Count > 0;
        }

        /// <summary>
        /// Test if at least one item is selected in the supplied ListView.
        /// </summary>
        /// <param name="ListViewName"></param>
        /// <returns>bool</returns>
        public static bool AtLeastOneItemIsSelected(ListView ListViewName)
        {
            // Test if ListView has more than 0 selected items

            // Return true if more than 0
            // Return false if 0

            return ListViewName.SelectedItems.Count > 0;
        }

        /// <summary>
        /// Test if all elements of a string array are valid file paths to valid image files.
        /// </summary>
        /// <param name="ImagePathArray"></param>
        /// <returns>bool</returns>
        public static bool AreAllImageFiles(string[] ImagePathArray)
        {
            /* Loop through each [imagePath] in a string array containing directory paths of images (ImagePathArray)
             * First check if [imagePath] file extension is inside FileTypes enum, if yes then attempt to create a Bitmap
             * from the [ImagePath] to provoke an ArgumentException which can be handled at the importing process
             
             * Return false if [ImagePath] extension is not in FileTypes enum then,
             * Return false if [ImagePath] Bitmap throws ArgumentException.
             * Return true if neither of above is satisfied
             */

            foreach (string imagePath in ImagePathArray)
            {
                // Initialize a string with value received from GetExtension method tested on imagePath
                string fileExtension = Path.GetExtension(imagePath);

                // We need to remove the '.' from the file extension as the values in the FileTypes enum cannot contain '.'
                fileExtension = fileExtension.Substring(1);

                // Using LINQ, check if fileExtension is somewhere inside the FileTypes enum
                // If it isn't, return false and break execution
                if (!(Enum.GetNames(typeof(FileTypes)).Contains(fileExtension)))
                {
                    return false;
                }

                // Inside a try-catch, attempt to create a Bitmap from imagePath
                // If successful, do nothing and move onto next imagePath
                // If ArgumentException is thrown, return false and break execution
                try
                {
                    using(Bitmap bmp = new Bitmap(imagePath))
                    {
                        // Do nothing
                    }
                }
                catch (ArgumentException)
                {
                    return false;
                }
            }

            // Return true if all imagePaths are inside the FileTypes enum and can be made into a Bitmap
            return true;
        }

        /// <summary>
        /// Test if keypress was numeric or backspace.
        /// </summary>
        /// <param name="e"></param>
        /// <returns>bool</returns>
        public static bool KeypressIsNumericOrBackspace(KeyPressEventArgs e)
        {
            // Test if the KeyPress argument is a digit or the backspace key

            // Return true if it is
            // Return false if not
            return !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        /// <summary>
        /// Test if supplied int is not 0.
        /// </summary>
        /// <param name="numericValue"></param>
        /// <returns>bool</returns>
        public static bool IsNotEmpty(int numericValue)
        {
            // Test if the supplied integer is not equal to 0

            // Return true if numericValue is not 0
            // Return false if numericValue is 0
            return numericValue != 0;
        }

        /// <summary>
        /// Test if supplied string is not null, empty or whitespace.
        /// </summary>
        /// <param name="stringValue"></param>
        /// <returns>bool</returns>
        public static bool IsNotEmpty(string stringValue)
        {
            // Overload method for IsNotEmpty to deal with strings
            // Test if the supplied string is not null, empty or whitespace

            // Return true if stringValue is not null, empty or whitespace
            // Return false if stringValue is null, empty or whitespace
            return !string.IsNullOrEmpty(stringValue) || !string.IsNullOrWhiteSpace(stringValue);
        }
        
        /// <summary>
        /// Test if two supplied directories exist, are unique, and have write access from current Windows User.
        /// </summary>
        /// <param name="filePath1"></param>
        /// <param name="filePath2"></param>
        /// <returns>string</returns>
        public static string AreValidDirectories(string filePath1, string filePath2)
        {
            // Test if both directories exist using the Exists method
            if (Directory.Exists(filePath1) || Directory.Exists(filePath2))
            {
                // Test if both directories are unique
                if (filePath1 != filePath2)
                {
                    // Test if the program has write permissions to the first directory
                    if (DirectoryHasPermission(filePath1, FileSystemRights.Write))
                    {
                        // Test if the program has write permissions to the second directory
                        if (DirectoryHasPermission(filePath2, FileSystemRights.Write))
                        {
                            // Return "valid" if all tests return True
                            return "valid";
                        }
                        else { return "The program does not have write permissions to path named '" + filePath2 + "', please select a different destination folder/directory with WRITE permissions."; }
                    }
                    else { return "The program does not have write permissions to path named '" + filePath1 + "', please select a different destination folder/directory with WRITE permissions."; }
                }
                else { return "Destination paths are not unique"; }
            }
            else { return "One or both directories do not exist"; }
        }

        /// <summary>
        /// Test a directory for file access permissions .
        /// </summary>
        /// <param name="DirectoryPath"></param>
        /// <param name="AccessRight"></param>
        /// <returns>bool</returns>
        private static bool DirectoryHasPermission(string DirectoryPath, FileSystemRights AccessRight)
        {
            try
            {
                // Initialize a AuthorizationRuleCollection object with access rules
                AuthorizationRuleCollection rules = Directory.GetAccessControl(DirectoryPath).GetAccessRules(true, true, typeof(System.Security.Principal.SecurityIdentifier));

                // Initialize a WindowsIdentity object with the value of the current Windows User
                WindowsIdentity identity = WindowsIdentity.GetCurrent();

                // Loop through each FileSystemAccessRule inside the rules collection
                foreach (FileSystemAccessRule rule in rules)
                {
                    // Test if the current Windows Identity contains the current rule Identity Reference
                    if (identity.Groups.Contains(rule.IdentityReference))
                    {
                        // Test if the supplied AccessRight is in FileSystemRights to then evaluate it
                        if ((AccessRight & rule.FileSystemRights) == AccessRight)
                        {
                            // Test if the supplied AccessRight is allowed, then return true if it is
                            if (rule.AccessControlType == AccessControlType.Allow)
                                return true;
                        }
                    }
                }
            }
            catch { }
            return false;
        }
    }
}

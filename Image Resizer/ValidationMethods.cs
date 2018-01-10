using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Image_Resizer
{
    public class ValidationMethods
    {
        public bool listContainsAtLeastOneItem(CheckedListBox listName) {
            if (listName.Items.Count > 0) {
                return true;
            } else {
                return false;
            }
        }

        public bool atLeastOneItemIsSelected(CheckedListBox listName) {
            if (listName.CheckedItems.Count > 0) {
                return true;
            } else {
                return false;
            }
        }

        public bool areAllImageFiles(string[] array) {

            int i = 0;

            foreach (string element in array)
            {
                string fileExtension = Path.GetExtension(element);
                if (fileExtension.Contains(".jpg") || fileExtension.Contains(".jpeg") || fileExtension.Contains(".gif") || fileExtension.Contains(".bmp") || fileExtension.Contains(".png")) {
                    i++;
                    if (i == array.Length) { return true; }
                } else { return false; }
            }
            return false;
        }

        public void displayErrorMessageBox(string text, string title) {
            MessageBox.Show(text, title, MessageBoxButtons.OK);
        }


    }
}

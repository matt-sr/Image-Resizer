using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Resizer
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
            AllowDrop = true;
            DragDrop += new DragEventHandler(formMain_DragDrop);
            DragEnter += new DragEventHandler(formMain_DragEnter);
        }

        ValidationMethods Validation = new ValidationMethods();
        Logic Logic = new Logic();
        List<ImageObj> ImageObjList = new List<ImageObj>();

        private void formMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void formMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] itemArray = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (Validation.areAllImageFiles(itemArray)) {

                ImageObjList.Clear();
                clbItemList.Items.Clear();
                Logic.populateImageList(itemArray, ImageObjList);
                Logic.populateItemList(ImageObjList, clbItemList);

            } else {

                Validation.displayErrorMessageBox("The program will only process image files.", "Non-image file detected");

            }
        }

        private void btnProcessImages_Click(object sender, EventArgs e)
        {
            
        }

        private void btnImportImages_Click(object sender, EventArgs e)
        {
            OpenFileDialog importImagesDialog = new OpenFileDialog();
            importImagesDialog.Multiselect = true;
            if (importImagesDialog.ShowDialog() == DialogResult.OK) {
                string[] imageFilePathsArray = importImagesDialog.FileNames;

                ImageObjList.Clear();
                clbItemList.Items.Clear();
                Logic.populateImageList(imageFilePathsArray, ImageObjList);
                Logic.populateItemList(ImageObjList, clbItemList);
                Console.WriteLine(clbItemList.Items[0]);
            }

        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            if (Validation.listContainsAtLeastOneItem(clbItemList)) {
                ImageObjList.Clear();
                clbItemList.Items.Clear();
            } else {
                Validation.displayErrorMessageBox("Please tick items that you want to remove and try again.", "No files found");
            }
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (Validation.atLeastOneItemIsSelected(clbItemList)) {
                while (clbItemList.CheckedItems.Count > 0) {
                    //clbItemList.Items.Remove(clbItemList.CheckedItems[0]);
                    foreach (ListViewItem item in clbItemList.CheckedItems[0])
                    {

                    }
                }
            } else {
                Validation.displayErrorMessageBox("Please tick files that you want to remove from the list and try again.", "Ticked files not found");
            };
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            //open instructions form
        }

    }
}

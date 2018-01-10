using System.Collections.Generic;
using System.Windows.Forms;

namespace Image_Resizer
{
    /// <summary>
    /// Contains methods for manipulating all Objects related to the interface.
    /// </summary>
    public static class View
    {
        /// <summary>
        /// Populates ListView with file names of each ImageObject in ImageObjectList.
        /// </summary>
        /// <param name="ImageObjectList"></param>
        /// <param name="LvItemList"></param>
        public static void PopulateListView(List<ImageObject> ImageObjectList, ListView LvItemList)
        {
            foreach (var image in ImageObjectList)
            {
                // Loop through each ImageObject in ImageObjectList and 
                // add the ImageObject's FileName property as an item in the ListView
                LvItemList.Items.Add(image.FileName);
            }
        }

        /// <summary>
        /// Remove Item from ListView at provided index.
        /// </summary>
        /// <param name="ListView"></param>
        /// <param name="index"></param>
        public static void RemoveItemFromListViewByIndex(ListView ListView, int index)
        {
            ListView.Items[index].Remove();
        }

        /// <summary>
        /// Clears all items from ListView.
        /// </summary>
        /// <param name="ListView"></param>
        public static void ClearItemsFromListView(ListView ListView)
        {
            ListView.Clear();
        }
    }
}
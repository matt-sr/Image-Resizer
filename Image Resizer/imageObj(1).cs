using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_Resizer
{
    class ImageObj
    {

        private string fileLocation;
        private int width;
        private int height;

        public ImageObj(string fileLocation, int width, int height)
        {
            this.fileLocation = fileLocation;
            this.width = width;
            this.height = height;
        }
        public string FileLocation
        {
            get { return fileLocation; }
            set { fileLocation = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
    }
}

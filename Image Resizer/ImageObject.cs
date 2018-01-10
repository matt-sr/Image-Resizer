namespace Image_Resizer
{
    /// <summary>
    /// Contains properties for file location and file name.
    /// </summary>
    public class ImageObject
    {
        // Currently this object could be replaced by an array created in MainForm, but the object offers
        // future-proofing and potential expandability if more features were to be added to the program, like image editing

        // Declare the properties of ImageObject
        private string fileLocation;
        private string fileName;
        
        public ImageObject(string fileLocation, string fileName)
        {
            this.fileLocation = fileLocation;
            this.fileName = fileName;
        }

        // The rest of the program has enough validation to be sure that the values in this object will be as expected
        // In the future, the program could be re-structured to contain more validation in Getters and Setters but not necessary at this stage

        // Get | Set for FileLocation
        public string FileLocation
        {
            get { return fileLocation; }
            set { fileLocation = value; }
        }

        // Get | Set for FileName
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
    }
}

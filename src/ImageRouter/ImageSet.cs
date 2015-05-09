using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ImageRouter
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class ImageSet
    {
        private HashSet<String> images;

        public ImageSet()
        {
            images = new HashSet<string>();
        }

        public void GatherImages(String folder)
        {
            try
            {
                foreach (String currentDir in Directory.GetDirectories(folder))
                {
                    foreach (String currentFile in Directory.GetFiles(currentDir))
                    {
                        if(currentFile.Contains(".png"))
                        {
                            Console.WriteLine(currentFile);
                            images.Add(currentFile);

                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                
            }
        }

        private void AddImage(String url)
        {
            this.images.Add(url);
        }

        public Boolean HasImage(String url)
        {
            return this.images.Contains(url);
        }
    }
}

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.PixelFormats;


namespace CollageMaker
{
    class ImageListLoader
    {
        public static List<Image> LoadImagesOntoList(string folderPath)
        {
            List<Image> files = new List<Image>();

            foreach (var file in Directory.GetFiles(folderPath))
            {
                Image imageHolder = Image.Load(file);
                files.Add(imageHolder);
            }

            return files;
        }
    }
}

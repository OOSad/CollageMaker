using System;
using System.Collections.Generic;
using System.Text;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace CollageMaker
{
    class ProperHeightCalculator
    {
        public static int CalculateCanvasHeight(List<Image> listOfImages)
        {
            int canvasWidth = 0;
            int numberOfRows = 0;

            for (int i = 0; i < listOfImages.Count; i++)
            {
                canvasWidth += listOfImages[i].Width;
            }

            numberOfRows = canvasWidth / 1920;

            return numberOfRows;
        }
    }
}

using System;
using System.Collections.Generic;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace CollageMaker
{
    class CanvasWorker
    {
        public static int finalCroppingHeight = 0;

        public static Image PasteImagesIntoCanvas(List<Image> listOfImages, Image canvas)
        {
            canvas.Mutate(operation => operation.DrawImage(listOfImages[0], new Point(0, 0), 1f));
            int incrementedWidth = listOfImages[0].Width;
            int incrementedHeight = 0;
            int targetPositionInList = 0;

            for (int i = 1; i < listOfImages.Count; i++)
            {
                if (incrementedWidth + listOfImages[i].Width > 1920)
                {
                    Console.WriteLine("Width too large. Wrapping around!");
                    finalCroppingHeight = 0;
                    incrementedHeight += BiggestHeightFinder.FindBiggestHeight(listOfImages, i, targetPositionInList);
                    finalCroppingHeight = incrementedHeight + BiggestHeightFinder.FindBiggestHeight(listOfImages, i, targetPositionInList);
                    canvas.Mutate(operation => operation.DrawImage(listOfImages[i], new Point(0, incrementedHeight), 1f));
                    incrementedWidth = listOfImages[i].Width;
                    targetPositionInList = i;
                }

                else
                {
                    canvas.Mutate(operation => operation.DrawImage(listOfImages[i], new Point(incrementedWidth, incrementedHeight), 1f));
                    incrementedWidth += listOfImages[i].Width;
                }

                //canvas.Save(@"OutputFolder\OutputImage.png"); //For debugging! Comment out or erase when not needed.
            }

            return canvas;
        }
    }
}

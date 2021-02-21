using System.Collections.Generic;
using SixLabors.ImageSharp;

namespace CollageMaker
{
    class BiggestHeightFinder
    {
        public static int FindBiggestHeight (List<Image> listOfImages, int currentPositionInList, int targetPositionInList)
        {
            int biggestImageHeight = 0;

            for (int i = currentPositionInList; i > targetPositionInList; i--)
            {
                if (listOfImages[i].Height > biggestImageHeight)
                {
                    biggestImageHeight = listOfImages[i].Height;
                }
            }

            return biggestImageHeight;
        }
    }
}

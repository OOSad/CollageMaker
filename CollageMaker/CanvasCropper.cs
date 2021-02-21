using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace CollageMaker
{
    class CanvasCropper
    {
        public static Image CropEmptySpaceFromFinishedCanvas(Image canvas, int croppingHeight)
        {
            canvas.Mutate(operation => operation.Crop(1920, croppingHeight));

            return canvas;
        }
    }
}

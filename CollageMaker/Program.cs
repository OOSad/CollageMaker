using System;
using SixLabors.ImageSharp;


namespace CollageMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Image canvas = CanvasInitializer.CreateEmptyCanvas();
            canvas = CanvasWorker.PasteImagesIntoCanvas(ImageListLoader.LoadImagesOntoList(@"ImagesFolder"), canvas);
            canvas = CanvasCropper.CropEmptySpaceFromFinishedCanvas(canvas, CanvasWorker.finalCroppingHeight);

            canvas.Save(@"OutputFolder\OutputImage.png");
        }
    }
}

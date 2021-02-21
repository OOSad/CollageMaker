using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace CollageMaker
{
    class CanvasInitializer
    {
        public static Image CreateEmptyCanvas()
        {
            int canvasWidth = 10000;
            int canvasHeight = 5000;

            var canvas = new Image<Rgba32>(canvasWidth, canvasHeight);

            return canvas;
        }
    }
}

using System.Drawing;

namespace ImagesFilter.Logic
{
    public class RotateRight : IImageFilter
    {
        public void Perform(Image image)
        {
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);
        }
    }
}

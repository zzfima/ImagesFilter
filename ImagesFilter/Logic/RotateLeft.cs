using System.Drawing;

namespace ImagesFilter.Logic
{
    public class RotateLeft : IImageFilter
    {
        public void Perform(Image image)
        {
            image.RotateFlip(RotateFlipType.Rotate270FlipNone);
        }
    }
}

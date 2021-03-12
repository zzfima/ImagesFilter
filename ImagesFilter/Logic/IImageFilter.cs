using System.Drawing;

namespace ImagesFilter.Logic
{
    public interface IImageFilter
    {
        void Perform(Image image);
    }
}

using System.Drawing;

namespace FacebookApp.Interfaces
{
    public interface IGridItem
    {
        Image ImageThumb { get; }

        Image ImageLarge { get; }
    }
}

using Core.Entities;

namespace Entities.Concrete
{
    public class Color : IEntityBase
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}

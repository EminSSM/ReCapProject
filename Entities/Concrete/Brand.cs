using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Brand:IEntityBase
    {
        public int BrandId { get; set; }
        [MinLength(2)]
        public string BrandName { get; set; }
    }
}

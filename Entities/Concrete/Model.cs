using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class Model : Entity
{
    public string Name { get; set; }
    public int BrandId { get; set; }
    public virtual Brand Brand { get; set; }
    public virtual ICollection<Car> Cars { get; set; }
}

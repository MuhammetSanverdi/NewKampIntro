using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Model:IEntity
    {
        public int ModelId { get; set; }
        public int BrandId { get; set; }
        public string ModelName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeEquipment
{
    public class Equipment: IDisposable
    {
        private readonly DateTime orderedAt = DateTime.Now;

        public DateTime OrderedAt
        {
            get { return this.orderedAt; }
        }

        public string CakeName { get; set; }

        public void Dispose()
        {
            this.CakeName = null;
        }
    }
}

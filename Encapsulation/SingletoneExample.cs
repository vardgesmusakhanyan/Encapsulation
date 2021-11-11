using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class SingletoneExample
    {
        private SingletoneExample() { }
        private static SingletoneExample instance = null;
        public static SingletoneExample Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletoneExample();
                }
                return instance;
            }
        }
    }
}

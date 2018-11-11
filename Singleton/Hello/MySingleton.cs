using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Hello
{
    public class MySingleton
    {
        private static MySingleton instance;

        private MySingleton() { }

        public static MySingleton Instance
        {
            get
            {
                return instance ?? (instance =
             new MySingleton());
            }
        }

        public string SomeText { get; set; }
    }
}

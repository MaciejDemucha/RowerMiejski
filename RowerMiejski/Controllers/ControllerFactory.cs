using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowerMiejski.Controllers
{
    public static class ControllerFactory
    {
        public static ViewController CreateStacjaController()
        {
            return new ViewController();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Client
    {
        Component Root;

        public Client(Component RootElement)
        {
            Root = RootElement;
        }

        public void GetHouseInfo()
        {
            Root.GetDescription();   
        }
    }
}

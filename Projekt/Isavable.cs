using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    interface ISavable
    {
        void ZapiszXML(string nazwa);
        Object OdczytXML(string nazwa);
    }
}
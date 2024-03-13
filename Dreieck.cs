using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flächen;

public class Dreieck : Rechteck
{

    int _flaeche = 0;
    public Dreieck(int flaeche) : base(flaeche)
    {
       flaeche= _flaeche;
    }
}

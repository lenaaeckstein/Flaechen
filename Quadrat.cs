using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flächen;

public class Quadrat : Rechteck
{

    public override double GetFlaeche()
    {
        return _flaeche;
    }

    int _flaeche = 0;
    public Quadrat(int flaeche) : base(flaeche)
    {
        flaeche = _flaeche;
    }

}
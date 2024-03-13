using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flächen;

public class Rechteck
{
    
    public virtual double GetFlaeche()
    {
        return _flaeche;
    }

    int _flaeche = 0;
    public Rechteck(int flaeche)
    {
        _flaeche = flaeche;
    }


}

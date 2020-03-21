using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.PourTous
{
    public interface IShipProp
    {

        //nombre de cases du bateau
        int NbSquare { get; set; }
       //nombre de cases touchées lors du combat
        int NbSquareTouch { get; set; }
    }
}

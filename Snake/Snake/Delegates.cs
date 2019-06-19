using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public delegate void YilanHareketiHandler(Snake yilan, ConsoleLocation kuyrukSonu, ConsoleLocation yilanBasi);
    public delegate void OyunBittiHandler(SnakeGame oyun);
    public delegate void YeminYeriDegistiHandler(Bait yem);
    public delegate void OyunBasliyorHandler(ConsoleLocation[] yilanGovdeKonumlari, ConsoleLocation yemKonumu);
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
    public class MacroEvent
    {
        EventType type;
        int time, locationX, locationY;

        public int Time { get => time; set => time = value; }
        public int LocationX { get => locationX; set => locationX = value; }
        public int LocationY { get => locationY; set => locationY = value; }
        public EventType Type { get => type; set => type = value; }
    }
    public enum EventType { Click, Wait }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSio860
{
    class Game
    {
       public static IntPtr BattleListStart = Client.BaseAddress + 0x23FEFC;

       static Memory m = new Memory(Client.Tibia);

        public static Player FindPlayer(string PlayerName)
        {
            for(int i = 0; i < 500; i++)
            {
                string name = m.ReadString(BattleListStart + (i * 0xA8), 25).ToLower(); // Offset 0xA8 differs from other clients, 9.60 ~ above is 0xDC
                if (name == PlayerName.ToLower())
                {
                    return new Player(BattleListStart + (i * 0xA8) - 0x4);
                }
            }
            return null;
        }

    }
}

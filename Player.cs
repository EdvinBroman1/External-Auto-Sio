<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSio860
{

    class Player
    {
        IntPtr StartAddress;
        Memory mem = new Memory(Client.Tibia);
        int _CreatureID;
        string _PlayerName;
        int _HealthProcent;

        Position _Pos;
        public Player(int cid, string name, int hpp, int x, int y, int z)
        {
            _CreatureID = cid;
            _PlayerName = name;
            _HealthProcent = hpp;
            _Pos = new Position(x, y, z);
        }
        public Player(IntPtr BaseAdr)
        {
            _CreatureID = mem.ReadInt32(BaseAdr);
            _PlayerName = mem.ReadString(BaseAdr + 0x4, 25);
            _HealthProcent = mem.ReadInt32(BaseAdr + 0x88);
            _Pos = new Position(mem.ReadInt32(BaseAdr + 0x24), mem.ReadInt32(BaseAdr + 0x28), mem.ReadInt32(BaseAdr + 0x2C));
            StartAddress = BaseAdr;
        }

        public string GetName
        {
            get
            {
                return _PlayerName;
            }
        }
        public int GetHealthProcent
        {
            get
            {
                _HealthProcent = mem.ReadInt32(StartAddress + 0x88);
                return _HealthProcent;
            }
        }
        public Position GetPosition
        {
            get
            {
                _Pos.x = mem.ReadInt32(StartAddress + 0x24);
                _Pos.y = mem.ReadInt32(StartAddress + 0x28);
                _Pos.z = mem.ReadInt32(StartAddress + 0x2C);
                return _Pos;

            }
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSio860
{

    class Player
    {
        IntPtr StartAddress;
        Memory mem = new Memory(Client.Tibia);
        int _CreatureID;
        string _PlayerName;
        int _HealthProcent;

        Position _Pos;
        public Player(int cid, string name, int hpp, int x, int y, int z)
        {
            _CreatureID = cid;
            _PlayerName = name;
            _HealthProcent = hpp;
            _Pos = new Position(x, y, z);
        }
        public Player(IntPtr BaseAdr)
        {
            _CreatureID = mem.ReadInt32(BaseAdr);
            _PlayerName = mem.ReadString(BaseAdr + 0x4, 25);
            _HealthProcent = mem.ReadInt32(BaseAdr + 0x88);
            _Pos = new Position(mem.ReadInt32(BaseAdr + 0x24), mem.ReadInt32(BaseAdr + 0x28), mem.ReadInt32(BaseAdr + 0x2C));
            StartAddress = BaseAdr;
        }

        public string GetName
        {
            get
            {
                return _PlayerName;
            }
        }
        public int GetHealthProcent
        {
            get
            {
                _HealthProcent = mem.ReadInt32(StartAddress + 0x88);
                return _HealthProcent;
            }
        }
        public Position GetPosition
        {
            get
            {
                _Pos.x = mem.ReadInt32(StartAddress + 0x24);
                _Pos.y = mem.ReadInt32(StartAddress + 0x28);
                _Pos.z = mem.ReadInt32(StartAddress + 0x2C);
                return _Pos;

            }
        }
    }
}
>>>>>>> b1f5faf1825734f3398dbf5cff4a14cd16caed66

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    internal class rooms
    {

        public int up;
        public int down;
        public int left;
        public int right;
        public int upRight;
        public int downRight;
        public int upLeft;
        public int downLeft;

        public string roomName;
        public string roomDesc;

        public rooms(int u, int d, int l, int r, int ur, int dr, int ul, int dl, string rn, string rd)
        {
            up = u;
            down = d;
            left = l;
            right = r;
            upRight = ur;
            downRight = dr;
            upLeft = ul;
            downLeft = dl;
            roomName = rn;
            roomDesc = rd;
        }
    }
}

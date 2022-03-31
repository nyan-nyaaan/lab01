using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABARATORNAYA
{
    internal class PositionName
    {
        int positionId;
        String name;

        public void setAll(int positionId, String name)

        {
            this.positionId = positionId;
            this.name = name;
        }
    }
}

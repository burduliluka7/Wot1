using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wot1
{
    public class TankFactory
    {
        public IEnumerable<Tank> Create(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return new Tank("", 1, 1, 1);
            }
        }
    }
}

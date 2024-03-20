using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._03
{
    public class ArrayProcessors
    {
        public delegate IEnumerable<int> ArrayProcessor(int[] array);
    }
}

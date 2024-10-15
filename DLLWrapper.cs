using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_useCpp
{
    internal class DLLWrapper
    {

        public float Sum(float[] array)
        {
            return DLLSum(array, array.Length);
        }

        [DllImport("CppSum.dll", EntryPoint = "ArraySum", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern float DLLSum(float[] array, int length);

    }
}

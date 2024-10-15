using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_useCpp
{
    internal class ArraySum
    {

        private float[] array;
        public float result;

        public void GenerateRandomArray(int length)
        {
            array = new float[length];

            Random random = new Random();

            for(var i = 0; i < array.LongLength; i++) {
                array[i] = (float)random.Next(0, 10);
            }
        }

        public string CSharpSum()
        {
            if (array == null) return @"Array is not generated";

            Stopwatch timer = new Stopwatch();
            timer.Start();

            result = 0;

            for (var i = 0; i < array.LongLength; i++)
            {
                result = result + array[i];
            }

            timer.Stop();

            return string.Format("Sum: {0}\nTime: {1}", result, timer.Elapsed);
        } 

        public string CppSum()
        {
            if (array == null) return @"Array is not generated";

            Stopwatch timer = new Stopwatch();
            timer.Start();

            result = 0;


            timer.Stop();

            return string.Format("Sum: {0}\nTime: {1}", result, timer.Elapsed);
        }
    }
}

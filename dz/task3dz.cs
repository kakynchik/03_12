// Task3dz.cs
namespace _03_12
{
    public class Task3dz
    {
        public void Execute()
        {
            int[] values = { 10, 5, 20, 30, 15, 20 };

            ArrayOperations3 arrayOps3 = new ArrayOperations3(values);
            Console.WriteLine("Distinct count: " + arrayOps3.CountDistinct());  // 5
            Console.WriteLine("Equal to 20: " + arrayOps3.EqualToValue(20));   // 2
        }
    }

    public class ArrayOperations3 : ICalc2
    {
        private int[] _array;

        public ArrayOperations3(int[] array)
        {
            _array = array;
        }

        public int CountDistinct()
        {
            var distinctValues = new HashSet<int>(_array);
            return distinctValues.Count;
        }

        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            foreach (var value in _array)
            {
                if (value == valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }

    public interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }
}
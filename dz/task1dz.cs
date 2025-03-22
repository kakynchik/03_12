// Task1dz.cs
namespace _03_12
{
    public class Task1dz
    {
        public void Execute()
        {
            int[] values = { 10, 5, 20, 30, 15, 20 };
            
            ArrayOperations arrayOps = new ArrayOperations(values);
            Console.WriteLine("Less than 15: " + arrayOps.Less(15));  // 3
            Console.WriteLine("Greater than 15: " + arrayOps.Greater(15));  // 2
        }
    }

    public class ArrayOperations : ICalc
    {
        private int[] _array;

        public ArrayOperations(int[] array)
        {
            _array = array;
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (var value in _array)
            {
                if (value < valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (var value in _array)
            {
                if (value > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }

    public interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }
}
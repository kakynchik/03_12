// Task2dz.cs
namespace _03_12
{
    public class Task2dz
    {
        public void Execute()
        {
            int[] values = { 10, 5, 20, 30, 15, 20 };
            
            ArrayOperations2 arrayOps2 = new ArrayOperations2(values);
            Console.WriteLine("Even numbers:");
            arrayOps2.ShowEven();  // 10, 20, 30, 20
            Console.WriteLine("Odd numbers:");
            arrayOps2.ShowOdd();   // 5, 15
        }
    }

    public class ArrayOperations2 : IOutput2
    {
        private int[] _array;

        public ArrayOperations2(int[] array)
        {
            _array = array;
        }

        public void ShowEven()
        {
            foreach (var value in _array)
            {
                if (value % 2 == 0)
                {
                    Console.Write(value + " ");
                }
            }
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            foreach (var value in _array)
            {
                if (value % 2 != 0)
                {
                    Console.Write(value + " ");
                }
            }
            Console.WriteLine();
        }
    }

    public interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
    }
}
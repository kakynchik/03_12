namespace _03_12
{
    public class Task1Pr
    {
        public void Execute()
        {
            int[] values = { 10, 5, 20, 30, 15, 20 };
        }

        public class ArrayOperations : IOutput
        {
            private int[] _array;

            public ArrayOperations(int[] array)
            {
                _array = array;
            }
            
            public void Show()
            {
                Console.WriteLine("Array elements:");
                foreach (var value in _array)
                {
                    Console.Write(value + " ");
                }

                Console.WriteLine();
            }
            public void Show(string info)
            {
                Console.WriteLine("Array elements: " + info);
                foreach (var value in _array)
                {
                    Console.Write(value + " ");
                }

                Console.WriteLine();
            }
        }
        
        public interface IOutput
        {
            void Show(); 
            void Show(string info); 
        }
    }
}
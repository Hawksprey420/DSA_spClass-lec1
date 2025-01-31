namespace DSA_spClass_lec1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Enter the size of the array: ");
            int array_size = int.Parse(Console.ReadLine());

            int[] array1 = new int[array_size];

            Console.WriteLine("Enter the numbers:");

            for (int i = 0; i < array_size; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            if (array1.Length == array_size)
            {
                Console.WriteLine("Full.");
            }


            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }

            Console.WriteLine();

            for (int i = array1.Length -1 ; i >= 0; i--)
            {
                Console.WriteLine(array1[i]);
            }
        }
    }
}
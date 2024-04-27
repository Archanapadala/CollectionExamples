using System.Collections;

//non generic collections 

namespace CollectionExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("Initial Capacity " +al.Capacity);
            Console.WriteLine("Initial Count " + al.Count);
            al.Add(1); al.Add(2);
            al.Add(3);al.Add(4);
            al.Add(5);al.Add(6);
            Console.WriteLine("After Capacity "+al.Capacity);
            Console.WriteLine("After Count " + al.Count);
            Console.WriteLine("Elemets are ");
            foreach (var item in al)
            {
                Console.WriteLine(" " + item);
            }


        }
    }
}

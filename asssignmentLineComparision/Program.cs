namespace asssignmentLineComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("chooes option\n1.length calculation\n2.line equlity");
            int opt=Convert.ToInt32(Console.ReadLine());

            switch(opt)
            {
                case 1:lengthcalculation.lenght();
                    break;
               case 2:lineEqulity.lenghtLineEqulity();
                    break;
            }

        }  
    }
}
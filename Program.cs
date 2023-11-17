namespace Labb_1_h23vilmu_GIK299
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Familjemedlem 1
            Console.WriteLine("Skriv namnet på familjemedlem 1.");
            string personOne = Console.ReadLine();
            Console.WriteLine("Skriv även ålder.");
            string personOneAgestr = Console.ReadLine();
            int personOneAge = Convert.ToInt32(personOneAgestr);
            Console.WriteLine("");


            //Familjemedlem 2
            Console.WriteLine("Skriv namnet på familjemedlem 2.");
            string personTwo = Console.ReadLine();
            Console.WriteLine("Skriv även ålder.");
            string personTwoAgestr = Console.ReadLine();
            int personTwoAge = Convert.ToInt32(personTwoAgestr);
            Console.WriteLine("");


            //Familjemedlem 3
            Console.WriteLine("Skriv namnet på familjemedlem 3.");
            string personThree = Console.ReadLine();
            Console.WriteLine("Skriv även ålder.");
            string personThreeAgestr = Console.ReadLine();
            int personThreeAge = Convert.ToInt32(personThreeAgestr);
            Console.WriteLine("");


            //Familjemedlem 4
            Console.WriteLine("Skriv namnet på familjemedlem 4.");
            string personFour = Console.ReadLine();
            Console.WriteLine("Skriv även ålder.");
            string personFourAgestr = Console.ReadLine();
            int personFourAge = Convert.ToInt32(personFourAgestr);
            Console.WriteLine("");


            //Sammanställning av åldrarna
            Console.WriteLine(personOne + " är " + personOneAge + " år gammal.");
            Console.WriteLine(personTwo + " är " + personTwoAge + " år gammal.");
            Console.WriteLine(personThree + " är " + personThreeAge + " år gammal.");
            Console.WriteLine(personFour + " är " + personFourAge + " år gammal.");
            Console.WriteLine("");

            //Total åldern för alla medlemmar
            int totalAge = personOneAge + personTwoAge + personThreeAge + personFourAge;
            Console.WriteLine("Sammanlagda åldern är: " + totalAge + " år.");

            //Medel ålder för alla medlemmar
            double avrageAge = totalAge / 4.0;
            Console.WriteLine("Medel ålder är: " + avrageAge.ToString("##.00")  + " år.");





            Console.ReadKey();
        }
    }
}
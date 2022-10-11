
namespace SuperDevOps
{
    internal class Program
    {
       


        
      
        public static void Main(string[] args)
        {
            DelegatenKlasse.WeiterleitenAnProgramklasse();
            
            LambdaAusdrücken.Begrüßung('A');
            string[] words = { "apple", "strawberry", "grape", "peach", "banana" };
            var wordQuery = from word in words
                            where word[0] == 's'
                            select word;
            foreach (var item in wordQuery)
            {
                Console.WriteLine(item);
            }


        }
    }
}
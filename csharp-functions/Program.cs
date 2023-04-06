namespace csharp_functions
{
    internal class Program
    {
        static void Main()
        {   
            // int[] array = new int[] { 2, 6, 7, 5, 3, 9 };
            

            //INIZIO BONUS

            //dichiaro lunghezza array da riempire
            int arrayLength;

            //chiedo all'utente la lunghezza dell'array
            Console.WriteLine("Quanti numeri vuoi inserire nell'array?");
            while (!int.TryParse(Console.ReadLine(), out arrayLength))
                Console.WriteLine("Inserisci un VERO numero");

            //creo un array con la lunghezza
            int[] array = CreaArray(arrayLength);

            //Chiedo all'utente di inserire i numeri nell'array
            InserisciNumeriArray(array);

            //stampa array
            StampaArray("Array Iniziale",array);

            //creo nuovo array con gli elementi dell'array precedente elevati al quadrato
            int[] arrayCopy = ElevaArrayAlQuadrato(array);
            //FINE BONUS

            //stampo nuovo array
            StampaArray("Array al quadrato", arrayCopy);

            //verifico che l'array originario sia ancora lo stesso
            StampaArray("Array Iniziale non modificato", array);
            
            //sommo gli elementi dell array originario
            int sum = SommaElementiArray(array);

            //mostro la somma in console
            Console.WriteLine("Somma elementi array iniziale: " + sum);

            //mostro la somma degli elementi al quadrato in console
            Console.WriteLine("Somma array quadrato: " +  SommaElementiArray(arrayCopy));

        }

        public static void StampaArray(string definition,int[] array)
        {
            Console.Write(definition + " = [");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);

                if (i != array.Length - 1)
                    Console.Write(", "); 
            }
            Console.WriteLine("]");
        }

        public static int Quadrato(int n)
        {
            n *= n;

            return n;
        }

        public static int[] ElevaArrayAlQuadrato(int[] array)
        {
            int[] arrayCopy = (int[])array.Clone();

            for (int i = 0; i < arrayCopy.Length; i++)
            {
                arrayCopy[i]= Quadrato(arrayCopy[i]);
            }

            return arrayCopy;
        }

        public static int SommaElementiArray(int[] array)
        {
            int sum = 0;

            for (int i = 0;i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        //FUNZIONI BONUS
        public static int[] CreaArray(int length)
        {
            return new int[length];
        }

        public static void InserisciNumeriArray(int[] array)
        {
            for (int i = 0; i < array.Length ; i++)
            {
                Console.WriteLine($"Inserisci il {i + 1}° numero");
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                    Console.WriteLine("Inserisci un VERO numero");
            }
        }
    }
}
namespace onlyFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bemenet
            int wCount;
            int sCount;

            //Kimenet
            int count;

            //Beolvasás
            wCount = inString_outZtype("Ennyi varazslo(nyilvan egesz szam): ");
            sCount = inString_outZtype("Ennyi tantargy(nyilvan egesz szam): ");

            //Matrix deklaralas
            int[,] grades = new int[wCount+1, sCount+1];

            //Mátrix beolvasas
            matrixZtype(wCount, sCount, grades);

            //Megoldás

        }

        static int inString_outZtype (string inputText)
        {
            int data;
            //Ellenőrzéshez
            bool error;

            //Beolvasás megvalósítása
            do
            {
                inputText = Console.ReadLine ();
                error = !int.TryParse(inputText, out data);
                if (error)
                {
                    Console.WriteLine("nem egesz szam. ujra");
                }

            } while (error);
            return data;
        }

        static void matrixZtype(int row, int column, int[,] matrix)
        {
            //Matrix belovasasa
            for (int i = 1; i <= row; i++)
            { 
                for(int j = 1; j <= column; j++)
                {
                    matrix[i, j] = inString_outZtype("Add meg a(z)"+i+". tanulo"+j+". targyanak a jegyet!");
                }
            }

        }

        static void onlyFiveCount(int[] row)
        {
            for(int i = 1; i<=row.Length; i++)
            {
                if ()
                {

                }
            }
        }
    }
}
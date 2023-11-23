namespace MultiDimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // iki boyutlu diziler

            //ilk gösterim şekli köşeli parantezin içerisine iki adet boyut ekliyoruz. Bu boyutların uzunluğu tamamen bize bağlı tıpkı tıpkı normal bir arrayde arrayin uzunluğunu yazdığımız gibi burada da her boyuta birer maksimum uzunluk tanımlıyoruz. Sonra da önce 0. index'e yani x eksenine sonrada birinci boyuta yani y eksenine uzunlukları verip değerlerini alıyoruz. Burada oluşturduğumuz dizi bir dikdörtgen dizidir. Yani her bir satırda aynı adet eleman bulunur. 

            //int[,] array = new int[2, 3];
            //array[0, 0] = 1;
            //array[0, 1] = 2;
            //array[0, 2] = 3;
            //array[1, 0] = 4;
            //array[1, 1] = 5;
            //array[1, 2] = 6;

            //int[,] array =
            //{
            //    { 1, 2, 3 },
            //    { 4, 5, 6 }
            //};

            //Console.WriteLine(array[1, 0]);

            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        Console.Write(array[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            // JaggedArray

            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[3];
            //jaggedArray[1] = new int[5];
            //jaggedArray[2] = new int[2];
            //jaggedArray[0][0] = 1;
            //jaggedArray[0][1] = 2;
            //jaggedArray[0][2] = 3;
            //jaggedArray[1][0] = 4;
            //jaggedArray[1][1] = 5;
            //jaggedArray[1][2] = 6;
            //jaggedArray[1][3] = 7;
            //jaggedArray[1][4] = 8;
            //jaggedArray[2][0] = 9;
            //jaggedArray[2][1] = 10;


            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write(jaggedArray[i][j] + "\t");
            //    }
            //    Console.WriteLine();
            //}


            int[][] sinemaSalonu = new int[3][];
            sinemaSalonu[0] = new int[10];
            sinemaSalonu[1] = new int[12];
            sinemaSalonu[2] = new int[8];

            Random random = new Random();

            for (int i = 0; i < sinemaSalonu.Length; i++)
            {
                for (int j = 0; j < sinemaSalonu[i].Length; j++)
                {
                    sinemaSalonu[i][j] = random.Next(0, 2);
                }
            }

            for (int i = 0; i < sinemaSalonu.Length; i++)
            {
                for (int j = 0; j < sinemaSalonu[i].Length; j++)
                {
                    Console.Write($"Sıra: {i + 1}, Koltuk: {j + 1}: ");
                    Console.WriteLine(sinemaSalonu[i][j] == 1 ? "Dolu" : "Boş");
                }
            }
        }
    }
}

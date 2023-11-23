namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Listler collectionlar olarak adlandırılan yapının bir elemanıdır.
            List<int> sayilar = new List<int>();

            // Bu diziye nasıl eleman ekleriz.
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] x = { 2, 4554, 75, 7 };
            //sayilar.AddRange(x);
            //sayilar.AddRange(new int[] {5,9,12});

            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            // Listenin uzunluğu için count metodu kullanılır.
            //Console.WriteLine(sayilar.Count);

            // Listenin içerisinde bir elemanın olup olmadığını kontrol eden metod
            //bool isExist = sayilar.Contains(1);
            //Console.WriteLine(isExist);


        }
    }
}

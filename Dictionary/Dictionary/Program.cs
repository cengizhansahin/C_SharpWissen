namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary dediğimiz sınıf aslında bir anahtar kilit(değer) çiftlerini saklamak için kullanılan bir değer yapıdır. Her anahtar için aslında generic TKey oluşturulur, buna karşılık gelen bir TValue olur. Hızlı erişim sağlamak için hash table kullanılır.

            /* Add --> yeni bir anahtar kilit ekler.
             * Remove --> belli bir anahtar kilidi siler
             * TryGetValue --> bir anahtarı var mı yok mu inceler
             * ContainsKey --> bir anahtarın o dictionary içinde olup olmadığına bakar
             * ContainsValue --> bir kilidin bir değerin var mı yok mu suna bakar.
             * Count --> toplam eleman sayısı
             * Keys --> tüm anahtarların dönmesini sağlar
             * Values --> tüm değerlerin dönmesini sağlar
             */

            Dictionary<string, int> yaslar = new Dictionary<string, int>();
            yaslar.Add("Erkin", 36);
            yaslar.Add("Barbaros", 31);
            yaslar.Add("Niyazi", 23);

            //if (yaslar.ContainsKey("Erkin"))
            //{
            //    int age = yaslar["Erkin"];
            //    Console.WriteLine($"Erkinin yaşı: {age}");
            //}
            //yaslar.Remove("Niyazi");

            //foreach (KeyValuePair<string, int> item in yaslar)
            //{
            //    Console.WriteLine($"Name: {item.Key}, Age: {item.Value}");
            //}


            //Eğer ki if kısmında değeri yakalayabilirse out diyerek onu bir değişken ismi vererek dışarı fırlatıyor, eğer ki yakalayamazsa bu durum false dönüyor gibi düşünerek else bloğuna giriyor ve istediğinz kodu yazdırıyor.

            if (yaslar.TryGetValue("Erkin", out int erkinYas))
            {
                Console.WriteLine($"Erkin's Age: {erkinYas}");
            }
            else
            {
                Console.WriteLine("Erkin yaşsız");
            }

        }
    }
}

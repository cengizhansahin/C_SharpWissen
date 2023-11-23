using System.Reflection;
using System.Threading.Channels;

namespace StringMetodları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string text = "Hello 502";
            //Console.WriteLine(text.Length);
            //Console.WriteLine(text.Substring(0,5));

            //bool varMi = text.Contains("Hello");
            //Console.WriteLine(varMi);

            //int index = text.IndexOf('e');
            //Console.WriteLine(index);

            //Console.WriteLine(text.ToUpper());
            //Console.WriteLine(text.ToLower());

            //Console.WriteLine(text.Replace("Hello","Merhaba"));
            //Console.WriteLine(text.Length);
            //Console.WriteLine(text.Trim().Length);

            //string yazi = "HTML,CSS,JavaScript,React,Redux,Postman,Bootstrap,Tailwind,JQuery,NodeJS";
            //string[] dizi = yazi.Split(',');
            //Array.ForEach(dizi, (d) => { Console.WriteLine(d); });

            //Console.WriteLine(text.Trim().StartsWith("Hel"));
            //Console.WriteLine(text.Trim().EndsWith("2"));

            //string inserted = text.Insert(9, "!!!!");
            //Console.WriteLine(inserted);

            //string removed = text.Remove(6,3);
            //Console.WriteLine(removed);


            //kullanıcıdan bir email isteyen ve bu adresin geçerli mi yoksa geçersiz mi olduğunu fonksiyonlar aracılığıyla tespit eden, geçerli olamsı için içerisinde '@' ifadesinin geçmesini zorunlu kılan, aynı zamanda @ işaretinden sonra . gelmesini zorunlu kılan bir validasyon hazırlayın.


            Console.Write("Lütfen email adresinizi giriniz: ");
            string email = Console.ReadLine();

            if (EmailKontrol(email))
            {
                Console.WriteLine($"Giriş durumu: {EmailKontrol(email)}\nTebrikler giriş başarılı!");
            }
            else
            {
                Console.WriteLine($"Giriş durumu: {EmailKontrol(email)}\nLütfen geçerli bir email adresi giriniz!");
            }
        }
        public static bool EmailKontrol(string email)
        {
            bool varMi = email.Contains("@");
            if (varMi)
            {
                int indexNo = email.IndexOf("@");
                bool varMi2 = email.Substring(indexNo).Contains(".");
                if (varMi2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

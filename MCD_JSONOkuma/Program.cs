using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MCD_JSONOkuma
{
    class Program
    {
        static void Main(string[] args)
        {
            string JsonOkunanData = File.ReadAllText("c:\\JsonIslemlerim\\Personellerim.json");
            List<Personel> Data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Personel>>(JsonOkunanData);
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(Data[i].ID);
                Console.WriteLine(Data[i].Isim);
                Console.WriteLine(Data[i].Soyisim);
                Console.WriteLine(Data[i].TelefonNumarasi);
                Console.WriteLine(Data[i].Sehir);
            }

            Console.ReadLine();
        }
    }
}

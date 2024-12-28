using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Collection
{
    public class Dictionary
    {
        public  void  AlphabetDictionary()
        {
            Dictionary<char, string> alphabetsStands = new Dictionary<char, string>();
            {
                alphabetsStands.Add('A' , "Apake");
                alphabetsStands.Add('B' ,  "Bella");
                alphabetsStands.Add('C' , "Canet");
                alphabetsStands.Add('D' , "Dior");
                alphabetsStands.Add('E' , "Eko");
                alphabetsStands.Add('f' , "Fendi");
                alphabetsStands.Add('G' , "Gectha");
                alphabetsStands.Add('H' , "Hello");
                alphabetsStands.Add('I' , "Ink");
                alphabetsStands.Add('J' , "Jpa");
                alphabetsStands.Add('K' , "Kasablanca");
                alphabetsStands.Add('L' , "Leopard");
                alphabetsStands.Add('M' , "Mount");
                alphabetsStands.Add('N' , "Nunez");
                alphabetsStands.Add('O' , "Osapolo");
                alphabetsStands.Add('P' , "Papa");
                alphabetsStands.Add('Q' , "Quick");
                alphabetsStands.Add('R' , "Raza");
                alphabetsStands.Add('S' , "Sapele");
                alphabetsStands.Add('T' , "Tatoo");
                alphabetsStands.Add('U' , "Umbrella");
                alphabetsStands.Add('V' , "Vamos");
                alphabetsStands.Add('W' , "Wike");
                alphabetsStands.Add('X' , "Xyndie");
                alphabetsStands.Add('Y' , "Yepe");
                alphabetsStands.Add('Z' , "Zabby");

                int count = 0;

                foreach (var text in alphabetsStands)
                {
                    count++;
                    Console.WriteLine($"{count}. {text.Key} for {text.Value}");
                }
        
            }

        }

    }
}
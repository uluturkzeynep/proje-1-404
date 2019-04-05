﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOyunu
{
    class AI : Oyuncu
    {
        public AI(string zorlukderecesi, string tahmini) : base(zorlukderecesi, tahmini)
        {
            
        }
        Random r = new Random();
        string[] kolay = Kelime.kolayKelimeGonder();
        string [] orta = Kelime.ortaKelimeGonder();
        string[] zor = Kelime.zorKelimeGonder();


        public static string[] rasgeleKolay = new string[10];
        public static string[] rasgeleOrta = new string[10];
        public static string[] rasgeleZor = new string[10];

        public static string[] secilenKelime = new string[10];

        public string kelimeSec()
        {
            if (zorlukderecesi == "kolay")
            {
                for (int i = 0; i < 10; i++)
                {
                    int randomIndex = r.Next(0, kolay.Length);
                    secilenKelime[i] = kolay[randomIndex];
                }
                Console.WriteLine(secilenKelime);
                Console.WriteLine(zorlukderecesi);
                //return rasgeleKolay[];
            }

            else if (zorlukderecesi == "orta")
            {
                for (int i = 0; i < 10; i++)
                {
                    int randomIndex = r.Next(0, orta.Length);
                    secilenKelime[i] = orta[randomIndex];
                }
                //return rasgeleOrta[];
            }

            else if (zorlukderecesi == "zor")
            {
                for (int i = 0; i < 10; i++)
                {
                    int randomIndex = r.Next(0, zor.Length);
                   secilenKelime[i] = zor[randomIndex];
                }
                //return rasgeleZor[];
                return secilenKelime[];
            }
            else Console.WriteLine("Yanlış seçim yaptınız"); return "";
        }
        
        public void ipucuVer(string tahmini,string kelime)
        {     
            char[] tahminChar = tahmini.ToCharArray();
            char[] kelimeChaar = kelime.ToCharArray();
            if (tahmini == kelime)
            {
                Console.WriteLine("Doğru bildiniz tebrikler!!");

            }
            else
            {
                for(int i = 0; i < tahminChar.Length; i++)
                {
                    for(int j=0; j < kelimeChaar.Length; j++)
                    {
                        if(tahminChar[i]==kelimeChaar[j])
                        {
                            if(i==j)
                            {
                                Console.WriteLine("Eşlesme sağlayan karakterler= {0}", tahminChar[i]);
                            }
                        }
                        
                    }
                }

                for (int i = 0; i < tahminChar.Length; i++)
                {
                    for (int j = 0; j < kelimeChaar.Length; j++)
                    {
                        if (tahminChar[i] == kelimeChaar[j])
                        {
                                Console.WriteLine("Sözcükten yer alan karakterler= {0} ", tahminChar[i]);
                        }
                    }
                }
            }
        }
    }
}
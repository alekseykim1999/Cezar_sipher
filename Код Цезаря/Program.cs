using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_Цезаря
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = 1;
            List<string> masive = new List<string>{ "a","б","в","г","д","е","ж","з","и","к","л","м","н","о","п","р","с","т","у","ф","х","ц","ч","ш","щ","ъ","ы","э","ю","я"};
            string word = "ТБВРЭФРАВЭЛЕЪАШЯВЮУАРДШЗХБЪШЕБШБВХЬРЕШБЯЮЫМЧГХВБП ЮФШЭШВЮВЦХЪЫОЗШФЫПИШДАЮТРЭШПШФЫПАРБИШДАЮТЪШ";
            Console.WriteLine(word);

            for(int i=0;i<32;i++)
            {
                
                string ans= "";
                foreach(var ss in word)
                {
                    if(masive.Contains(ss.ToString().ToLower()))
                    {
                        int x = masive.IndexOf(ss.ToString().ToLower());
                        int check = x - key;
                        if (check < 0)
                        {
                            
                           ans += masive[masive.Count + check];
                            
                            
                        }
                        else
                        {
                            ans += masive[check];
                        }


                    }
                    if(ss.ToString()==" ")
                    {
                        ans += " ";
                    }

                }
                Console.WriteLine(ans);
                key++;

            }

            Console.ReadLine();

        }
    }
}

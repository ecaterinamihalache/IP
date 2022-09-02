/******************************************************************************************/
/* 
 * Autor: Ichim Ioana
 * Comentarii: Radion Claudia
*/
/******************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*! \namespace Processing
 */
namespace Processing
{
    /* ! \class Procesare
     *   \brief Clasă pentru procesarea cuvintelor din dicționar cu diacritice
     */
    public class Procesare
    {
        /* Metodă publică statică pentru Căutarea unui anumit cuvânt fără diacritice */
        public static List<string> Cautare(string cuvant, List<string> chei)
        {
            bool isVerb = false;
            if(cuvant != SimpleForm(cuvant))
            {
                isVerb = true;
            }

            int j = 0;
            while(j<chei.Count)
            {
                if(isVerb)
                {
                    if (chei[j].Length != cuvant.Length)
                    {
                        chei.RemoveAt(j);
                        j--;
                    }
                }
                else
                {
                    if (SimpleForm(chei[j]).Length != cuvant.Length)
                    {
                        chei.RemoveAt(j);
                        j--;
                    }
                }
                j++;
            }
            cuvant = SimpleForm(cuvant);

            for (int i = 0; i < cuvant.Length; ++i)
            {
               if( CanBeDiactritica(cuvant[i]))
               {
                    j = 0;
                    while(j < chei.Count) 
                    {
                        if (cuvant[i]=='a')
                        {
                            if(!(SimpleForm(chei[j])[i] == cuvant[i] || SimpleForm(chei[j])[i] == Diactritica('/')|| SimpleForm(chei[j])[i] == Diactritica(cuvant[i])))
                            {
                                chei.RemoveAt(j);
                                j--;
                            }
                        }
                        else
                        {
                            if (!(SimpleForm(chei[j])[i] == cuvant[i] || SimpleForm(chei[j])[i] == Diactritica(cuvant[i])))
                            {
                                chei.RemoveAt(j);
                                j--;
                            }
                        }
                        j++;
                    }
               }
               else
               {
                    j = 0;
                    while(j < chei.Count)
                    {
                        if(SimpleForm(chei[j])[i]!=cuvant[i])
                        {
                            chei.RemoveAt(j);
                            j--;
                        }
                        j++;
                    }
               }
            }
            return chei;
        }
        /* Metodă publică Diacritica pentru returnarea diacriticelor */
        public static char Diactritica(char litera)
        {
            switch (litera)
            {
                case 'a':return 'â';break;
                case 'i': return 'î'; break;
                case 's': return 'ș'; break;
                case 't': return 'ț'; break;
                default: return 'ă';
            }
        }
        /* Metodă publică CanBeDiacritică pentru căutarea literelor care pot fi dicritice (a, i, s, t) */
        public static bool CanBeDiactritica(char litera)
        {
            bool canBe = false;
           
            if (litera == 'a' || litera == 'i' || litera == 's' || litera == 't')
                canBe = true;
            return canBe;
        }
        /* Metodă publică SimpleForm */
        public static string SimpleForm(string cuvant)
        {
            if (cuvant.StartsWith("a se "))
                return cuvant.Remove(0, 5);
            else if (cuvant.StartsWith("a "))
                return cuvant.Remove(0, 2);
            else
                return cuvant;
        }
    }
}

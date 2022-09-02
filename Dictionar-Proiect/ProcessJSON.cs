/******************************************************************************************/
/* 
 * Autor: Moroșan Carla-Adriana
 * Comentarii: Radion Claudia
*/
/******************************************************************************************/

using Dict;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*! \namespace Dictionar_Proiect
 */
namespace DictionarProiect
{
    /* ! \class ProcesareJSON
     *   \brief Clasă pentru procesarea fișierului JSON
     */
    class ProcessJSON
    {
        private const string _Path = "dictionar.json";
        /*! \function Metodă publică statică care returnează un dicționar care conține informațiile din fișierul JSON */
        public static Dictionary<string, DefinitionList> PopulareJSON()
        {
            return JsonConvert.DeserializeObject<Dictionary<string, DefinitionList>>(File.ReadAllText(_Path));
        }
    }
}

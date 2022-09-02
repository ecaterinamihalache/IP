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
    /* ! \class ModifyOberver
    *   \extends Observer
    *   \brief Modifică oberverul
    */
    class ModifyObserver : Observer
    {
        /* Constructor */
        public ModifyObserver(Dictionar dictionar, MainForm formular) : base(dictionar,formular) 
        {
            _dictionar.AdaugaObserver(this);
        }
        /* Metodă de actualizare a fișierului JSON */
        public override void UpdateJsonFile()
        {
            if(_dictionar.UltimaOp == UltimaOperatie.modifica)
            {
                //adauga cod modificare json
                Dictionary<string, DefinitionList> dict = _dictionar.GetDictionary();
                string jsonString = JsonConvert.SerializeObject(dict, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("dictionar.json", jsonString);

                //dupa ce am efectuat operatia, resetez ultima operatie pentru a nu intra intr-o bucla 
                _formular.SetStatusControl("Cuvânt modificat cu succes!");
                _dictionar.UltimaOp = UltimaOperatie.none;
            }
        }
    }
}

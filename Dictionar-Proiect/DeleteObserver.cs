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
    /* ! \class DeleteObserver
     *   \extends Observer
     *   \brief Se șterge un observer
     */
    class DeleteObserver : Observer
    {
        /* Constructor */
        public DeleteObserver(Dictionar dictionar,MainForm formular) : base(dictionar,formular) 
        {
            _dictionar.AdaugaObserver(this); 
        }
        /* Metodă pentru actualizarea fișierului JSON*/
        public override void UpdateJsonFile()
        {
            if(_dictionar.UltimaOp == UltimaOperatie.sterge)
            {
                Dictionary<string, DefinitionList> dict = _dictionar.GetDictionary();
                string jsonString = JsonConvert.SerializeObject(dict, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("dictionar.json", jsonString);
                
                _formular.SetStatusControl("Cuvânt șters cu succes!");
                _formular.SetLabelNrWords(dict.Count.ToString() + " cuvinte");
                _dictionar.UltimaOp = UltimaOperatie.none;
            }
        }
    }
}

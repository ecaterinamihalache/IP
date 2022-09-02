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
using System.Windows.Forms;

/*! \namespace Dictionar_Proiect
 */
namespace DictionarProiect
{
    /*! \class AddObserver 
     *  \extends Observer
     *  \brief Se adaugă un observer nou
     */
    public class AddObserver : Observer
    {
        /* Constructor */
        public AddObserver(Dictionar dictionar,MainForm formular) : base(dictionar,formular) 
        {
            _dictionar.AdaugaObserver(this);
        }
        /* Metodă pentru actualizarea fișierului JSON */
        public override void UpdateJsonFile()
        {
            if(_dictionar.UltimaOp == UltimaOperatie.adauga)
            { 
                Dictionary<string, DefinitionList>  dict = _dictionar.GetDictionary();
                string jsonString = JsonConvert.SerializeObject(dict, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("dictionar.json", jsonString);
                
                _formular.SetStatusControl("Cuvânt adăugat cu succes: "+ ",," + dict.Last().Key + '"' + "!");
                _formular.SetLabelNrWords(dict.Count.ToString() + " cuvinte");
                _dictionar.UltimaOp = UltimaOperatie.none;
            }
        }
    }
}

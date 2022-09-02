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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*! \namespace Dictionar_Proiect
 */
namespace DictionarProiect
{
    /* ! \class Observer
     *   \brief Clasă abstractă Observer care ajută la implementarea șablonului Observer
     */
    public abstract class Observer
    {
        
        protected Dictionar _dictionar;  //! membru protected _dictionar
        protected MainForm _formular;  //! membru protectede _formular
        /* Contructor - inițializarea membrilor */
        public Observer(Dictionar dictionar,MainForm formular)
        {
            _dictionar = dictionar;
            _formular = formular;
        }
        /* Metodă abstractă pentru actualizarea fișierului JSON */
        public abstract void UpdateJsonFile();
    }
}

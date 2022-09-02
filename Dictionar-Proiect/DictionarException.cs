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

/*! \namespace DictionarProiect
 */
namespace DictionarProiect
{
    /* ! \class DictionarException
    *   \extends Exception
    *   \brief Clasă pentru tratarea excepțiilor în cadrul dicționarului
    */
    class DictionarException : Exception
    {
        private string _message;  //! membru privat string _message - reține un anumit mesaj pentru returnarea excepțiilor
        private string _cuvant;  //! membru privat string _cuvânt - reține pe rând anumite cuvinte din dicționar

        /* Get-erul pentru mesajul de eroare */
        public string Message
        {
            get
            {
                if (_cuvant == "")
                    return (_message + ".");
                else
                    return (_message + ":\'" + _cuvant + "\'.");
            }
        }
        /* Constructor - inițializarea membrilor*/
        public DictionarException(string message, string cuvant)
        {
            _message = message;
            _cuvant = cuvant;
        }

    }
}

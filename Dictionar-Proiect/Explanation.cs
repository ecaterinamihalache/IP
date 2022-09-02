/******************************************************************************************/
/* 
 * Autor: Moroșan Carla-Adriana
 * Comentarii: Radion Claudia
*/
/******************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*! \namespace Dictionar_Proiect
 */
namespace DictionarProiect
{
    /* ! \class Explanation
    *   \brief Clasa pentru tratarea definiției unui cuvânt (parte de vorbire + explicație)
    */
    public class Explanation
    {
        private string _parte;  //! membru privat string - conține partea de vorbire
        private string _explicatie;  //! membru privat string - conține explicația cuvântului
        
        /* Constructor -  inițializează membrii clasei */

        public Explanation(string parte, string explicatie)
        {
            _parte = parte;
            _explicatie = explicatie;
        }
        /* Get-erul și Set-erul pentru partea de vorbire */
        public string Parte
        {
            get { return _parte;  }
            set { _parte = value; }
        }
        /* Get-erul și Set-erul pentru explicație */
        public string Explicatie
        {
            get { return _explicatie;  }
            set { _explicatie = value; }
        }
        /* Metodă suprascrisă ToString() */
        public override string ToString()
        {
            return Parte + ";   " + Explicatie;
        }
    }
}

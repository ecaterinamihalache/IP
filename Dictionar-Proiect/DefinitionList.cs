/******************************************************************************************/
/* 
 * Autor: Moroșan Carla-Adriana
 * Comentarii: Radion Claudia
*/
/******************************************************************************************/
using DictionarProiect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*! \namespace Dict
 */
namespace Dict
{
    /*! \class DefinitionList 
        \brief Clasa care conține dicționarul și procesările făcute pe acesta 
     */
    public class DefinitionList
    {
        private List<Explanation> _definitii;

        /* Constructor */
        public DefinitionList(List<Explanation> definitions)
        {
            _definitii = definitions;
        }

        /* Get și Set pentru membrul _definitions */
        public List<Explanation> Definitii
        {
            get { return _definitii; }
            set { _definitii = value; }
        }

        /* Metodă publică pentru Adăugarea unei definiții */
        public void AddDefinition(Explanation def)
        {
            _definitii.Add(def);
        }

        /* Metodă publică pentru Extragerea unei explicații */
        public Explanation GetExplanation(int index)
        {
            if (index < _definitii.Count)
                return _definitii[index];
            else
                throw new Exception("Index in afara intervalului");
        }

        /* Metodă publică pentru Actualizarea unei definiții */
        public void UpdateDefinition(int indexDef, string newPart, string newDef)
        {
            if (indexDef < _definitii.Count)
            {
                _definitii[indexDef].Parte = newPart;
                _definitii[indexDef].Explicatie = newDef;
            }
            else
                throw new Exception("Index in afara intervalului");
            
        }
        /* Metodă publică pentru Ștergerea unei definiții */
        public void RemoveDefinition(int indexDef)
        {
            if (indexDef < _definitii.Count)
                _definitii.RemoveAt(indexDef);
        }
        /* Metodă pentru reprezentarea sub formă de string a listei de definiții a unui cuvânt */
        public override string ToString()
        {
            string listaExplicatii = "";

            for(int i = 0; i < _definitii.Count; i++)
            {
                listaExplicatii += _definitii[i].ToString() + '\n';
            }

            return listaExplicatii;
        }
       
    }
}

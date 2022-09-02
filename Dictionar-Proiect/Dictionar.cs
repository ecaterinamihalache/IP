/******************************************************************************************/
/* 
 * Autori: 
 * Moroșan Carla-Adriana - Clasa Dictionar, constructor, implementare Singleton, metoda CautaDefinitie
 * Mihalache Nicoleta-Ecaterina - metoda AddWord
 * Ichim Ioana - metoda UpdateWord,NewWordDefinition, AddFromExcel
 * Radion Claudia - metoda DeleteWord, comentarii
*/
/******************************************************************************************/
using DictionarProiect;
using Processing;
using System.Collections.Generic;
using System.Text.RegularExpressions;
/*! \namespace Dict
 */
namespace Dict
{
    /*! \enum UltimaOperatie
    *  \brief Se reține dacă ultima operație a fost de adăugare, ștergere, modificare
    *      sau nu s-a realizat nicio operație anterior
    */
    public enum UltimaOperatie { adauga, sterge, modifica, none};
    /*! \class Dictionar
      *  \implements IDictionar
      *  \brief Se realizează toate acțiunile asupra dicționarului
      */
    public class Dictionar : IDictionar
    {
        private static Dictionar _instance; //! membru privat static Dictionar - instanța pentru Singleton
        private Dictionary<string, DefinitionList> _dictionary;  /*! membru privat de tip Dictionary care are ca și cheie 
                                                                 * un string conectat la DefinitionList*/


        private UltimaOperatie _ultimaOperatie;  /*! membru privat - obiect enum UltimaOperati */
        private List<Observer> _observers;  //! membru privat - listă de oberveri 
        private MainForm _formular;  //! membru privat de tip MainForm


        /* Constructor - inițializează membrii clasei */
        private Dictionar(MainForm formular)
        {
            _dictionary = ProcessJSON.PopulareJSON();
            _formular = formular;

            _ultimaOperatie = UltimaOperatie.none;

            _observers = new List<Observer>();
            _observers.Add(new AddObserver(this,_formular));
            _observers.Add(new DeleteObserver(this,_formular));
            _observers.Add(new ModifyObserver(this,_formular));
        }
        /* Metodă pentru crearea unei instanțe */
        public static Dictionar Instance(MainForm formular)
        {
            if (_instance == null)
                _instance = new Dictionar(formular);
            return _instance;
        }
        /* Get-erul si set-erul pentru membrul _ultimaOperație */
        public UltimaOperatie UltimaOp
        {
            get
            {
                return _ultimaOperatie; ;
            }

            set
            {
                _ultimaOperatie = value;
            }
        }
        /* Metodă pentru adăugarea unui nou cuvânt în dicționar */
        public void AddWord(string cuvant, string parte, string explicatie)
        {
            Explanation explication = new Explanation(parte, explicatie);

            List<Explanation> listaDef = new List<Explanation>();
            listaDef.Add(explication);

            DefinitionList def = new DefinitionList(listaDef);
            _dictionary.Add(cuvant, def);

            _ultimaOperatie = UltimaOperatie.adauga;
            NotificaObserveri(_observers);
        }
        /* Metodă pentru ștergerea unui cuvânt din dicționar */
        public void DeleteWord(string cuvant)
        {
            _dictionary.Remove(cuvant);
            _ultimaOperatie = UltimaOperatie.sterge;

            NotificaObserveri(_observers);
        }
        /* Metodă pentru ștergerea unei definiții asociată unui anumit cuvânt din dicționar */
        public void DeleteDefinition(string cuvant, int indexDef)
        {
            _dictionary[cuvant].RemoveDefinition(indexDef);
            _ultimaOperatie = UltimaOperatie.modifica;

            NotificaObserveri(_observers);
        }
        /* Metodă pentru actualizarea unui cuvânt în dicționar */
        public void UpdateWord(string key, int indexDefinition, string part, string def)
        {
            _dictionary[key].UpdateDefinition(indexDefinition, part, def);
            _ultimaOperatie = UltimaOperatie.modifica;

            NotificaObserveri(_observers);
        }
        /* Metodă pentru găsirea unei definiții asociată unui cuvânt */
        public DefinitionList GetDefinitions(string cuvant)
        {
            if (_dictionary.ContainsKey(cuvant))
                return _dictionary[cuvant];
            else
                return null;
        }
        /* Metodă pentru verificarea existenței unui cuvânt în dicționar */
        public bool WordExists(string cuvant)
        {
            List<string> cuvinte = Procesare.Cautare(cuvant, this.GetCuvinte());

            for (int i = 0; i < cuvinte.Count; i++)
            {
                if(_dictionary.ContainsKey(cuvinte[i]))
                {
                    return true;
                }
            }
            return false;
        }
        /* Metodă pentru adăugarea unei noi definiții asociată unui cuvânt */
        public void NewWordDefinition(string key, string part, string def)
        {
            _dictionary[key].AddDefinition(new Explanation(part, def));
            _ultimaOperatie = UltimaOperatie.modifica;

            NotificaObserveri(_observers);
        }
        /* Metodă pentru returnarea listei de cuvinte */
        public List<string> GetCuvinte()
        {
            List<string> keyList = new List<string>(this._dictionary.Keys);
            keyList.Sort();

            return keyList;
        }
        /* Metode pentru implementarea șablonului Oberver */
        public void AdaugaObserver(Observer observer)
        {
            _observers.Add(observer);
        }

        public void StergeObserver(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void NotificaObserveri(List<Observer> observers)
        {
            for(int i = 0; i < observers.Count; i++)
            {
                observers[i].UpdateJsonFile();
            }
        }
        /* Metodă pentru retunarea unei instanțe de dicționar */
        public Dictionary<string, DefinitionList> GetDictionary()
        {
            return Instance(_formular)._dictionary;
        }
        /* Metodă publică pentru încărcarea dicționarului dintr-un fișier Excel */
        public void AddFromExcel(string path,int sheet,int columnWord, int columnPart,int columnExplanation, int rowBegin,int RowFinish)
        {
            ExcelData.ExcelContent excel = new ExcelData.ExcelContent(path, sheet);

            for (int i=rowBegin;i<RowFinish;i++)
            {
                string cuvant, parte, explicatie;
                cuvant = excel.ReadCell(i, columnWord);
                parte = excel.ReadCell(i, columnPart);
                explicatie = excel.ReadCell(i, columnExplanation);
                //cuvintele nu trebuie sa aiba cifre asa ca acestea sunt eliminate
                cuvant = Regex.Replace(cuvant, @"[\d]", string.Empty);
                if (_dictionary.ContainsKey(cuvant))
                {
                     NewWordDefinition(cuvant, parte, explicatie);  
                }
                else
                {
                    AddWord(cuvant, parte, explicatie);
                }
            }
            excel.CloseExcelFile();
        }
    }
}

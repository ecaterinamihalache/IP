/******************************************************************************************/
/* 
 * Autor: Moroșan Carla-Adriana
 * Comentarii: Radion CLaudia
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
    /* ! \interface DeleteObserver
     *   \brief Interfața care ajută la implementarea șablonului observer
     */
    interface IDictionar
    {
        /* Prototipurile funcțiilor pentru implementarea șablonului Observer */
        void AdaugaObserver(Observer observer);
        void StergeObserver(Observer observer);
        void NotificaObserveri(List<Observer> observers);
    }
}

/******************************************************************************************/
/* 
 * Autori: 
 * Ichim Ioana
 * Mihalache Nicoleta-Ecaterina
 * Moroșan Carla-Adriana
 * Radion Claudia
 * 
 * Titlu: Dicționar explicativ - limba română
 */
/******************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*! \namespace Dict
 */
namespace Dict
{
    /* ! \class Program
     *   \brief Main-ul. Punctul de pornire al aplicației
     */
    static class Program
    {
        /* Funcția Main() - punctul de plecare al aplicației */
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

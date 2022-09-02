/******************************************************************************************/
/* 
 * Autori: 
 * Moroșan Carla-Adriana - CautaClicked, checkBox1_CheckedChanged
 * Mihalache Nicoleta-Ecaterina - buttonAddWord_Click, exitToolStripMenuItem_Click,
 *                  checkBox1_CheckedChanged, aboutToolStripMenuItem_Click, buttonClear_Click, helpToolStripMenuItem_Click, SetLabelNrWords
 * Claudia Radion - buttonDelete_Click, comentarii
 * Ichim Ioana - buttonModDef_Click, buttonSearchM_Click, buttonDeleteDef_Click, listBoxDefinitions_SelectedIndexChanged, ClearModify, buttonAddDef_Click, SetStatusControl
 * 
*/
/******************************************************************************************/
using DictionarProiect;
using System;
using System.Drawing;
using System.Windows.Forms;
using Processing;
using System.Collections.Generic;

namespace Dict
{
    /*! \Class MainForm 
      \brief Clasa care conține funcțiilede callback ale butoanelor din formular 
  */
    public partial class MainForm : Form
    {
        private Dictionar _dictionar;

        /*! Constructorul clasei MainForm
         * Implementarea șablonului de proiectare Singleton
         */
        public MainForm()
        {
            InitializeComponent();
            _dictionar = Dictionar.Instance(this);
        }

        
        /*! Funcție care tratează evenimentul Click al butonului Caută 
            Se caută cuvântul în Dicționar și dacă se găsește, se afișează definițiile asociate. 
        */
        private void CautaClicked(object sender, EventArgs e)
        {
            try
            {
                richTextBoxDefinitions.Clear(); //! inițial se sterge caseta pentru Definiție 

                string cuvant = textBoxSearch.Text.ToLower(); //! variabilă de tip string în care se stochează cuvântul de căutat
                DefinitionList def = null;
                if (cuvant == "")
                {
                    throw new DictionarException("Nu ați introdus niciun cuvânt", cuvant);
                }
                else if (!_dictionar.WordExists(cuvant))
                {
                    throw new DictionarException("Nu există în dicționar", cuvant);
                }
                else
                {
                    List<string> cuvinte = Procesare.Cautare(cuvant, _dictionar.GetCuvinte());

                    for(int i = 0; i < cuvinte.Count; i++)
                    {
                        def = _dictionar.GetDefinitions(cuvinte[i]);
                        if (def != null)
                        {
                            richTextBoxDefinitions.AppendText(cuvinte[i] + " = " + def.ToString());
                        }
                        else
                        {
                            throw new DictionarException("Listă de definiții goală ", cuvant);
                        }
                    }
                }

            }
            catch (DictionarException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*! Funcție care tratează evenimentul Click al butonului Adaugă 
            Se adaugă un cuvânt nou în dicționar cu posibilitatea de adăugare a unei noi definiții
               în cazul în care cuvântul introdus face parte deja din dicționar
         */
        private void buttonAddWord_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxWord.Text == "" && textBoxPart.Text == "" && textBoxDef.Text == "")
                {
                    MessageBox.Show("Atenție! Nu ați introdus date!");
                }
                else
                {
                    if (_dictionar.GetDefinitions(textBoxWord.Text.ToLower()) != null)
                    {
                        string message = "Cuvantul există în dicționar. Doriți să adăugați o nouă definiție?";
                        MessageBox.Show(message);
                        string title = "Adaugă Cuvânt Existent";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {
                            _dictionar.NewWordDefinition(textBoxWord.Text.ToLower(), textBoxPart.Text, textBoxDef.Text);
                            string afisare = textBoxWord.Text + " = " + textBoxPart.Text + ", " + textBoxDef.Text;
                            richTextBoxMessage.Text += afisare + '\n';
                        }
                    }
                    else
                    {
                        string message = "Cuvântul nu există în dicționar. Sigur doriți să adăugați informațiile de mai sus?";
                        string title = "Adaugă Cuvânt Neexistent";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {
                            //adauga in dictionar
                            _dictionar.AddWord(textBoxWord.Text.ToLower(), textBoxPart.Text, textBoxDef.Text);
                            string afisare = textBoxWord.Text + " : " + textBoxPart.Text + ", " + textBoxDef.Text;
                            richTextBoxMessage.Text += afisare + '\n';
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*! Funcție care tratează evenimentul Click al butonului Goleste din interfață
            Se sterg toate câmpurile din acest tab 
        */
        private void buttonClear_Click(object sender, EventArgs e) 
        {
            textBoxWord.Clear();
            textBoxPart.Clear();
            textBoxDef.Clear();
            richTextBoxMessage.Clear();
        }

        /*! Funcție care tratează evenimentul Click al butonului Ieșire
           Ieșire sigură din program cu un pas suplimentar de confirmare
       */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Doriți să ieșiți din program ?", "Ieșire", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /*! Funcție care tratează evenimentul checkBox-ului DarkMode
                Se oferă posibilitatea personalizării aplicației prin alegerea optiunii 
                cu nuanțe întunecate sau luminoase 
        */
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDark.Checked)
            {
                this.BackColor = Color.Silver;

                buttonSearch.BackColor = Color.FromArgb(34, 36, 49);
                buttonSearch.ForeColor = Color.White;

                richTextBoxDefinitions.BackColor = Color.Silver; 
                textBoxSearch.BackColor = Color.Silver; 

                aboutToolStripMenuItem.BackColor = Color.DimGray;
                helpToolStripMenuItem.BackColor = Color.DimGray;
                exitToolStripMenuItem.BackColor = Color.DimGray;

                menuStrip.BackColor = Color.DimGray; 
                panel1.BackColor = Color.DimGray;

                tabControlAdd.BackColor = Color.DimGray; 
                statusStrip1.BackColor = Color.DimGray; 

                textBoxWord.BackColor = Color.Silver; 
                textBoxPart.BackColor = Color.Silver; 
                textBoxDef.BackColor = Color.Silver; 
                richTextBoxMessage.BackColor = Color.Silver; 

                buttonAddWord.BackColor = Color.FromArgb(34, 36, 49); 
                buttonAddWord.ForeColor = Color.White;

                buttonClear.BackColor = Color.FromArgb(34, 36, 49); 
                buttonClear.ForeColor = Color.White;


                textBoxDelete.BackColor = Color.Silver;
                buttonDelete.BackColor = Color.FromArgb(34, 36, 49); 
                buttonDelete.ForeColor = Color.White;


                listBoxDefinitions.BackColor = Color.Silver;
                textBoxPartM.BackColor = Color.Silver; 
                textBoxToModify.BackColor = Color.Silver; 
                textBoxSearchM.BackColor = Color.Silver; 

                buttonSearchM.BackColor = Color.FromArgb(34, 36, 49);
                buttonSearchM.ForeColor = Color.White;

                buttonModDef.BackColor = Color.FromArgb(34, 36, 49);
                buttonModDef.ForeColor = Color.White;

                buttonDeleteDef.BackColor = Color.FromArgb(34, 36, 49);
                buttonDeleteDef.ForeColor = Color.White;

                buttonAddDef.BackColor = Color.FromArgb(34, 36, 49);
                buttonAddDef.ForeColor = Color.White;

                tabCautare.BackColor =Color.FromArgb(34, 36, 49);
                tabAdauga.BackColor = Color.FromArgb(34, 36, 49);
                tabModifica.BackColor = Color.FromArgb(34, 36, 49);
                tabSterge.BackColor = Color.FromArgb(34, 36, 49);

                labelCuvant_.ForeColor = Color.White;
                labelCuv.ForeColor = Color.White;
                labelCuvant.ForeColor = Color.White;
                labelParte.ForeColor = Color.White;
                labelDefinitie.ForeColor = Color.White;
                labelPartVb.ForeColor = Color.White;
                labelWord.ForeColor = Color.White;
                labelDefi.ForeColor = Color.White;

                checkBoxDark.ForeColor = Color.White;

                aboutToolStripMenuItem.ForeColor = Color.White;
                helpToolStripMenuItem.ForeColor = Color.White;
                exitToolStripMenuItem.ForeColor = Color.White;
                statusStrip1.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = DefaultBackColor;

                buttonSearch.BackColor = Color.Transparent;
                buttonSearch.ForeColor = Color.Black;

                richTextBoxDefinitions.BackColor = Color.White;

                textBoxSearch.BackColor = Color.White;

                textBoxWord.BackColor = Color.White;
                textBoxPart.BackColor = Color.White;
                textBoxDef.BackColor = Color.White;
                richTextBoxMessage.BackColor = Color.White;

                buttonAddWord.BackColor = Color.Transparent; 
                buttonAddWord.ForeColor = Color.Black;

                buttonClear.BackColor = Color.Transparent; 
                buttonClear.ForeColor = Color.Black;


                textBoxDelete.BackColor = Color.White;
                buttonDelete.BackColor = Color.Transparent;
                buttonDelete.ForeColor = Color.Black;

                listBoxDefinitions.BackColor = Color.White;
                textBoxPartM.BackColor = Color.White;
                textBoxToModify.BackColor = Color.White;
                textBoxSearchM.BackColor = Color.White;

                buttonSearchM.BackColor = Color.Transparent;
                buttonSearchM.ForeColor = Color.Black;

                buttonModDef.BackColor = Color.Transparent;
                buttonModDef.ForeColor = Color.Black;

                buttonDeleteDef.BackColor = Color.Transparent;
                buttonDeleteDef.ForeColor = Color.Black;

                buttonAddDef.BackColor = Color.Transparent;
                buttonAddDef.ForeColor = Color.Black;


                tabCautare.BackColor = Color.White;
                tabAdauga.BackColor = Color.White;
                tabModifica.BackColor = Color.White;
                tabSterge.BackColor = Color.White;

                tabControlAdd.BackColor = DefaultBackColor;

                menuStrip.BackColor = Color.SeaShell;
                tabControlAdd.BackColor = DefaultBackColor;
                statusStrip1.BackColor = DefaultBackColor;
                panel1.BackColor = Color.SeaShell;

                aboutToolStripMenuItem.BackColor = Color.SeaShell;
                helpToolStripMenuItem.BackColor = Color.SeaShell;
                exitToolStripMenuItem.BackColor = Color.SeaShell;


                labelCuvant_.ForeColor = Color.Black;
                labelCuv.ForeColor = Color.Black;
                labelCuvant.ForeColor = Color.Black;
                labelParte.ForeColor = Color.Black;
                labelDefinitie.ForeColor = Color.Black;
                labelPartVb.ForeColor = Color.Black;
                labelWord.ForeColor = Color.Black;
                labelDefi.ForeColor = Color.Black;

                checkBoxDark.ForeColor = Color.Black;
                aboutToolStripMenuItem.ForeColor = Color.Black;
                helpToolStripMenuItem.ForeColor = Color.Black;
                exitToolStripMenuItem.ForeColor = Color.Black;
                statusStrip1.ForeColor = Color.Black;
            }
        }

        /*! Funcție care tratează evenimentul Click al butonului Despre
           Oferă infomații despre aplicație
       */
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string copyright =
              "Proiect Dicționar Explicativ\r\n" +
              "Ingineria programării\r\n" +
              "Realizat de: Ichim Ioana, Mihalache Ecaterina,\r\n" + "Moroșan Carla, Radion Claudia\r\n" +
              "(c) 2020-2021 \r\n" ;

            MessageBox.Show(copyright, "Dicționar Explicativ");
        }

        /*! Funcție care tratează evenimentul Click al butonului Ștergere 
            Dacă cuvântul scris se regăsește în dicționar, acesta se va șterge la acționarea acestui buton. 
        */
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string cuvant = textBoxDelete.Text.ToLower();
                if (cuvant == "")
                {
                    throw new DictionarException("Nu ați introdus niciun cuvânt", cuvant);
                }
                else if (!_dictionar.WordExists(cuvant))
                {
                    throw new DictionarException("Nu există în dicționar", cuvant);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Sigur doriți să ștergeți cuvântul: " + cuvant, "Ștergere cuvânt", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        _dictionar.DeleteWord(cuvant);
                        textBoxDelete.Text = "";
                    }

                }
            }
            catch (DictionarException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Tab Modifica
        /*! Funcție care tratează evenimentul Click al butonului Caută */
        private void buttonSearchM_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxDefinitions.Items.Clear();
                string cuvant = textBoxSearchM.Text.ToLower();
                DefinitionList def = null;

                if (cuvant == "")
                {
                    throw new DictionarException("Nu ați introdus niciun cuvânt", cuvant);
                }
                else if (!_dictionar.WordExists(cuvant))
                {
                    throw new DictionarException("Nu există în dicționar", cuvant);
                }
                else
                {
                    def = _dictionar.GetDefinitions(cuvant);
                    panelModify.Enabled = true;
                    if (def != null)
                    {
                        for (int i = 0; i < def.Definitii.Count; i++)
                            listBoxDefinitions.Items.Add(def.Definitii[i]);
                    }
                    else
                    {
                        throw new DictionarException("Nu are atribuită nicio definiție ", cuvant);
                    }
                }

            }
            catch (DictionarException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*! Funcție care tratează evenimentul Click al butonului Modifică
            Se modifică definiția selectată. */
        private void buttonModDef_Click(object sender, EventArgs e)
        {
            try
            {
                string key = textBoxSearchM.Text.ToLower();
                string defModified = textBoxToModify.Text;
                string partModified = textBoxPartM.Text;
                int index = listBoxDefinitions.SelectedIndex;
                if (index != -1)
                {
                    _dictionar.UpdateWord(key, index, partModified, defModified);
                    ClearModify();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*! Funcție care tratează evenimentul Click al butonului Șterge Definiție
            Se șterge definiția selectată. */
        private void buttonDeleteDef_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBoxDefinitions.SelectedIndex;
                string key = textBoxSearchM.Text.ToLower();
                _dictionar.DeleteDefinition(key, index);
                ClearModify();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*! Funcție care tratează evenimentul ListBox-ului pentru selectarea definiției curente */
        private void listBoxDefinitions_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string cuvant = textBoxSearchM.Text.ToLower();
                int index = listBoxDefinitions.SelectedIndex;
                if (index != -1)
                {
                    textBoxPartM.Text = _dictionar.GetDefinitions(cuvant).GetExplanation(index).Parte;
                    textBoxToModify.Text = _dictionar.GetDefinitions(cuvant).GetExplanation(index).Explicatie;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*! Funcție care se apeleza dupa operatiile de modificare pentru a curata campurile din tab */
        private void ClearModify()
        {
            listBoxDefinitions.Items.Clear();
            textBoxPartM.Clear();
            textBoxToModify.Clear();
            textBoxSearchM.Clear();
            panelModify.Enabled = false;
        }

        /*! Funcție care tratează evenimentul Click al butonului Adaugă Definiție 
            Se adaugă o nouă definiție la cuvânt. */
        private void buttonAddDef_Click(object sender, EventArgs e)
        {
            try
            {
                string key = textBoxSearchM.Text.ToLower();
                string def = textBoxToModify.Text;
                string part = textBoxPartM.Text;
                int index = listBoxDefinitions.SelectedIndex;
                _dictionar.NewWordDefinition(key, part, def);
                ClearModify();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Dictionar Explicativ.chm");
        }
        public void SetStatusControl(string text)
        {
            toolStripStatusLabel.Text = text;
        }
        public void SetLabelNrWords(string text)
        {
            toolStripStatusLabelNrWords.Text = text;
        }
    }
}

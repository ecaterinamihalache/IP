
namespace Dict
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNrWords = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkBoxDark = new System.Windows.Forms.CheckBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.richTextBoxDefinitions = new System.Windows.Forms.RichTextBox();
            this.tabControlAdd = new System.Windows.Forms.TabControl();
            this.tabCautare = new System.Windows.Forms.TabPage();
            this.labelCuv = new System.Windows.Forms.Label();
            this.tabAdauga = new System.Windows.Forms.TabPage();
            this.labelDefinitie = new System.Windows.Forms.Label();
            this.labelParte = new System.Windows.Forms.Label();
            this.labelCuvant = new System.Windows.Forms.Label();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.textBoxDef = new System.Windows.Forms.TextBox();
            this.textBoxPart = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAddWord = new System.Windows.Forms.Button();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.tabModifica = new System.Windows.Forms.TabPage();
            this.panelModify = new System.Windows.Forms.Panel();
            this.textBoxPartM = new System.Windows.Forms.TextBox();
            this.labelDefi = new System.Windows.Forms.Label();
            this.buttonDeleteDef = new System.Windows.Forms.Button();
            this.buttonAddDef = new System.Windows.Forms.Button();
            this.labelPartVb = new System.Windows.Forms.Label();
            this.textBoxToModify = new System.Windows.Forms.TextBox();
            this.buttonModDef = new System.Windows.Forms.Button();
            this.listBoxDefinitions = new System.Windows.Forms.ListBox();
            this.labelCuvant_ = new System.Windows.Forms.Label();
            this.buttonSearchM = new System.Windows.Forms.Button();
            this.textBoxSearchM = new System.Windows.Forms.TextBox();
            this.tabSterge = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelWord = new System.Windows.Forms.Label();
            this.textBoxDelete = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControlAdd.SuspendLayout();
            this.tabCautare.SuspendLayout();
            this.tabAdauga.SuspendLayout();
            this.tabModifica.SuspendLayout();
            this.panelModify.SuspendLayout();
            this.tabSterge.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.SeaShell;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(982, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.aboutToolStripMenuItem.Text = "Despre";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.helpToolStripMenuItem.Text = "Ajutor";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(49, 22);
            this.exitToolStripMenuItem.Text = "Ieșire";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxSearch.Location = new System.Drawing.Point(32, 54);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(673, 23);
            this.textBoxSearch.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.checkBoxDark);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 490);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 59);
            this.panel1.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            //this.toolStripStatusLabel1,
            this.toolStripStatusLabelNrWords,
            //this.toolStripStatusLabel2,
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 37);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(982, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(88, 17);
            this.toolStripStatusLabel.Text = "Bine ai venit!";
          
            // 
            // toolStripStatusLabelNrWords
            // 
            this.toolStripStatusLabelNrWords.Name = "toolStripStatusLabelNrWords";
            this.toolStripStatusLabelNrWords.Size = new System.Drawing.Size(0, 17);
          
            // 
            // checkBoxDark
            // 
            this.checkBoxDark.AutoSize = true;
            this.checkBoxDark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxDark.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDark.Location = new System.Drawing.Point(27, 12);
            this.checkBoxDark.Name = "checkBoxDark";
            this.checkBoxDark.Size = new System.Drawing.Size(83, 18);
            this.checkBoxDark.TabIndex = 1;
            this.checkBoxDark.Text = "DarkMode";
            this.checkBoxDark.UseVisualStyleBackColor = true;
            this.checkBoxDark.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSearch.Location = new System.Drawing.Point(771, 51);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(169, 26);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Caută";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.CautaClicked);
            // 
            // richTextBoxDefinitions
            // 
            this.richTextBoxDefinitions.Location = new System.Drawing.Point(32, 99);
            this.richTextBoxDefinitions.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxDefinitions.Name = "richTextBoxDefinitions";
            this.richTextBoxDefinitions.Size = new System.Drawing.Size(908, 328);
            this.richTextBoxDefinitions.TabIndex = 10;
            this.richTextBoxDefinitions.Text = "";
            // 
            // tabControlAdd
            // 
            this.tabControlAdd.Controls.Add(this.tabCautare);
            this.tabControlAdd.Controls.Add(this.tabAdauga);
            this.tabControlAdd.Controls.Add(this.tabModifica);
            this.tabControlAdd.Controls.Add(this.tabSterge);
            this.tabControlAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControlAdd.Location = new System.Drawing.Point(0, 24);
            this.tabControlAdd.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlAdd.Name = "tabControlAdd";
            this.tabControlAdd.SelectedIndex = 0;
            this.tabControlAdd.Size = new System.Drawing.Size(982, 466);
            this.tabControlAdd.TabIndex = 11;
            // 
            // tabCautare
            // 
            this.tabCautare.Controls.Add(this.labelCuv);
            this.tabCautare.Controls.Add(this.textBoxSearch);
            this.tabCautare.Controls.Add(this.buttonSearch);
            this.tabCautare.Controls.Add(this.richTextBoxDefinitions);
            this.tabCautare.Location = new System.Drawing.Point(4, 25);
            this.tabCautare.Margin = new System.Windows.Forms.Padding(2);
            this.tabCautare.Name = "tabCautare";
            this.tabCautare.Padding = new System.Windows.Forms.Padding(2);
            this.tabCautare.Size = new System.Drawing.Size(974, 437);
            this.tabCautare.TabIndex = 0;
            this.tabCautare.Text = "Căutare";
            this.tabCautare.UseVisualStyleBackColor = true;
            // 
            // labelCuv
            // 
            this.labelCuv.AutoSize = true;
            this.labelCuv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCuv.Location = new System.Drawing.Point(362, 24);
            this.labelCuv.Name = "labelCuv";
            this.labelCuv.Size = new System.Drawing.Size(52, 17);
            this.labelCuv.TabIndex = 11;
            this.labelCuv.Text = "Cuvânt";
            // 
            // tabAdauga
            // 
            this.tabAdauga.Controls.Add(this.labelDefinitie);
            this.tabAdauga.Controls.Add(this.labelParte);
            this.tabAdauga.Controls.Add(this.labelCuvant);
            this.tabAdauga.Controls.Add(this.richTextBoxMessage);
            this.tabAdauga.Controls.Add(this.textBoxDef);
            this.tabAdauga.Controls.Add(this.textBoxPart);
            this.tabAdauga.Controls.Add(this.buttonClear);
            this.tabAdauga.Controls.Add(this.buttonAddWord);
            this.tabAdauga.Controls.Add(this.textBoxWord);
            this.tabAdauga.Location = new System.Drawing.Point(4, 25);
            this.tabAdauga.Margin = new System.Windows.Forms.Padding(2);
            this.tabAdauga.Name = "tabAdauga";
            this.tabAdauga.Padding = new System.Windows.Forms.Padding(2);
            this.tabAdauga.Size = new System.Drawing.Size(974, 437);
            this.tabAdauga.TabIndex = 1;
            this.tabAdauga.Text = "Adaugă";
            this.tabAdauga.UseVisualStyleBackColor = true;
            // 
            // labelDefinitie
            // 
            this.labelDefinitie.AutoSize = true;
            this.labelDefinitie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDefinitie.Location = new System.Drawing.Point(645, 87);
            this.labelDefinitie.Name = "labelDefinitie";
            this.labelDefinitie.Size = new System.Drawing.Size(59, 17);
            this.labelDefinitie.TabIndex = 8;
            this.labelDefinitie.Text = "Definiție";
            // 
            // labelParte
            // 
            this.labelParte.AutoSize = true;
            this.labelParte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelParte.Location = new System.Drawing.Point(160, 87);
            this.labelParte.Name = "labelParte";
            this.labelParte.Size = new System.Drawing.Size(110, 17);
            this.labelParte.TabIndex = 7;
            this.labelParte.Text = "Parte de vorbire";
            // 
            // labelCuvant
            // 
            this.labelCuvant.AutoSize = true;
            this.labelCuvant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCuvant.Location = new System.Drawing.Point(160, 20);
            this.labelCuvant.Name = "labelCuvant";
            this.labelCuvant.Size = new System.Drawing.Size(52, 17);
            this.labelCuvant.TabIndex = 6;
            this.labelCuvant.Text = "Cuvânt";
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Location = new System.Drawing.Point(35, 158);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(899, 267);
            this.richTextBoxMessage.TabIndex = 5;
            this.richTextBoxMessage.Text = "";
            // 
            // textBoxDef
            // 
            this.textBoxDef.Location = new System.Drawing.Point(428, 115);
            this.textBoxDef.Name = "textBoxDef";
            this.textBoxDef.Size = new System.Drawing.Size(506, 23);
            this.textBoxDef.TabIndex = 4;
            // 
            // textBoxPart
            // 
            this.textBoxPart.Location = new System.Drawing.Point(35, 115);
            this.textBoxPart.Name = "textBoxPart";
            this.textBoxPart.Size = new System.Drawing.Size(338, 23);
            this.textBoxPart.TabIndex = 3;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonClear.Location = new System.Drawing.Point(784, 45);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(150, 29);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Golire";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAddWord
            // 
            this.buttonAddWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAddWord.Location = new System.Drawing.Point(428, 45);
            this.buttonAddWord.Name = "buttonAddWord";
            this.buttonAddWord.Size = new System.Drawing.Size(150, 29);
            this.buttonAddWord.TabIndex = 1;
            this.buttonAddWord.Text = "Adaugă";
            this.buttonAddWord.UseVisualStyleBackColor = true;
            this.buttonAddWord.Click += new System.EventHandler(this.buttonAddWord_Click);
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(35, 45);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(338, 23);
            this.textBoxWord.TabIndex = 0;
            // 
            // tabModifica
            // 
            this.tabModifica.Controls.Add(this.panelModify);
            this.tabModifica.Controls.Add(this.labelCuvant_);
            this.tabModifica.Controls.Add(this.buttonSearchM);
            this.tabModifica.Controls.Add(this.textBoxSearchM);
            this.tabModifica.Location = new System.Drawing.Point(4, 25);
            this.tabModifica.Margin = new System.Windows.Forms.Padding(2);
            this.tabModifica.Name = "tabModifica";
            this.tabModifica.Size = new System.Drawing.Size(974, 437);
            this.tabModifica.TabIndex = 2;
            this.tabModifica.Text = "Modifică";
            this.tabModifica.UseVisualStyleBackColor = true;
            // 
            // panelModify
            // 
            this.panelModify.Controls.Add(this.textBoxPartM);
            this.panelModify.Controls.Add(this.labelDefi);
            this.panelModify.Controls.Add(this.buttonDeleteDef);
            this.panelModify.Controls.Add(this.buttonAddDef);
            this.panelModify.Controls.Add(this.labelPartVb);
            this.panelModify.Controls.Add(this.textBoxToModify);
            this.panelModify.Controls.Add(this.buttonModDef);
            this.panelModify.Controls.Add(this.listBoxDefinitions);
            this.panelModify.Enabled = false;
            this.panelModify.Location = new System.Drawing.Point(17, 90);
            this.panelModify.Margin = new System.Windows.Forms.Padding(2);
            this.panelModify.Name = "panelModify";
            this.panelModify.Size = new System.Drawing.Size(945, 350);
            this.panelModify.TabIndex = 19;
            // 
            // textBoxPartM
            // 
            this.textBoxPartM.Location = new System.Drawing.Point(7, 29);
            this.textBoxPartM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPartM.Name = "textBoxPartM";
            this.textBoxPartM.Size = new System.Drawing.Size(326, 23);
            this.textBoxPartM.TabIndex = 14;
            // 
            // labelDefi
            // 
            this.labelDefi.AutoSize = true;
            this.labelDefi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDefi.Location = new System.Drawing.Point(119, 61);
            this.labelDefi.Name = "labelDefi";
            this.labelDefi.Size = new System.Drawing.Size(59, 17);
            this.labelDefi.TabIndex = 18;
            this.labelDefi.Text = "Definiție";
            // 
            // buttonDeleteDef
            // 
            this.buttonDeleteDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDeleteDef.Location = new System.Drawing.Point(845, 260);
            this.buttonDeleteDef.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonDeleteDef.Name = "buttonDeleteDef";
            this.buttonDeleteDef.Size = new System.Drawing.Size(98, 58);
            this.buttonDeleteDef.TabIndex = 12;
            this.buttonDeleteDef.Text = "Șterge definiție";
            this.buttonDeleteDef.UseVisualStyleBackColor = true;
            this.buttonDeleteDef.Click += new System.EventHandler(this.buttonDeleteDef_Click);
            // 
            // buttonAddDef
            // 
            this.buttonAddDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAddDef.Location = new System.Drawing.Point(845, 134);
            this.buttonAddDef.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonAddDef.Name = "buttonAddDef";
            this.buttonAddDef.Size = new System.Drawing.Size(98, 58);
            this.buttonAddDef.TabIndex = 15;
            this.buttonAddDef.Text = "Adaugă definiție";
            this.buttonAddDef.UseVisualStyleBackColor = true;
            this.buttonAddDef.Click += new System.EventHandler(this.buttonAddDef_Click);
            // 
            // labelPartVb
            // 
            this.labelPartVb.AutoSize = true;
            this.labelPartVb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPartVb.Location = new System.Drawing.Point(103, 10);
            this.labelPartVb.Name = "labelPartVb";
            this.labelPartVb.Size = new System.Drawing.Size(110, 17);
            this.labelPartVb.TabIndex = 17;
            this.labelPartVb.Text = "Parte de vorbire";
            // 
            // textBoxToModify
            // 
            this.textBoxToModify.Location = new System.Drawing.Point(7, 80);
            this.textBoxToModify.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxToModify.Multiline = true;
            this.textBoxToModify.Name = "textBoxToModify";
            this.textBoxToModify.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxToModify.Size = new System.Drawing.Size(818, 81);
            this.textBoxToModify.TabIndex = 13;
            // 
            // buttonModDef
            // 
            this.buttonModDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonModDef.Location = new System.Drawing.Point(845, 10);
            this.buttonModDef.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonModDef.Name = "buttonModDef";
            this.buttonModDef.Size = new System.Drawing.Size(98, 58);
            this.buttonModDef.TabIndex = 11;
            this.buttonModDef.Text = "Modifică definiție";
            this.buttonModDef.UseVisualStyleBackColor = true;
            this.buttonModDef.Click += new System.EventHandler(this.buttonModDef_Click);
            // 
            // listBoxDefinitions
            // 
            this.listBoxDefinitions.FormattingEnabled = true;
            this.listBoxDefinitions.HorizontalScrollbar = true;
            this.listBoxDefinitions.ItemHeight = 16;
            this.listBoxDefinitions.Location = new System.Drawing.Point(7, 165);
            this.listBoxDefinitions.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxDefinitions.Name = "listBoxDefinitions";
            this.listBoxDefinitions.Size = new System.Drawing.Size(818, 180);
            this.listBoxDefinitions.TabIndex = 1;
            this.listBoxDefinitions.SelectedIndexChanged += new System.EventHandler(this.listBoxDefinitions_SelectedIndexChanged);
            // 
            // labelCuvant_
            // 
            this.labelCuvant_.AutoSize = true;
            this.labelCuvant_.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCuvant_.Location = new System.Drawing.Point(143, 24);
            this.labelCuvant_.Name = "labelCuvant_";
            this.labelCuvant_.Size = new System.Drawing.Size(52, 17);
            this.labelCuvant_.TabIndex = 16;
            this.labelCuvant_.Text = "Cuvânt";
            // 
            // buttonSearchM
            // 
            this.buttonSearchM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSearchM.Location = new System.Drawing.Point(368, 46);
            this.buttonSearchM.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonSearchM.Name = "buttonSearchM";
            this.buttonSearchM.Size = new System.Drawing.Size(98, 32);
            this.buttonSearchM.TabIndex = 10;
            this.buttonSearchM.Text = "Caută";
            this.buttonSearchM.UseVisualStyleBackColor = true;
            this.buttonSearchM.Click += new System.EventHandler(this.buttonSearchM_Click);
            // 
            // textBoxSearchM
            // 
            this.textBoxSearchM.Location = new System.Drawing.Point(24, 51);
            this.textBoxSearchM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearchM.Name = "textBoxSearchM";
            this.textBoxSearchM.Size = new System.Drawing.Size(326, 23);
            this.textBoxSearchM.TabIndex = 0;
            // 
            // tabSterge
            // 
            this.tabSterge.Controls.Add(this.buttonDelete);
            this.tabSterge.Controls.Add(this.labelWord);
            this.tabSterge.Controls.Add(this.textBoxDelete);
            this.tabSterge.Location = new System.Drawing.Point(4, 25);
            this.tabSterge.Margin = new System.Windows.Forms.Padding(2);
            this.tabSterge.Name = "tabSterge";
            this.tabSterge.Size = new System.Drawing.Size(974, 437);
            this.tabSterge.TabIndex = 3;
            this.tabSterge.Text = "Șterge";
            this.tabSterge.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDelete.Location = new System.Drawing.Point(431, 245);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 36);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Șterge";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelWord.Location = new System.Drawing.Point(444, 129);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(52, 17);
            this.labelWord.TabIndex = 1;
            this.labelWord.Text = "Cuvânt";
            // 
            // textBoxDelete
            // 
            this.textBoxDelete.Location = new System.Drawing.Point(311, 186);
            this.textBoxDelete.Name = "textBoxDelete";
            this.textBoxDelete.Size = new System.Drawing.Size(333, 23);
            this.textBoxDelete.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(982, 549);
            this.Controls.Add(this.tabControlAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "MainForm";
            this.Text = "Dicționar explicativ";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControlAdd.ResumeLayout(false);
            this.tabCautare.ResumeLayout(false);
            this.tabCautare.PerformLayout();
            this.tabAdauga.ResumeLayout(false);
            this.tabAdauga.PerformLayout();
            this.tabModifica.ResumeLayout(false);
            this.tabModifica.PerformLayout();
            this.panelModify.ResumeLayout(false);
            this.panelModify.PerformLayout();
            this.tabSterge.ResumeLayout(false);
            this.tabSterge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.RichTextBox richTextBoxDefinitions;
        private System.Windows.Forms.TabControl tabControlAdd;
        private System.Windows.Forms.TabPage tabCautare;
        private System.Windows.Forms.TabPage tabAdauga;
        private System.Windows.Forms.TabPage tabModifica;
        private System.Windows.Forms.TabPage tabSterge;
        private System.Windows.Forms.TextBox textBoxDef;
        private System.Windows.Forms.TextBox textBoxPart;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAddWord;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.CheckBox checkBoxDark;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.TextBox textBoxDelete;
        private System.Windows.Forms.TextBox textBoxPartM;
        private System.Windows.Forms.ListBox listBoxDefinitions;
        private System.Windows.Forms.Button buttonSearchM;
        private System.Windows.Forms.TextBox textBoxSearchM;
        private System.Windows.Forms.Button buttonModDef;
        private System.Windows.Forms.Button buttonDeleteDef;
        private System.Windows.Forms.TextBox textBoxToModify;
        private System.Windows.Forms.Label labelDefinitie;
        private System.Windows.Forms.Label labelParte;
        private System.Windows.Forms.Label labelCuvant;
        private System.Windows.Forms.Button buttonAddDef;
        private System.Windows.Forms.Label labelDefi;
        private System.Windows.Forms.Label labelPartVb;
        private System.Windows.Forms.Label labelCuvant_;
        private System.Windows.Forms.Label labelCuv;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Panel panelModify;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNrWords;
    }
}


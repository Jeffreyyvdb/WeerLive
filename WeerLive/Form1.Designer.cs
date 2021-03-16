
namespace WeerLive
{
    partial class Form1
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPageAlgemeen = new MetroFramework.Controls.MetroTabPage();
            this.comboBoxLocation1 = new System.Windows.Forms.ComboBox();
            this.metroLabelWeerv = new MetroFramework.Controls.MetroLabel();
            this.metroLabelDauwp = new MetroFramework.Controls.MetroLabel();
            this.metroLabelLv = new MetroFramework.Controls.MetroLabel();
            this.metroLabelZicht = new MetroFramework.Controls.MetroLabel();
            this.metroLabelLuchtd = new MetroFramework.Controls.MetroLabel();
            this.metroLabelWindr = new MetroFramework.Controls.MetroLabel();
            this.metroLabelWind = new MetroFramework.Controls.MetroLabel();
            this.metroLabelgTemp = new MetroFramework.Controls.MetroLabel();
            this.metroLabelSamenv = new MetroFramework.Controls.MetroLabel();
            this.metroLabelTemp = new MetroFramework.Controls.MetroLabel();
            this.metroLabelHetWeerVan = new MetroFramework.Controls.MetroLabel();
            this.metroTabPageVerwachting = new MetroFramework.Controls.MetroTabPage();
            this.metroLabelOvermorgen = new MetroFramework.Controls.MetroLabel();
            this.metroLabelMorgen = new MetroFramework.Controls.MetroLabel();
            this.metroLabelVandaag = new MetroFramework.Controls.MetroLabel();
            this.metroLabelD2max = new MetroFramework.Controls.MetroLabel();
            this.metroLabelD1max = new MetroFramework.Controls.MetroLabel();
            this.metroLabelD0max = new MetroFramework.Controls.MetroLabel();
            this.metroLabelMax = new MetroFramework.Controls.MetroLabel();
            this.metroLabelD2gem = new MetroFramework.Controls.MetroLabel();
            this.metroLabelD1gem = new MetroFramework.Controls.MetroLabel();
            this.metroLabelD0gem = new MetroFramework.Controls.MetroLabel();
            this.metroLabelGem = new MetroFramework.Controls.MetroLabel();
            this.metroLabelD2min = new MetroFramework.Controls.MetroLabel();
            this.metroLabelD1min = new MetroFramework.Controls.MetroLabel();
            this.metroLabelD0min = new MetroFramework.Controls.MetroLabel();
            this.metroLabelMin = new MetroFramework.Controls.MetroLabel();
            this.metroLabelHetWeerIn2 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.comboBoxSaved = new System.Windows.Forms.ComboBox();
            this.metroLabelOpgeslagen = new MetroFramework.Controls.MetroLabel();
            this.metroLabelDatum = new MetroFramework.Controls.MetroLabel();
            this.metroButtonExport = new MetroFramework.Controls.MetroButton();
            this.pictureBoxAlgemeen = new System.Windows.Forms.PictureBox();
            this.pictureBoxD2weer = new System.Windows.Forms.PictureBox();
            this.pictureBoxD1weer = new System.Windows.Forms.PictureBox();
            this.pictureBoxD0weer = new System.Windows.Forms.PictureBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPageAlgemeen.SuspendLayout();
            this.metroTabPageVerwachting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlgemeen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD2weer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD1weer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD0weer)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPageAlgemeen);
            this.metroTabControl1.Controls.Add(this.metroTabPageVerwachting);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(760, 370);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // metroTabPageAlgemeen
            // 
            this.metroTabPageAlgemeen.Controls.Add(this.metroButtonExport);
            this.metroTabPageAlgemeen.Controls.Add(this.metroLabelOpgeslagen);
            this.metroTabPageAlgemeen.Controls.Add(this.comboBoxSaved);
            this.metroTabPageAlgemeen.Controls.Add(this.comboBoxLocation1);
            this.metroTabPageAlgemeen.Controls.Add(this.pictureBoxAlgemeen);
            this.metroTabPageAlgemeen.Controls.Add(this.metroLabelWeerv);
            this.metroTabPageAlgemeen.Controls.Add(this.metroLabelDauwp);
            this.metroTabPageAlgemeen.Controls.Add(this.metroLabelLv);
            this.metroTabPageAlgemeen.Controls.Add(this.metroLabelZicht);
            this.metroTabPageAlgemeen.Controls.Add(this.metroLabelLuchtd);
            this.metroTabPageAlgemeen.Controls.Add(this.metroLabelWindr);
            this.metroTabPageAlgemeen.Controls.Add(this.metroLabelWind);
            this.metroTabPageAlgemeen.Controls.Add(this.metroLabelgTemp);
            this.metroTabPageAlgemeen.Controls.Add(this.metroLabelSamenv);
            this.metroTabPageAlgemeen.Controls.Add(this.metroLabelTemp);
            this.metroTabPageAlgemeen.Controls.Add(this.metroLabelHetWeerVan);
            this.metroTabPageAlgemeen.HorizontalScrollbarBarColor = true;
            this.metroTabPageAlgemeen.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageAlgemeen.HorizontalScrollbarSize = 10;
            this.metroTabPageAlgemeen.Location = new System.Drawing.Point(4, 44);
            this.metroTabPageAlgemeen.Name = "metroTabPageAlgemeen";
            this.metroTabPageAlgemeen.Size = new System.Drawing.Size(752, 322);
            this.metroTabPageAlgemeen.TabIndex = 0;
            this.metroTabPageAlgemeen.Text = "Algemeen   ";
            this.metroTabPageAlgemeen.VerticalScrollbarBarColor = true;
            this.metroTabPageAlgemeen.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageAlgemeen.VerticalScrollbarSize = 10;
            // 
            // comboBoxLocation1
            // 
            this.comboBoxLocation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLocation1.FormattingEnabled = true;
            this.comboBoxLocation1.ItemHeight = 25;
            this.comboBoxLocation1.Location = new System.Drawing.Point(527, 16);
            this.comboBoxLocation1.Name = "comboBoxLocation1";
            this.comboBoxLocation1.Size = new System.Drawing.Size(222, 33);
            this.comboBoxLocation1.TabIndex = 6;
            this.comboBoxLocation1.SelectedIndexChanged += new System.EventHandler(this.comboBoxLocation1_SelectedIndexChanged);
            this.comboBoxLocation1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxLocation1_KeyDown);
            // 
            // metroLabelWeerv
            // 
            this.metroLabelWeerv.AutoSize = true;
            this.metroLabelWeerv.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelWeerv.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelWeerv.Location = new System.Drawing.Point(-4, 287);
            this.metroLabelWeerv.Name = "metroLabelWeerv";
            this.metroLabelWeerv.Size = new System.Drawing.Size(478, 25);
            this.metroLabelWeerv.TabIndex = 3;
            this.metroLabelWeerv.Text = "Verwachting onstuimig met buien, vrijdag minder wind.";
            // 
            // metroLabelDauwp
            // 
            this.metroLabelDauwp.AutoSize = true;
            this.metroLabelDauwp.Location = new System.Drawing.Point(-4, 248);
            this.metroLabelDauwp.Name = "metroLabelDauwp";
            this.metroLabelDauwp.Size = new System.Drawing.Size(103, 20);
            this.metroLabelDauwp.TabIndex = 3;
            this.metroLabelDauwp.Text = "Dauwpunt 5 °C";
            // 
            // metroLabelLv
            // 
            this.metroLabelLv.AutoSize = true;
            this.metroLabelLv.Location = new System.Drawing.Point(-4, 228);
            this.metroLabelLv.Name = "metroLabelLv";
            this.metroLabelLv.Size = new System.Drawing.Size(203, 20);
            this.metroLabelLv.TabIndex = 3;
            this.metroLabelLv.Text = "Relatieve luchtvochtigheid 69%";
            // 
            // metroLabelZicht
            // 
            this.metroLabelZicht.AutoSize = true;
            this.metroLabelZicht.Location = new System.Drawing.Point(-4, 208);
            this.metroLabelZicht.Name = "metroLabelZicht";
            this.metroLabelZicht.Size = new System.Drawing.Size(120, 20);
            this.metroLabelZicht.TabIndex = 3;
            this.metroLabelZicht.Text = "Zicht 10 Kilometer";
            // 
            // metroLabelLuchtd
            // 
            this.metroLabelLuchtd.AutoSize = true;
            this.metroLabelLuchtd.Location = new System.Drawing.Point(-4, 188);
            this.metroLabelLuchtd.Name = "metroLabelLuchtd";
            this.metroLabelLuchtd.Size = new System.Drawing.Size(139, 20);
            this.metroLabelLuchtd.TabIndex = 2;
            this.metroLabelLuchtd.Text = "Luchtdruk 992.7  hPa";
            // 
            // metroLabelWindr
            // 
            this.metroLabelWindr.AutoSize = true;
            this.metroLabelWindr.Location = new System.Drawing.Point(-4, 168);
            this.metroLabelWindr.Name = "metroLabelWindr";
            this.metroLabelWindr.Size = new System.Drawing.Size(113, 20);
            this.metroLabelWindr.TabIndex = 2;
            this.metroLabelWindr.Text = "Windrichting ZW";
            // 
            // metroLabelWind
            // 
            this.metroLabelWind.AutoSize = true;
            this.metroLabelWind.Location = new System.Drawing.Point(-4, 148);
            this.metroLabelWind.Name = "metroLabelWind";
            this.metroLabelWind.Size = new System.Drawing.Size(275, 20);
            this.metroLabelWind.TabIndex = 2;
            this.metroLabelWind.Text = "Wind 7bft | 33 knopen | 17 m/s |   61,2 km/h";
            // 
            // metroLabelgTemp
            // 
            this.metroLabelgTemp.AutoSize = true;
            this.metroLabelgTemp.Location = new System.Drawing.Point(-4, 65);
            this.metroLabelgTemp.Name = "metroLabelgTemp";
            this.metroLabelgTemp.Size = new System.Drawing.Size(102, 20);
            this.metroLabelgTemp.TabIndex = 2;
            this.metroLabelgTemp.Text = "Voelt als 3,8 °C";
            // 
            // metroLabelSamenv
            // 
            this.metroLabelSamenv.AutoSize = true;
            this.metroLabelSamenv.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelSamenv.Location = new System.Drawing.Point(-4, 85);
            this.metroLabelSamenv.Name = "metroLabelSamenv";
            this.metroLabelSamenv.Size = new System.Drawing.Size(160, 25);
            this.metroLabelSamenv.TabIndex = 2;
            this.metroLabelSamenv.Text = "Droog na regenen";
            // 
            // metroLabelTemp
            // 
            this.metroLabelTemp.AutoSize = true;
            this.metroLabelTemp.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelTemp.Location = new System.Drawing.Point(-4, 40);
            this.metroLabelTemp.Name = "metroLabelTemp";
            this.metroLabelTemp.Size = new System.Drawing.Size(67, 25);
            this.metroLabelTemp.TabIndex = 2;
            this.metroLabelTemp.Text = "10,9 °C";
            // 
            // metroLabelHetWeerVan
            // 
            this.metroLabelHetWeerVan.AutoSize = true;
            this.metroLabelHetWeerVan.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelHetWeerVan.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelHetWeerVan.Location = new System.Drawing.Point(-4, 15);
            this.metroLabelHetWeerVan.Name = "metroLabelHetWeerVan";
            this.metroLabelHetWeerVan.Size = new System.Drawing.Size(218, 25);
            this.metroLabelHetWeerVan.TabIndex = 2;
            this.metroLabelHetWeerVan.Text = "Het weer in Amsterdam :";
            // 
            // metroTabPageVerwachting
            // 
            this.metroTabPageVerwachting.Controls.Add(this.metroLabelOvermorgen);
            this.metroTabPageVerwachting.Controls.Add(this.metroLabelMorgen);
            this.metroTabPageVerwachting.Controls.Add(this.metroLabelVandaag);
            this.metroTabPageVerwachting.Controls.Add(this.metroLabelD2max);
            this.metroTabPageVerwachting.Controls.Add(this.metroLabelD1max);
            this.metroTabPageVerwachting.Controls.Add(this.metroLabelD0max);
            this.metroTabPageVerwachting.Controls.Add(this.metroLabelMax);
            this.metroTabPageVerwachting.Controls.Add(this.metroLabelD2gem);
            this.metroTabPageVerwachting.Controls.Add(this.metroLabelD1gem);
            this.metroTabPageVerwachting.Controls.Add(this.metroLabelD0gem);
            this.metroTabPageVerwachting.Controls.Add(this.metroLabelGem);
            this.metroTabPageVerwachting.Controls.Add(this.metroLabelD2min);
            this.metroTabPageVerwachting.Controls.Add(this.metroLabelD1min);
            this.metroTabPageVerwachting.Controls.Add(this.metroLabelD0min);
            this.metroTabPageVerwachting.Controls.Add(this.metroLabelMin);
            this.metroTabPageVerwachting.Controls.Add(this.metroLabelHetWeerIn2);
            this.metroTabPageVerwachting.Controls.Add(this.pictureBoxD2weer);
            this.metroTabPageVerwachting.Controls.Add(this.pictureBoxD1weer);
            this.metroTabPageVerwachting.Controls.Add(this.pictureBoxD0weer);
            this.metroTabPageVerwachting.HorizontalScrollbarBarColor = true;
            this.metroTabPageVerwachting.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageVerwachting.HorizontalScrollbarSize = 10;
            this.metroTabPageVerwachting.Location = new System.Drawing.Point(4, 44);
            this.metroTabPageVerwachting.Name = "metroTabPageVerwachting";
            this.metroTabPageVerwachting.Size = new System.Drawing.Size(752, 322);
            this.metroTabPageVerwachting.TabIndex = 1;
            this.metroTabPageVerwachting.Text = "Verwachting   ";
            this.metroTabPageVerwachting.VerticalScrollbarBarColor = true;
            this.metroTabPageVerwachting.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageVerwachting.VerticalScrollbarSize = 10;
            // 
            // metroLabelOvermorgen
            // 
            this.metroLabelOvermorgen.AutoSize = true;
            this.metroLabelOvermorgen.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelOvermorgen.Location = new System.Drawing.Point(355, 89);
            this.metroLabelOvermorgen.Name = "metroLabelOvermorgen";
            this.metroLabelOvermorgen.Size = new System.Drawing.Size(115, 25);
            this.metroLabelOvermorgen.TabIndex = 8;
            this.metroLabelOvermorgen.Text = "Overmorgen";
            // 
            // metroLabelMorgen
            // 
            this.metroLabelMorgen.AutoSize = true;
            this.metroLabelMorgen.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelMorgen.Location = new System.Drawing.Point(237, 89);
            this.metroLabelMorgen.Name = "metroLabelMorgen";
            this.metroLabelMorgen.Size = new System.Drawing.Size(76, 25);
            this.metroLabelMorgen.TabIndex = 8;
            this.metroLabelMorgen.Text = "Morgen";
            // 
            // metroLabelVandaag
            // 
            this.metroLabelVandaag.AutoSize = true;
            this.metroLabelVandaag.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelVandaag.Location = new System.Drawing.Point(121, 89);
            this.metroLabelVandaag.Name = "metroLabelVandaag";
            this.metroLabelVandaag.Size = new System.Drawing.Size(80, 25);
            this.metroLabelVandaag.TabIndex = 8;
            this.metroLabelVandaag.Text = "Vandaag";
            // 
            // metroLabelD2max
            // 
            this.metroLabelD2max.AutoSize = true;
            this.metroLabelD2max.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelD2max.Location = new System.Drawing.Point(355, 169);
            this.metroLabelD2max.Name = "metroLabelD2max";
            this.metroLabelD2max.Size = new System.Drawing.Size(45, 25);
            this.metroLabelD2max.TabIndex = 8;
            this.metroLabelD2max.Text = "Max";
            // 
            // metroLabelD1max
            // 
            this.metroLabelD1max.AutoSize = true;
            this.metroLabelD1max.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelD1max.Location = new System.Drawing.Point(237, 169);
            this.metroLabelD1max.Name = "metroLabelD1max";
            this.metroLabelD1max.Size = new System.Drawing.Size(45, 25);
            this.metroLabelD1max.TabIndex = 8;
            this.metroLabelD1max.Text = "Max";
            // 
            // metroLabelD0max
            // 
            this.metroLabelD0max.AutoSize = true;
            this.metroLabelD0max.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelD0max.Location = new System.Drawing.Point(121, 169);
            this.metroLabelD0max.Name = "metroLabelD0max";
            this.metroLabelD0max.Size = new System.Drawing.Size(45, 25);
            this.metroLabelD0max.TabIndex = 8;
            this.metroLabelD0max.Text = "Max";
            // 
            // metroLabelMax
            // 
            this.metroLabelMax.AutoSize = true;
            this.metroLabelMax.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelMax.Location = new System.Drawing.Point(-4, 169);
            this.metroLabelMax.Name = "metroLabelMax";
            this.metroLabelMax.Size = new System.Drawing.Size(45, 25);
            this.metroLabelMax.TabIndex = 8;
            this.metroLabelMax.Text = "Max";
            // 
            // metroLabelD2gem
            // 
            this.metroLabelD2gem.AutoSize = true;
            this.metroLabelD2gem.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelD2gem.Location = new System.Drawing.Point(355, 207);
            this.metroLabelD2gem.Name = "metroLabelD2gem";
            this.metroLabelD2gem.Size = new System.Drawing.Size(51, 25);
            this.metroLabelD2gem.TabIndex = 8;
            this.metroLabelD2gem.Text = "Gem";
            // 
            // metroLabelD1gem
            // 
            this.metroLabelD1gem.AutoSize = true;
            this.metroLabelD1gem.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelD1gem.Location = new System.Drawing.Point(237, 207);
            this.metroLabelD1gem.Name = "metroLabelD1gem";
            this.metroLabelD1gem.Size = new System.Drawing.Size(51, 25);
            this.metroLabelD1gem.TabIndex = 8;
            this.metroLabelD1gem.Text = "Gem";
            // 
            // metroLabelD0gem
            // 
            this.metroLabelD0gem.AutoSize = true;
            this.metroLabelD0gem.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelD0gem.Location = new System.Drawing.Point(121, 207);
            this.metroLabelD0gem.Name = "metroLabelD0gem";
            this.metroLabelD0gem.Size = new System.Drawing.Size(51, 25);
            this.metroLabelD0gem.TabIndex = 8;
            this.metroLabelD0gem.Text = "Gem";
            // 
            // metroLabelGem
            // 
            this.metroLabelGem.AutoSize = true;
            this.metroLabelGem.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelGem.Location = new System.Drawing.Point(-4, 207);
            this.metroLabelGem.Name = "metroLabelGem";
            this.metroLabelGem.Size = new System.Drawing.Size(51, 25);
            this.metroLabelGem.TabIndex = 8;
            this.metroLabelGem.Text = "Gem";
            // 
            // metroLabelD2min
            // 
            this.metroLabelD2min.AutoSize = true;
            this.metroLabelD2min.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelD2min.Location = new System.Drawing.Point(355, 242);
            this.metroLabelD2min.Name = "metroLabelD2min";
            this.metroLabelD2min.Size = new System.Drawing.Size(42, 25);
            this.metroLabelD2min.TabIndex = 8;
            this.metroLabelD2min.Text = "Min";
            // 
            // metroLabelD1min
            // 
            this.metroLabelD1min.AutoSize = true;
            this.metroLabelD1min.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelD1min.Location = new System.Drawing.Point(237, 242);
            this.metroLabelD1min.Name = "metroLabelD1min";
            this.metroLabelD1min.Size = new System.Drawing.Size(42, 25);
            this.metroLabelD1min.TabIndex = 8;
            this.metroLabelD1min.Text = "Min";
            // 
            // metroLabelD0min
            // 
            this.metroLabelD0min.AutoSize = true;
            this.metroLabelD0min.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelD0min.Location = new System.Drawing.Point(121, 242);
            this.metroLabelD0min.Name = "metroLabelD0min";
            this.metroLabelD0min.Size = new System.Drawing.Size(42, 25);
            this.metroLabelD0min.TabIndex = 8;
            this.metroLabelD0min.Text = "Min";
            // 
            // metroLabelMin
            // 
            this.metroLabelMin.AutoSize = true;
            this.metroLabelMin.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelMin.Location = new System.Drawing.Point(-4, 242);
            this.metroLabelMin.Name = "metroLabelMin";
            this.metroLabelMin.Size = new System.Drawing.Size(42, 25);
            this.metroLabelMin.TabIndex = 8;
            this.metroLabelMin.Text = "Min";
            // 
            // metroLabelHetWeerIn2
            // 
            this.metroLabelHetWeerIn2.AutoSize = true;
            this.metroLabelHetWeerIn2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelHetWeerIn2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelHetWeerIn2.Location = new System.Drawing.Point(-4, 15);
            this.metroLabelHetWeerIn2.Name = "metroLabelHetWeerIn2";
            this.metroLabelHetWeerIn2.Size = new System.Drawing.Size(218, 25);
            this.metroLabelHetWeerIn2.TabIndex = 6;
            this.metroLabelHetWeerIn2.Text = "Het weer in Amsterdam :";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // comboBoxSaved
            // 
            this.comboBoxSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSaved.FormattingEnabled = true;
            this.comboBoxSaved.ItemHeight = 25;
            this.comboBoxSaved.Location = new System.Drawing.Point(527, 55);
            this.comboBoxSaved.Name = "comboBoxSaved";
            this.comboBoxSaved.Size = new System.Drawing.Size(222, 33);
            this.comboBoxSaved.TabIndex = 7;
            this.comboBoxSaved.SelectedIndexChanged += new System.EventHandler(this.comboBoxSaved_SelectedIndexChanged);
            // 
            // metroLabelOpgeslagen
            // 
            this.metroLabelOpgeslagen.AutoSize = true;
            this.metroLabelOpgeslagen.Location = new System.Drawing.Point(430, 65);
            this.metroLabelOpgeslagen.Name = "metroLabelOpgeslagen";
            this.metroLabelOpgeslagen.Size = new System.Drawing.Size(91, 20);
            this.metroLabelOpgeslagen.TabIndex = 8;
            this.metroLabelOpgeslagen.Text = "Opgeslagen :";
            // 
            // metroLabelDatum
            // 
            this.metroLabelDatum.AutoSize = true;
            this.metroLabelDatum.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelDatum.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelDatum.Location = new System.Drawing.Point(551, 39);
            this.metroLabelDatum.Name = "metroLabelDatum";
            this.metroLabelDatum.Size = new System.Drawing.Size(72, 25);
            this.metroLabelDatum.TabIndex = 9;
            this.metroLabelDatum.Text = "Datum";
            // 
            // metroButtonExport
            // 
            this.metroButtonExport.BackColor = System.Drawing.Color.Transparent;
            this.metroButtonExport.BackgroundImage = global::WeerLive.Properties.Resources.export;
            this.metroButtonExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButtonExport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroButtonExport.Location = new System.Drawing.Point(710, 94);
            this.metroButtonExport.Name = "metroButtonExport";
            this.metroButtonExport.Size = new System.Drawing.Size(39, 32);
            this.metroButtonExport.TabIndex = 11;
            this.metroButtonExport.UseSelectable = true;
            this.metroButtonExport.Click += new System.EventHandler(this.metroButtonExport_Click);
            // 
            // pictureBoxAlgemeen
            // 
            this.pictureBoxAlgemeen.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAlgemeen.Image = global::WeerLive.Properties.Resources.bewolkt;
            this.pictureBoxAlgemeen.InitialImage = global::WeerLive.Properties.Resources.zonnig;
            this.pictureBoxAlgemeen.Location = new System.Drawing.Point(219, 53);
            this.pictureBoxAlgemeen.Name = "pictureBoxAlgemeen";
            this.pictureBoxAlgemeen.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxAlgemeen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAlgemeen.TabIndex = 4;
            this.pictureBoxAlgemeen.TabStop = false;
            // 
            // pictureBoxD2weer
            // 
            this.pictureBoxD2weer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxD2weer.Image = global::WeerLive.Properties.Resources.halfbewolkt;
            this.pictureBoxD2weer.Location = new System.Drawing.Point(374, 127);
            this.pictureBoxD2weer.Name = "pictureBoxD2weer";
            this.pictureBoxD2weer.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxD2weer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxD2weer.TabIndex = 9;
            this.pictureBoxD2weer.TabStop = false;
            // 
            // pictureBoxD1weer
            // 
            this.pictureBoxD1weer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxD1weer.Image = global::WeerLive.Properties.Resources.halfbewolkt;
            this.pictureBoxD1weer.Location = new System.Drawing.Point(256, 127);
            this.pictureBoxD1weer.Name = "pictureBoxD1weer";
            this.pictureBoxD1weer.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxD1weer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxD1weer.TabIndex = 9;
            this.pictureBoxD1weer.TabStop = false;
            // 
            // pictureBoxD0weer
            // 
            this.pictureBoxD0weer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxD0weer.Image = global::WeerLive.Properties.Resources.halfbewolkt;
            this.pictureBoxD0weer.Location = new System.Drawing.Point(133, 127);
            this.pictureBoxD0weer.Name = "pictureBoxD0weer";
            this.pictureBoxD0weer.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxD0weer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxD0weer.TabIndex = 9;
            this.pictureBoxD0weer.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabelDatum);
            this.Controls.Add(this.metroTabControl1);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "WeerLive";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPageAlgemeen.ResumeLayout(false);
            this.metroTabPageAlgemeen.PerformLayout();
            this.metroTabPageVerwachting.ResumeLayout(false);
            this.metroTabPageVerwachting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlgemeen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD2weer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD1weer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD0weer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPageAlgemeen;
        private MetroFramework.Controls.MetroLabel metroLabelgTemp;
        private MetroFramework.Controls.MetroLabel metroLabelTemp;
        private MetroFramework.Controls.MetroLabel metroLabelHetWeerVan;
        private MetroFramework.Controls.MetroTabPage metroTabPageVerwachting;
        private MetroFramework.Controls.MetroLabel metroLabelLuchtd;
        private MetroFramework.Controls.MetroLabel metroLabelWindr;
        private MetroFramework.Controls.MetroLabel metroLabelWind;
        private MetroFramework.Controls.MetroLabel metroLabelSamenv;
        private MetroFramework.Controls.MetroLabel metroLabelZicht;
        private System.Windows.Forms.PictureBox pictureBoxAlgemeen;
        private MetroFramework.Controls.MetroLabel metroLabelWeerv;
        private MetroFramework.Controls.MetroLabel metroLabelDauwp;
        private MetroFramework.Controls.MetroLabel metroLabelLv;
        private MetroFramework.Controls.MetroLabel metroLabelOvermorgen;
        private MetroFramework.Controls.MetroLabel metroLabelMorgen;
        private MetroFramework.Controls.MetroLabel metroLabelVandaag;
        private MetroFramework.Controls.MetroLabel metroLabelMax;
        private MetroFramework.Controls.MetroLabel metroLabelGem;
        private MetroFramework.Controls.MetroLabel metroLabelMin;
        private MetroFramework.Controls.MetroLabel metroLabelHetWeerIn2;
        private System.Windows.Forms.PictureBox pictureBoxD2weer;
        private System.Windows.Forms.PictureBox pictureBoxD1weer;
        private System.Windows.Forms.PictureBox pictureBoxD0weer;
        private MetroFramework.Controls.MetroLabel metroLabelD2max;
        private MetroFramework.Controls.MetroLabel metroLabelD1max;
        private MetroFramework.Controls.MetroLabel metroLabelD0max;
        private MetroFramework.Controls.MetroLabel metroLabelD2gem;
        private MetroFramework.Controls.MetroLabel metroLabelD1gem;
        private MetroFramework.Controls.MetroLabel metroLabelD0gem;
        private MetroFramework.Controls.MetroLabel metroLabelD2min;
        private MetroFramework.Controls.MetroLabel metroLabelD1min;
        private MetroFramework.Controls.MetroLabel metroLabelD0min;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.ComboBox comboBoxLocation1;
        private MetroFramework.Controls.MetroLabel metroLabelOpgeslagen;
        private System.Windows.Forms.ComboBox comboBoxSaved;
        private MetroFramework.Controls.MetroLabel metroLabelDatum;
        private MetroFramework.Controls.MetroButton metroButtonExport;
    }
}


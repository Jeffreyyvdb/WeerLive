using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MetroFramework.Controls;
using System.Resources;
using WeerLive.Properties;
using Newtonsoft.Json;

namespace WeerLive
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        string PATH_PLAATSNAMEN = @"../../../plaatsnamen.txt";
        const string PATH_SAVED = @"../../../test.json";
        Weer weer;
        List<Weer> weerLijst;

        public Form1()
        {
            InitializeComponent();
            FillComboBoxLocation();
            getSavedList();
            fillComboboxSaved(weerLijst);

            // Huidge datum
            DateTime datum = DateTime.Now.Date;
            //metroLabelDatum.Text = datum.ToString("dd MMMM yyyy");
            // Eerte tabpage geopenend
            metroTabControl1.SelectedIndex = 0;
            // Bij opstarten Amsterdam openenen
            comboBoxLocation1.SelectedItem = "Amsterdam";
        }

        private void FillComboBoxLocation()
        {
            // leest plaatsnamen file, maakt een array van elke line en voegt deze toe aan de 2 comboboxxen
            string[] plaatsnamen = File.ReadAllLines(PATH_PLAATSNAMEN);

            comboBoxLocation1.DataSource = plaatsnamen;
            comboBoxLocation1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxLocation1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxLocation1.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxLocation1.DrawItem += comboBoxLocation_DrawItem;
        }

        //Color van de selected item binnen de combobox aanpassen...
        private void comboBoxLocation_DrawItem(object sender, DrawItemEventArgs e)
        {
            
            Color backColor = MetroFramework.MetroColors.Blue;
            var combo = sender as ComboBox;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(backColor), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds);
            }

            e.Graphics.DrawString(combo.Items[e.Index].ToString(),
                                          e.Font,
                                          new SolidBrush(Color.Black),
                                          new Point(e.Bounds.X, e.Bounds.Y));
        }

        // Wanneer een andere tabpage geselecteerd word de combobox toevoegen aan deze page
        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //add de combobox naar de huidige geselecteerde combobox..
            MetroTabControl tab = ((MetroTabControl)sender);
            int i = tab.SelectedIndex;
            metroTabControl1.TabPages[i].Controls.Add(comboBoxLocation1);
            metroTabControl1.TabPages[i].Controls.Add(comboBoxSaved);
            metroTabControl1.TabPages[i].Controls.Add(metroButtonExport);

            //if (metroTabControl1.SelectedTab.Name == "metroTabPageAlgemeen")
            //{
            //    Console.WriteLine("Algemeen geselecteerd");
            //    metroTabPageAlgemeen.Controls.Add(comboBoxLocation1);
            //}
            //else if (metroTabControl1.SelectedTab.Name == "metroTabPageVerwachting")
            //{
            //    Console.WriteLine("Verwachting geselecteerd");
            //    metroTabPageVerwachting.Controls.Add(comboBoxLocation1);
            //}
        }

        private void comboBoxLocation1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //laad de plaats uit de combobox als de index veranderd
            //En geeft deze plaats mee naar de WeerPlaats functie
            //Die de api data als een weer object terug geeft.
            string plaats = comboBoxLocation1.Text;
            // check of de plaats wel een waarde is
            if (plaats != "")
            {
                weer = Weer.WeerPlaats(plaats);
                fillLabels(weer);
            }

        }

        public void fillLabels(Weer p)
        {
            Console.WriteLine(p.d0weer);
            string pathToImage = getCorrectImage(p.d0weer);
            
            pictureBoxAlgemeen.Image = Image.FromFile(pathToImage);
            metroLabelHetWeerVan.Text = $"Het weer van {comboBoxLocation1.Text}";
            metroLabelTemp.Text = p.temp + " °C";
            metroLabelgTemp.Text = $"Voelt als : {p.gtemp} °C";
            metroLabelSamenv.Text = p.samenv;
            metroLabelWind.Text = $"Wind : {p.winds} bft | {p.windk} knoppen | {p.windms} m/s | {p.windkmh} km/h";
            metroLabelLuchtd.Text = $"Luchtdruk : {p.luchtd} hPa";
            metroLabelZicht.Text = $"Zicht : {p.zicht} Kilometer";
            metroLabelLv.Text = $"Relatieve luchtvochtigheid : {p.lv} %";
            metroLabelDauwp.Text = $"Dauwpunt : {p.dauwp} °C";
            metroLabelWeerv.Text = $"{p.verw}";
            
            metroLabelHetWeerIn2.Text = $"Het weer van {p.plaats}";

            metroLabelD0max.Text = $"{p.d0tmax} °C";
            metroLabelD0gem.Text = $"{gemiddeldeTemp(p.d0tmax, p.d0tmin)} °C";
            metroLabelD0min.Text = $"{p.d0tmin} °C";

            metroLabelD1max.Text = $"{p.d1tmax} °C";
            metroLabelD1gem.Text = $"{gemiddeldeTemp(p.d1tmax, p.d1tmin)} °C";
            metroLabelD1min.Text = $"{p.d1tmin} °C";

            metroLabelD2max.Text = $"{p.d2tmax} °C";
            metroLabelD2gem.Text = $"{gemiddeldeTemp(p.d2tmax, p.d2tmin)} °C";
            metroLabelD2min.Text = $"{p.d2tmin} °C";

            pictureBoxD0weer.Image = Image.FromFile(pathToImage);

            pictureBoxD1weer.Image = Image.FromFile(getCorrectImage(p.d1weer));
            pictureBoxD2weer.Image = Image.FromFile(getCorrectImage(p.d2weer));

            metroLabelDatum.Text = p.datum.ToString("dd MMMM yyy");
        }

        // Gemiddelde temperatuur berekenen
        public int gemiddeldeTemp(string max, string min)
        {
            return (Convert.ToInt32(max) + Convert.ToInt32(min)) / 2;
        }

        // Juiste foto krijgen voor het weer
        public string getCorrectImage(string imgName)
        {
            string pathToImage = "zonnig";
            switch (imgName)
            {
                case "zonnig":
                    pathToImage = @"../../../iconen-weerlive/zonnig.png";
                    break;
                case "bliksem":
                    pathToImage = @"../../../iconen-weerlive/bliksem.png";
                    break;
                case "regen":
                    pathToImage = @"../../../iconen-weerlive/regen.png";
                    break;
                case "buien":
                    pathToImage = @"../../../iconen-weerlive/buien.png";
                    break;
                case "hagel":
                    pathToImage = @"../../../iconen-weerlive/hagel.png";
                    break;
                case "mist":
                    pathToImage = @"../../../iconen-weerlive/mist.png";
                    break;
                case "sneeuw":
                    pathToImage = @"../../../iconen-weerlive/sneeuw.png";
                    break;
                case "bewolkt":
                    pathToImage = @"../../../iconen-weerlive/bewolkt.png";
                    break;
                case "halfbewolkt":
                    pathToImage = @"../../../iconen-weerlive/halfbewolkt.png";
                    break;
                case "zwaarbewolkt":
                    pathToImage = @"../../../iconen-weerlive/zwaarbewolkt.png";
                    break;
                case "nachtmist":
                    pathToImage = @"../../../iconen-weerlive/nachtmist.png";
                    break;
                case "helderenacht":
                    pathToImage = @"../../../iconen-weerlive/helderenacht.png";
                    break;
                case "wolkennacht":
                    pathToImage = @"../../../iconen-weerlive/wolkennacht.png";
                    break;
                default:
                    pathToImage = @"../../../iconen-weerlive/zonnig.png";
                    break;
            }
            return pathToImage;
        }

        // Comboxbox dropdown closen als er getyped word
        private void comboBoxLocation1_KeyDown(object sender, KeyEventArgs e)
        {
            comboBoxLocation1.DroppedDown = false;
        }

        public void getSavedList()
        {
             weerLijst = new List<Weer>();

            string json = File.ReadAllText(PATH_SAVED);
            if (json.StartsWith("[") && json.EndsWith("]"))
            {
                weerLijst = JsonConvert.DeserializeObject<List<Weer>>(json);
            }
        }
        private void metroButtonExport_Click(object sender, EventArgs e)
        {
            getSavedList();

            //Save huidige data naar json
            weerLijst.Add(weer);
            string x = JsonConvert.SerializeObject(weerLijst, Formatting.Indented);
            File.WriteAllText(PATH_SAVED, x);
            fillComboboxSaved(weerLijst);
        }
        void fillComboboxSaved(List<Weer> l)
        {
            comboBoxSaved.Items.Clear();
            foreach (Weer saved in l)
            {
                comboBoxSaved.Items.Add(saved.plaatsNaam + " " + saved.datum.ToString("dd-MM-yy"));
            
            }
        }

        private void comboBoxSaved_SelectedIndexChanged(object sender, EventArgs e)
        {
            string plaats = comboBoxSaved.Text;
            //plaats = plaats.Remove(plaats.Length - 9);
            List<Weer> weerLijst = JsonConvert.DeserializeObject<List<Weer>>(File.ReadAllText(PATH_SAVED));

            foreach (Weer w in weerLijst)
            {
                string saved = $"{w.plaatsNaam} {w.datum.Date.ToString("dd-MM-yy")}";
                if(saved == plaats)
                {
                    fillLabels(w);
                    metroLabelHetWeerVan.Text = $"Het weer van {plaats.Remove(plaats.Length - 9)}";
                    metroLabelDatum.Text = w.datum.ToString("dd MMMM yyyy");
                }
            }
        }
    }   
}

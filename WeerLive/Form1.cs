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

namespace WeerLive
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        string PATH_PLAATSNAMEN = @"../../../plaatsnamen.txt";

        public Form1()
        {
            InitializeComponent();
            FillComboBoxLocation();
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
            string plaats = comboBoxLocation1.Text;
            Weer weer = Weer.WeerPlaats(plaats);
            fillLabels(weer);

        }

        public void fillLabels(Weer p)
        {
            Console.WriteLine(p.d0weer);
            string pathToImage = getCorrectImage(p.d0weer);
            
            pictureBoxAlgemeen.Image = Image.FromFile(pathToImage);
            metroLabelHetWeerVan.Text = $"Het weer van {p.plaats}";
            metroLabelTemp.Text = p.temp;
            metroLabelgTemp.Text = $"Voelt als : {p.gtemp}";
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


        }

        public int gemiddeldeTemp(string max, string min)
        {
            return (Convert.ToInt32(max) + Convert.ToInt32(min)) / 2;
        }
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
    }   
}

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
            string[] test = { "test1", "test2", "test3" };

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
            // add de combobox naar de huidige geselecteerde combobox..
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
        }
    }
}

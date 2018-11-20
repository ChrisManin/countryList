using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountryList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string ligne;
            Char caractere = ';';

            System.IO.StreamReader fichier = new System.IO.StreamReader(@"C:\Users\dell-optilex-3010\Documents\liste_pays.csv");

            while ((ligne = fichier.ReadLine()) != null)
            {
                String[] substrings = ligne.Split(caractere);
                lbCountry.Items.Add(substrings[0]);
                lbCity.Items.Add(substrings[1]);
            }

            fichier.Close();
        }

        private void lbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCountry.SelectedIndex > 0)
            {
                string selectedCountry = lbCountry.SelectedItem.ToString();
                tbCountry.Text = selectedCountry;
                int index = lbCountry.SelectedIndex;
                lbCity.SelectedIndex = index;
                string selectedCity = lbCity.SelectedItem.ToString();
                tbCity.Text = selectedCity;
            }
        }

        public bool verif(string item, ListBox lst)
        {
            foreach (string s in lst.Items)
            {
                if (item == s)
                {
                    bool verif = true;
                    return verif;
                }
            }
            return false;
        }

        private void btInput_Click(object sender, EventArgs e)
        {
            if (!verif(tbCountry.Text.ToString(), lbCountry) && !verif(tbCity.Text.ToString(), lbCity))
            {
                lbCountry.Items.Add(tbCountry.Text.ToString());
                lbCity.Items.Add(tbCity.Text.ToString());
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            lbCountry.Items.Remove(lbCountry.SelectedItem);
            lbCity.Items.Remove(lbCity.SelectedItem);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter save = new System.IO.StreamWriter(@"C:\Users\dell-optilex-3010\Documents\liste_pays.csv");

            for (int i = 0; i < lbCountry.Items.Count; i++)
            {
                lbCountry.SelectedItem = lbCountry.Items[i];
                lbCity.SelectedItem = lbCity.Items[i];
                save.WriteLine(lbCountry.Items[i].ToString() + ";" + lbCity.Items[i].ToString());
            }
            save.Close();
        }
    }
}

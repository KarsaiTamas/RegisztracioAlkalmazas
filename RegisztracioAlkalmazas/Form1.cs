using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public void Uj_Hobbi()
        {
            string ad = Uj_Hobbi_TextBox.Text;
            Hobbik_ListBox.Items.Add(ad);
        }

        public void Hobbi_Hozzaad()
        {
             
            Hozzaad_Button.Click += (sender, e) =>
            {
                Uj_Hobbi();
            };
            
        }
        public void Adatok_Menteshez()
        {
            string nem = "";
            if (Ferfi_RadioButton.Checked)
            {
                nem = "Ferfi";
            }
            if (No_RadioButton.Checked)
            {
                nem = "No";
            }
            string textbox = "";
            for (int i = 0; i < Hobbik_ListBox.Items.Count; i++)
            {
                textbox+=Hobbik_ListBox.Items[i]+",";
            }
            int kedvenc_hobbi = Hobbik_ListBox.SelectedIndex;
            textbox = textbox.TrimEnd(',');
            string ertek = "";
            ertek += Nev_TextBox.Text + ";"+ nem + ";"+ Szul_DateTimePicker.Value+";"+kedvenc_hobbi+";"+ textbox;
            var eredmeny = saveFileDialog.ShowDialog(this);
            if (eredmeny == DialogResult.OK)
            {
                string file_nev;
                file_nev = saveFileDialog.FileName;
                using (var file = File.CreateText(file_nev))
                {
                    file.Write(ertek);
                }
            }
        }
        public void Mentes()
        {
            
            Ment_Button.Click += (sender, e) =>
            {
                Adatok_Menteshez();
            };
            
        }
         

        public void Betoltes_Adatok()
        {
            var eredmeny = openFileDialog.ShowDialog(this);
            if (eredmeny == DialogResult.OK)
            {
                string file_nave = openFileDialog.FileName;
                using (var file = File.OpenText(file_nave))
                {
                    string sor = file.ReadLine();
                    string[] adatok = sor.Split(';');
                    string[] hobbik = adatok[adatok.Length-1].Split(',');
                    Nev_TextBox.Text = adatok[0];
                    DateTime asd;
                     
                     if(DateTime.TryParse(adatok[2],out asd) == true) { 
                    Szul_DateTimePicker.Value = asd;
                    }
                    else
                    {
                        Szul_DateTimePicker.Value = DateTime.Today;
                    }
                    if (adatok[1] == "Ferfi")
                    {
                        Ferfi_RadioButton.Checked = true;
                        No_RadioButton.Checked = false;
                    }
                    else
                    {
                        Ferfi_RadioButton.Checked = false;
                        No_RadioButton.Checked = true;
                    }

                    Hobbik_ListBox.Items.Clear();
                    for (int i = 0; i < hobbik.Length; i++)
                    {
                        Hobbik_ListBox.Items.Add(hobbik[i]);
                    }
                    Hobbik_ListBox.SetSelected(int.Parse(adatok[3]),true);
                }
            }

        }
        public void Betoltes()
        {
            Betolt_Button.Click += (sender, e) =>
            {
                Betoltes_Adatok();
            };
        }
        public Form1()
        {
            InitializeComponent();
            Hobbik_ListBox.SetSelected(1, true);
            Hobbi_Hozzaad();
            Mentes();
            Betoltes();
        }
    }
}

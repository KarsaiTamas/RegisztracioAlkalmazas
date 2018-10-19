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
                nem = "no";
            }
            string textbox = "";
            for (int i = 0; i < Hobbik_ListBox.Items.Count; i++)
            {
                textbox+=Hobbik_ListBox.Items[i]+",";
            }
            textbox.Last;
            string ertek = "";
            ertek += Nev_TextBox.Text + ";"+ nem + ";"+ Szul_Cim_TextBox.Text+";"+ textbox;
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
        public Form1()
        {
            InitializeComponent();
            Hobbi_Hozzaad();
            Mentes();
        }
    }
}

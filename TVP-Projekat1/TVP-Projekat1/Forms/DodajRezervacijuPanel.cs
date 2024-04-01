using Dash.Managers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Dash.Forms
{
    public partial class DodajRezervacijuPanel : Form
    {
        private const string placeholder = "Unesite ime jela: ";
        private int odabraniDodaci = 0;
        private bool disableDodaci = false;
        private readonly RestoranManager restoranManager;
        private readonly JeloManager jeloManager;
        private readonly DodatakManager dodatakManager;
        private readonly PrilogManager prilogManager;
        private readonly RezervacijaManager rezervacijaManager;
        private readonly Rezervacija rezervacija;
        public DodajRezervacijuPanel(RestoranManager restoranManager, JeloManager jeloManager, DodatakManager dodatakManager, PrilogManager prilogManager, RezervacijaManager rezervacijaManager, Korisnik korisnik)
        {
            InitializeComponent();
            this.restoranManager = restoranManager;
            this.jeloManager = jeloManager;
            this.dodatakManager = dodatakManager;
            this.prilogManager = prilogManager;
            this.rezervacijaManager = rezervacijaManager;
            rezervacija = new Rezervacija(korisnik.Id);
            var autocompletion = new AutoCompleteStringCollection();
            autocompletion.AddRange(jeloManager.Get().Select(it => it.Naziv).ToArray());
            Filtertb.AutoCompleteCustomSource = autocompletion;
            Filtertb.GotFocus += HandleFocusGetTb;
            Filtertb.LostFocus += HandleFocusLostTb;
            SetPlaceholder(Filtertb);
            RestoranComboBox.DataSource = GetRestoranByFilter();
            RestoranComboBox.SelectedIndex = -1;
            DatumPorudzbinePicker.MinDate = DateTime.Now;
        }

        private void HandleFocusGetTb(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox.Text == placeholder)
            {
                textbox.Clear();
                textbox.ForeColor = Color.Black;    
            }
        }

        private void HandleFocusLostTb(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (string.IsNullOrEmpty(textbox.Text)) SetPlaceholder(textbox);
        }

        private void HandleChangeFilter(object sender, EventArgs e)
        {
            RestoranComboBox.DataSource = GetRestoranByFilter();
            RestoranComboBox.SelectedIndex = -1;
        }
    }
}

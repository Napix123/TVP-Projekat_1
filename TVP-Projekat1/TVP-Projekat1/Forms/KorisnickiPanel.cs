using Dash.Managers;
using Dash.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;


namespace Dash.Forms
{
    public partial class KorisnickiPanel : Form
    {
        private readonly Form loginContainer;
        private readonly Korisnik trenutniKorisnik;
        private readonly RestoranManager restoranManager;
        private readonly JeloManager jeloManager;
        private readonly DodatakManager dodatakManager;
        private readonly PrilogManager prilogManager;
        private readonly RezervacijaManager rezervacijaManager;
        public KorisnickiPanel(Korisnik korisnik, IDictionary<string, IManager> managers)
        {
            InitializeComponent();
            loginContainer = Application.OpenForms["LoginContaienr"];
            Dobrodoslilbl.Text = Dobrodoslilbl.Text.Replaceplaceholders(korisnik);
            this.trenutniKorisnik = korisnik;
            restoranManager = managers["restoran"] as RestoranManager;
            jeloManager = managers["jelo"] as JeloManager;
            dodatakManager = managers["dodatak"] as DodatakManager;
            prilogManager = managers["prilog"] as PrilogManager;
            rezervacijaManager = managers["rezervacija"] as RezervacijaManager;
            Rezervacijelb.DataSource = rezervacijaManager.GetRezervacijaByKorisnik(trenutniKorisnik.Id);
            Infolbl.Text = Infolbl.Text.Replaceplaceholders(korisnik);
        }

        private void HandleFormClose(object sender, EventArgs e)
        {
            if (!loginContainer.Visible) loginContainer.Close();
        }

        private void HandleMeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 13;
            ListBox listbox = sender as ListBox;
            string text = listbox.Items[e.Index].ToString();
            int count = text.Split('\n').Length;
            e.ItemHeight = count * 20;
        }

        private void HandleItemDrawnEvent(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString(Rezervacijelb.Items[e.Index].ToString(), e.Font,
                new SolidBrush(e.ForeColor), e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void HandleFilter(object sender, EventArgs e)
        {
            DateTime odVreme = odDatePicker.Value;
            DateTime doVreme = doDatePicker.Value;

            if (odVreme.Date > doVreme.Date)
            {
                MessageBox.Show("OD vreme ne može biti posle DO vremena");
                return;
            }
            Rezervacijelb.DataSource = rezervacijaManager.GetRezervacijaByKorisnik(trenutniKorisnik.Id)
                .Where(rez => rez.Datum.Date >= odVreme.Date && rez.Datum.Date <= doVreme.Date).ToList();
        }

        private void HandleObrisiFilter(object sender, EventArgs e)
        {
            Rezervacijelb.DataSource = rezervacijaManager.GetRezervacijaByKorisnik(trenutniKorisnik.Id);
        }

        private void SetButtonStatus(bool status)
        {
            Dodajbtn.Enabled = status;
            Filtrirajbtn.Enabled = status;
            Obrisifilterbtn.Enabled = status;
        }

        private void HandleDodajRezervaciju(object sender, EventArgs e)
        {
            SetButtonStatus(false);
            rezervacijaManager.PreventCollision();
            DodajRezervacijuPanel panel = new DodajRezervacijuPanel(
                restoranManager,
                jeloManager,
                dodatakManager,
                prilogManager,
                rezervacijaManager,
                trenutniKorisnik
                );
            panel.FormClosing += (snd, args) =>
            {
                SetButtonStatus(true);
                Rezervacijelb.DataSource = rezervacijaManager.GetRezervacijaByKorisnik(trenutniKorisnik.Id);
            };
            panel.Show();
        }

        private void HandlePromeniSifru(object sender, EventArgs e)
        {
            if (PromeniSifrutb.Text.Length < 6)
            {
                MessageBox.Show("Šifra mora imati barem 6 karaktera!");
                return;
            }
            trenutniKorisnik.Password = PromeniSifrutb.Text;
            MessageBox.Show("Uspešno ste promenili šifru!");
        }

        private void HandleContextOpen(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            ListBox listbox = sender as ListBox;
            var index = listbox.IndexFromPoint(e.Location);
            if (index != -1)
            {
                listbox.SelectedIndex = index;
                contextMenuStrip1.Show(listbox, e.Location);
            }
        }

        private void Infolbl_Click(object sender, EventArgs e)
        {

        }
    }
}

using Dash.Managers;
using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Windows.Forms;

namespace Dash.Forms
{
    public partial class LoginContainer : Form
    {
        private readonly IDictionary<string, IManager> managers;
        public LoginContainer()
        {
            InitializeComponent();
            managers = new Dictionary<string, IManager>()
            {
                ["korisnik"] = new KorisnikManager(),
                ["restoran"] = new RestoranManager(),
                ["jelo"] = new JeloManager(),
                ["dodatak"] = new DodatakManager(),
                ["prilog"] = new PrilogManager(),
                ["rezervacija"] = new RezervacijaManager(),
            };
            this.FormClosing += (sender, args) =>
            {
                foreach (IManager manager in managers.Values)
                {
                    manager.Save();
                }
            };
            this.FormClosed += (sender, args) => Application.Exit();
        }

        private void HandleClick(object sender, EventArgs e)
        {
            if (usernametBox.Text.Length < 4)
            {
                MessageBox.Show("Username mora imati bar 4 karaktera!");
                return;
            }
            Korisnik korisnik;
            try
            {
                korisnik = (managers["korisnik"] as KorisnikManager).TryLogin(usernametBox.Text, passwordtBox.Text);
            }
            catch (AuthenticationException)
            {

                MessageBox.Show("Pogrešna lozinka!");
                passwordtBox.Clear();
                return;
            }
            if (korisnik != null)
            {
                MessageBox.Show("Uneti username nije pronađen, probajte ponovo! ");
                return;
            }
            usernametBox.Clear();
            passwordtBox.Clear();
            if (korisnik.IsAdmin())
            {
                OpenForm(new AdminPanel(korisnik, managers));
            }
            else OpenForm(new KorisnickiPanel(korisnik, managers));
        }

        private void OpenForm(Form form)
        {
            this.Hide();
            form.Show();
        }
        private void LoginContainer_Load(object sender, EventArgs e)
        {

        }
    }
}

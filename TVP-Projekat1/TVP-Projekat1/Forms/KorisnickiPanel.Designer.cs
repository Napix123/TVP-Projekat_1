namespace Dash.Forms
{
    partial class KorisnickiPanel
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
            this.Rezervacijelb = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.odDatePicker = new System.Windows.Forms.DateTimePicker();
            this.doDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Filtrirajbtn = new System.Windows.Forms.Button();
            this.Obrisifilterbtn = new System.Windows.Forms.Button();
            this.Dodajbtn = new System.Windows.Forms.Button();
            this.Infolbl = new System.Windows.Forms.Label();
            this.PromeniSifrutb = new System.Windows.Forms.TextBox();
            this.Sifrabtn = new System.Windows.Forms.Button();
            this.Dobrodoslilbl = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rezervacijelb
            // 
            this.Rezervacijelb.FormattingEnabled = true;
            this.Rezervacijelb.ItemHeight = 16;
            this.Rezervacijelb.Location = new System.Drawing.Point(9, 134);
            this.Rezervacijelb.Name = "Rezervacijelb";
            this.Rezervacijelb.Size = new System.Drawing.Size(1040, 244);
            this.Rezervacijelb.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 147);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1060, 434);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Dodajbtn);
            this.tabPage1.Controls.Add(this.Obrisifilterbtn);
            this.tabPage1.Controls.Add(this.Filtrirajbtn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.doDatePicker);
            this.tabPage1.Controls.Add(this.odDatePicker);
            this.tabPage1.Controls.Add(this.Rezervacijelb);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1052, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rezervacije";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Sifrabtn);
            this.tabPage2.Controls.Add(this.PromeniSifrutb);
            this.tabPage2.Controls.Add(this.Infolbl);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1052, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Profil";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // odDatePicker
            // 
            this.odDatePicker.Location = new System.Drawing.Point(19, 57);
            this.odDatePicker.Name = "odDatePicker";
            this.odDatePicker.Size = new System.Drawing.Size(200, 22);
            this.odDatePicker.TabIndex = 1;
            // 
            // doDatePicker
            // 
            this.doDatePicker.Location = new System.Drawing.Point(343, 57);
            this.doDatePicker.Name = "doDatePicker";
            this.doDatePicker.Size = new System.Drawing.Size(200, 22);
            this.doDatePicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Do";
            // 
            // Filtrirajbtn
            // 
            this.Filtrirajbtn.Location = new System.Drawing.Point(562, 21);
            this.Filtrirajbtn.Name = "Filtrirajbtn";
            this.Filtrirajbtn.Size = new System.Drawing.Size(94, 37);
            this.Filtrirajbtn.TabIndex = 4;
            this.Filtrirajbtn.Text = "Filtriraj";
            this.Filtrirajbtn.UseVisualStyleBackColor = true;
            // 
            // Obrisifilterbtn
            // 
            this.Obrisifilterbtn.Location = new System.Drawing.Point(562, 91);
            this.Obrisifilterbtn.Name = "Obrisifilterbtn";
            this.Obrisifilterbtn.Size = new System.Drawing.Size(101, 37);
            this.Obrisifilterbtn.TabIndex = 5;
            this.Obrisifilterbtn.Text = "Obrisi filter";
            this.Obrisifilterbtn.UseVisualStyleBackColor = true;
            // 
            // Dodajbtn
            // 
            this.Dodajbtn.Location = new System.Drawing.Point(863, 50);
            this.Dodajbtn.Name = "Dodajbtn";
            this.Dodajbtn.Size = new System.Drawing.Size(145, 37);
            this.Dodajbtn.TabIndex = 6;
            this.Dodajbtn.Text = "Dodaj";
            this.Dodajbtn.UseVisualStyleBackColor = true;
            // 
            // Infolbl
            // 
            this.Infolbl.AutoSize = true;
            this.Infolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Infolbl.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Infolbl.Location = new System.Drawing.Point(224, 58);
            this.Infolbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Infolbl.Name = "Infolbl";
            this.Infolbl.Size = new System.Drawing.Size(595, 29);
            this.Infolbl.TabIndex = 0;
            this.Infolbl.Text = "Username: {Username} Ime: {Ime} Prezime: {Prezime}";
            this.Infolbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Infolbl.Click += new System.EventHandler(this.Infolbl_Click);
            // 
            // PromeniSifrutb
            // 
            this.PromeniSifrutb.Location = new System.Drawing.Point(254, 204);
            this.PromeniSifrutb.Name = "PromeniSifrutb";
            this.PromeniSifrutb.Size = new System.Drawing.Size(190, 22);
            this.PromeniSifrutb.TabIndex = 1;
            // 
            // Sifrabtn
            // 
            this.Sifrabtn.Location = new System.Drawing.Point(514, 203);
            this.Sifrabtn.Name = "Sifrabtn";
            this.Sifrabtn.Size = new System.Drawing.Size(199, 23);
            this.Sifrabtn.TabIndex = 2;
            this.Sifrabtn.Text = "Promeni sifru";
            this.Sifrabtn.UseVisualStyleBackColor = true;
            // 
            // Dobrodoslilbl
            // 
            this.Dobrodoslilbl.AutoSize = true;
            this.Dobrodoslilbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dobrodoslilbl.Location = new System.Drawing.Point(368, 54);
            this.Dobrodoslilbl.Name = "Dobrodoslilbl";
            this.Dobrodoslilbl.Size = new System.Drawing.Size(318, 32);
            this.Dobrodoslilbl.TabIndex = 2;
            this.Dobrodoslilbl.Text = "{Username}, dobrodosli!";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // KorisnickiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 593);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.Dobrodoslilbl);
            this.Controls.Add(this.tabControl1);
            this.Name = "KorisnickiPanel";
            this.Text = "KorisnickiPanel";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Rezervacijelb;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Dodajbtn;
        private System.Windows.Forms.Button Obrisifilterbtn;
        private System.Windows.Forms.Button Filtrirajbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker doDatePicker;
        private System.Windows.Forms.DateTimePicker odDatePicker;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Infolbl;
        private System.Windows.Forms.Button Sifrabtn;
        private System.Windows.Forms.TextBox PromeniSifrutb;
        private System.Windows.Forms.Label Dobrodoslilbl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class edit : Form
    {
        #region Properties
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Iban { get; set; }
        public string Ort { get; set; }
        public int ID { get; set; }
        #endregion

        #region Funktionen
        public edit(int id, string vorname, string nachname, string ort, string iban)
        {
            InitializeComponent();
            Vorname = vorname;
            ID = id;
            Nachname = nachname;
            Ort = ort;
            Iban = iban;
        }

        public void setTextBoxen(){
            tb_vorname.Text = Vorname;
            tb_nachname.Text = Nachname;
            tb_ort.Text = Ort;
            tb_iban.Text = Iban;
        }

        public void getTextBoxen()
        {
            Vorname= tb_vorname.Text;
            Nachname= tb_nachname.Text;
            Ort= tb_ort.Text;
            Iban= tb_iban.Text;
        }

        public void save() //Mitarbeiter speichern
        {
            SqlConnection con = new SqlConnection(Form1.constr);

            SqlCommand cmd = new SqlCommand("UPDATE dbo.kunden SET Vorname = @vorname, Nachname = @nachname, Wohnort = @ort, IBAN = @iban WHERE kundenID = @ID", con);

            con.Open();

            cmd.Parameters.AddWithValue("@vorname", Vorname);
            cmd.Parameters.AddWithValue("@nachname", Nachname);
            cmd.Parameters.AddWithValue("@ort", Ort);
            cmd.Parameters.AddWithValue("@iban", Iban);
            cmd.Parameters.AddWithValue("@ID", ID);

            cmd.ExecuteNonQuery();

            con.Close();
        }

        public void add() //Mitarbeiter hinzufügen
        {
            SqlConnection con = new SqlConnection(Form1.constr);

            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.kunden (Vorname,Nachname,Wohnort,Iban) VALUES (@vorname,@nachname,@ort,@iban)", con);

            con.Open();

            cmd.Parameters.AddWithValue("@vorname", Vorname);
            cmd.Parameters.AddWithValue("@nachname", Nachname);
            cmd.Parameters.AddWithValue("@ort", Ort);
            cmd.Parameters.AddWithValue("@iban", Iban);

            cmd.ExecuteNonQuery();

            con.Close();
        }
        #endregion

        #region Event Listener
        private void saveBTN_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}

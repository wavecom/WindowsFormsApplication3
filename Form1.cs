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


/* Datenbank Login in .xml
 * Neue Mitarbeiter anlegen
 * Nach Edit neu laden
 * */

namespace WindowsFormsApplication3
{

    public partial class Form1 : Form
    {
        #region Properties
        public static string constr { get; set; }
        #endregion

        #region Konstruktor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Listener
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //edit Button
        {
            DataGridViewRow reihe = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
            reihe.Selected = true;
            int id = (int)reihe.Cells[0].Value;
            String vorname = reihe.Cells[1].Value.ToString();
            String nachname = reihe.Cells[2].Value.ToString();
            String ort = reihe.Cells[3].Value.ToString();
            String iban = reihe.Cells[4].Value.ToString();

            edit edit = new edit(id, vorname, nachname, ort, iban);

            edit.setTextBoxen();
            DialogResult dr = edit.ShowDialog();

            if (dr == DialogResult.OK)
            {
                edit.getTextBoxen();
                edit.save();
                edit.Close();
                reihe.Cells[1].Value = edit.Vorname;
                reihe.Cells[2].Value = edit.Nachname;
                reihe.Cells[3].Value = edit.Ort;
                reihe.Cells[4].Value = edit.Iban;
            }

        }

        private void button2_Click(object sender, EventArgs e) //Datenbank button
        {
            //Server: LBW7\\SAGE User: sa PW: iwm db:kunden
            LoginFenster login = new LoginFenster();
            DialogResult dr = login.ShowDialog();

            if (dr == DialogResult.OK) {

                string sql = "SELECT * FROM dbo.kunden";
                constr = login.getString();
                SqlConnection connection = new SqlConnection(constr);
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "kunden");
                connection.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "kunden";
                login.Close();
            }
        }

        private void NeuerMitarbeiter_Click(object sender, EventArgs e)
        {
            edit edit = new edit(-1, "", "", "", "");
            DialogResult dr = edit.ShowDialog();

            if (dr == DialogResult.OK)
            {
                edit.getTextBoxen();
                edit.add();
                edit.Close();
            }
        }
        #endregion

        #region Funktionen

        #endregion
    }
}

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
using System.Xml;

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
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\lbroichhaus\\Documents\\Visual Studio 2013\\Projects\\WindowsFormsApplication3\\WindowsFormsApplication3\\config.xml");
            XmlNode config = doc.SelectSingleNode("/config");
            string srv = config.ChildNodes[0].InnerText;
            string db = config.ChildNodes[1].InnerText;
            string usr = config.ChildNodes[2].InnerText;
            string pw = config.ChildNodes[3].InnerText;
            string trusted = config.ChildNodes[4].InnerText;
            if (trusted == "true"){
                constr = String.Format("Server={0};Database={1};Trusted_Connection=True;", srv, db);
            }else{
                constr = String.Format("Server={0};Database={1};User Id={2};Password={3};",srv ,db, usr, pw);
            }
            loadSQL();
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
                constr = login.getString();
                loadSQL();
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
                loadSQL();
            }
        }
        #endregion

        #region Funktionen

        private void loadSQL()
        {
            string sql = "SELECT * FROM dbo.kunden";
            SqlConnection connection = new SqlConnection(constr);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "kunden");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "kunden";
        }
        #endregion
    }
}

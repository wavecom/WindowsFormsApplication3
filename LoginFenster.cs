using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class LoginFenster : Form
    {

        #region Konstruktor

        public LoginFenster()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Listener

        private void trusted_CheckedChanged(object sender, EventArgs e)
        {
            bool b = (trusted.Checked) ? false : true; //Ternary Operator 
            tb_pw.Enabled = b;
            tb_usr.Enabled = b;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Funktionen
        public string getString()
        {
            string connectionString;
            if (trusted.Checked)
            {
                connectionString = String.Format("Server={0};" +
                                "Database={1};" +
                                "Trusted_Connection=True;",
                                tb_srv.Text,
                                tb_db.Text
                                );
            }
            else
            {
                connectionString = String.Format("Server={0};" +
                                "Database={1};" +
                                "User Id={2};" +
                                "Password={3};",
                                tb_srv.Text,
                                tb_db.Text,
                                tb_usr.Text,
                                tb_pw.Text
                                );
            }
            return connectionString;
        }
        #endregion

    }
}

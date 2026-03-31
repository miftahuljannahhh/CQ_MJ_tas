using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PraktikumADO
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Koneksi()
        {
            conn = new SqlConnection(
                "Data Source=MIFTAHULJANNAH\\MIFTAHJW;Initial Catalog=DBAkademikADO;Integrated Security=True"
            );
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnHitungMhs_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace production_activity
{
    public partial class frmPO : Form
    {
        private OleDbConnection con;
        public frmPO()
        {
            InitializeComponent();
            con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =C:\Users\User\Desktop\dev\2NDYEAR\2nd SEM\appsdev\production-activity\PRODUCTION.mdb");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string BOM =
            @"INSERT INTO BOMHeaderFile(BOMHNO,BOMHDATE,BOMHJONO,BOMHPRODCODE,BOMHPREPBY,BOMHAPBY)
            VALUES (@Bomhno,@Date,@Bomhjono,@Bomhprodcode,@Bomhprodcode,@Bomhprepby,@Bomhapby);

            INSERT INTO BOMDetailFile(BOMDNO,BOMDMATCODE,BOMDQTYNEED,BOMDTOTQTYNEED)
            VALUES (@Bomdno, @Bomdmatcode, @Bomdqtycode, @Bomdtotqtyneed)";

            OleDbCommand command = new OleDbCommand(BOM, con);
            try
            {
                con.Open();
                command.Parameters.AddWithValue("@Bomhno", int.Parse(txtBoxBOMNo.Text));
                command.Parameters.AddWithValue("@Date", DateTime.ParseExact(txtBoxDate.Text, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture));
                command.Parameters.AddWithValue("@Bomhprodcode", int.Parse(txtBoxSC.Text));
                command.Parameters.AddWithValue("@Bomhprepby", int.Parse(txtBoxID1.Text));
                command.Parameters.AddWithValue("@Bomhapby", int.Parse(txtBoxID2.Text));
                command.Parameters.AddWithValue("@Bomdno", int.Parse(txtBoxBOMNo.Text));
                command.Parameters.AddWithValue("@Bomdmatcode", "Stone");

                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
            }
            catch (Exception)
            {
                MessageBox.Show("Error na ako utok, Naglibog nako sir", "Adding value", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

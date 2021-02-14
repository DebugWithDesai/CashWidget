using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CashWidget
{
    public partial class CashWidgetMainForm : Form
    {
        public CashWidgetMainForm()
        {
            InitializeComponent();
        }


        public static void MakeConnection()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source=C:/Users/user/source/repos/CashWidget/bin/Debug/Database/Database.db;Version = 3;New = True;Compress = True;");
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while establishing connection to the database.");
            }

        }

        private void CashWidgetMainForm_Load(object sender, EventArgs e)
        {
            MakeConnection();
        }

        private void addTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AddTransactionForm = new AddTransaction();
            AddTransactionForm.Show();
        }
    }
}

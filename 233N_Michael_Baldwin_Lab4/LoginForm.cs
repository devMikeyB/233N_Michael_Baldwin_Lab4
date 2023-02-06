using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _233N_Michael_Baldwin_Lab4
{
    public partial class LoginForm : Form
    {
        OleDbConnection dbConnection = new OleDbConnection();

        public LoginForm()
        {
            InitializeComponent();
            dbConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\acc.accdb";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string inpUser = userTextBox.Text; //User input USER
            string inpPassword = passTextBox.Text; //User input PASS
            dbConnection.Open(); //Open Database at connection string.
            OleDbCommand command = new OleDbCommand(); //Init command object
            command.Connection = dbConnection;
            command.CommandText = "SELECT * " + //SQL query to find matching user and password.
                                  "FROM accounts " +
                                  "WHERE Username='"+inpUser+"' " +
                                  "AND Password='"+inpPassword+"';";

            //Console.WriteLine(command.ExecuteNonQuery());

            OleDbDataReader reader = command.ExecuteReader();

            int c = 0;
            while (reader.Read()) //reader object returns True if it advances to a new line.
            { 
                c++;
            }
            if (c == 1) //If reader found a line.
            {
               MessageBox.Show("Logged in as "+ inpUser);
                Travelers travelers = new Travelers();
                travelers.ShowDialog();
            }
            else //Not found
            {
                MessageBox.Show("Not found");
            }
            c = 0; //Reset count to 0;

            

            /*if (command.ExecuteNonQuery() == 1)  ////////<---This would be preferred if it were usable with simple selects, but it will only return a value if a row was CHANGED by the statement.
            {
                Console.WriteLine("Logged in");
            } else { Console.WriteLine("Not Found"); }
            */
            dbConnection.Close(); //Close connection.
        }
    }
}

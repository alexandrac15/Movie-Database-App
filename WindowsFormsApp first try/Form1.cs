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
using System.Data;
namespace WindowsFormsApp_first_try
{
    public partial class MDB : Form
    {
        public MDB()
        {
            InitializeComponent();
        }

        private void ShowDirectors_Click(object sender, EventArgs e)
        {
            SqlConnection connection = null;
            using (
              connection = new SqlConnection("Server=DESKTOP-51G331G\\SQLEXPRESS;Database=MDB;Trusted_Connection=True")
              )
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Directors", connection);
                DataSet Directors = new DataSet();
                adapter.Fill(Directors, "Directors");
               

                ListBox.Items.Clear();
                foreach (DataRow row in Directors.Tables["Directors"].Rows)
                {   
                    ListBox.Items.Add(row["DID"] + " " + row["DName"]);
                }
            }

        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = ListBox.GetItemText(ListBox.SelectedItem);
            int indexD= Convert.ToInt16(text[0].ToString());
           

            SqlConnection connection = null;
            using (
              connection = new SqlConnection("Server=DESKTOP-51G331G\\SQLEXPRESS;Database=MDB;Trusted_Connection=True")
              )
            {
                SqlDataAdapter adapter1 = new SqlDataAdapter("select m.MID,m.Title,m.DID from Movies m inner join Directors d on d.DID=m.DID", connection);
                DataSet Movies = new DataSet();
                adapter1.Fill(Movies, "Movies");



                listBox1.Items.Clear();
                foreach (DataRow row in Movies.Tables["Movies"].Rows)
                {   if(row["DID"].Equals(indexD)){
                        listBox1.Items.Add(row["MID"] + " " + row["Title"]);
                    }
                }
            }
    
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = null;
            using (
            connection = new SqlConnection("Server=DESKTOP-51G331G\\SQLEXPRESS;Database=MDB;Trusted_Connection=True")
            )
            {
                SqlDataAdapter adapter1 = new SqlDataAdapter("select * from Movies", connection);
                DataSet Movies = new DataSet();
                adapter1.Fill(Movies, "Movies");
                connection.Open();

                string text = ListBox.GetItemText(ListBox.SelectedItem);
                int indexD = Convert.ToInt16(text[0].ToString());
                string toInsert = "";



                toInsert = "insert into Movies values (" + "'" + textBoxTitle.Text + "'" + "," + Convert.ToDouble(textBoxRating.Text) + "," + textBoxYear.Text + "," + indexD + ")";
                SqlCommand insertCommand = new SqlCommand(toInsert, connection);
                adapter1.InsertCommand = insertCommand;
                adapter1.InsertCommand.ExecuteNonQuery();

            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = null;
            using (
            connection = new SqlConnection("Server=DESKTOP-51G331G\\SQLEXPRESS;Database=MDB;Trusted_Connection=True")
            )
            {
                SqlDataAdapter adapter1 = new SqlDataAdapter("select * from Movies", connection);
                DataSet Movies = new DataSet();
                adapter1.Fill(Movies, "Movies");
                connection.Open();

                string text = ListBox.GetItemText(ListBox.SelectedItem);
                int indexD = Convert.ToInt16(text[0].ToString());
                string toDelete = "";

                toDelete = "delete from Movies where " + "Title=" + "'" + textBoxTitle.Text + "'" ;


                SqlCommand insertCommand = new SqlCommand(toDelete, connection);
                adapter1.InsertCommand = insertCommand;
                adapter1.InsertCommand.ExecuteNonQuery();

            }

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = null;
            using (
            connection = new SqlConnection("Server=DESKTOP-51G331G\\SQLEXPRESS;Database=MDB;Trusted_Connection=True")
            )
            {
                SqlDataAdapter adapter1 = new SqlDataAdapter("select * from Movies", connection);
                DataSet Movies = new DataSet();
                adapter1.Fill(Movies, "Movies");
                connection.Open();
               
                string text = listBox1.GetItemText(listBox1.SelectedItem);
                int indexM = Convert.ToInt16(text[0].ToString());
                string toUpdate = "";

                toUpdate = "update Movies set Title=" + "'" + textBoxTitle.Text + "', Rating=" + "'" + textBoxRating.Text + "',Year= " + "'" + Convert.ToInt16(textBoxYear.Text) + "' where MID=" + text[0].ToString();

                SqlCommand insertCommand = new SqlCommand(toUpdate, connection);
                adapter1.InsertCommand = insertCommand;
                adapter1.InsertCommand.ExecuteNonQuery();


            }

        }
    }  
}

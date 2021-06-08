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
using System.Drawing.Imaging;
using System.IO;

namespace BasicSQLConnections
{
    public partial class Form1 : Form
    {
        private SqlConnection _sqlConnection;
        public Form1()
        {
            InitializeComponent();
            _sqlConnection = new SqlConnection();
            _sqlConnection.ConnectionString = "Server=localhost;Database=Northwind;User Id=sa;Password=12345;";
        }


        void GetRecords()
        {

            var sqlCommand = new SqlCommand();
            sqlCommand.Connection = _sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM Categories";

            var sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            var dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable); dgCategories.DataSource = dataTable;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetRecords();
        }

        void addCategory(string categoryName, string description, byte[] picture)
        {
            var sqlCommand = new SqlCommand();
            sqlCommand.Connection = _sqlConnection;
            sqlCommand.CommandText = "INSERT INTO Categories(CategoryName,Description,Picture)" +
                                     " VALUES(@CategoryName,@Description,@Picture)";

            sqlCommand.Parameters.AddWithValue("@CategoryName", categoryName);
            sqlCommand.Parameters.AddWithValue("@Description", description);
            sqlCommand.Parameters.AddWithValue("@Picture", picture);

            _sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var categoryName = this.txtCategoryName.Text;
            var description = this.txtDescription.Text;

            var ms = new MemoryStream();
            pictureBox1.Image.Save(ms, ImageFormat.Gif);
            var picture = ms.ToArray();

            addCategory(categoryName,description,picture);

            GetRecords();
            Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image=Image.FromFile(openFileDialog.FileName);
            }
        }

        void deleteCategory(int categoryId)
        {
            var sqlCommand = new SqlCommand();
            sqlCommand.Connection = _sqlConnection;
            sqlCommand.CommandText = "DELETE FROM Categories WHERE CategoryID=@CategoryID";

            sqlCommand.Parameters.AddWithValue("@CategoryID", categoryId);
           

            _sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public int CategoryId { get; set; }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteCategory(CategoryId);
            GetRecords();
            Clear();
        }

        private void dgCategories_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var item = (int)dgCategories.Rows[e.RowIndex].Cells[0].Value;

                CategoryId = item;

                var (categoryName, description, picture)=GetCategory(CategoryId);
                txtCategoryName.Text = categoryName;
                txtDescription.Text = description;
                pictureBox1.Image=picture;

            }
            catch (Exception exception)
            {
                CategoryId = -1;
            }
            
        }

        (string, string, Image) GetCategory(int categoryId)
        {
            var sqlCommand = new SqlCommand();
            sqlCommand.Connection = _sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM Categories WHERE CategoryID=@CategoryID";

            sqlCommand.Parameters.AddWithValue("@CategoryID", categoryId); ;


            if (_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            var categoryName=sqlDataReader.GetString("CategoryName");
            var description = sqlDataReader.GetString("Description");
            var picture =(Image)(new ImageConverter().ConvertFrom((byte[])sqlDataReader["Picture"]));


            _sqlConnection.Close();

            return (categoryName, description, picture);
        }

        void Clear()
        {
            txtCategoryName.Clear();
            txtDescription.Clear();
            pictureBox1.Image = null;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }


        void updateCategory(string categoryName, string description, byte[] picture)
        {
            var sqlCommand = new SqlCommand();
            sqlCommand.Connection = _sqlConnection;
            sqlCommand.CommandText = "UPDATE Categories SET CategoryName=@CategoryName, Description=@Description, " +
                                     "Picture=@Picture WHERE CategoryID=@CategoryID";

            sqlCommand.Parameters.AddWithValue("@CategoryID", CategoryId);
            sqlCommand.Parameters.AddWithValue("@CategoryName", categoryName);
            sqlCommand.Parameters.AddWithValue("@Description", description);
            sqlCommand.Parameters.AddWithValue("@Picture", picture);

            _sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var categoryName = txtCategoryName.Text;
            var description = txtDescription.Text;

            var ms = new MemoryStream();
            pictureBox1.Image.Save(ms, ImageFormat.Gif);
            var picture = ms.ToArray();

            updateCategory(categoryName,description,picture);

            GetRecords();
            Clear();
        }
    }
}

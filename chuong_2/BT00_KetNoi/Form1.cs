using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //sử dụng khi kết nối và làm việc với Access
using System.Data.SqlClient; // sử dụng khi kết nối và làm việc với SQL Server

namespace BT00_KetNoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcc2003_Click(object sender, EventArgs e)
        {
            //Khai báo các đối tượng cần sử dụng để tạo kết nối
            //1. Chuỗi kết nối đến Access 2003
            string strcon = @"provider=microsoft.jet.oledb.4.0; data source = ..\..\..\Data\QL_SINHVIEN.mdb";
            //2. Khai báo đối tượng kết nối
            OleDbConnection cnn = new OleDbConnection(strcon);
            //3. Mở kết nối
            cnn.Open();
            //4. Kiểm tra kết nối có được mở không
            if(cnn.State == ConnectionState.Open)
            {
                MessageBox.Show("Kết nối đã mở.");
            }
            //5. Đóng kết nối
            cnn.Close();
        }

        private void btnAcc2019_Click(object sender, EventArgs e)
        {
            //Khai báo các đối tượng cần sử dụng để tạo kết nối
            //1. Chuỗi kết nối đến Access 2019
            string strcon = @"provider=microsoft.ACE.oledb.12.0; data source = ..\..\..\Data\QL_SINHVIEN.mdb";
            //2. Khai báo đối tượng kết nối
            OleDbConnection cnn = new OleDbConnection(strcon);
            //3. Mở kết nối
            cnn.Open();
            //4. Kiểm tra kết nối có được mở không
            if (cnn.State == ConnectionState.Open)
            {
                MessageBox.Show("Kết nối đã mở.");
            }
            //5. Đóng kết nối
            cnn.Close();
        }

        private void btnSQLWin_Click(object sender, EventArgs e)
        {
            //Khai báo các đối tượng cần sử dụng để tạo kết nối
            //1. Chuỗi kết nối đến SQL Server bằng user của Windows
            string strcon = @"server=.; database=C21TH2_LTCSDL; integrated security=true";
            //2. Khai báo đối tượng kết nối
            SqlConnection cnn = new SqlConnection(strcon);
            //3. Mở kết nối
            cnn.Open();
            //4. Kiểm tra kết nối có được mở không
            if (cnn.State == ConnectionState.Open)
            {
                MessageBox.Show("Kết nối đã mở.");
            }
            //5. Đóng kết nối
            cnn.Close();
        }

        private void btnSQLsa_Click(object sender, EventArgs e)
        {
            //Khai báo các đối tượng cần sử dụng để tạo kết nối
            //1. Chuỗi kết nối đến SQL Server bằng user của Windows
            string strcon = @"server=.; database=C21TH2_LTCSDL; uid=sa; pwd=c21th";
            //2. Khai báo đối tượng kết nối
            SqlConnection cnn = new SqlConnection(strcon);
            //3. Mở kết nối
            cnn.Open();
            //4. Kiểm tra kết nối có được mở không
            if (cnn.State == ConnectionState.Open)
            {
                MessageBox.Show("Kết nối đã mở.");
            }
            //5. Đóng kết nối
            cnn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

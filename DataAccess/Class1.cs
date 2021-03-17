using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess
{
    public class Data
    {
        public SqlConnection getConnect() //Nhận chuỗi kết nối
        {
            return new SqlConnection("Data Source=THANG-PC;Initial Catalog=QuanLyBaiTapLon;Integrated Security=True");
        }
        //Lệnh trả về một bảng
        public DataTable getTable(string sql)
        {
            SqlConnection connect = getConnect();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return (data);
        }
        //Lệnh thực hiện 1 hành động, không trả về một bảng
        public void ExecuteNonQuery(string sql)
        {
            SqlConnection connect = getConnect();
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
    }
}

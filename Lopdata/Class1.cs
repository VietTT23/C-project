using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataAccess;

namespace Lopdata
{
    #region Lớp đăng nhập
    //-------------Lớp đăng nhập----------------------------------//
    public class Dangnhap
    {
        Data dn = new Data();
        //Hàm thêm tài khoản
        public void themtaikhoan(string ten, string pass)
        {
            string sql = "insert into tblTaiKhoan(Ten,Pass,QThem,QSua,QXoa,QIn,QTim) values(N'" + ten + "',N'" + pass + "',N'" + false + "',N'" + false + "',N'" + false + "',N'" + false + "',N'" + false + "' )";
            dn.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
            //N phòng trường hợp lỗi font tiếng việt
        }
        public DataTable ShowDN()
        {
            string sql = "Select * from tblTaiKhoan";
            DataTable dt = new DataTable();
            dt = dn.getTable(sql);
            return dt;
        }
        public void InsertQuyen(string dk, bool them, bool sua, bool xoa, bool In, bool tim)
        {

            string sql = "Update  tblTaiKhoan set QThem=N'" + them + "',QSua=N'" + sua + "',QXoa=N'" + xoa + "',QIn=N'" + In + "',QTim=N'" + tim + "' where Ten=N'" + dk + "' ";
            dn.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
            //N phòng trường hợp lỗi font tiếng việt
        }
        public void Xoa(string dk)
        {
            string sql = "delete tblTaiKhoan Where Ten=N'" + dk + "'";
            dn.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
            //N phòng trường hợp lỗi font tiếng việt
        }
    }


    public class TK
    {
        Data tk = new Data();
        //Hàm thêm tài khoản
        public DataTable Timsv(string dk)
        {
            string sql = "select * from view1 where TenBTL like N'%" + dk + "%' or TenCD like N'%" + dk + "%'  or TenSV like N'%" + dk + "%' or TenLop like N'%" + dk + "%' or TenGV like N'%" + dk + "%' or TenHP like N'%" + dk + "%' or TenSV like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = tk.getTable(sql);
            return dt;
        }

    }
    #endregion

    #region Lớp sinh viên
    //--------------------------Lớp sinh viên--------------------------------//
    public class SV
    {
        Data sv = new Data();
        //Hàm lấy thông tin và đổ ra 1 datagridview
        public DataTable ShowKho()
        {
            string sql = "Select * from tblSV";
            DataTable dt = new DataTable();
            dt = sv.getTable(sql);
            return dt;
        }


        public void Insertsv(string ma, string ten, string ns, string em, string sdt, string lop)
        {

            string sql = "insert into tblSV (MaSV,TenSV ,NamSinh,Email,SDT,MaLop) values(N'" + ma + "',N'" + ten + "',N'" + ns + "',N'" + em + "',N'" + sdt + "',N'" + lop + "')";
            sv.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
            //N phòng trường hợp lỗi font tiếng việt
        }

        public void Updatesv(string ma, string ten, string ns, string em, string sdt, string lop)
        {
            string sql = "update tblSV set TenSV=N'" + ten + "' ,NamSinh=N'" + ns + "',Email=N'" + em + "',SDT=N'" + sdt + "',MaLop=N'" + lop + "'   where MaSV=N'" + ma + "'";
            sv.ExecuteNonQuery(sql);
            //lệnh thực thi không trả về bảng đã viết bên lớp 1
            //N phòng trường hợp lỗi font tiếng việt

        }
        public void Deletesv(string ml)
        {
            string sql = "delete tblSV where MaSV=N'" + ml + "'";
            sv.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
            //N phòng trường hợp lỗi font tiếng việt
        }
        //Hàm lấy thông tin và đổ ra 1 datagridview
        public DataTable Timsv(string dk)
        {
            string sql = "select * from tblSV where MaSV like N'%" + dk + "%' or TenSV like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = sv.getTable(sql);
            return dt;
        }
    }
    #endregion

    #region Lớp lớp
    // ------------------Lớp lớp--------------------------//
    public class LOP
    {
        Data Lop = new Data();
        //Hàm lấy thông tin và đổ ra 1 datagridview
        public DataTable ShowLop()
        {
            DataTable dt = new DataTable();
            string sql = "select *from tblLop";
            dt = Lop.getTable(sql);
            return (dt);
        }
        public void ThemLop(string ma, string ten, int sosv, string kdt, string bdt)
        {
            string sql = "insert into tblLop (MaLop,TenLop,SoSV,KhoaDaoTao,BacDaoTao) values(N'" + ma + "',N'" + ten + "',N'" + sosv + "',N'" + kdt + "',N'" + bdt + "')";
            Lop.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
            //N phòng trường hợp lỗi font tiếng việt

        }
        //Hàm lấy thông tin và đổ ra 1 datagridview
        public DataTable timLop(string dk)
        {
            string sql = " select * from tblLop where MaLop like N'%" + dk + "%' or TenLop like N'%" + dk + "%' or KhoaDaoTao like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = Lop.getTable(sql);
            return dt;
        }
        public void SuaLop(string ma, string ten, int sosv, string kdt, string bdt)
        {
            string sql = " update tblLop set TenLop=N'" + ten + "',SoSV=N'" + sosv + "',KhoaDaoTao=N'" + kdt + "',BacDaoTao=N'" + bdt + "'  where MaLop=N'" + ma + "' ";
            Lop.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
            //N phòng trường hợp lỗi font tiếng việt ,,,
        }
        public void XoaLop(string dk)
        {
            string sql = "delete tblLop where MaLop=N'" + dk + "'";
            Lop.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
            //N phòng trường hợp lỗi font tiếng việt
        }
    }
    #endregion

    #region Lớp hướng dẫn
    //--------------------Lớp hướng dẫn--------------------------------------------------------//
    //public class HD
    //{
    //    Data HuongDan = new Data();
    //    //Hàm lấy thông tin và đổ ra 1 datagridview
    //    public DataTable ShowHuongDan()
    //    {
    //        string sql = "Select * from tblHuongDan";
    //        DataTable dt = new DataTable();
    //        dt = HuongDan.GetTable(sql);
    //        return dt;
    //    }

    //    public void InsertHuongDan(string ma1, string ma2, string nx,int d)
    //    {
    //        string sql = "insert into tblHuongDan (DeTaiId,GiangVienId,NhanXet,Diem) values(N'" + ma1 + "',N'" + ma2 + "', N'" + nx + "', N'" + d + "')";
    //        HuongDan.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
    //        //N phòng trường hợp lỗi font tiếng việt

    //    }
    //    public void UpdateHuongDan(string dk1, string dk2, string m1, int m2)
    //    {
    //        string sql = "update tblHuongDan set NhanXet=N'" + m1 + "',Diem=N'" + m2 + "' Where DeTaiId = N'" + dk1 + "' and GiangVienId= N'" + dk2 + "'";
    //        HuongDan.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
    //        //N phòng trường hợp lỗi font tiếng việt
    //    }

    //    public void XoaHuongDan(string ma, string ma1)
    //    {
    //        string sql = "delete tblHuongDan where DeTaiId=N'" + ma + "' and GiangVienId= N'" + ma1 + "'";
    //        HuongDan.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
    //        //N phòng trường hợp lỗi font tiếng việt
    //    }
    //    //Hàm lấy thông tin và đổ ra 1 datagridview
    //    public DataTable TimHuongDan(string dk)
    //    {
    //        string sql = "select * from tblHuongDan where DeTaiId like N'%" + dk + "%' or GiangVienId like N'%" + dk + "%'";
    //        DataTable dt = new DataTable();
    //        dt = HuongDan.GetTable(sql);
    //        return dt;
    //    }
    //}
    #endregion

    #region Lớp hội đồng
    //--------------------Lớp hội đồng--------------------------------------------------------//
    public class HD1
    {
        Data HoiDong = new Data();
        //Hàm lấy thông tin và đổ ra 1 datagridview
        public DataTable ShowHoiDong()
        {
            string sql = "Select * from tblHoiDong";
            DataTable dt = new DataTable();
            dt = HoiDong.getTable(sql);
            return dt;
        }

        public void InsertHoiDong(string ma, string cthd, int sotv)
        {
            string sql = "insert into tblHoiDong (MaHoiDong,ChuTichHD,Soluong) values(N'" + ma + "',N'" + cthd + "', N'" + sotv + "')";
            HoiDong.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
            //N phòng trường hợp lỗi font tiếng việt

        }
        public void UpdateHoiDong(string ma, string cthd, int sotv)
        {
            string sql = "update tblHoiDong set ChuTichHD= N'" + cthd + "',Soluong=  N'" + sotv + "'  Where MaHoiDong = N'" + ma + "'";
            HoiDong.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
            //N phòng trường hợp lỗi font tiếng việt ,
        }

        public void XoaHoiDong(string ma)
        {
            string sql = "delete tblHoiDong where MaHoiDong=N'" + ma + "'";
            HoiDong.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
            //N phòng trường hợp lỗi font tiếng việt
        }
        //Hàm lấy thông tin và đổ ra 1 datagridview
        public DataTable TimHoiDong(string dk)
        {
            string sql = "select * from tblHoiDong where MaHoiDong like N'%" + dk + "%' or ChuTichHD like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = HoiDong.getTable(sql);
            return dt;
        }
    }
    #endregion

    #region Lớp giáo viên
    //---------------------Lớp giáo viên --------------------------------------\\
    public class GV
    {
        Data GiaoVien = new Data();
        //Hàm lấy thông tin và đổ ra 1 datagridview
        public DataTable ShowGiaoVien()
        {
            string sql = "Select * from tblGV";
            DataTable dt = new DataTable();
            dt = GiaoVien.getTable(sql);
            return dt;
        }
        public void InsertGiaoVien(string ma, string ten, string em, string sdt, string tto, string hv)
        {
            string sql = "Insert into tblGV(MaGV,TenGV,Email,SDT,TTo,HocVi) values(N'" + ma + "',N'" + ten + "',N'" + em + "',N'" + sdt + "',N'" + tto + "',N'" + hv + "')";
            GiaoVien.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
            //N phòng trường hợp lỗi font tiếng việt
        }
        public void SuaGV(string ma, string ten, string em, string sdt, string tto, string hv)
        {
            string sql = " update tblGV set TenGV=N'" + ten + "',Email=N'" + em + "',SDT=N'" + sdt + "',TTo=N'" + tto + "',HocVi=N'" + hv + "' where MaGV=N'" + ma + "'";
            GiaoVien.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
            //N phòng trường hợp lỗi font tiếng việt,,,,,,,,
        }

        public void XoaGV(string ma)
        {
            string sql = "Delete tblGV where MaGV=N'" + ma + "'";
            GiaoVien.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
            //N phòng trường hợp lỗi font tiếng việt
        }
        //Hàm lấy thông tin và đổ ra 1 datagridview
        public DataTable TimGV(string dk)
        {
            string sql = "select *from tblGV Where MaGV like N'%" + dk + "%' or TenGV like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = GiaoVien.getTable(sql);
            return dt;
        }
    }
    #endregion

    #region Lớp chuyên đề
    //---------------------Lớp chuyên đề--------------------------------------\\
    public class CD1
    {
        Data CD = new Data();
        //Hàm lấy thông tin và đổ ra 1 datagridview
        public DataTable ShowCD()
        {
            string sql = "Select * from tblCD";
            DataTable dt = new DataTable();
            dt = CD.getTable(sql);
            return dt;
        }
        public void InsertCD(string ma, string ten, string nam, string hd)
        {
            string sql = "Insert into tblCD(MaCD,TenCD,Nam,MaHoiDong) values(N'" + ma + "',N'" + ten + "',N'" + nam + "', N'" + hd + "')";
            CD.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
            //N phòng trường hợp lỗi font tiếng việt
        }
        public void SuaCD(string ma, string ten, string nam, string hd)
        {
            string sql = " update tblCD set TenCD=N'" + ten + "',Nam=N'" + nam + "' ,MaHoiDong=N'" + hd + "' where MaCD=N'" + ma + "'";
            CD.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1 ,,,,,, 
            //N phòng trường hợp lỗi font tiếng việt
        }

        public void XoaCD(string ma)
        {
            string sql = "Delete tblCD where MaCD=N'" + ma + "'";
            CD.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
            //N phòng trường hợp lỗi font tiếng việt
        }
        //Hàm lấy thông tin và đổ ra 1 datagridview
        public DataTable TimCD(string dk)
        {
            string sql = "select *from tblCD Where MaCDlike N'%" + dk + "%' or TenCD like N'%" + dk + "%' ";
            DataTable dt = new DataTable();
            dt = CD.getTable(sql);
            return dt;
        }
    }
    #endregion

    #region Lớp bài tập lớn
    //---------------------Lớp Bài tập lớn--------------------------------------\\
    public class BTL1
    {
        Data BTL = new Data();
        //Hàm lấy thông tin và đổ ra 1 datagridview
        public DataTable ShowBTL()
        {
            string sql = "Select * from tblBTL";
            DataTable dt = new DataTable();
            dt = BTL.getTable(sql);
            return dt;
        }
        public void InsertBTL(string ma, string ten, string nam, string mahv)
        {
            string sql = "Insert into tblBTL(MaBTL,TenBTL,Nam,MaHP) values(N'" + ma + "',N'" + ten + "',N'" + nam + "',N'" + mahv + "')";
            BTL.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
            //N phòng trường hợp lỗi font tiếng việt
        }
        public void SuaBTL(string ma, string ten, string nam, string mahv)
        {
            string sql = " update tblBTL set TenBTL=N'" + ten + "',Nam=N'" + nam + "',MaHP=N'" + mahv + "' where MaBTL=N'" + ma + "'";
            BTL.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1 ,,,,,, 
            //N phòng trường hợp lỗi font tiếng việt
        }

        public void XoaBTL(string ma)
        {
            string sql = "Delete tblBTL where MaBTL=N'" + ma + "'";
            BTL.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
            //N phòng trường hợp lỗi font tiếng việt
        }
        //Hàm lấy thông tin và đổ ra 1 datagridview
        public DataTable TimBTL(string dk)
        {
            string sql = "select *from tblBTL Where MaBTL like N'%" + dk + "%' or TenBTL like N'%" + dk + "%' ";
            DataTable dt = new DataTable();
            dt = BTL.getTable(sql);
            return dt;
        }

    }
    #endregion

    #region Lớp học phần
    //---------------------Lớp học phần--------------------------------------\\
    public class Hp
    {
        Data HP = new Data();
        //Hàm lấy thông tin và đổ ra 1 datagridview
        public DataTable ShowHP()
        {
            string sql = "Select * from tblHP";
            DataTable dt = new DataTable();
            dt = HP.getTable(sql);
            return dt;
        }
        public void InsertHP(string ma, string ten, int sol)
        {
            string sql = "Insert into tblHP(MaHP,TenHP,SoT) values(N'" + ma + "',N'" + ten + "',N'" + sol + "')";
            HP.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
            //N phòng trường hợp lỗi font tiếng việt
        }
        public void SuaHP(string ma, string ten, int sol)
        {
            string sql = " update tblHP set TenHP=N'" + ten + "',SoT=N'" + sol + "' where MaHP=N'" + ma + "'";
            HP.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1 ,,,,,, 
            //N phòng trường hợp lỗi font tiếng việt
        }

        public void XoaHP(string ma)
        {
            string sql = "Delete tblHP where MaHP=N'" + ma + "'";
            HP.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
            //N phòng trường hợp lỗi font tiếng việt
        }
        //Hàm lấy thông tin và đổ ra 1 datagridview
        public DataTable TimHP(string dk)
        {
            string sql = "select *from tblHP Where MaHP like N'%" + dk + "%' or TenHP like N'%" + dk + "%' ";
            DataTable dt = new DataTable();
            dt = HP.getTable(sql);
            return dt;
        }

    }
    #endregion

    #region Lớp BTL_SV
    //---------------------Lớp BTL SV--------------------------------------\\
    public class BTL_SV1
    {
        Data BTL_SV = new Data();
        //Hàm lấy thông tin và đổ ra 1 datagridview
        public DataTable ShowBTL_SV()
        {
            string sql = "Select * from tblBTL_SV";
            DataTable dt = new DataTable();
            dt = BTL_SV.getTable(sql);
            return dt;
        }
        public void InsertBTL_SV(string masv, string mabtl, string magv, int d)
        {
            string sql = "Insert into tblBTL_SV(MaSV,MaBTL,MaGV,Diem) values(N'" + masv + "',N'" + mabtl + "',N'" + magv + "',N'" + d + "')";
            BTL_SV.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
            //N phòng trường hợp lỗi font tiếng việt
        }
        public void SuaBTL_SV(string masv, string mabtl, string magv, int d)
        {
            string sql = " update tblBTL_SV set Diem=N'" + d + "' where MaSV=N'" + masv + "' and MaBTL=N'" + mabtl + "' and MaGV=N'" + magv + "'";
            BTL_SV.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1 ,,,,,, 
            //N phòng trường hợp lỗi font tiếng việt
        }

        public void XoaBTL_SV(string masv, string mabtl, string magv)
        {
            string sql = "Delete tblBTL_SV where MaSV=N'" + masv + "' and MaBTL=N'" + mabtl + "' and MaGV=N'" + magv + "'";
            BTL_SV.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
            //N phòng trường hợp lỗi font tiếng việt
        }
        //Hàm lấy thông tin và đổ ra 1 datagridview
        public DataTable TimBTL_SV(string dk)
        {
            string sql = "select *from tblBTL_SV Where MaSV like N'%" + dk + "%' or MaBTL like N'%" + dk + "%' ";
            DataTable dt = new DataTable();
            dt = BTL_SV.getTable(sql);
            return dt;
        }

    }
    #endregion

    #region Lớp CD_SV
    //---------------------Lớp CD SV--------------------------------------\\
    public class CD_SV1
    {
        Data CD_SV = new Data();
        //Hàm lấy thông tin và đổ ra 1 datagridview
        public DataTable ShowCD_SV()
        {
            string sql = "Select * from tblCD_SV";
            DataTable dt = new DataTable();
            dt = CD_SV.getTable(sql);
            return dt;
        }
        public void InsertCD_SV(string masv, string mahp, string magv, string macd, int d)
        {
            string sql = "Insert into tblCD_SV(MaSV,MaHP,MaGV,MaCD,Diem) values(N'" + masv + "',N'" + mahp + "',N'" + magv + "',N'" + macd + "',N'" + d + "')";
            CD_SV.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
            //N phòng trường hợp lỗi font tiếng việt
        }
        public void SuaCD_SV(string masv, string mahp, string magv, string macd, int d)
        {
            string sql = " update tblCD_SV set MaCD=N'" + macd + "', MaGV=N'" + magv + "', Diem=N'" + d + "' where MaSV=N'" + masv + "' and MaHP=N'" + mahp + "'  ";
            CD_SV.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1 ,,,,,, 
            //N phòng trường hợp lỗi font tiếng việt
        }

        public void XoaCD_SV(string masv, string mahp, string magv)
        {
            string sql = "Delete tblCD_SV where MaSV=N'" + masv + "' and MaHP=N'" + mahp + "' ";
            CD_SV.ExecuteNonQuery(sql);//lệnh thực thi không trả về bảng đã viết bên lớp 1
            //N phòng trường hợp lỗi font tiếng việt
        }
        //Hàm lấy thông tin và đổ ra 1 datagridview
        public DataTable TimCD_SV(string dk)
        {
            string sql = "select *from tblCD_SV Where MaSV like N'%" + dk + "%' or MaHP like N'%" + dk + "%' or MaGV like N'%" + dk + "%' ";
            DataTable dt = new DataTable();
            dt = CD_SV.getTable(sql);
            return dt;
        }

    }
    #endregion
}
    
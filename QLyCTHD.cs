using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace DoAn
{
    public partial class QLyCTHD : Form
    {
        string updateDateHD   = "Update TableHD SET NgayXuatHD = GetDate()";
        string oldMaSP;
        string oldSoLuong;
        string oldMaCTHD;
        string updateSoLuongSP;
        bool modeNew;
        bool check = false;
        bool check3 = false;
        bool check4 = false;
        bool check5 = false;
        string varMaHD;
        Double soluong;
        Double dongia;
        bool isUpdate = false;
        private void SetControls(bool edit)
        {
           
           
            txtMaSP.Enabled = edit;
            txtSoLuong.Enabled = edit;
            btnSave.Enabled = edit;
            btnAdd.Enabled = !edit;
            btnUpdate.Enabled = !edit;
            btnRetry.Enabled = edit;
            btnDelete.Enabled = !edit;
        }
        ConnectSQL conn = new ConnectSQL();
        ConnectSQL conn2 = new ConnectSQL();
        private string sqlStr = "";
        private string sqlStr2 = "";

        int pos;
        public QLyCTHD()
        {
            InitializeComponent();
        }
       
        public QLyCTHD(string maHD)
        {
            InitializeComponent();
            varMaHD = maHD;
        }

       

        private void LoadTable(string MaHD)
        {
            try
            {
                
                string sqlStr2 = "SELECT * FROM [dbo].[TableCTHD] Where MaHD = '" + MaHD.ToString() + "'";

                DataTable dt = new DataTable();
                dt = conn.ViewData(sqlStr2);
                if (dt.Rows.Count > 0)
                {
                    dgvCTHD.Visible = true;
                    dgvCTHD.DataSource = dt;
                }    
                    
                else
                {
                    dgvCTHD.Visible = false;
                    erase();
                }    
                    
                //dgvCTHD.DataSource = conn.GetData(sqlStr, "TableCTHD");

            }
            catch (Exception)
            {
            }
        }

        private void QLyCTHD_Load(object sender, EventArgs e)
        {
         
            LoadTable(varMaHD);
            SetControls(false);
            conn.Connect();
        }

        private void dgvCTHD_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCTHD.RowCount >= 0)
            {
                pos = e.RowIndex;
                if (pos != -1)
                {
                    txtMaCTHD.Text = dgvCTHD.Rows[pos].Cells[1].Value.ToString();
                    txtMaHD.Text = dgvCTHD.Rows[pos].Cells[2].Value.ToString();
                    txtMaSP.Text = dgvCTHD.Rows[pos].Cells[3].Value.ToString();
                    txtTenSP.Text = dgvCTHD.Rows[pos].Cells[4].Value.ToString();
                    txtSoLuong.Text = dgvCTHD.Rows[pos].Cells[5].Value.ToString();
                    txtDonGia.Text = dgvCTHD.Rows[pos].Cells[6].Value.ToString();
                    txtThanhTien.Text = dgvCTHD.Rows[pos].Cells[7].Value.ToString();
                }

            }
            else LoadTable(varMaHD);
        }

       private void setMaCTHD()
        {
            string sqls = "select * from CapPhatID";
            DataTable dtid = new DataTable();
            dtid = conn.ViewData(sqls);
            string maso = dtid.Rows[0][3].ToString();
            int num = Convert.ToInt32(maso);
            if (num < 10) txtMaCTHD.Text = "CT000" + num.ToString();
            else if (num < 100) txtMaCTHD.Text = "CT00" + num.ToString();
            else if (num < 1000) txtMaCTHD.Text = "CT0" + num.ToString();
            else txtMaCTHD.Text = "CT" + num.ToString();
            
        }
        private void setCapPhatID(int num)
        {
            string sqls = "Update [dbo].[CapPhatID] SET IDCTHD =IDCTHD +  " + num.ToString();
            conn.Excute(sqls);
        }
        private void updateTongTienHD()
        {
            conn.Connect();
            string strud = "select Sum(ThanhTien) as tien from [dbo].[TableCTHD] where MaHD = '" + txtMaHD.Text + "'";
            DataTable dt1 = new DataTable();
            dt1 = conn.ViewData(strud);
            string tongtin = dt1.Rows[0][0].ToString();
           
            string sqls = "Update [dbo].[TableHD] set TongTien = " + tongtin + "Where MaHD = '" + txtMaHD.Text +"'";
            conn.Excute(sqls);

        }
        private void updateTongTienHD(string oldmahd)
        {
           
            string sqls = "Update [dbo].[TableHD] set TongTien = 0 Where MaHD = '" + oldmahd + "'";
            conn.Excute(sqls);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            oldSoLuong = txtSoLuong.Text;
            check = true;
            isUpdate = true;
            oldMaCTHD = txtMaCTHD.Text;
            modeNew = false;
            SetControls(true);
            txtMaCTHD.Focus();
            dgvCTHD.Enabled = false;
            btnRetry.Enabled = false;
        }

        private void ThanhTien()
        {
            txtThanhTien.Text = (Convert.ToDouble(txtSoLuong.Text) * Convert.ToDouble(txtDonGia.Text)).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            modeNew = true;
            SetControls(true);
            setMaCTHD();
            txtMaHD.Text = varMaHD;
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtThanhTien.Text = "";
            txtMaSP.Focus();
            dgvCTHD.Enabled = false;
            conn2.Connect();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           oldSoLuong = txtSoLuong.Text;
            oldMaSP = txtMaSP.Text;
            int n = dgvCTHD.Rows.Count;
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            DialogResult choice = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", btn, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                MessageBox.Show("Xóa thành công");
                string sqlStr1 = "SELECT * FROM TableCTHD";
                DataTable dt = new DataTable();
                dt = conn.GetData(sqlStr1, "TableCTHD");
                if (dt.Rows.Count == 0) return;
                string sqlStr2 = "DELETE FROM TableCTHD WHERE MaCTHD ='" + txtMaCTHD.Text + "'";
                conn.Excute(sqlStr2);

                if (n>1) updateTongTienHD();
                else updateTongTienHD(varMaHD);
                conn.Excute(updateDateHD);
                LoadTable(varMaHD);
              
                string str = "Select SoLuong From TableSanPham where MaSP = '" + oldMaSP + "'";
                DataTable dtt = new DataTable();
                dtt = conn.ViewData(str);
                updateSoLuongSP = "Update TableSanPham Set SoLuong = '" + (Convert.ToInt32(dtt.Rows[0][0].ToString()) + Convert.ToInt32(oldSoLuong)).ToString() + "' where MaSP='" + oldMaSP +"'" ;
                conn.Excute(updateSoLuongSP);
            }
            else { return; }

        }
        void erase()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtThanhTien.Text = "";
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            erase();  
            btnAdd_Click(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetControls(false);
            dgvCTHD.Enabled = true;

        }
        
        private void txtMaSP_KeyUp(object sender, KeyEventArgs e)
        { 
            if (txtMaSP.Text != "") check3 = true;
            sqlStr2 = "Select * from TableSanPham where MaSP like '%' + '" + txtMaSP.Text + "' + '%'";
            DataTable dtt = new DataTable();
            dtt = conn2.ViewData(sqlStr2);

            if (dtt.Rows.Count > 0)
            {
                if(txtMaSP.Text ==dtt.Rows[0][2].ToString())
                    txtMaSP.Text = dtt.Rows[0][1].ToString();
                else
                    txtTenSP.Text = dtt.Rows[0][2].ToString();
                dongia = Convert.ToDouble(dtt.Rows[0][4].ToString());
                txtDonGia.Text = dongia.ToString(); 
                if (txtSoLuong.Text != "")
                {
                    soluong = Convert.ToDouble(txtSoLuong.Text);
                    txtThanhTien.Text = (soluong * dongia).ToString();
                }

            }
            else txtTenSP.PlaceholderText = "Sản phẩm không tồn tại!";

        }

        private void txtSoLuong_KeyUp(object sender, KeyEventArgs e)
        {          
            if (txtTenSP.Text == "")
            {
                MessageBox.Show("Sản phẩm không tồn tại!");
                return;
            }
            if (txtSoLuong.Text != "") check4 = true;

            if (txtSoLuong.Text != "")
            {
                double soluong2 = Convert.ToDouble(txtSoLuong.Text);
                txtThanhTien.Text = (soluong2 * dongia).ToString();
                conn.Connect();
                string str = "Select SoLuong From TableSanPham where MaSP = '" + txtMaSP.Text + "'";
                DataTable dt = new DataTable();
                dt = conn.ViewData(str);
                try
                {
                    if (Convert.ToInt32(txtSoLuong.Text) > Convert.ToInt32(dt.Rows[0][0].ToString()))
                    {
                        MessageBox.Show("Không đủ số lượng !");
                        txtSoLuong.Text = "";
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show("Không tồn tại mã sản phẩm này!");
                }
                
            }
        }

        private void txtTenSP_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTenSP.Text != "") check5 = true;
        }


       /* private void btnSearch_Click(object sender, EventArgs e)
        {
            string sqlStr1 = "SELECT * FROM TableCustomer Where Name like N'%" +txtSearch.Text + "%'";
            DataTable dt = new DataTable();
            dt = conn.ViewData(sqlStr1);
            if (dt.Rows.Count <= 0)
            {
                string sqlStr2 = "SELECT * FROM TableCustomer Where SDT like '%" + txtSearch.Text + "%'";
                dt = conn.ViewData(sqlStr2);
            }  
            dgvKH.DataSource = dt;
        }*/

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadTable(varMaHD);
        }

        private void txtMaSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isAdd = false;
            dgvCTHD.Enabled = false;
            string sqlStr3 = "";
            string sqlStr4 = "";
            oldMaSP = txtMaSP.Text;

            if (txtMaSP.Text != "" && txtTenSP.Text == "")
            {
                MessageBox.Show("Sản phẩm không tồn tại!");
                return;
            }
            if (txtMaSP.Text == "" || txtSoLuong.Text == "" || txtTenSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }
            if (modeNew == true && check3 == true && check4 == true)
            {
                ThanhTien();
                sqlStr3 = "INSERT INTO [dbo].[TableCTHD]([MaCTHD],[MaHD],[MaSP],[TenSP],[SoLuong],[DonGia],[ThanhTien]) VALUES ('" + txtMaCTHD.Text + "','" + txtMaHD.Text + "', '" + txtMaSP.Text + "', N'" + txtTenSP.Text + "','" + txtSoLuong.Text + "','" + txtDonGia.Text + "','" + txtThanhTien.Text + "')";
                string str = "Select SoLuong From TableSanPham where MaSP = '" + txtMaSP.Text + "'";
                DataTable dt = new DataTable();
                dt = conn.ViewData(str);
                sqlStr4 = "Update TableSanPham set SoLuong = " + (Convert.ToInt32(dt.Rows[0][0].ToString()) - Convert.ToInt32(txtSoLuong.Text)).ToString()+",NgayCapNhat = GetDate()" + "where MaSP = '" + txtMaSP.Text + "'";
                MessageBox.Show("Thêm thành công");
                isAdd = true;
            }
        
            else
            {
                string str = "Select SoLuong From TableSanPham where MaSP = '" + txtMaSP.Text + "'";
                DataTable dt = new DataTable();
                dt = conn.ViewData(str);

                ThanhTien();
                MessageBox.Show("Đã cập nhật chi tiết hóa đơn");
                sqlStr3 = "UPDATE [dbo].[TableCTHD] SET  MaSP = '" + txtMaSP.Text +
               "',TenSP = N'" + txtTenSP.Text +
               "',SoLuong = '" + txtSoLuong.Text +
               "',ThanhTien ='" + txtThanhTien.Text + "'"

               + "Where MaCTHD = '" + txtMaCTHD.Text + "'";
                isUpdate = true;

                updateSoLuongSP = "Update TableSanPham Set SoLuong = '" + (Convert.ToInt32(dt.Rows[0][0].ToString()) + Convert.ToInt32(oldSoLuong) - Convert.ToInt32(txtSoLuong.Text)).ToString()+"' where MaSP = '" +oldMaSP +"'" ;


            }
            try
            {
                conn.Excute(sqlStr3);
               if(isUpdate==false) conn.Excute(sqlStr4);
               else conn.Excute(updateSoLuongSP);
                LoadTable(txtMaHD.Text);
                conn.Excute(updateDateHD);

            }
            catch (Exception ex)

            {
                MessageBox.Show("Lỗi");
                isAdd = false;
                isUpdate = false;
                

            }
            finally
            {
                if (isAdd)
                {
                    setCapPhatID(1);
                    updateTongTienHD();            
                    
                }
                if(isUpdate)
                {
                    updateTongTienHD();
                }    
                SetControls(false);
                dgvCTHD.Enabled = true;
                LoadTable(txtMaHD.Text);

            }
        }

        private void QLyCTHD_FormClosed(object sender, FormClosedEventArgs e)
        {
            QLyHoaDon qlhd = new QLyHoaDon();
            qlhd.LoadTable();

        }
    }
}

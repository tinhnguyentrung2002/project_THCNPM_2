using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DoAn
{
    public partial class QLySanPham : Form
    {
       
        private string sqlStr = "";
        string oldID;
        string sqlStr3 = "";
        bool modeNew;
        int pos,newStt,lastrow;
        ConnectSQL conn = new ConnectSQL();
        public QLySanPham()
        {
            InitializeComponent();
        }
        private void SetControls(bool edit)
        {
            txtSTT.Enabled = false;
            txtID.Enabled = false;
            txtName.Enabled = edit;
            txtNSX.Enabled = edit;
            nudSL.Enabled = edit;
            cboUnit.Enabled = edit;
            cboDanhmuc.Enabled = edit;
            txtPrices.Enabled = edit;
            btnSave.Enabled = edit;
            btnThem.Enabled = !edit;
            btnSua.Enabled = !edit;
            btnReset.Enabled = edit;
            btnXoa.Enabled = !edit;
        }


        void SetLock(bool edit)
        {
            btnThem.Enabled = edit;
            btnSua.Enabled = edit;
            btnXoa.Enabled = edit;
            btnCancel.Enabled = edit;
            btnReset.Enabled = edit;
            btnSave.Enabled = edit;
        }

        void PhanQuyen()
        {
            if (Main.chucVu != 'Q' && Main.chucVu != 'A')
                SetLock(false);
        }
        public void LoadTable()
        {
            try
            {
                //SqlConnection conn1 = new SqlConnection();
                //conn1.ConnectionString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
                sqlStr = "SELECT * FROM TableSanPham ORDER BY[STT]";
                dgvSanPham.DataSource = conn.GetData(sqlStr, "TableSanPham");
                PhanQuyen();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void QLySanPham_Load(object sender, EventArgs e)
        {
            LoadTable();
            SetControls(false);
            conn.Connect();
            cboDanhmuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory1.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory1.SelectedIndex = 0;
            PhanQuyen();
        }

        private void dgvSanPham_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSanPham.RowCount >= 0)
            {
                pos = e.RowIndex;
                if (pos != -1)
                {
                    txtSTT.Text = dgvSanPham.Rows[pos].Cells[0].Value.ToString();
                    txtID.Text = dgvSanPham.Rows[pos].Cells[1].Value.ToString();
                    txtName.Text = dgvSanPham.Rows[pos].Cells[2].Value.ToString();
                    cboUnit.Text = dgvSanPham.Rows[pos].Cells[3].Value.ToString();
                    txtPrices.Text = dgvSanPham.Rows[pos].Cells[4].Value.ToString();
                    txtNSX.Text = dgvSanPham.Rows[pos].Cells[5].Value.ToString();
                    nudSL.Text = dgvSanPham.Rows[pos].Cells[6].Value.ToString();
                    cboDanhmuc.Text = dgvSanPham.Rows[pos].Cells[7].Value.ToString();
                }

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cboDanhmuc.SelectedIndex = 8;
            if (dgvSanPham.Rows.Count == 0)
            {
                newStt = 1;
            }
            else
            {
                lastrow = dgvSanPham.Rows.Count;
                newStt = Convert.ToInt32(dgvSanPham.Rows[lastrow - 1].Cells[0].Value.ToString()) + 1;
                
            }
           
            
                txtID.Text = "SP_00" + newStt.ToString();
            
            
            modeNew = true;
            SetControls(true);
            txtSTT.Text = newStt.ToString();
            txtName.Text = "";
            txtNSX.Text = "";
            txtPrices.Text = "";
            cboUnit.Text = "";
            nudSL.Value = 0;
            dgvSanPham.Enabled = false;
        } 

        private void btnSua_Click(object sender, EventArgs e)
        {
            oldID = txtID.Text;
            modeNew = false;
            SetControls(true);
            cboDanhmuc.Enabled = false;
            txtID.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            DialogResult choice = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", btn, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                MessageBox.Show("Xóa thành công");
                string sqlStr1 = "SELECT * FROM TableSanPham";
                DataTable dt = new DataTable();
                dt = conn.GetData(sqlStr1, "TableSanPham");
                if (dt.Rows.Count == 0) return;
                string sqlStr2 = "DELETE FROM TableSanPham WHERE MaSP ='" + txtID.Text + "'";
                conn.Excute(sqlStr2);
                LoadTable();
                
            }
            else { return; }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtNSX.Text = "";
            txtPrices.Text = "";
            cboDanhmuc.Text = "";
            cboUnit.Text = "";
            nudSL.Value = 0;
            cboDanhmuc.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetControls(false);
            dgvSanPham.Enabled = true;
            

        }

        private void txtPrices_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cboCategory1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlStr1;
            if (String.Compare(cboCategory1.Text, "Tất cả", true) == 0)
            {
                LoadTable();
            }
            if (String.Compare(cboCategory1.Text, "Đồ Gia Dụng", true) == 0)
            {
                sqlStr1 = "SELECT * FROM TableSanPham WHERE(DanhMuc = N'" + cboCategory1.Text + "') ORDER BY[STT]";
                dgvSanPham.DataSource = conn.GetData(sqlStr1,"TableSanPham");
            }
            if (String.Compare(cboCategory1.Text, "Bộ Quà Tặng", true) == 0)
            {
                sqlStr1 = "SELECT * FROM TableSanPham WHERE(DanhMuc = N'" + cboCategory1.Text + "') ORDER BY[STT]";
                dgvSanPham.DataSource = conn.GetData(sqlStr1, "TableSanPham");
            }
            if (String.Compare(cboCategory1.Text, "Đồ Uống", true) == 0)
            {
                sqlStr1 = "SELECT * FROM TableSanPham WHERE(DanhMuc = N'" + cboCategory1.Text + "') ORDER BY[STT]";
                dgvSanPham.DataSource = conn.GetData(sqlStr1, "TableSanPham");
            }
            if (String.Compare(cboCategory1.Text, "Thực phẩm đóng hộp và Khô", true) == 0)
            {
                sqlStr1 = "SELECT * FROM TableSanPham WHERE(DanhMuc = N'" + cboCategory1.Text + "') ORDER BY[STT]";
                dgvSanPham.DataSource = conn.GetData(sqlStr1, "TableSanPham");
            }
            if (String.Compare(cboCategory1.Text, "Sữa và Các sản phẩm từ sữa", true) == 0)
            {
                sqlStr1 = "SELECT * FROM TableSanPham WHERE(DanhMuc = N'" + cboCategory1.Text + "') ORDER BY[STT]";
                dgvSanPham.DataSource = conn.GetData(sqlStr1, "TableSanPham");
            }
            if (String.Compare(cboCategory1.Text, "Đồ Ăn Vặt", true) == 0)
            {
                sqlStr1 = "SELECT * FROM TableSanPham WHERE(DanhMuc = N'" + cboCategory1.Text + "') ORDER BY[STT]";
                dgvSanPham.DataSource = conn.GetData(sqlStr1, "TableSanPham");
            }
            if (String.Compare(cboCategory1.Text, "Gia vị và Chế biến", true) == 0)
            {
                sqlStr1 = "SELECT * FROM TableSanPham WHERE(DanhMuc = N'" + cboCategory1.Text + "') ORDER BY[STT]";
                dgvSanPham.DataSource = conn.GetData(sqlStr1, "TableSanPham");
            }
            if (String.Compare(cboCategory1.Text, "Thực phẩm chức năng", true) == 0)
            {
                sqlStr1 = "SELECT * FROM TableSanPham WHERE(DanhMuc = N'" + cboCategory1.Text + "') ORDER BY[STT]";
                dgvSanPham.DataSource = conn.GetData(sqlStr1, "TableSanPham");
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sqlTimKiem = "";
            if (cboCategory1.Text == "" && txtSearch.Text != "")
            {
                sqlTimKiem = "SELECT * FROM TableSanPham WHERE TenSP like N'%" + txtSearch.Text + "%' ORDER BY[STT]";
                dgvSanPham.DataSource = conn.ViewData(sqlTimKiem);
            }
            if (cboCategory1.Text == "Tất cả" && txtSearch.Text != "")
            {
                sqlTimKiem = "SELECT * FROM TableSanPham WHERE TenSP like N'%" + txtSearch.Text + "%' ORDER BY[STT]";
                dgvSanPham.DataSource = conn.ViewData(sqlTimKiem);
            }
            if (cboCategory1.Text == "Đồ Gia Dụng" && txtSearch.Text != "")
            {
                sqlTimKiem = "SELECT * FROM TableSanPham WHERE TenSP like N'%" + txtSearch.Text + "%' AND DanhMuc = N'" + cboCategory1.Text + "' ORDER BY[STT]";
                dgvSanPham.DataSource = conn.ViewData(sqlTimKiem);
            }
            if (cboCategory1.Text == "Bộ Quà Tặng" && txtSearch.Text != "")
            {
                sqlTimKiem = "SELECT * FROM TableSanPham WHERE TenSP like N'%" + txtSearch.Text + "%' AND DanhMuc = N'" + cboCategory1.Text + "' ORDER BY[STT]";
                dgvSanPham.DataSource = conn.ViewData(sqlTimKiem);
            }
            if (cboCategory1.Text == "Đồ Uống" && txtSearch.Text != "")
            {
                sqlTimKiem = "SELECT * FROM TableSanPham WHERE TenSP like N'%" + txtSearch.Text + "%' AND DanhMuc = N'" + cboCategory1.Text + "' ORDER BY[STT]";
                dgvSanPham.DataSource = conn.ViewData(sqlTimKiem);
            }
            if (cboCategory1.Text == "Thực phẩm đóng hộp và Khô" && txtSearch.Text != "")
            {
                sqlTimKiem = "SELECT * FROM TableSanPham WHERE TenSP like N'%" + txtSearch.Text + "%' AND DanhMuc = N'" + cboCategory1.Text + "' ORDER BY[STT]";
                dgvSanPham.DataSource = conn.ViewData(sqlTimKiem);
            }
            if (cboCategory1.Text == "Sữa và Các sản phẩm từ sữa" && txtSearch.Text != "")
            {
                sqlTimKiem = "SELECT * FROM TableSanPham WHERE TenSP like N'%" + txtSearch.Text + "%' AND DanhMuc = N'" + cboCategory1.Text + "' ORDER BY[STT]";
                dgvSanPham.DataSource = conn.ViewData(sqlTimKiem);
            }
            if (cboCategory1.Text == "Đồ Ăn Vặt" && txtSearch.Text != "")
            {
                sqlTimKiem = "SELECT * FROM TableSanPham WHERE TenSP like N'%" + txtSearch.Text + "%' AND DanhMuc = N'" + cboCategory1.Text + "' ORDER BY[STT]";
                dgvSanPham.DataSource = conn.ViewData(sqlTimKiem);
            }
            if (cboCategory1.Text == "Gia vị và Chế biến" && txtSearch.Text != "")
            {
                sqlTimKiem = "SELECT * FROM TableSanPham WHERE TenSP like N'%" + txtSearch.Text + "%' AND DanhMuc = N'" + cboCategory1.Text + "' ORDER BY[STT]";
                dgvSanPham.DataSource = conn.ViewData(sqlTimKiem);
            }
            if (cboCategory1.Text == "Thực phẩm chức năng" && txtSearch.Text != "")
            {
                sqlTimKiem = "SELECT * FROM TableSanPham WHERE TenSP like N'%" + txtSearch.Text + "%' AND DanhMuc = N'" + cboCategory1.Text + "' ORDER BY[STT]";
                dgvSanPham.DataSource = conn.ViewData(sqlTimKiem);
            }
            if (cboCategory1.Text != "" && txtSearch.Text == "")
            {
                sqlTimKiem = "SELECT * FROM TableSanPham WHERE DanhMuc = N'" + cboCategory1.Text + "' ORDER BY[STT]";
                dgvSanPham.DataSource = conn.ViewData(sqlTimKiem);

            }
            if (cboCategory1.Text == "Tất cả" && txtSearch.Text == "")
            {
                sqlTimKiem = "SELECT * FROM TableSanPham ORDER BY[STT]";
                dgvSanPham.DataSource = conn.ViewData(sqlTimKiem);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (modeNew && txtName.Text != null && txtName.Text != null && txtPrices.Text != null && txtNSX.Text != null && cboUnit.Text != null && cboDanhmuc.Text != null && nudSL.Value != 0)
            {
                    sqlStr3 = "INSERT INTO [dbo].[TableSanPham]([STT],[MaSP],[TenSP],[DVT],[Gia],[NSX],[SoLuong],[DanhMuc],[NgayCapNhat]) VALUES ('"
                        + txtSTT.Text + "','"
                        + txtID.Text + "', N'" 
                        + txtName.Text + "', N'" 
                        + cboUnit.Text + "','" 
                        + txtPrices.Text + "',N'" 
                        + txtNSX.Text + "','" 
                        + nudSL.Text + "',N'" 
                        + cboDanhmuc.Text + "',"  + "GetDate()" + ")";
                MessageBox.Show("Thêm thành công");
                dgvSanPham.Enabled = true;
            }
            else
            {
                    sqlStr3 = "UPDATE [dbo].[TableSanPham] SET TenSP = N'" + txtName.Text +                   
                   "',DVT = N'" + cboUnit.Text +
                   "',Gia ='" + txtPrices.Text +
                   "',NSX = N'" + txtNSX.Text +
                   "',SoLuong ='" + nudSL.Text +
                   "',DanhMuc = N'" + cboDanhmuc.Text +     
                   "',NgayCapNhat = " + "GetDate()" + " WHERE MaSP = '" + oldID + "'";

            }
            try
            {
                conn.Excute(sqlStr3);
                LoadTable();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu không hợp lệ ! Vui lòng thử lại");

            }
            finally
            {
                SetControls(false);
                LoadTable();
            }
        
        }
    }
}

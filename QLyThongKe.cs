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
using System.Net;
using System.Net.Mail;
using Excel = Microsoft.Office.Interop.Excel;
namespace DoAn
{
    public partial class QLyThongKe : Form
    {

        private string btnValue;
        private string pathSaveFile;
        public QLyThongKe()
        {
            InitializeComponent();
        }

        ConnectSQL conn = new ConnectSQL();

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            picLoad.Visible = false;
            btnValue = btnNhanVien.Text;
            setLabelText(btnValue);
            dgvThongKe.Visible = true;
            QLyNhanVien qlnv = new QLyNhanVien();
            qlnv.LoadTable();
            dgvThongKe.DataSource = qlnv.dgvNV.DataSource;
            setTextSoLuong(dgvThongKe);
            cboCategory1.Visible = false;
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }


        void setLabelText(string text)
        {
            label1.Text = text;
        }

        void setTextSoLuong(DataGridView dgv)
        {
            lblSoLuong.Text = "SỐ LƯỢNG: " +  (dgv.Rows.Count).ToString();
            lblSoLuong.Visible = true;
        }

        void setTextDoanhThu(DataGridView dgv)
        {
           
            String sqlStr1 = "Select COUNT(*) AS SoLuong,SUM(TongTien) AS Dthu From TableHD";
            DataTable dt1 = new DataTable();
         
            dt1 = conn.ViewData(sqlStr1);
            lblSoLuong.Text = "TỔNG DOANH THU: " + dt1.Rows[0][1].ToString();
            lblSoLuong.Visible = true;
            cboCategory1.Visible = false;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            picLoad.Visible = false;
            btnValue = btnKhachHang.Text;
            setLabelText(btnValue);
            dgvThongKe.Visible = true;
            QLyKhachHang qlkh = new QLyKhachHang();
            qlkh.LoadTable();
            dgvThongKe.DataSource = qlkh.dgvKH.DataSource;
            setTextSoLuong(dgvThongKe);
            cboCategory1.Visible = false;

        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            picLoad.Visible = false;
            cboCategory1.SelectedIndex = 0;
            btnValue = btnSanPham.Text;
            setLabelText(btnValue);
            dgvThongKe.Visible = true;
            QLySanPham qlsp = new QLySanPham();
            qlsp.LoadTable();
            dgvThongKe.DataSource = qlsp.dgvSanPham.DataSource;
            cboCategory1.Visible = true;
            setTextSoLuong(dgvThongKe);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            picLoad.Visible = false;
            btnValue = btnHoaDon.Text;
            setLabelText(btnValue);
            dgvThongKe.Visible = true;
            QLyHoaDon qlhd = new QLyHoaDon();
            qlhd.LoadTable();
            dgvThongKe.DataSource = qlhd.dgvHD.DataSource;
            setTextDoanhThu(dgvThongKe);
            cboCategory1.Visible = false;
        }

        private void ToExcel(DataGridView dataGridView1, string fileName, string NameReport)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = NameReport;

                // export header trong DataGridView

                worksheet.Range["A1:F1"].Merge();

                worksheet.Cells[1, 1] = worksheet.Name + " " + DateTime.Now.ToString();
                //worksheet.Cells[1, 1].Font.Bold = true;
                //worksheet.Cells[1, 1].Font.Size = 14;
                //worksheet.Cells[1, 1].Font.Color = Color.Red;

                worksheet.get_Range("A1", "F1").Cells.HorizontalAlignment =
                 Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                worksheet.Cells[1, 2] = DateTime.Now.ToString();

                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[3, i + 1] = dataGridView1.Columns[i].HeaderText;
                    //worksheet.Cells[3, i+1].Font.Bold = true;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount-1; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 4, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                    if(i== dataGridView1.RowCount - 2)
                    {
                        worksheet.Cells[i+5,1] = lblSoLuong.Text;
                  
                    }    
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }




        public void email_send()
        {
            
            ConnectSQL conn = new ConnectSQL();
            string Str = "SELECT TableNV.Email FROM TableNV INNER JOIN TableUser ON TableNV.MaNV = TableUser.MaNV WHERE(TableUser.Username = '" + frmLogin.UserName + "')";
          
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            dt = conn.ViewData(Str);

            string emailCaNhan;
            if (dt.Rows.Count>0) emailCaNhan = dt.Rows[0][0].ToString();
            else
                emailCaNhan = "Example@gmail.com";
         
            try
            {
                MailMessage msg = new MailMessage();
                SmtpClient mailServer = new SmtpClient("smtp.gmail.com");
                string from = "lovealone777888@gmail.com";
                string to = emailCaNhan;

                msg.From = new MailAddress(from);
                msg.To.Add(to);
                msg.Subject = "HỆ THỐNG VINMART - " + btnValue;
                msg.Body = "File Excel " + btnValue + " của Vinmart. Mail này được trả lời tự động, vì vậy bạn không nên trả lời lại mail này";
               

                mailServer.Port = 587;
                msg.IsBodyHtml = true;
                mailServer.UseDefaultCredentials = false;
                mailServer.Credentials = new System.Net.NetworkCredential("nguyenngocninh12a8@gmail.com", "meaumjotjvuqdhfv");
                mailServer.EnableSsl = true;

                  msg.Attachments.Add(new Attachment(pathSaveFile));
                mailServer.Send(msg);
            }


            
            catch (Exception ex)
            {
                Console.WriteLine("Unable to send email. Error : " + ex);
            }


        }


        private void button1_Click(object sender, EventArgs e)
        {

            picLoad.Visible = false;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ("Excel Files|*.xls;*.xlsx;*.xlsm");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dgvThongKe, sfd.FileName, btnValue);
                pathSaveFile = Path.GetFullPath(sfd.FileName);
                email_send();

            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlStr1;
            if (String.Compare(cboCategory1.Text, "Tất cả", true) == 0)
            {
                btnSanPham_Click(sender,e);
            }
            if (String.Compare(cboCategory1.Text, "Đồ Gia Dụng", true) == 0)
            {
                sqlStr1 = "SELECT * FROM TableSanPham WHERE(DanhMuc = N'" + cboCategory1.Text + "') ORDER BY[STT]";
                dgvThongKe.DataSource = conn.GetData(sqlStr1, "TableSanPham");
            }
            if (String.Compare(cboCategory1.Text, "Bộ Quà Tặng", true) == 0)
            {
                sqlStr1 = "SELECT * FROM TableSanPham WHERE(DanhMuc = N'" + cboCategory1.Text + "') ORDER BY[STT]";
                dgvThongKe.DataSource = conn.GetData(sqlStr1, "TableSanPham");
            }
            if (String.Compare(cboCategory1.Text, "Đồ Uống", true) == 0)
            {
                sqlStr1 = "SELECT * FROM TableSanPham WHERE(DanhMuc = N'" + cboCategory1.Text + "') ORDER BY[STT]";
                dgvThongKe.DataSource = conn.GetData(sqlStr1, "TableSanPham");
            }
            if (String.Compare(cboCategory1.Text, "Thực phẩm đóng hộp và Khô", true) == 0)
            {
                sqlStr1 = "SELECT * FROM TableSanPham WHERE(DanhMuc = N'" + cboCategory1.Text + "') ORDER BY[STT]";
                dgvThongKe.DataSource = conn.GetData(sqlStr1, "TableSanPham");
            }
            if (String.Compare(cboCategory1.Text, "Sữa và Các sản phẩm từ sữa", true) == 0)
            {
                sqlStr1 = "SELECT * FROM TableSanPham WHERE(DanhMuc = N'" + cboCategory1.Text + "') ORDER BY[STT]";
                dgvThongKe.DataSource = conn.GetData(sqlStr1, "TableSanPham");
            }
            if (String.Compare(cboCategory1.Text, "Đồ Ăn Vặt", true) == 0)
            {
                sqlStr1 = "SELECT * FROM TableSanPham WHERE(DanhMuc = N'" + cboCategory1.Text + "') ORDER BY[STT]";
                dgvThongKe.DataSource = conn.GetData(sqlStr1, "TableSanPham");
            }
            if (String.Compare(cboCategory1.Text, "Gia vị và Chế biến", true) == 0)
            {
                sqlStr1 = "SELECT * FROM TableSanPham WHERE(DanhMuc = N'" + cboCategory1.Text + "') ORDER BY[STT]";
                dgvThongKe.DataSource = conn.GetData(sqlStr1, "TableSanPham");
            }
            if (String.Compare(cboCategory1.Text, "Thực phẩm chức năng", true) == 0)
            {
                sqlStr1 = "SELECT * FROM TableSanPham WHERE(DanhMuc = N'" + cboCategory1.Text + "') ORDER BY[STT]";
                dgvThongKe.DataSource = conn.GetData(sqlStr1, "TableSanPham");
            }
            setTextSoLuong(dgvThongKe);
        }

        private void QLyThongKe_Load(object sender, EventArgs e)
        {
            cboCategory1.DropDownStyle = ComboBoxStyle.DropDownList;
         
            label1.Text = "THỐNG KÊ";
            lblSoLuong.Text = "";
         //   dgvThongKe.DataSource = null;
        }
    }
}

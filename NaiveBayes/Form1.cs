using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NaiveBayes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Data text file (*.txt) | *.txt";
            if(od.ShowDialog() == DialogResult.OK)
            {
                tbDuongDan.Text = od.FileName;
            }

        }

        private void btThucHien_Click(object sender, EventArgs e)
        {
            // Kiem tra dau vao gom: tep tin du lieu va so nhom
            if(tbDuongDan.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải chọn tệp tin chứa các điểm");
                btTim.Focus();
                return;
            }
            

            // Xử lý sô liệu
            tbKetQua.Text = "";
            Bayes bs = new Bayes();
            List<Diem> dsDiem = bs.DocDuLieu(tbDuongDan.Text);
            if(dsDiem != null && dsDiem.Count > 0)
            {
                List<Nhom> dsNhom = bs.KhoiTaoNhom((int)nudSoNhom.Value, dsDiem);
                dsDiem = bs.ChiaNhom(dsNhom, dsDiem);

                //Hiển thị lên textbox
                foreach(Nhom n in dsNhom)
                {
                    tbKetQua.Text += n.Ten + "\r\n";
                    foreach(Diem d in dsDiem)
                    {
                        if(d.MaNhom == n.Ma)
                        {
                            tbKetQua.Text += $"{d.HocSinh} ( Toan: {d.DiemToan}, Van: {d.DiemVan}, Anh: {d.DiemAnh}, Hoa: {d.DiemHoa}, Ly: {d.DiemLy})\r\n";
                        }
                    }
                    tbKetQua.Text += "\r\n\r\n";
                }
            }
        }
    }
}

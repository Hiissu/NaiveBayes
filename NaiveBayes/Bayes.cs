using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace NaiveBayes
{
    public class Bayes
    {
        /* Bài toán
        * INPUT: Tập các điểm và các số nhóm cần phân chia
        * OUPUT: Các điểm đã được phân chia hợp lý vào các nhóm
        * - CÁC BƯỚC THỰC HIỆN
        * B1: Lấy n điểm bất kỳ tương ứng với n nhóm cần phân chia tâm các nhóm
        * B2: Tính khoảng cách các điểm đến từng tâm nhóm nếu điểm đó gần tâm nhóm nào nhất thì nạp vào điểm đó vào nhóm đó
        * B3: Tính lại tâm của các nhóm
        * B4: Kiểm tra xem tâm các nhóm có thay đổi hay không, Nếu tâm nhóm thay đổi thì quay lại bước 2, nếu tâm nhóm k thay đổi thì kết thúc
        * 
        */

        public List<Diem> DocDuLieu(String duongDan)
        {
            String dl = File.ReadAllText(duongDan);
            List<Diem> ds = new List<Diem>();
            if (dl.Length > 0 && dl.Contains("\r\n") && dl.Contains(","))
            {
                foreach (string dong in dl.Split('\r'))
                {
                    if (String.IsNullOrEmpty(dong.Trim()))
                        continue;
                    String tmp = dong.Replace("\n", "").Trim();
                    string hocSinh = tmp.Split('(')[0].Trim();
                    string diem = tmp.Split('(')[1].Trim().Replace(')', ' ');

                    float diemToan = float.Parse(diem.Split(',')[0].Trim().Split(':')[1]);
                    float diemVan = float.Parse(diem.Split(',')[1].Trim().Split(':')[1]);
                    float diemAnh = float.Parse(diem.Split(',')[2].Trim().Split(':')[1]);
                    float diemHoa = float.Parse(diem.Split(',')[3].Trim().Split(':')[1]);
                    float diemLy = float.Parse(diem.Split(',')[4].Trim().Split(':')[1]);
                    Diem d = new Diem();
                    d.HocSinh = hocSinh;
                    d.DiemToan = diemToan;
                    d.DiemVan = diemVan;
                    d.DiemAnh = diemAnh;
                    d.DiemHoa = diemHoa;
                    d.DiemLy = diemLy;
                    ds.Add(d);
                }
                return ds;
            }
            else
                return null;

        }

        public List<Nhom> KhoiTaoNhom(int soNhom, List<Diem> dsDiem)
        {
            int soDiem = dsDiem.Count;
            Random r = new Random();

            List<Nhom> dsNhom = new List<Nhom>();
            for(int i = 0; i < soNhom; i++)
            {
                Nhom n = new Nhom();
                n.Ma = i;
                n.Ten = " Nhóm thứ " + i.ToString();
                Diem d = dsDiem[r.Next(soDiem - 1)];
                n.DiemToan = d.DiemToan; 
                n.DiemVan= d.DiemVan;
                n.DiemAnh= d.DiemAnh;
                n.DiemHoa= d.DiemHoa;
                n.DiemLy= d.DiemLy;
                dsNhom.Add(n);
            }
            return dsNhom;

        } 

        public List<Diem> ChiaNhom(List<Nhom> dsNhom, List<Diem> dsDiem)
        {
            // Duyet tung diem va tinh khoang cach tu diem do den tam nhom
            foreach(Diem d in dsDiem)
            {
                float khoangCachNhoNhat = 0;
                int MaNhom = -1;
                foreach (Nhom n in dsNhom)
                {
                    float khoangCach = (float)Math.Sqrt((d.DiemToan - n.DiemToan) * (d.DiemToan - n.DiemToan) 
                        + (d.DiemVan - n.DiemVan) * (d.DiemVan - n.DiemVan)
                        + (d.DiemAnh - n.DiemAnh) * (d.DiemAnh - n.DiemAnh)
                        + (d.DiemHoa - n.DiemHoa) * (d.DiemHoa - n.DiemHoa)
                        + (d.DiemLy - n.DiemLy) * (d.DiemLy - n.DiemLy));
                    if (khoangCachNhoNhat == 0 || khoangCach < khoangCachNhoNhat)
                    {
                        khoangCachNhoNhat = khoangCach;
                        MaNhom = n.Ma;
                    }
                }
                d.MaNhom = MaNhom;
            }

            // Tinh lai tam cua tung nhom
            while(true)
            {
                Boolean thayDoi = false;
                foreach (Nhom n in dsNhom)
                {
                    float dToanMoi = 0;
                    float dVanMoi = 0;
                    float dAnhMoi = 0;
                    float dHoaMoi = 0;
                    float dLyMoi = 0;
                    int dem = 0;
                    foreach (Diem d in dsDiem)
                    {
                        if (d.MaNhom == n.Ma)
                        {
                            dToanMoi += d.DiemToan;
                            dVanMoi += d.DiemVan;
                            dAnhMoi += d.DiemAnh;
                            dHoaMoi += d.DiemHoa;
                            dLyMoi += d.DiemLy;
                            dem++;
                        }
                    }
                    if (dem > 0)
                    {
                        dToanMoi = dToanMoi / dem;
                        dVanMoi = dVanMoi / dem;
                        dAnhMoi = dAnhMoi / dem;
                        dHoaMoi = dHoaMoi / dem;
                        dLyMoi = dLyMoi / dem;

                        // Kiem tra xem co thay doi khong, neu thay doithi cap nhat
                        if (n.DiemToan != dToanMoi || n.DiemVan != dVanMoi 
                                                   || n.DiemAnh != dAnhMoi
                                                   || n.DiemHoa != dHoaMoi
                                                   || n.DiemLy != dLyMoi)
                        {
                            thayDoi = true;
                            n.DiemToan = dToanMoi;
                            n.DiemVan = dVanMoi;
                            n.DiemAnh = dAnhMoi;
                            n.DiemHoa = dHoaMoi;
                            n.DiemLy = dLyMoi;
                        }
                    }
                }
                // Kiem tra xem danh sach nhom co bien dong hay khong
                if (thayDoi == false) ;
                break;
            }
            return dsDiem;
           
        }
    }
}

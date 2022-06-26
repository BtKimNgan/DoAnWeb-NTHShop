using DoAnWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnWeb.Controllers
{
    public class GioHangController : Controller
    {
        // GET: GioHang
        MyDataDataContext data = new MyDataDataContext();

        public List<Giohang> LayGioHang()
        {
            List<Giohang> lstgiohang = Session["Giohang"] as List<Giohang>;
            if (lstgiohang == null)
            {
                lstgiohang = new List<Giohang>();
                Session["Giohang"] = lstgiohang;
            }
            return lstgiohang;
        }
        public ActionResult ThemGioHang(int id, string strURL)
        {
            List<Giohang> lstGiohang = LayGioHang();
            Giohang sanpham = lstGiohang.Find(n => n.masanpham == id);
            if (sanpham == null)
            {
                sanpham = new Giohang(id);
                lstGiohang.Add(sanpham);
                return Redirect(strURL);
            }
            else
            {
                sanpham.iSoLuong++;
                return Redirect(strURL);
            }
        }
        private int TongSoLuong()
        {
            int tsl = 0;
            List<Giohang> lstGiohang = Session["Giohang"] as List<Giohang>;
            if (lstGiohang != null)
            {
                tsl = lstGiohang.Sum(n => n.iSoLuong);
            }
            return tsl;
        }
        private int TongSoLuongSanPham()
        {
            int tsl = 0;
            List<Giohang> lstGiohang = Session["Giohang"] as List<Giohang>;
            if (lstGiohang != null)
            {
                tsl = lstGiohang.Count;
            }
            return tsl;
        }
        private double TongTien()
        {
            double tt = 0;
            List<Giohang> lstGiohang = Session["Giohang"] as List<Giohang>;
            if (lstGiohang != null)
            {
                tt = lstGiohang.Sum(n => n.dThanhTien);
            }
            return tt;
        }

        public ActionResult GioHang()
        {
            List<Giohang> lstGioHang = LayGioHang();
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            ViewBag.Tongsoluongsanpham = TongSoLuongSanPham();
            return View(lstGioHang);
        }

        public ActionResult GioHangPartial()
        {
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            ViewBag.Tongsoluongsanpham = TongSoLuongSanPham();
            return PartialView();
        }

        public ActionResult XoaGioHang(int id)
        {
            List<Giohang> lstGioHang = LayGioHang();
            Giohang sanpham = lstGioHang.SingleOrDefault(n => n.masanpham == id);
            if (sanpham != null)
            {
                lstGioHang.RemoveAll(n => n.masanpham == id);
                return RedirectToAction("GioHang");
            }
            return RedirectToAction("GioHang");
        }
        public ActionResult CapnhapGiohang(int id, FormCollection collection)
        {
            List<Giohang> lstGioHang = LayGioHang();
            Giohang sanpham = lstGioHang.SingleOrDefault(n => n.masanpham == id);
            if (sanpham != null)
            {
                sanpham.iSoLuong = int.Parse(collection["txtSoLg"].ToString());
            }
            return RedirectToAction("GioHang");
        }
        public ActionResult XoaTatCaGioHang()
        {
            List<Giohang> lstGioHang = LayGioHang();
            lstGioHang.Clear();
            return RedirectToAction("GioHang");
        }
        [HttpGet]
        public ActionResult DatHang()
        {
            if (Session["Taikhoan"] == null || Session["Taikhoan"].ToString() == "")

                return RedirectToAction("Register", "Account");

            if (Session["Giohang"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            List<Giohang> lstGiohang = LayGioHang();
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            ViewBag.Tongsoluongsanpham = TongSoLuongSanPham();
            return View(lstGiohang);
        }
        public ActionResult DatHang(FormCollection collection)
        {
            HoaDon dh = new HoaDon();
            KhachHang kh = (KhachHang)Session["TaiKhoan"];
            SanPham lt = new SanPham();
            List<Giohang> gh = LayGioHang();
            var ngaygiao = String.Format("{0:MM/dd/yyyy}", collection["NgayGiao"]);
            dh.MaKH = kh.MaKH;
            dh.NgaylapHD = DateTime.Now;
            dh.Ngaygiaohang = DateTime.Parse(ngaygiao);
            //dh.GiaoHang = false;
            dh.Thanhtoan = false;
            data.HoaDons.InsertOnSubmit(dh);
            data.SubmitChanges();
            foreach (var item in gh)
            {
                CTHD ctdh = new CTHD();
                ctdh.MaHD = dh.MaHD;
                ctdh.MaSP = item.masanpham;
                ctdh.Soluong = item.iSoLuong;
                ctdh.Dongiaban = (decimal)item.dongia;
                lt = data.SanPhams.Single(n => n.MaSP == item.masanpham);
                lt.Soluong = ctdh.Soluong;
                data.SubmitChanges();
                data.CTHDs.InsertOnSubmit(ctdh);
            }
            data.SubmitChanges();
            Session["Giohang"] = null;
            return RedirectToAction("XacnhanDonhang", "GioHang");
        }
        public ActionResult XacnhanDonhang()
        {
            return View();
        }





    }
}
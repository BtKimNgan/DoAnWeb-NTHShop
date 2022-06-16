﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnWeb1.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLbanhang")]
	public partial class MyDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCTHD(CTHD instance);
    partial void UpdateCTHD(CTHD instance);
    partial void DeleteCTHD(CTHD instance);
    partial void InsertHoaDon(HoaDon instance);
    partial void UpdateHoaDon(HoaDon instance);
    partial void DeleteHoaDon(HoaDon instance);
    partial void InsertKhachHang(KhachHang instance);
    partial void UpdateKhachHang(KhachHang instance);
    partial void DeleteKhachHang(KhachHang instance);
    partial void InsertLoaiSP(LoaiSP instance);
    partial void UpdateLoaiSP(LoaiSP instance);
    partial void DeleteLoaiSP(LoaiSP instance);
    partial void InsertSanPham(SanPham instance);
    partial void UpdateSanPham(SanPham instance);
    partial void DeleteSanPham(SanPham instance);
    #endregion
		
		public MyDataDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QLbanhangConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CTHD> CTHDs
		{
			get
			{
				return this.GetTable<CTHD>();
			}
		}
		
		public System.Data.Linq.Table<HoaDon> HoaDons
		{
			get
			{
				return this.GetTable<HoaDon>();
			}
		}
		
		public System.Data.Linq.Table<KhachHang> KhachHangs
		{
			get
			{
				return this.GetTable<KhachHang>();
			}
		}
		
		public System.Data.Linq.Table<LoaiSP> LoaiSPs
		{
			get
			{
				return this.GetTable<LoaiSP>();
			}
		}
		
		public System.Data.Linq.Table<SanPham> SanPhams
		{
			get
			{
				return this.GetTable<SanPham>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CTHD")]
	public partial class CTHD : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHD;
		
		private int _MaSP;
		
		private System.Nullable<int> _Soluong;
		
		private System.Nullable<decimal> _Dongiaban;
		
		private EntityRef<HoaDon> _HoaDon;
		
		private EntityRef<SanPham> _SanPham;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDChanging(int value);
    partial void OnMaHDChanged();
    partial void OnMaSPChanging(int value);
    partial void OnMaSPChanged();
    partial void OnSoluongChanging(System.Nullable<int> value);
    partial void OnSoluongChanged();
    partial void OnDongiabanChanging(System.Nullable<decimal> value);
    partial void OnDongiabanChanged();
    #endregion
		
		public CTHD()
		{
			this._HoaDon = default(EntityRef<HoaDon>);
			this._SanPham = default(EntityRef<SanPham>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHD", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaHD
		{
			get
			{
				return this._MaHD;
			}
			set
			{
				if ((this._MaHD != value))
				{
					if (this._HoaDon.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaHDChanging(value);
					this.SendPropertyChanging();
					this._MaHD = value;
					this.SendPropertyChanged("MaHD");
					this.OnMaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					if (this._SanPham.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSPChanging(value);
					this.SendPropertyChanging();
					this._MaSP = value;
					this.SendPropertyChanged("MaSP");
					this.OnMaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Soluong", DbType="Int")]
		public System.Nullable<int> Soluong
		{
			get
			{
				return this._Soluong;
			}
			set
			{
				if ((this._Soluong != value))
				{
					this.OnSoluongChanging(value);
					this.SendPropertyChanging();
					this._Soluong = value;
					this.SendPropertyChanged("Soluong");
					this.OnSoluongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dongiaban", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Dongiaban
		{
			get
			{
				return this._Dongiaban;
			}
			set
			{
				if ((this._Dongiaban != value))
				{
					this.OnDongiabanChanging(value);
					this.SendPropertyChanging();
					this._Dongiaban = value;
					this.SendPropertyChanged("Dongiaban");
					this.OnDongiabanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HoaDon_CTHD", Storage="_HoaDon", ThisKey="MaHD", OtherKey="MaHD", IsForeignKey=true)]
		public HoaDon HoaDon
		{
			get
			{
				return this._HoaDon.Entity;
			}
			set
			{
				HoaDon previousValue = this._HoaDon.Entity;
				if (((previousValue != value) 
							|| (this._HoaDon.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._HoaDon.Entity = null;
						previousValue.CTHDs.Remove(this);
					}
					this._HoaDon.Entity = value;
					if ((value != null))
					{
						value.CTHDs.Add(this);
						this._MaHD = value.MaHD;
					}
					else
					{
						this._MaHD = default(int);
					}
					this.SendPropertyChanged("HoaDon");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SanPham_CTHD", Storage="_SanPham", ThisKey="MaSP", OtherKey="MaSP", IsForeignKey=true)]
		public SanPham SanPham
		{
			get
			{
				return this._SanPham.Entity;
			}
			set
			{
				SanPham previousValue = this._SanPham.Entity;
				if (((previousValue != value) 
							|| (this._SanPham.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SanPham.Entity = null;
						previousValue.CTHDs.Remove(this);
					}
					this._SanPham.Entity = value;
					if ((value != null))
					{
						value.CTHDs.Add(this);
						this._MaSP = value.MaSP;
					}
					else
					{
						this._MaSP = default(int);
					}
					this.SendPropertyChanged("SanPham");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HoaDon")]
	public partial class HoaDon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHD;
		
		private System.Nullable<int> _MaKH;
		
		private System.Nullable<int> _MaNV;
		
		private System.Nullable<System.DateTime> _NgaylapHD;
		
		private System.Nullable<System.DateTime> _Ngaygiaohang;
		
		private System.Nullable<bool> _Thanhtoan;
		
		private EntitySet<CTHD> _CTHDs;
		
		private EntityRef<KhachHang> _KhachHang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDChanging(int value);
    partial void OnMaHDChanged();
    partial void OnMaKHChanging(System.Nullable<int> value);
    partial void OnMaKHChanged();
    partial void OnMaNVChanging(System.Nullable<int> value);
    partial void OnMaNVChanged();
    partial void OnNgaylapHDChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaylapHDChanged();
    partial void OnNgaygiaohangChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaygiaohangChanged();
    partial void OnThanhtoanChanging(System.Nullable<bool> value);
    partial void OnThanhtoanChanged();
    #endregion
		
		public HoaDon()
		{
			this._CTHDs = new EntitySet<CTHD>(new Action<CTHD>(this.attach_CTHDs), new Action<CTHD>(this.detach_CTHDs));
			this._KhachHang = default(EntityRef<KhachHang>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHD", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaHD
		{
			get
			{
				return this._MaHD;
			}
			set
			{
				if ((this._MaHD != value))
				{
					this.OnMaHDChanging(value);
					this.SendPropertyChanging();
					this._MaHD = value;
					this.SendPropertyChanged("MaHD");
					this.OnMaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="Int")]
		public System.Nullable<int> MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					if (this._KhachHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNV", DbType="Int")]
		public System.Nullable<int> MaNV
		{
			get
			{
				return this._MaNV;
			}
			set
			{
				if ((this._MaNV != value))
				{
					this.OnMaNVChanging(value);
					this.SendPropertyChanging();
					this._MaNV = value;
					this.SendPropertyChanged("MaNV");
					this.OnMaNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaylapHD", DbType="Date")]
		public System.Nullable<System.DateTime> NgaylapHD
		{
			get
			{
				return this._NgaylapHD;
			}
			set
			{
				if ((this._NgaylapHD != value))
				{
					this.OnNgaylapHDChanging(value);
					this.SendPropertyChanging();
					this._NgaylapHD = value;
					this.SendPropertyChanged("NgaylapHD");
					this.OnNgaylapHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaygiaohang", DbType="Date")]
		public System.Nullable<System.DateTime> Ngaygiaohang
		{
			get
			{
				return this._Ngaygiaohang;
			}
			set
			{
				if ((this._Ngaygiaohang != value))
				{
					this.OnNgaygiaohangChanging(value);
					this.SendPropertyChanging();
					this._Ngaygiaohang = value;
					this.SendPropertyChanged("Ngaygiaohang");
					this.OnNgaygiaohangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Thanhtoan", DbType="Bit")]
		public System.Nullable<bool> Thanhtoan
		{
			get
			{
				return this._Thanhtoan;
			}
			set
			{
				if ((this._Thanhtoan != value))
				{
					this.OnThanhtoanChanging(value);
					this.SendPropertyChanging();
					this._Thanhtoan = value;
					this.SendPropertyChanged("Thanhtoan");
					this.OnThanhtoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HoaDon_CTHD", Storage="_CTHDs", ThisKey="MaHD", OtherKey="MaHD")]
		public EntitySet<CTHD> CTHDs
		{
			get
			{
				return this._CTHDs;
			}
			set
			{
				this._CTHDs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_HoaDon", Storage="_KhachHang", ThisKey="MaKH", OtherKey="MaKH", IsForeignKey=true)]
		public KhachHang KhachHang
		{
			get
			{
				return this._KhachHang.Entity;
			}
			set
			{
				KhachHang previousValue = this._KhachHang.Entity;
				if (((previousValue != value) 
							|| (this._KhachHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KhachHang.Entity = null;
						previousValue.HoaDons.Remove(this);
					}
					this._KhachHang.Entity = value;
					if ((value != null))
					{
						value.HoaDons.Add(this);
						this._MaKH = value.MaKH;
					}
					else
					{
						this._MaKH = default(Nullable<int>);
					}
					this.SendPropertyChanged("KhachHang");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_CTHDs(CTHD entity)
		{
			this.SendPropertyChanging();
			entity.HoaDon = this;
		}
		
		private void detach_CTHDs(CTHD entity)
		{
			this.SendPropertyChanging();
			entity.HoaDon = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhachHang")]
	public partial class KhachHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKH;
		
		private string _TenKH;
		
		private string _Diachi;
		
		private string _SDT;
		
		private string _Email;
		
		private string _Tendangnhap;
		
		private string _Matkhau;
		
		private System.Nullable<System.DateTime> _Ngaysinh;
		
		private EntitySet<HoaDon> _HoaDons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKHChanging(int value);
    partial void OnMaKHChanged();
    partial void OnTenKHChanging(string value);
    partial void OnTenKHChanged();
    partial void OnDiachiChanging(string value);
    partial void OnDiachiChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnTendangnhapChanging(string value);
    partial void OnTendangnhapChanged();
    partial void OnMatkhauChanging(string value);
    partial void OnMatkhauChanged();
    partial void OnNgaysinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaysinhChanged();
    #endregion
		
		public KhachHang()
		{
			this._HoaDons = new EntitySet<HoaDon>(new Action<HoaDon>(this.attach_HoaDons), new Action<HoaDon>(this.detach_HoaDons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKH", DbType="NVarChar(50)")]
		public string TenKH
		{
			get
			{
				return this._TenKH;
			}
			set
			{
				if ((this._TenKH != value))
				{
					this.OnTenKHChanging(value);
					this.SendPropertyChanging();
					this._TenKH = value;
					this.SendPropertyChanged("TenKH");
					this.OnTenKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Diachi", DbType="NVarChar(50)")]
		public string Diachi
		{
			get
			{
				return this._Diachi;
			}
			set
			{
				if ((this._Diachi != value))
				{
					this.OnDiachiChanging(value);
					this.SendPropertyChanging();
					this._Diachi = value;
					this.SendPropertyChanged("Diachi");
					this.OnDiachiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="NVarChar(30)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tendangnhap", DbType="VarChar(20)")]
		public string Tendangnhap
		{
			get
			{
				return this._Tendangnhap;
			}
			set
			{
				if ((this._Tendangnhap != value))
				{
					this.OnTendangnhapChanging(value);
					this.SendPropertyChanging();
					this._Tendangnhap = value;
					this.SendPropertyChanged("Tendangnhap");
					this.OnTendangnhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Matkhau", DbType="VarChar(10)")]
		public string Matkhau
		{
			get
			{
				return this._Matkhau;
			}
			set
			{
				if ((this._Matkhau != value))
				{
					this.OnMatkhauChanging(value);
					this.SendPropertyChanging();
					this._Matkhau = value;
					this.SendPropertyChanged("Matkhau");
					this.OnMatkhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaysinh", DbType="Date")]
		public System.Nullable<System.DateTime> Ngaysinh
		{
			get
			{
				return this._Ngaysinh;
			}
			set
			{
				if ((this._Ngaysinh != value))
				{
					this.OnNgaysinhChanging(value);
					this.SendPropertyChanging();
					this._Ngaysinh = value;
					this.SendPropertyChanged("Ngaysinh");
					this.OnNgaysinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_HoaDon", Storage="_HoaDons", ThisKey="MaKH", OtherKey="MaKH")]
		public EntitySet<HoaDon> HoaDons
		{
			get
			{
				return this._HoaDons;
			}
			set
			{
				this._HoaDons.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = this;
		}
		
		private void detach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoaiSP")]
	public partial class LoaiSP : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaloaiSP;
		
		private string _TenloaiSP;
		
		private EntitySet<SanPham> _SanPhams;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaloaiSPChanging(int value);
    partial void OnMaloaiSPChanged();
    partial void OnTenloaiSPChanging(string value);
    partial void OnTenloaiSPChanged();
    #endregion
		
		public LoaiSP()
		{
			this._SanPhams = new EntitySet<SanPham>(new Action<SanPham>(this.attach_SanPhams), new Action<SanPham>(this.detach_SanPhams));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaloaiSP", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaloaiSP
		{
			get
			{
				return this._MaloaiSP;
			}
			set
			{
				if ((this._MaloaiSP != value))
				{
					this.OnMaloaiSPChanging(value);
					this.SendPropertyChanging();
					this._MaloaiSP = value;
					this.SendPropertyChanged("MaloaiSP");
					this.OnMaloaiSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenloaiSP", DbType="NVarChar(50)")]
		public string TenloaiSP
		{
			get
			{
				return this._TenloaiSP;
			}
			set
			{
				if ((this._TenloaiSP != value))
				{
					this.OnTenloaiSPChanging(value);
					this.SendPropertyChanging();
					this._TenloaiSP = value;
					this.SendPropertyChanged("TenloaiSP");
					this.OnTenloaiSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiSP_SanPham", Storage="_SanPhams", ThisKey="MaloaiSP", OtherKey="MaloaiSP")]
		public EntitySet<SanPham> SanPhams
		{
			get
			{
				return this._SanPhams;
			}
			set
			{
				this._SanPhams.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.LoaiSP = this;
		}
		
		private void detach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.LoaiSP = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SanPham")]
	public partial class SanPham : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaSP;
		
		private string _TenSP;
		
		private System.Nullable<decimal> _Dongia;
		
		private System.Nullable<int> _MaloaiSP;
		
		private string _HinhSP;
		
		private System.Nullable<int> _Soluong;
		
		private System.Nullable<System.DateTime> _Ngaycapnhat;
		
		private EntitySet<CTHD> _CTHDs;
		
		private EntityRef<LoaiSP> _LoaiSP;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSPChanging(int value);
    partial void OnMaSPChanged();
    partial void OnTenSPChanging(string value);
    partial void OnTenSPChanged();
    partial void OnDongiaChanging(System.Nullable<decimal> value);
    partial void OnDongiaChanged();
    partial void OnMaloaiSPChanging(System.Nullable<int> value);
    partial void OnMaloaiSPChanged();
    partial void OnHinhSPChanging(string value);
    partial void OnHinhSPChanged();
    partial void OnSoluongChanging(System.Nullable<int> value);
    partial void OnSoluongChanged();
    partial void OnNgaycapnhatChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaycapnhatChanged();
    #endregion
		
		public SanPham()
		{
			this._CTHDs = new EntitySet<CTHD>(new Action<CTHD>(this.attach_CTHDs), new Action<CTHD>(this.detach_CTHDs));
			this._LoaiSP = default(EntityRef<LoaiSP>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					this.OnMaSPChanging(value);
					this.SendPropertyChanging();
					this._MaSP = value;
					this.SendPropertyChanged("MaSP");
					this.OnMaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSP", DbType="NVarChar(50)")]
		public string TenSP
		{
			get
			{
				return this._TenSP;
			}
			set
			{
				if ((this._TenSP != value))
				{
					this.OnTenSPChanging(value);
					this.SendPropertyChanging();
					this._TenSP = value;
					this.SendPropertyChanged("TenSP");
					this.OnTenSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dongia", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Dongia
		{
			get
			{
				return this._Dongia;
			}
			set
			{
				if ((this._Dongia != value))
				{
					this.OnDongiaChanging(value);
					this.SendPropertyChanging();
					this._Dongia = value;
					this.SendPropertyChanged("Dongia");
					this.OnDongiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaloaiSP", DbType="Int")]
		public System.Nullable<int> MaloaiSP
		{
			get
			{
				return this._MaloaiSP;
			}
			set
			{
				if ((this._MaloaiSP != value))
				{
					if (this._LoaiSP.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaloaiSPChanging(value);
					this.SendPropertyChanging();
					this._MaloaiSP = value;
					this.SendPropertyChanged("MaloaiSP");
					this.OnMaloaiSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HinhSP", DbType="NVarChar(50)")]
		public string HinhSP
		{
			get
			{
				return this._HinhSP;
			}
			set
			{
				if ((this._HinhSP != value))
				{
					this.OnHinhSPChanging(value);
					this.SendPropertyChanging();
					this._HinhSP = value;
					this.SendPropertyChanged("HinhSP");
					this.OnHinhSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Soluong", DbType="Int")]
		public System.Nullable<int> Soluong
		{
			get
			{
				return this._Soluong;
			}
			set
			{
				if ((this._Soluong != value))
				{
					this.OnSoluongChanging(value);
					this.SendPropertyChanging();
					this._Soluong = value;
					this.SendPropertyChanged("Soluong");
					this.OnSoluongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaycapnhat", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> Ngaycapnhat
		{
			get
			{
				return this._Ngaycapnhat;
			}
			set
			{
				if ((this._Ngaycapnhat != value))
				{
					this.OnNgaycapnhatChanging(value);
					this.SendPropertyChanging();
					this._Ngaycapnhat = value;
					this.SendPropertyChanged("Ngaycapnhat");
					this.OnNgaycapnhatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SanPham_CTHD", Storage="_CTHDs", ThisKey="MaSP", OtherKey="MaSP")]
		public EntitySet<CTHD> CTHDs
		{
			get
			{
				return this._CTHDs;
			}
			set
			{
				this._CTHDs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiSP_SanPham", Storage="_LoaiSP", ThisKey="MaloaiSP", OtherKey="MaloaiSP", IsForeignKey=true)]
		public LoaiSP LoaiSP
		{
			get
			{
				return this._LoaiSP.Entity;
			}
			set
			{
				LoaiSP previousValue = this._LoaiSP.Entity;
				if (((previousValue != value) 
							|| (this._LoaiSP.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LoaiSP.Entity = null;
						previousValue.SanPhams.Remove(this);
					}
					this._LoaiSP.Entity = value;
					if ((value != null))
					{
						value.SanPhams.Add(this);
						this._MaloaiSP = value.MaloaiSP;
					}
					else
					{
						this._MaloaiSP = default(Nullable<int>);
					}
					this.SendPropertyChanged("LoaiSP");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_CTHDs(CTHD entity)
		{
			this.SendPropertyChanging();
			entity.SanPham = this;
		}
		
		private void detach_CTHDs(CTHD entity)
		{
			this.SendPropertyChanging();
			entity.SanPham = null;
		}
	}
}
#pragma warning restore 1591

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

namespace BTL_asp_quanaobaochau.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanAoBaoChau")]
	public partial class DataBaseContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertChiTietDonHang(ChiTietDonHang instance);
    partial void UpdateChiTietDonHang(ChiTietDonHang instance);
    partial void DeleteChiTietDonHang(ChiTietDonHang instance);
    partial void InsertDonHang(DonHang instance);
    partial void UpdateDonHang(DonHang instance);
    partial void DeleteDonHang(DonHang instance);
    partial void InsertHinhAnh(HinhAnh instance);
    partial void UpdateHinhAnh(HinhAnh instance);
    partial void DeleteHinhAnh(HinhAnh instance);
    partial void InsertLoaiSanPham(LoaiSanPham instance);
    partial void UpdateLoaiSanPham(LoaiSanPham instance);
    partial void DeleteLoaiSanPham(LoaiSanPham instance);
    partial void InsertSanPham(SanPham instance);
    partial void UpdateSanPham(SanPham instance);
    partial void DeleteSanPham(SanPham instance);
    partial void InsertTinTuc(TinTuc instance);
    partial void UpdateTinTuc(TinTuc instance);
    partial void DeleteTinTuc(TinTuc instance);
    partial void InsertTinTuc1(TinTuc1 instance);
    partial void UpdateTinTuc1(TinTuc1 instance);
    partial void DeleteTinTuc1(TinTuc1 instance);
    #endregion
		
		public DataBaseContextDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QuanAoBaoChauConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ChiTietDonHang> ChiTietDonHangs
		{
			get
			{
				return this.GetTable<ChiTietDonHang>();
			}
		}
		
		public System.Data.Linq.Table<DonHang> DonHangs
		{
			get
			{
				return this.GetTable<DonHang>();
			}
		}
		
		public System.Data.Linq.Table<HinhAnh> HinhAnhs
		{
			get
			{
				return this.GetTable<HinhAnh>();
			}
		}
		
		public System.Data.Linq.Table<LoaiSanPham> LoaiSanPhams
		{
			get
			{
				return this.GetTable<LoaiSanPham>();
			}
		}
		
		public System.Data.Linq.Table<SanPham> SanPhams
		{
			get
			{
				return this.GetTable<SanPham>();
			}
		}
		
		public System.Data.Linq.Table<TinTuc> TinTucs
		{
			get
			{
				return this.GetTable<TinTuc>();
			}
		}
		
		public System.Data.Linq.Table<TinTuc1> TinTuc1s
		{
			get
			{
				return this.GetTable<TinTuc1>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChiTietDonHang")]
	public partial class ChiTietDonHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaChiTietDonHang;
		
		private int _MaSanPham;
		
		private string _SoLuongMua;
		
		private int _MaDonHang;
		
		private EntityRef<DonHang> _DonHang;
		
		private EntityRef<SanPham> _SanPham;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaChiTietDonHangChanging(int value);
    partial void OnMaChiTietDonHangChanged();
    partial void OnMaSanPhamChanging(int value);
    partial void OnMaSanPhamChanged();
    partial void OnSoLuongMuaChanging(string value);
    partial void OnSoLuongMuaChanged();
    partial void OnMaDonHangChanging(int value);
    partial void OnMaDonHangChanged();
    #endregion
		
		public ChiTietDonHang()
		{
			this._DonHang = default(EntityRef<DonHang>);
			this._SanPham = default(EntityRef<SanPham>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaChiTietDonHang", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaChiTietDonHang
		{
			get
			{
				return this._MaChiTietDonHang;
			}
			set
			{
				if ((this._MaChiTietDonHang != value))
				{
					this.OnMaChiTietDonHangChanging(value);
					this.SendPropertyChanging();
					this._MaChiTietDonHang = value;
					this.SendPropertyChanged("MaChiTietDonHang");
					this.OnMaChiTietDonHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSanPham", DbType="Int NOT NULL")]
		public int MaSanPham
		{
			get
			{
				return this._MaSanPham;
			}
			set
			{
				if ((this._MaSanPham != value))
				{
					if (this._SanPham.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSanPhamChanging(value);
					this.SendPropertyChanging();
					this._MaSanPham = value;
					this.SendPropertyChanged("MaSanPham");
					this.OnMaSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuongMua", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string SoLuongMua
		{
			get
			{
				return this._SoLuongMua;
			}
			set
			{
				if ((this._SoLuongMua != value))
				{
					this.OnSoLuongMuaChanging(value);
					this.SendPropertyChanging();
					this._SoLuongMua = value;
					this.SendPropertyChanged("SoLuongMua");
					this.OnSoLuongMuaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDonHang", DbType="Int NOT NULL")]
		public int MaDonHang
		{
			get
			{
				return this._MaDonHang;
			}
			set
			{
				if ((this._MaDonHang != value))
				{
					if (this._DonHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaDonHangChanging(value);
					this.SendPropertyChanging();
					this._MaDonHang = value;
					this.SendPropertyChanged("MaDonHang");
					this.OnMaDonHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonHang_ChiTietDonHang", Storage="_DonHang", ThisKey="MaDonHang", OtherKey="MaDonHang", IsForeignKey=true)]
		public DonHang DonHang
		{
			get
			{
				return this._DonHang.Entity;
			}
			set
			{
				DonHang previousValue = this._DonHang.Entity;
				if (((previousValue != value) 
							|| (this._DonHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DonHang.Entity = null;
						previousValue.ChiTietDonHangs.Remove(this);
					}
					this._DonHang.Entity = value;
					if ((value != null))
					{
						value.ChiTietDonHangs.Add(this);
						this._MaDonHang = value.MaDonHang;
					}
					else
					{
						this._MaDonHang = default(int);
					}
					this.SendPropertyChanged("DonHang");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SanPham_ChiTietDonHang", Storage="_SanPham", ThisKey="MaSanPham", OtherKey="MaSanPham", IsForeignKey=true)]
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
						previousValue.ChiTietDonHangs.Remove(this);
					}
					this._SanPham.Entity = value;
					if ((value != null))
					{
						value.ChiTietDonHangs.Add(this);
						this._MaSanPham = value.MaSanPham;
					}
					else
					{
						this._MaSanPham = default(int);
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DonHang")]
	public partial class DonHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDonHang;
		
		private string _HoTen;
		
		private string _DiaChi;
		
		private string _Email;
		
		private string _SoDienThoai;
		
		private System.Nullable<int> _TongTien;
		
		private EntitySet<ChiTietDonHang> _ChiTietDonHangs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDonHangChanging(int value);
    partial void OnMaDonHangChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnSoDienThoaiChanging(string value);
    partial void OnSoDienThoaiChanged();
    partial void OnTongTienChanging(System.Nullable<int> value);
    partial void OnTongTienChanged();
    #endregion
		
		public DonHang()
		{
			this._ChiTietDonHangs = new EntitySet<ChiTietDonHang>(new Action<ChiTietDonHang>(this.attach_ChiTietDonHangs), new Action<ChiTietDonHang>(this.detach_ChiTietDonHangs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDonHang", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaDonHang
		{
			get
			{
				return this._MaDonHang;
			}
			set
			{
				if ((this._MaDonHang != value))
				{
					this.OnMaDonHangChanging(value);
					this.SendPropertyChanging();
					this._MaDonHang = value;
					this.SendPropertyChanged("MaDonHang");
					this.OnMaDonHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDienThoai", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string SoDienThoai
		{
			get
			{
				return this._SoDienThoai;
			}
			set
			{
				if ((this._SoDienThoai != value))
				{
					this.OnSoDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._SoDienThoai = value;
					this.SendPropertyChanged("SoDienThoai");
					this.OnSoDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongTien", DbType="Int")]
		public System.Nullable<int> TongTien
		{
			get
			{
				return this._TongTien;
			}
			set
			{
				if ((this._TongTien != value))
				{
					this.OnTongTienChanging(value);
					this.SendPropertyChanging();
					this._TongTien = value;
					this.SendPropertyChanged("TongTien");
					this.OnTongTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DonHang_ChiTietDonHang", Storage="_ChiTietDonHangs", ThisKey="MaDonHang", OtherKey="MaDonHang")]
		public EntitySet<ChiTietDonHang> ChiTietDonHangs
		{
			get
			{
				return this._ChiTietDonHangs;
			}
			set
			{
				this._ChiTietDonHangs.Assign(value);
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
		
		private void attach_ChiTietDonHangs(ChiTietDonHang entity)
		{
			this.SendPropertyChanging();
			entity.DonHang = this;
		}
		
		private void detach_ChiTietDonHangs(ChiTietDonHang entity)
		{
			this.SendPropertyChanging();
			entity.DonHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HinhAnh")]
	public partial class HinhAnh : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHinhAnh;
		
		private string _LinkAnh;
		
		private System.Nullable<int> _MaSanPham;
		
		private EntityRef<SanPham> _SanPham;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHinhAnhChanging(int value);
    partial void OnMaHinhAnhChanged();
    partial void OnLinkAnhChanging(string value);
    partial void OnLinkAnhChanged();
    partial void OnMaSanPhamChanging(System.Nullable<int> value);
    partial void OnMaSanPhamChanged();
    #endregion
		
		public HinhAnh()
		{
			this._SanPham = default(EntityRef<SanPham>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHinhAnh", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaHinhAnh
		{
			get
			{
				return this._MaHinhAnh;
			}
			set
			{
				if ((this._MaHinhAnh != value))
				{
					this.OnMaHinhAnhChanging(value);
					this.SendPropertyChanging();
					this._MaHinhAnh = value;
					this.SendPropertyChanged("MaHinhAnh");
					this.OnMaHinhAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LinkAnh", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
		public string LinkAnh
		{
			get
			{
				return this._LinkAnh;
			}
			set
			{
				if ((this._LinkAnh != value))
				{
					this.OnLinkAnhChanging(value);
					this.SendPropertyChanging();
					this._LinkAnh = value;
					this.SendPropertyChanged("LinkAnh");
					this.OnLinkAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSanPham", DbType="Int")]
		public System.Nullable<int> MaSanPham
		{
			get
			{
				return this._MaSanPham;
			}
			set
			{
				if ((this._MaSanPham != value))
				{
					if (this._SanPham.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSanPhamChanging(value);
					this.SendPropertyChanging();
					this._MaSanPham = value;
					this.SendPropertyChanged("MaSanPham");
					this.OnMaSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SanPham_HinhAnh", Storage="_SanPham", ThisKey="MaSanPham", OtherKey="MaSanPham", IsForeignKey=true)]
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
						previousValue.HinhAnhs.Remove(this);
					}
					this._SanPham.Entity = value;
					if ((value != null))
					{
						value.HinhAnhs.Add(this);
						this._MaSanPham = value.MaSanPham;
					}
					else
					{
						this._MaSanPham = default(Nullable<int>);
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoaiSanPham")]
	public partial class LoaiSanPham : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaLoai;
		
		private string _TenLoai;
		
		private EntitySet<SanPham> _SanPhams;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaLoaiChanging(int value);
    partial void OnMaLoaiChanged();
    partial void OnTenLoaiChanging(string value);
    partial void OnTenLoaiChanged();
    #endregion
		
		public LoaiSanPham()
		{
			this._SanPhams = new EntitySet<SanPham>(new Action<SanPham>(this.attach_SanPhams), new Action<SanPham>(this.detach_SanPhams));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoai", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaLoai
		{
			get
			{
				return this._MaLoai;
			}
			set
			{
				if ((this._MaLoai != value))
				{
					this.OnMaLoaiChanging(value);
					this.SendPropertyChanging();
					this._MaLoai = value;
					this.SendPropertyChanged("MaLoai");
					this.OnMaLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLoai", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string TenLoai
		{
			get
			{
				return this._TenLoai;
			}
			set
			{
				if ((this._TenLoai != value))
				{
					this.OnTenLoaiChanging(value);
					this.SendPropertyChanging();
					this._TenLoai = value;
					this.SendPropertyChanged("TenLoai");
					this.OnTenLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiSanPham_SanPham", Storage="_SanPhams", ThisKey="MaLoai", OtherKey="MaLoaiSanPham")]
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
			entity.LoaiSanPham = this;
		}
		
		private void detach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.LoaiSanPham = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SanPham")]
	public partial class SanPham : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaSanPham;
		
		private string _TenSanPham;
		
		private string _LinkAnh;
		
		private string _MoTa;
		
		private int _Gia;
		
		private int _SoLuongCon;
		
		private string _XuatXu;
		
		private string _Hang;
		
		private int _SoLuotXem;
		
		private System.Nullable<int> _MaLoaiSanPham;
		
		private System.Nullable<int> _TinhTrang;
		
		private EntitySet<ChiTietDonHang> _ChiTietDonHangs;
		
		private EntitySet<HinhAnh> _HinhAnhs;
		
		private EntityRef<LoaiSanPham> _LoaiSanPham;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSanPhamChanging(int value);
    partial void OnMaSanPhamChanged();
    partial void OnTenSanPhamChanging(string value);
    partial void OnTenSanPhamChanged();
    partial void OnLinkAnhChanging(string value);
    partial void OnLinkAnhChanged();
    partial void OnMoTaChanging(string value);
    partial void OnMoTaChanged();
    partial void OnGiaChanging(int value);
    partial void OnGiaChanged();
    partial void OnSoLuongConChanging(int value);
    partial void OnSoLuongConChanged();
    partial void OnXuatXuChanging(string value);
    partial void OnXuatXuChanged();
    partial void OnHangChanging(string value);
    partial void OnHangChanged();
    partial void OnSoLuotXemChanging(int value);
    partial void OnSoLuotXemChanged();
    partial void OnMaLoaiSanPhamChanging(System.Nullable<int> value);
    partial void OnMaLoaiSanPhamChanged();
    partial void OnTinhTrangChanging(System.Nullable<int> value);
    partial void OnTinhTrangChanged();
    #endregion
		
		public SanPham()
		{
			this._ChiTietDonHangs = new EntitySet<ChiTietDonHang>(new Action<ChiTietDonHang>(this.attach_ChiTietDonHangs), new Action<ChiTietDonHang>(this.detach_ChiTietDonHangs));
			this._HinhAnhs = new EntitySet<HinhAnh>(new Action<HinhAnh>(this.attach_HinhAnhs), new Action<HinhAnh>(this.detach_HinhAnhs));
			this._LoaiSanPham = default(EntityRef<LoaiSanPham>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSanPham", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaSanPham
		{
			get
			{
				return this._MaSanPham;
			}
			set
			{
				if ((this._MaSanPham != value))
				{
					this.OnMaSanPhamChanging(value);
					this.SendPropertyChanging();
					this._MaSanPham = value;
					this.SendPropertyChanged("MaSanPham");
					this.OnMaSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSanPham", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TenSanPham
		{
			get
			{
				return this._TenSanPham;
			}
			set
			{
				if ((this._TenSanPham != value))
				{
					this.OnTenSanPhamChanging(value);
					this.SendPropertyChanging();
					this._TenSanPham = value;
					this.SendPropertyChanged("TenSanPham");
					this.OnTenSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LinkAnh", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string LinkAnh
		{
			get
			{
				return this._LinkAnh;
			}
			set
			{
				if ((this._LinkAnh != value))
				{
					this.OnLinkAnhChanging(value);
					this.SendPropertyChanging();
					this._LinkAnh = value;
					this.SendPropertyChanged("LinkAnh");
					this.OnLinkAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoTa", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string MoTa
		{
			get
			{
				return this._MoTa;
			}
			set
			{
				if ((this._MoTa != value))
				{
					this.OnMoTaChanging(value);
					this.SendPropertyChanging();
					this._MoTa = value;
					this.SendPropertyChanged("MoTa");
					this.OnMoTaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gia", DbType="Int NOT NULL")]
		public int Gia
		{
			get
			{
				return this._Gia;
			}
			set
			{
				if ((this._Gia != value))
				{
					this.OnGiaChanging(value);
					this.SendPropertyChanging();
					this._Gia = value;
					this.SendPropertyChanged("Gia");
					this.OnGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuongCon", DbType="Int NOT NULL")]
		public int SoLuongCon
		{
			get
			{
				return this._SoLuongCon;
			}
			set
			{
				if ((this._SoLuongCon != value))
				{
					this.OnSoLuongConChanging(value);
					this.SendPropertyChanging();
					this._SoLuongCon = value;
					this.SendPropertyChanged("SoLuongCon");
					this.OnSoLuongConChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_XuatXu", DbType="NVarChar(30)")]
		public string XuatXu
		{
			get
			{
				return this._XuatXu;
			}
			set
			{
				if ((this._XuatXu != value))
				{
					this.OnXuatXuChanging(value);
					this.SendPropertyChanging();
					this._XuatXu = value;
					this.SendPropertyChanged("XuatXu");
					this.OnXuatXuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hang", DbType="NVarChar(30)")]
		public string Hang
		{
			get
			{
				return this._Hang;
			}
			set
			{
				if ((this._Hang != value))
				{
					this.OnHangChanging(value);
					this.SendPropertyChanging();
					this._Hang = value;
					this.SendPropertyChanged("Hang");
					this.OnHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuotXem", DbType="Int NOT NULL")]
		public int SoLuotXem
		{
			get
			{
				return this._SoLuotXem;
			}
			set
			{
				if ((this._SoLuotXem != value))
				{
					this.OnSoLuotXemChanging(value);
					this.SendPropertyChanging();
					this._SoLuotXem = value;
					this.SendPropertyChanged("SoLuotXem");
					this.OnSoLuotXemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoaiSanPham", DbType="Int")]
		public System.Nullable<int> MaLoaiSanPham
		{
			get
			{
				return this._MaLoaiSanPham;
			}
			set
			{
				if ((this._MaLoaiSanPham != value))
				{
					if (this._LoaiSanPham.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaLoaiSanPhamChanging(value);
					this.SendPropertyChanging();
					this._MaLoaiSanPham = value;
					this.SendPropertyChanged("MaLoaiSanPham");
					this.OnMaLoaiSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrang", DbType="Int")]
		public System.Nullable<int> TinhTrang
		{
			get
			{
				return this._TinhTrang;
			}
			set
			{
				if ((this._TinhTrang != value))
				{
					this.OnTinhTrangChanging(value);
					this.SendPropertyChanging();
					this._TinhTrang = value;
					this.SendPropertyChanged("TinhTrang");
					this.OnTinhTrangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SanPham_ChiTietDonHang", Storage="_ChiTietDonHangs", ThisKey="MaSanPham", OtherKey="MaSanPham")]
		public EntitySet<ChiTietDonHang> ChiTietDonHangs
		{
			get
			{
				return this._ChiTietDonHangs;
			}
			set
			{
				this._ChiTietDonHangs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SanPham_HinhAnh", Storage="_HinhAnhs", ThisKey="MaSanPham", OtherKey="MaSanPham")]
		public EntitySet<HinhAnh> HinhAnhs
		{
			get
			{
				return this._HinhAnhs;
			}
			set
			{
				this._HinhAnhs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiSanPham_SanPham", Storage="_LoaiSanPham", ThisKey="MaLoaiSanPham", OtherKey="MaLoai", IsForeignKey=true)]
		public LoaiSanPham LoaiSanPham
		{
			get
			{
				return this._LoaiSanPham.Entity;
			}
			set
			{
				LoaiSanPham previousValue = this._LoaiSanPham.Entity;
				if (((previousValue != value) 
							|| (this._LoaiSanPham.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LoaiSanPham.Entity = null;
						previousValue.SanPhams.Remove(this);
					}
					this._LoaiSanPham.Entity = value;
					if ((value != null))
					{
						value.SanPhams.Add(this);
						this._MaLoaiSanPham = value.MaLoai;
					}
					else
					{
						this._MaLoaiSanPham = default(Nullable<int>);
					}
					this.SendPropertyChanged("LoaiSanPham");
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
		
		private void attach_ChiTietDonHangs(ChiTietDonHang entity)
		{
			this.SendPropertyChanging();
			entity.SanPham = this;
		}
		
		private void detach_ChiTietDonHangs(ChiTietDonHang entity)
		{
			this.SendPropertyChanging();
			entity.SanPham = null;
		}
		
		private void attach_HinhAnhs(HinhAnh entity)
		{
			this.SendPropertyChanging();
			entity.SanPham = this;
		}
		
		private void detach_HinhAnhs(HinhAnh entity)
		{
			this.SendPropertyChanging();
			entity.SanPham = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TinTuc")]
	public partial class TinTuc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaTinTuc;
		
		private string _TieuDe;
		
		private string _NoiDung;
		
		private string _LinkAnh;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaTinTucChanging(int value);
    partial void OnMaTinTucChanged();
    partial void OnTieuDeChanging(string value);
    partial void OnTieuDeChanged();
    partial void OnNoiDungChanging(string value);
    partial void OnNoiDungChanged();
    partial void OnLinkAnhChanging(string value);
    partial void OnLinkAnhChanged();
    #endregion
		
		public TinTuc()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTinTuc", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaTinTuc
		{
			get
			{
				return this._MaTinTuc;
			}
			set
			{
				if ((this._MaTinTuc != value))
				{
					this.OnMaTinTucChanging(value);
					this.SendPropertyChanging();
					this._MaTinTuc = value;
					this.SendPropertyChanged("MaTinTuc");
					this.OnMaTinTucChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TieuDe", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
		public string TieuDe
		{
			get
			{
				return this._TieuDe;
			}
			set
			{
				if ((this._TieuDe != value))
				{
					this.OnTieuDeChanging(value);
					this.SendPropertyChanging();
					this._TieuDe = value;
					this.SendPropertyChanged("TieuDe");
					this.OnTieuDeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoiDung", DbType="NText NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string NoiDung
		{
			get
			{
				return this._NoiDung;
			}
			set
			{
				if ((this._NoiDung != value))
				{
					this.OnNoiDungChanging(value);
					this.SendPropertyChanging();
					this._NoiDung = value;
					this.SendPropertyChanged("NoiDung");
					this.OnNoiDungChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LinkAnh", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string LinkAnh
		{
			get
			{
				return this._LinkAnh;
			}
			set
			{
				if ((this._LinkAnh != value))
				{
					this.OnLinkAnhChanging(value);
					this.SendPropertyChanging();
					this._LinkAnh = value;
					this.SendPropertyChanged("LinkAnh");
					this.OnLinkAnhChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TinTuc")]
	public partial class TinTuc1 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaTinTuc;
		
		private string _TieuDe;
		
		private string _NoiDung;
		
		private string _LinkAnh;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaTinTucChanging(int value);
    partial void OnMaTinTucChanged();
    partial void OnTieuDeChanging(string value);
    partial void OnTieuDeChanged();
    partial void OnNoiDungChanging(string value);
    partial void OnNoiDungChanged();
    partial void OnLinkAnhChanging(string value);
    partial void OnLinkAnhChanged();
    #endregion
		
		public TinTuc1()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTinTuc", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaTinTuc
		{
			get
			{
				return this._MaTinTuc;
			}
			set
			{
				if ((this._MaTinTuc != value))
				{
					this.OnMaTinTucChanging(value);
					this.SendPropertyChanging();
					this._MaTinTuc = value;
					this.SendPropertyChanged("MaTinTuc");
					this.OnMaTinTucChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TieuDe", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
		public string TieuDe
		{
			get
			{
				return this._TieuDe;
			}
			set
			{
				if ((this._TieuDe != value))
				{
					this.OnTieuDeChanging(value);
					this.SendPropertyChanging();
					this._TieuDe = value;
					this.SendPropertyChanged("TieuDe");
					this.OnTieuDeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoiDung", DbType="NText NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string NoiDung
		{
			get
			{
				return this._NoiDung;
			}
			set
			{
				if ((this._NoiDung != value))
				{
					this.OnNoiDungChanging(value);
					this.SendPropertyChanging();
					this._NoiDung = value;
					this.SendPropertyChanged("NoiDung");
					this.OnNoiDungChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LinkAnh", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string LinkAnh
		{
			get
			{
				return this._LinkAnh;
			}
			set
			{
				if ((this._LinkAnh != value))
				{
					this.OnLinkAnhChanging(value);
					this.SendPropertyChanging();
					this._LinkAnh = value;
					this.SendPropertyChanged("LinkAnh");
					this.OnLinkAnhChanged();
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
}
#pragma warning restore 1591

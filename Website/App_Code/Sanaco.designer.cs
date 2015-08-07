﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Sanaco")]
public partial class SanacoDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertSessionCart(SessionCart instance);
  partial void UpdateSessionCart(SessionCart instance);
  partial void DeleteSessionCart(SessionCart instance);
  partial void InsertProduct(Product instance);
  partial void UpdateProduct(Product instance);
  partial void DeleteProduct(Product instance);
  partial void InsertOrdersDetail(OrdersDetail instance);
  partial void UpdateOrdersDetail(OrdersDetail instance);
  partial void DeleteOrdersDetail(OrdersDetail instance);
  partial void InsertOrder(Order instance);
  partial void UpdateOrder(Order instance);
  partial void DeleteOrder(Order instance);
  #endregion
	
	public SanacoDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SanacoConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public SanacoDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public SanacoDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public SanacoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public SanacoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<SessionCart> SessionCarts
	{
		get
		{
			return this.GetTable<SessionCart>();
		}
	}
	
	public System.Data.Linq.Table<Product> Products
	{
		get
		{
			return this.GetTable<Product>();
		}
	}
	
	public System.Data.Linq.Table<OrdersDetail> OrdersDetails
	{
		get
		{
			return this.GetTable<OrdersDetail>();
		}
	}
	
	public System.Data.Linq.Table<Order> Orders
	{
		get
		{
			return this.GetTable<Order>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SessionCart")]
public partial class SessionCart : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _SessionId;
	
	private int _ProductId;
	
	private int _Quantity;
	
	private EntityRef<Product> _Product;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSessionIdChanging(string value);
    partial void OnSessionIdChanged();
    partial void OnProductIdChanging(int value);
    partial void OnProductIdChanged();
    partial void OnQuantityChanging(int value);
    partial void OnQuantityChanged();
    #endregion
	
	public SessionCart()
	{
		this._Product = default(EntityRef<Product>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SessionId", DbType="VarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string SessionId
	{
		get
		{
			return this._SessionId;
		}
		set
		{
			if ((this._SessionId != value))
			{
				this.OnSessionIdChanging(value);
				this.SendPropertyChanging();
				this._SessionId = value;
				this.SendPropertyChanged("SessionId");
				this.OnSessionIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ProductId
	{
		get
		{
			return this._ProductId;
		}
		set
		{
			if ((this._ProductId != value))
			{
				if (this._Product.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnProductIdChanging(value);
				this.SendPropertyChanging();
				this._ProductId = value;
				this.SendPropertyChanged("ProductId");
				this.OnProductIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
	public int Quantity
	{
		get
		{
			return this._Quantity;
		}
		set
		{
			if ((this._Quantity != value))
			{
				this.OnQuantityChanging(value);
				this.SendPropertyChanging();
				this._Quantity = value;
				this.SendPropertyChanged("Quantity");
				this.OnQuantityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_SessionCart", Storage="_Product", ThisKey="ProductId", OtherKey="ID", IsForeignKey=true)]
	public Product Product
	{
		get
		{
			return this._Product.Entity;
		}
		set
		{
			Product previousValue = this._Product.Entity;
			if (((previousValue != value) 
						|| (this._Product.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Product.Entity = null;
					previousValue.SessionCarts.Remove(this);
				}
				this._Product.Entity = value;
				if ((value != null))
				{
					value.SessionCarts.Add(this);
					this._ProductId = value.ID;
				}
				else
				{
					this._ProductId = default(int);
				}
				this.SendPropertyChanged("Product");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private int _ProductCategoryID;
	
	private string _ProductCode;
	
	private string _ProductName;
	
	private string _Description;
	
	private string _Detail;
	
	private System.Nullable<decimal> _OldPrice;
	
	private System.Nullable<int> _Discount;
	
	private System.Nullable<decimal> _NewPrice;
	
	private string _Thumbnail;
	
	private string _Image;
	
	private string _Origin;
	
	private string _Guarantee;
	
	private EntitySet<SessionCart> _SessionCarts;
	
	private EntitySet<OrdersDetail> _OrdersDetails;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnProductCategoryIDChanging(int value);
    partial void OnProductCategoryIDChanged();
    partial void OnProductCodeChanging(string value);
    partial void OnProductCodeChanged();
    partial void OnProductNameChanging(string value);
    partial void OnProductNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnDetailChanging(string value);
    partial void OnDetailChanged();
    partial void OnOldPriceChanging(System.Nullable<decimal> value);
    partial void OnOldPriceChanged();
    partial void OnDiscountChanging(System.Nullable<int> value);
    partial void OnDiscountChanged();
    partial void OnNewPriceChanging(System.Nullable<decimal> value);
    partial void OnNewPriceChanged();
    partial void OnThumbnailChanging(string value);
    partial void OnThumbnailChanged();
    partial void OnImageChanging(string value);
    partial void OnImageChanged();
    partial void OnOriginChanging(string value);
    partial void OnOriginChanged();
    partial void OnGuaranteeChanging(string value);
    partial void OnGuaranteeChanged();
    #endregion
	
	public Product()
	{
		this._SessionCarts = new EntitySet<SessionCart>(new Action<SessionCart>(this.attach_SessionCarts), new Action<SessionCart>(this.detach_SessionCarts));
		this._OrdersDetails = new EntitySet<OrdersDetail>(new Action<OrdersDetail>(this.attach_OrdersDetails), new Action<OrdersDetail>(this.detach_OrdersDetails));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductCategoryID", DbType="Int NOT NULL")]
	public int ProductCategoryID
	{
		get
		{
			return this._ProductCategoryID;
		}
		set
		{
			if ((this._ProductCategoryID != value))
			{
				this.OnProductCategoryIDChanging(value);
				this.SendPropertyChanging();
				this._ProductCategoryID = value;
				this.SendPropertyChanged("ProductCategoryID");
				this.OnProductCategoryIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductCode", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string ProductCode
	{
		get
		{
			return this._ProductCode;
		}
		set
		{
			if ((this._ProductCode != value))
			{
				this.OnProductCodeChanging(value);
				this.SendPropertyChanging();
				this._ProductCode = value;
				this.SendPropertyChanged("ProductCode");
				this.OnProductCodeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductName", DbType="NVarChar(100)")]
	public string ProductName
	{
		get
		{
			return this._ProductName;
		}
		set
		{
			if ((this._ProductName != value))
			{
				this.OnProductNameChanging(value);
				this.SendPropertyChanging();
				this._ProductName = value;
				this.SendPropertyChanged("ProductName");
				this.OnProductNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(300)")]
	public string Description
	{
		get
		{
			return this._Description;
		}
		set
		{
			if ((this._Description != value))
			{
				this.OnDescriptionChanging(value);
				this.SendPropertyChanging();
				this._Description = value;
				this.SendPropertyChanged("Description");
				this.OnDescriptionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Detail", DbType="NVarChar(MAX)")]
	public string Detail
	{
		get
		{
			return this._Detail;
		}
		set
		{
			if ((this._Detail != value))
			{
				this.OnDetailChanging(value);
				this.SendPropertyChanging();
				this._Detail = value;
				this.SendPropertyChanged("Detail");
				this.OnDetailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OldPrice", DbType="Money")]
	public System.Nullable<decimal> OldPrice
	{
		get
		{
			return this._OldPrice;
		}
		set
		{
			if ((this._OldPrice != value))
			{
				this.OnOldPriceChanging(value);
				this.SendPropertyChanging();
				this._OldPrice = value;
				this.SendPropertyChanged("OldPrice");
				this.OnOldPriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Discount", DbType="Int")]
	public System.Nullable<int> Discount
	{
		get
		{
			return this._Discount;
		}
		set
		{
			if ((this._Discount != value))
			{
				this.OnDiscountChanging(value);
				this.SendPropertyChanging();
				this._Discount = value;
				this.SendPropertyChanged("Discount");
				this.OnDiscountChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NewPrice", DbType="Money")]
	public System.Nullable<decimal> NewPrice
	{
		get
		{
			return this._NewPrice;
		}
		set
		{
			if ((this._NewPrice != value))
			{
				this.OnNewPriceChanging(value);
				this.SendPropertyChanging();
				this._NewPrice = value;
				this.SendPropertyChanged("NewPrice");
				this.OnNewPriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Thumbnail", DbType="NVarChar(100)")]
	public string Thumbnail
	{
		get
		{
			return this._Thumbnail;
		}
		set
		{
			if ((this._Thumbnail != value))
			{
				this.OnThumbnailChanging(value);
				this.SendPropertyChanging();
				this._Thumbnail = value;
				this.SendPropertyChanged("Thumbnail");
				this.OnThumbnailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Image", DbType="NVarChar(1000)")]
	public string Image
	{
		get
		{
			return this._Image;
		}
		set
		{
			if ((this._Image != value))
			{
				this.OnImageChanging(value);
				this.SendPropertyChanging();
				this._Image = value;
				this.SendPropertyChanged("Image");
				this.OnImageChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Origin", DbType="NVarChar(100)")]
	public string Origin
	{
		get
		{
			return this._Origin;
		}
		set
		{
			if ((this._Origin != value))
			{
				this.OnOriginChanging(value);
				this.SendPropertyChanging();
				this._Origin = value;
				this.SendPropertyChanged("Origin");
				this.OnOriginChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Guarantee", DbType="NVarChar(100)")]
	public string Guarantee
	{
		get
		{
			return this._Guarantee;
		}
		set
		{
			if ((this._Guarantee != value))
			{
				this.OnGuaranteeChanging(value);
				this.SendPropertyChanging();
				this._Guarantee = value;
				this.SendPropertyChanged("Guarantee");
				this.OnGuaranteeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_SessionCart", Storage="_SessionCarts", ThisKey="ID", OtherKey="ProductId")]
	public EntitySet<SessionCart> SessionCarts
	{
		get
		{
			return this._SessionCarts;
		}
		set
		{
			this._SessionCarts.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_OrdersDetail", Storage="_OrdersDetails", ThisKey="ID", OtherKey="ProductID")]
	public EntitySet<OrdersDetail> OrdersDetails
	{
		get
		{
			return this._OrdersDetails;
		}
		set
		{
			this._OrdersDetails.Assign(value);
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
	
	private void attach_SessionCarts(SessionCart entity)
	{
		this.SendPropertyChanging();
		entity.Product = this;
	}
	
	private void detach_SessionCarts(SessionCart entity)
	{
		this.SendPropertyChanging();
		entity.Product = null;
	}
	
	private void attach_OrdersDetails(OrdersDetail entity)
	{
		this.SendPropertyChanging();
		entity.Product = this;
	}
	
	private void detach_OrdersDetails(OrdersDetail entity)
	{
		this.SendPropertyChanging();
		entity.Product = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OrdersDetail")]
public partial class OrdersDetail : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _OrderID;
	
	private int _ProductID;
	
	private System.Nullable<int> _Quantity;
	
	private System.Nullable<decimal> _SellPrice;
	
	private System.Nullable<decimal> _Total;
	
	private EntityRef<Product> _Product;
	
	private EntityRef<Order> _Order;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIDChanging(int value);
    partial void OnOrderIDChanged();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnQuantityChanging(System.Nullable<int> value);
    partial void OnQuantityChanged();
    partial void OnSellPriceChanging(System.Nullable<decimal> value);
    partial void OnSellPriceChanged();
    partial void OnTotalChanging(System.Nullable<decimal> value);
    partial void OnTotalChanged();
    #endregion
	
	public OrdersDetail()
	{
		this._Product = default(EntityRef<Product>);
		this._Order = default(EntityRef<Order>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int OrderID
	{
		get
		{
			return this._OrderID;
		}
		set
		{
			if ((this._OrderID != value))
			{
				if (this._Order.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnOrderIDChanging(value);
				this.SendPropertyChanging();
				this._OrderID = value;
				this.SendPropertyChanged("OrderID");
				this.OnOrderIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ProductID
	{
		get
		{
			return this._ProductID;
		}
		set
		{
			if ((this._ProductID != value))
			{
				if (this._Product.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnProductIDChanging(value);
				this.SendPropertyChanging();
				this._ProductID = value;
				this.SendPropertyChanged("ProductID");
				this.OnProductIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int")]
	public System.Nullable<int> Quantity
	{
		get
		{
			return this._Quantity;
		}
		set
		{
			if ((this._Quantity != value))
			{
				this.OnQuantityChanging(value);
				this.SendPropertyChanging();
				this._Quantity = value;
				this.SendPropertyChanged("Quantity");
				this.OnQuantityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SellPrice", DbType="Money")]
	public System.Nullable<decimal> SellPrice
	{
		get
		{
			return this._SellPrice;
		}
		set
		{
			if ((this._SellPrice != value))
			{
				this.OnSellPriceChanging(value);
				this.SendPropertyChanging();
				this._SellPrice = value;
				this.SendPropertyChanged("SellPrice");
				this.OnSellPriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Total", DbType="Money")]
	public System.Nullable<decimal> Total
	{
		get
		{
			return this._Total;
		}
		set
		{
			if ((this._Total != value))
			{
				this.OnTotalChanging(value);
				this.SendPropertyChanging();
				this._Total = value;
				this.SendPropertyChanged("Total");
				this.OnTotalChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_OrdersDetail", Storage="_Product", ThisKey="ProductID", OtherKey="ID", IsForeignKey=true)]
	public Product Product
	{
		get
		{
			return this._Product.Entity;
		}
		set
		{
			Product previousValue = this._Product.Entity;
			if (((previousValue != value) 
						|| (this._Product.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Product.Entity = null;
					previousValue.OrdersDetails.Remove(this);
				}
				this._Product.Entity = value;
				if ((value != null))
				{
					value.OrdersDetails.Add(this);
					this._ProductID = value.ID;
				}
				else
				{
					this._ProductID = default(int);
				}
				this.SendPropertyChanged("Product");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_OrdersDetail", Storage="_Order", ThisKey="OrderID", OtherKey="ID", IsForeignKey=true)]
	public Order Order
	{
		get
		{
			return this._Order.Entity;
		}
		set
		{
			Order previousValue = this._Order.Entity;
			if (((previousValue != value) 
						|| (this._Order.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Order.Entity = null;
					previousValue.OrdersDetails.Remove(this);
				}
				this._Order.Entity = value;
				if ((value != null))
				{
					value.OrdersDetails.Add(this);
					this._OrderID = value.ID;
				}
				else
				{
					this._OrderID = default(int);
				}
				this.SendPropertyChanged("Order");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Orders")]
public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _HoTen;
	
	private string _Email;
	
	private string _DiaChi;
	
	private System.Nullable<int> _SDT;
	
	private string _YeuCauThem;
	
	private System.Nullable<System.DateTime> _NgayOrder;
	
	private System.Nullable<decimal> _TongHoaDon;
	
	private System.Nullable<int> _TrangThai;
	
	private string _SessionID;
	
	private EntitySet<OrdersDetail> _OrdersDetails;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnSDTChanging(System.Nullable<int> value);
    partial void OnSDTChanged();
    partial void OnYeuCauThemChanging(string value);
    partial void OnYeuCauThemChanged();
    partial void OnNgayOrderChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayOrderChanged();
    partial void OnTongHoaDonChanging(System.Nullable<decimal> value);
    partial void OnTongHoaDonChanged();
    partial void OnTrangThaiChanging(System.Nullable<int> value);
    partial void OnTrangThaiChanged();
    partial void OnSessionIDChanging(string value);
    partial void OnSessionIDChanged();
    #endregion
	
	public Order()
	{
		this._OrdersDetails = new EntitySet<OrdersDetail>(new Action<OrdersDetail>(this.attach_OrdersDetails), new Action<OrdersDetail>(this.detach_OrdersDetails));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(200)")]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(200)")]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(300)")]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="Int")]
	public System.Nullable<int> SDT
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YeuCauThem", DbType="NVarChar(3000)")]
	public string YeuCauThem
	{
		get
		{
			return this._YeuCauThem;
		}
		set
		{
			if ((this._YeuCauThem != value))
			{
				this.OnYeuCauThemChanging(value);
				this.SendPropertyChanging();
				this._YeuCauThem = value;
				this.SendPropertyChanged("YeuCauThem");
				this.OnYeuCauThemChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayOrder", DbType="SmallDateTime")]
	public System.Nullable<System.DateTime> NgayOrder
	{
		get
		{
			return this._NgayOrder;
		}
		set
		{
			if ((this._NgayOrder != value))
			{
				this.OnNgayOrderChanging(value);
				this.SendPropertyChanging();
				this._NgayOrder = value;
				this.SendPropertyChanged("NgayOrder");
				this.OnNgayOrderChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongHoaDon", DbType="Money")]
	public System.Nullable<decimal> TongHoaDon
	{
		get
		{
			return this._TongHoaDon;
		}
		set
		{
			if ((this._TongHoaDon != value))
			{
				this.OnTongHoaDonChanging(value);
				this.SendPropertyChanging();
				this._TongHoaDon = value;
				this.SendPropertyChanged("TongHoaDon");
				this.OnTongHoaDonChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrangThai", DbType="Int")]
	public System.Nullable<int> TrangThai
	{
		get
		{
			return this._TrangThai;
		}
		set
		{
			if ((this._TrangThai != value))
			{
				this.OnTrangThaiChanging(value);
				this.SendPropertyChanging();
				this._TrangThai = value;
				this.SendPropertyChanged("TrangThai");
				this.OnTrangThaiChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SessionID", DbType="NVarChar(100)")]
	public string SessionID
	{
		get
		{
			return this._SessionID;
		}
		set
		{
			if ((this._SessionID != value))
			{
				this.OnSessionIDChanging(value);
				this.SendPropertyChanging();
				this._SessionID = value;
				this.SendPropertyChanged("SessionID");
				this.OnSessionIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_OrdersDetail", Storage="_OrdersDetails", ThisKey="ID", OtherKey="OrderID")]
	public EntitySet<OrdersDetail> OrdersDetails
	{
		get
		{
			return this._OrdersDetails;
		}
		set
		{
			this._OrdersDetails.Assign(value);
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
	
	private void attach_OrdersDetails(OrdersDetail entity)
	{
		this.SendPropertyChanging();
		entity.Order = this;
	}
	
	private void detach_OrdersDetails(OrdersDetail entity)
	{
		this.SendPropertyChanging();
		entity.Order = null;
	}
}
#pragma warning restore 1591

namespace MvcApplication2.Models
{
 using System.Data;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using System;

[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Movie")]
 public partial class DataMovieDBDataContext : System.Data.Linq.DataContext
 {
    private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
    private static IDbConnection Iconnection = new System.Data.OleDb.OleDbConnection(MvcApplication2.Properties.Settings.Default.DataMovie);
   #region Extensibility Method Definitions
   partial void OnCreated();
   partial void InsertCategory(Category instance);
   partial void UpdateCategory(Category instance);
   partial void DeleteCategory(Category instance);
   partial void InsertMovie(Movie instance);
   partial void UpdateMovie(Movie instance);
   partial void DeleteMovie(Movie instance);
   partial void InsertOrder_Detail(Order_Detail instance);
   partial void UpdateOrder_Detail(Order_Detail instance);
   partial void DeleteOrder_Detail(Order_Detail instance);
   partial void InsertOrder(Order instance);
   partial void UpdateOrder(Order instance);
   partial void DeleteOrder(Order instance);
   partial void InsertProduct(Product instance);
   partial void UpdateProduct(Product instance);
   partial void DeleteProduct(Product instance);
   partial void InsertShipper(Shipper instance);
   partial void UpdateShipper(Shipper instance);
   partial void DeleteShipper(Shipper instance);
   partial void InsertSupplier(Supplier instance);
   partial void UpdateSupplier(Supplier instance);
   partial void DeleteSupplier(Supplier instance);
#endregion
	public DataMovieDBDataContext() :
       base(Iconnection, mappingSource)
	{
		OnCreated();
	}
  	public System.Data.Linq.Table<Category> Categories
	{
		get
		{
			return this.GetTable<Category>();
		}
 }
  	public System.Data.Linq.Table<Movie> Movies
	{
		get
		{
			return this.GetTable<Movie>();
		}
 }
  	public System.Data.Linq.Table<Order_Detail> Order_Details
	{
		get
		{
			return this.GetTable<Order_Detail>();
		}
 }
  	public System.Data.Linq.Table<Order> Orders
	{
		get
		{
			return this.GetTable<Order>();
		}
 }
  	public System.Data.Linq.Table<Product> Products
	{
		get
		{
			return this.GetTable<Product>();
		}
 }
  	public System.Data.Linq.Table<Shipper> Shippers
	{
		get
		{
			return this.GetTable<Shipper>();
		}
 }
  	public System.Data.Linq.Table<Supplier> Suppliers
	{
		get
		{
			return this.GetTable<Supplier>();
		}
 }

    public System.Data.Linq.Table<OrderDetail> OrderDetails
	{
		get
		{
            return this.GetTable<OrderDetail>();
		}
 }
    

	}

[global::System.Data.Linq.Mapping.TableAttribute(Name="Categories")]
[global::System.Runtime.Serialization.DataContractAttribute()]
public partial class Category   : INotifyPropertyChanging, INotifyPropertyChanged
 {
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
    private System.Nullable<int> _CategoryID;
    private string _CategoryName;
    private string _Description;
	private EntitySet<Product> _Products;
	  private bool serializing;
   #region Extensibility Method Definitions
   partial void OnLoaded();
   partial void OnValidate(System.Data.Linq.ChangeAction action);
   partial void OnCreated();
    partial void OnCategoryIDChanging(System.Nullable<int> Value);
    partial void OnCategoryIDChanged();
    partial void OnCategoryNameChanging(string Value);
    partial void OnCategoryNameChanged();
    partial void OnDescriptionChanging(string Value);
    partial void OnDescriptionChanged();
   #endregion
       public Category()
	{
		this.Initialize();
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="CategoryID", Storage="_CategoryID", DbType="Int NOT NULL IDENTITY",IsPrimaryKey=true, IsDbGenerated=true)]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=1)] 

	public System.Nullable<int> CategoryID
	{
		get
		{
			return this._CategoryID;
		}
		set
		{
			if ((this._CategoryID != value))
 			{
				this.OnCategoryIDChanging(value);
				this.SendPropertyChanging();
				this._CategoryID = value;
				this.SendPropertyChanged("CategoryID");
				this.OnCategoryIDChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="CategoryName", Storage="_CategoryName", DbType="NVarChar(15) NOT NULL ",CanBeNull=false)]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=2)] 

	public string CategoryName
	{
		get
		{
			return this._CategoryName;
		}
		set
		{
			if ((this._CategoryName != value))
 			{
				this.OnCategoryNameChanging(value);
				this.SendPropertyChanging();
				this._CategoryName = value;
				this.SendPropertyChanged("CategoryName");
				this.OnCategoryNameChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="Description", Storage="_Description", DbType="NVarChar(0)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=3)] 

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
[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Categories_Products", Storage="_Products", ThisKey="CategoryID", OtherKey="CategoryID")]
[global::System.Runtime.Serialization.DataMemberAttribute(Order=4, EmitDefaultValue=false)]

 	public EntitySet<Product> Products
	{
		get
		{
			if ((this.serializing 
						&& (this._Products.HasLoadedOrAssignedValues == false)))
			{
				return null;
			}
			return this._Products;
		}
		set
		{
			this._Products.Assign(value);
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
	private void attach_Products(Product entity)
	{
		this.SendPropertyChanging();
	entity.Category = this;
	}

	private void detach_Products(Product entity)
	{
		this.SendPropertyChanging();
		entity.Category = null;
	}
	private void Initialize()
	{
		this._Products = new EntitySet<Product>(new Action<Product>(this.attach_Products), new Action<Product>(this.detach_Products));
		OnCreated();
	}
	[global::System.Runtime.Serialization.OnDeserializingAttribute()]
	[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
	public void OnDeserializing(StreamingContext context)
	{
		this.Initialize();
	}
	[global::System.Runtime.Serialization.OnSerializingAttribute()]
	[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
	public void OnSerializing(StreamingContext context)
	{
		this.serializing = true;
	}
	[global::System.Runtime.Serialization.OnSerializedAttribute()]
	[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
	public void OnSerialized(StreamingContext context)
	{
		this.serializing = false;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="Movies")]
[global::System.Runtime.Serialization.DataContractAttribute()]
public partial class Movie   : INotifyPropertyChanging, INotifyPropertyChanged
 {
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
    private string _MovieID;
    private string _CompanyName;
    private string _ContactName;
    private string _ContactTitle;
    private string _Address;
    private string _City;
    private string _Region;
    private string _PostalCode;
    private string _Country;
    private string _Phone;
    private string _Fax;
	private EntitySet<Order> _Orders;
	  private bool serializing;
   #region Extensibility Method Definitions
   partial void OnLoaded();
   partial void OnValidate(System.Data.Linq.ChangeAction action);
   partial void OnCreated();
    partial void OnMovieIDChanging(string Value);
    partial void OnMovieIDChanged();
    partial void OnCompanyNameChanging(string Value);
    partial void OnCompanyNameChanged();
    partial void OnContactNameChanging(string Value);
    partial void OnContactNameChanged();
    partial void OnContactTitleChanging(string Value);
    partial void OnContactTitleChanged();
    partial void OnAddressChanging(string Value);
    partial void OnAddressChanged();
    partial void OnCityChanging(string Value);
    partial void OnCityChanged();
    partial void OnRegionChanging(string Value);
    partial void OnRegionChanged();
    partial void OnPostalCodeChanging(string Value);
    partial void OnPostalCodeChanged();
    partial void OnCountryChanging(string Value);
    partial void OnCountryChanged();
    partial void OnPhoneChanging(string Value);
    partial void OnPhoneChanged();
    partial void OnFaxChanging(string Value);
    partial void OnFaxChanged();
   #endregion
       public Movie()
	{
		this.Initialize();
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="MovieID", Storage="_MovieID", DbType="NVarChar(5)",IsPrimaryKey=true)]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=1)] 

	public string MovieID
	{
		get
		{
			return this._MovieID;
		}
		set
		{
			if ((this._MovieID != value))
 			{
				this.OnMovieIDChanging(value);
				this.SendPropertyChanging();
				this._MovieID = value;
				this.SendPropertyChanged("MovieID");
				this.OnMovieIDChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="CompanyName", Storage="_CompanyName", DbType="NVarChar(40) NOT NULL ",CanBeNull=false)]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=2)] 

	public string CompanyName
	{
		get
		{
			return this._CompanyName;
		}
		set
		{
			if ((this._CompanyName != value))
 			{
				this.OnCompanyNameChanging(value);
				this.SendPropertyChanging();
				this._CompanyName = value;
				this.SendPropertyChanged("CompanyName");
				this.OnCompanyNameChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="ContactName", Storage="_ContactName", DbType="NVarChar(30)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=3)] 

	public string ContactName
	{
		get
		{
			return this._ContactName;
		}
		set
		{
			if ((this._ContactName != value))
 			{
				this.OnContactNameChanging(value);
				this.SendPropertyChanging();
				this._ContactName = value;
				this.SendPropertyChanged("ContactName");
				this.OnContactNameChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="ContactTitle", Storage="_ContactTitle", DbType="NVarChar(30)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=4)] 

	public string ContactTitle
	{
		get
		{
			return this._ContactTitle;
		}
		set
		{
			if ((this._ContactTitle != value))
 			{
				this.OnContactTitleChanging(value);
				this.SendPropertyChanging();
				this._ContactTitle = value;
				this.SendPropertyChanged("ContactTitle");
				this.OnContactTitleChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="Address", Storage="_Address", DbType="NVarChar(60)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=5)] 

	public string Address
	{
		get
		{
			return this._Address;
		}
		set
		{
			if ((this._Address != value))
 			{
				this.OnAddressChanging(value);
				this.SendPropertyChanging();
				this._Address = value;
				this.SendPropertyChanged("Address");
				this.OnAddressChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="City", Storage="_City", DbType="NVarChar(15)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=6)] 

	public string City
	{
		get
		{
			return this._City;
		}
		set
		{
			if ((this._City != value))
 			{
				this.OnCityChanging(value);
				this.SendPropertyChanging();
				this._City = value;
				this.SendPropertyChanged("City");
				this.OnCityChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="Region", Storage="_Region", DbType="NVarChar(15)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=7)] 

	public string Region
	{
		get
		{
			return this._Region;
		}
		set
		{
			if ((this._Region != value))
 			{
				this.OnRegionChanging(value);
				this.SendPropertyChanging();
				this._Region = value;
				this.SendPropertyChanged("Region");
				this.OnRegionChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="PostalCode", Storage="_PostalCode", DbType="NVarChar(10)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=8)] 

	public string PostalCode
	{
		get
		{
			return this._PostalCode;
		}
		set
		{
			if ((this._PostalCode != value))
 			{
				this.OnPostalCodeChanging(value);
				this.SendPropertyChanging();
				this._PostalCode = value;
				this.SendPropertyChanged("PostalCode");
				this.OnPostalCodeChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="Country", Storage="_Country", DbType="NVarChar(15)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=9)] 

	public string Country
	{
		get
		{
			return this._Country;
		}
		set
		{
			if ((this._Country != value))
 			{
				this.OnCountryChanging(value);
				this.SendPropertyChanging();
				this._Country = value;
				this.SendPropertyChanged("Country");
				this.OnCountryChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="Phone", Storage="_Phone", DbType="NVarChar(24)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=10)] 

	public string Phone
	{
		get
		{
			return this._Phone;
		}
		set
		{
			if ((this._Phone != value))
 			{
				this.OnPhoneChanging(value);
				this.SendPropertyChanging();
				this._Phone = value;
				this.SendPropertyChanged("Phone");
				this.OnPhoneChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="Fax", Storage="_Fax", DbType="NVarChar(24)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=11)] 

	public string Fax
	{
		get
		{
			return this._Fax;
		}
		set
		{
			if ((this._Fax != value))
 			{
				this.OnFaxChanging(value);
				this.SendPropertyChanging();
				this._Fax = value;
				this.SendPropertyChanged("Fax");
				this.OnFaxChanged();
			}
		}
	}
[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Movies_Orders", Storage="_Orders", ThisKey="MovieID", OtherKey="MovieID")]
[global::System.Runtime.Serialization.DataMemberAttribute(Order=12, EmitDefaultValue=false)]

 	public EntitySet<Order> Orders
	{
		get
		{
			if ((this.serializing 
						&& (this._Orders.HasLoadedOrAssignedValues == false)))
			{
				return null;
			}
			return this._Orders;
		}
		set
		{
			this._Orders.Assign(value);
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
	private void attach_Orders(Order entity)
	{
		this.SendPropertyChanging();
	entity.Movie = this;
	}

	private void detach_Orders(Order entity)
	{
		this.SendPropertyChanging();
		entity.Movie = null;
	}
	private void Initialize()
	{
		this._Orders = new EntitySet<Order>(new Action<Order>(this.attach_Orders), new Action<Order>(this.detach_Orders));
		OnCreated();
	}
	[global::System.Runtime.Serialization.OnDeserializingAttribute()]
	[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
	public void OnDeserializing(StreamingContext context)
	{
		this.Initialize();
	}
	[global::System.Runtime.Serialization.OnSerializingAttribute()]
	[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
	public void OnSerializing(StreamingContext context)
	{
		this.serializing = true;
	}
	[global::System.Runtime.Serialization.OnSerializedAttribute()]
	[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
	public void OnSerialized(StreamingContext context)
	{
		this.serializing = false;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="Order Details")]
[global::System.Runtime.Serialization.DataContractAttribute()]
public partial class Order_Detail   : INotifyPropertyChanging, INotifyPropertyChanged
 {
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
    private System.Nullable<int> _OrderID;
    private System.Nullable<int> _ProductID;
    private System.Nullable<decimal> _UnitPrice;
    private System.Nullable<short> _Quantity;
    private System.Nullable<float> _Discount;
	private EntityRef<Order> _Order;
	private EntityRef<Product> _Product;
	private bool serializing;
   #region Extensibility Method Definitions
   partial void OnLoaded();
   partial void OnValidate(System.Data.Linq.ChangeAction action);
   partial void OnCreated();
    partial void OnOrderIDChanging(System.Nullable<int> Value);
    partial void OnOrderIDChanged();
    partial void OnProductIDChanging(System.Nullable<int> Value);
    partial void OnProductIDChanged();
    partial void OnUnitPriceChanging(System.Nullable<decimal> Value);
    partial void OnUnitPriceChanged();
    partial void OnQuantityChanging(System.Nullable<short> Value);
    partial void OnQuantityChanged();
    partial void OnDiscountChanging(System.Nullable<float> Value);
    partial void OnDiscountChanged();
   #endregion
       public Order_Detail()
	{
		this.Initialize();
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="OrderID", Storage="_OrderID", DbType="Int",IsPrimaryKey=true)]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=1)] 
	public System.Nullable<int> OrderID
	{
		get
		{
			return this._OrderID;
		}
		set
		{
			if ((this._OrderID != value))
 			{
				this.OnOrderIDChanging(value);
				this.SendPropertyChanging();
				this._OrderID = value;
				this.SendPropertyChanged("OrderID");
				this.OnOrderIDChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="ProductID", Storage="_ProductID", DbType="Int",CanBeNull=false)]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=2)] 
	public System.Nullable<int> ProductID
	{
		get
		{
			return this._ProductID;
		}
		set
		{
			if ((this._ProductID != value))
 			{
				this.OnProductIDChanging(value);
				this.SendPropertyChanging();
				this._ProductID = value;
				this.SendPropertyChanged("ProductID");
				this.OnProductIDChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="UnitPrice", Storage="_UnitPrice", DbType="Money NOT NULL",CanBeNull=false)]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=3)] 
  public System.Nullable<decimal> UnitPrice
	{
		get
		{
			return this._UnitPrice;
		}
		set
		{
			if ((this._UnitPrice != value))
 			{
				this.OnUnitPriceChanging(value);
				this.SendPropertyChanging();
				this._UnitPrice = value;
				this.SendPropertyChanged("UnitPrice");
				this.OnUnitPriceChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="Quantity", Storage="_Quantity", DbType="SmallInt",CanBeNull=false)]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=4)] 
  public System.Nullable<short> Quantity
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
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="Discount", Storage="_Discount", DbType="Real NOT NULL ",CanBeNull=false)]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=5)] 

	public System.Nullable<float> Discount
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
[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_Details_Orders", Storage="_Order", ThisKey="OrderID", OtherKey="OrderID")]
[global::System.Runtime.Serialization.DataMemberAttribute(Order=6, EmitDefaultValue=false)]

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
				previousValue.Order_Details.Remove(this);
			}
			this._Order.Entity = value;
			if ((value != null))
			{
				value.Order_Details.Add(this);
				this._OrderID = value.OrderID;
			}
              else
			{
				this._OrderID = default(System.Nullable<int>);
			}
			this.SendPropertyChanged("Order");
		 }
 	}
 }
[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_Details_Products", Storage="_Product", ThisKey="ProductID", OtherKey="ProductID")]
[global::System.Runtime.Serialization.DataMemberAttribute(Order=6, EmitDefaultValue=false)]
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
				previousValue.Order_Details.Remove(this);
			}
			this._Product.Entity = value;
			if ((value != null))
			{
				value.Order_Details.Add(this);
				this._ProductID = value.ProductID;
			}
              else
			{
				this._ProductID = default(System.Nullable<int>);
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
	private void Initialize()
	{
    this._Order = default(EntityRef<Order>);
    this._Product = default(EntityRef<Product>);
		OnCreated();
	}
	[global::System.Runtime.Serialization.OnDeserializingAttribute()]
	[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
	public void OnDeserializing(StreamingContext context)
	{
		this.Initialize();
	}
	[global::System.Runtime.Serialization.OnSerializingAttribute()]
	[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
	public void OnSerializing(StreamingContext context)
	{
		this.serializing = true;
	}
	[global::System.Runtime.Serialization.OnSerializedAttribute()]
	[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
	public void OnSerialized(StreamingContext context)
	{
        this.serializing = false;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="Orders")]
[global::System.Runtime.Serialization.DataContractAttribute()]
public partial class Order   : INotifyPropertyChanging, INotifyPropertyChanged
 {
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
    private System.Nullable<int> _OrderID;
    private string _MovieID;
    private System.Nullable<int> _EmployeeID;
    private System.Nullable<System.DateTime> _OrderDate;
    private System.Nullable<System.DateTime> _RequiredDate;
    private System.Nullable<System.DateTime> _ShippedDate;
    private System.Nullable<int> _ShipVia;
    private System.Nullable<decimal> _Freight;
    private string _ShipName;
    private string _ShipAddress;
    private string _ShipCity;
    private string _ShipRegion;
    private string _ShipPostalCode;
    private string _ShipCountry;
	private EntitySet<Order_Detail> _Order_Details;
	private EntityRef<Movie> _Movie;
	private EntityRef<Shipper> _Shipper;
	  private bool serializing;
   #region Extensibility Method Definitions
   partial void OnLoaded();
   partial void OnValidate(System.Data.Linq.ChangeAction action);
   partial void OnCreated();
    partial void OnOrderIDChanging(System.Nullable<int> Value);
    partial void OnOrderIDChanged();
    partial void OnMovieIDChanging(string Value);
    partial void OnMovieIDChanged();
    partial void OnEmployeeIDChanging(System.Nullable<int> Value);
    partial void OnEmployeeIDChanged();
    partial void OnOrderDateChanging(System.Nullable<System.DateTime> Value);
    partial void OnOrderDateChanged();
    partial void OnRequiredDateChanging(System.Nullable<System.DateTime> Value);
    partial void OnRequiredDateChanged();
    partial void OnShippedDateChanging(System.Nullable<System.DateTime> Value);
    partial void OnShippedDateChanged();
    partial void OnShipViaChanging(System.Nullable<int> Value);
    partial void OnShipViaChanged();
    partial void OnFreightChanging(System.Nullable<decimal> Value);
    partial void OnFreightChanged();
    partial void OnShipNameChanging(string Value);
    partial void OnShipNameChanged();
    partial void OnShipAddressChanging(string Value);
    partial void OnShipAddressChanged();
    partial void OnShipCityChanging(string Value);
    partial void OnShipCityChanged();
    partial void OnShipRegionChanging(string Value);
    partial void OnShipRegionChanged();
    partial void OnShipPostalCodeChanging(string Value);
    partial void OnShipPostalCodeChanged();
    partial void OnShipCountryChanging(string Value);
    partial void OnShipCountryChanged();
   #endregion
       public Order()
	{
		this.Initialize();
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="OrderID", Storage="_OrderID", DbType="Int NOT NULL IDENTITY",IsPrimaryKey=true, IsDbGenerated=true)]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=1)] 

	public System.Nullable<int> OrderID
	{
		get
		{
			return this._OrderID;
		}
		set
		{
			if ((this._OrderID != value))
 			{
				this.OnOrderIDChanging(value);
				this.SendPropertyChanging();
				this._OrderID = value;
				this.SendPropertyChanged("OrderID");
				this.OnOrderIDChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="MovieID", Storage="_MovieID", DbType="NVarChar(5)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=2)] 

	public string MovieID
	{
		get
		{
			return this._MovieID;
		}
		set
		{
			if ((this._MovieID != value))
 			{
				this.OnMovieIDChanging(value);
				this.SendPropertyChanging();
				this._MovieID = value;
				this.SendPropertyChanged("MovieID");
				this.OnMovieIDChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="EmployeeID", Storage="_EmployeeID", DbType="Int")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=3)] 

	public System.Nullable<int> EmployeeID
	{
		get
		{
			return this._EmployeeID;
		}
		set
		{
			if ((this._EmployeeID != value))
 			{
				this.OnEmployeeIDChanging(value);
				this.SendPropertyChanging();
				this._EmployeeID = value;
				this.SendPropertyChanged("EmployeeID");
				this.OnEmployeeIDChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="OrderDate", Storage="_OrderDate", DbType="DateTime")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=4)] 

	public System.Nullable<System.DateTime> OrderDate
	{
		get
		{
			return this._OrderDate;
		}
		set
		{
			if ((this._OrderDate != value))
 			{
				this.OnOrderDateChanging(value);
				this.SendPropertyChanging();
				this._OrderDate = value;
				this.SendPropertyChanged("OrderDate");
				this.OnOrderDateChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="RequiredDate", Storage="_RequiredDate", DbType="DateTime")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=5)] 

	public System.Nullable<System.DateTime> RequiredDate
	{
		get
		{
			return this._RequiredDate;
		}
		set
		{
			if ((this._RequiredDate != value))
 			{
				this.OnRequiredDateChanging(value);
				this.SendPropertyChanging();
				this._RequiredDate = value;
				this.SendPropertyChanged("RequiredDate");
				this.OnRequiredDateChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="ShippedDate", Storage="_ShippedDate", DbType="DateTime")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=6)] 

	public System.Nullable<System.DateTime> ShippedDate
	{
		get
		{
			return this._ShippedDate;
		}
		set
		{
			if ((this._ShippedDate != value))
 			{
				this.OnShippedDateChanging(value);
				this.SendPropertyChanging();
				this._ShippedDate = value;
				this.SendPropertyChanged("ShippedDate");
				this.OnShippedDateChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="ShipVia", Storage="_ShipVia", DbType="Int")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=7)] 

	public System.Nullable<int> ShipVia
	{
		get
		{
			return this._ShipVia;
		}
		set
		{
			if ((this._ShipVia != value))
 			{
				this.OnShipViaChanging(value);
				this.SendPropertyChanging();
				this._ShipVia = value;
				this.SendPropertyChanged("ShipVia");
				this.OnShipViaChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="Freight", Storage="_Freight", DbType="Money")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=8)] 

	public System.Nullable<decimal> Freight
	{
		get
		{
			return this._Freight;
		}
		set
		{
			if ((this._Freight != value))
 			{
				this.OnFreightChanging(value);
				this.SendPropertyChanging();
				this._Freight = value;
				this.SendPropertyChanged("Freight");
				this.OnFreightChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="ShipName", Storage="_ShipName", DbType="NVarChar(40)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=9)] 

	public string ShipName
	{
		get
		{
			return this._ShipName;
		}
		set
		{
			if ((this._ShipName != value))
 			{
				this.OnShipNameChanging(value);
				this.SendPropertyChanging();
				this._ShipName = value;
				this.SendPropertyChanged("ShipName");
				this.OnShipNameChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="ShipAddress", Storage="_ShipAddress", DbType="NVarChar(60)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=10)] 

	public string ShipAddress
	{
		get
		{
			return this._ShipAddress;
		}
		set
		{
			if ((this._ShipAddress != value))
 			{
				this.OnShipAddressChanging(value);
				this.SendPropertyChanging();
				this._ShipAddress = value;
				this.SendPropertyChanged("ShipAddress");
				this.OnShipAddressChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="ShipCity", Storage="_ShipCity", DbType="NVarChar(15)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=11)] 

	public string ShipCity
	{
		get
		{
			return this._ShipCity;
		}
		set
		{
			if ((this._ShipCity != value))
 			{
				this.OnShipCityChanging(value);
				this.SendPropertyChanging();
				this._ShipCity = value;
				this.SendPropertyChanged("ShipCity");
				this.OnShipCityChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="ShipRegion", Storage="_ShipRegion", DbType="NVarChar(15)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=12)] 

	public string ShipRegion
	{
		get
		{
			return this._ShipRegion;
		}
		set
		{
			if ((this._ShipRegion != value))
 			{
				this.OnShipRegionChanging(value);
				this.SendPropertyChanging();
				this._ShipRegion = value;
				this.SendPropertyChanged("ShipRegion");
				this.OnShipRegionChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="ShipPostalCode", Storage="_ShipPostalCode", DbType="NVarChar(10)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=13)] 

	public string ShipPostalCode
	{
		get
		{
			return this._ShipPostalCode;
		}
		set
		{
			if ((this._ShipPostalCode != value))
 			{
				this.OnShipPostalCodeChanging(value);
				this.SendPropertyChanging();
				this._ShipPostalCode = value;
				this.SendPropertyChanged("ShipPostalCode");
				this.OnShipPostalCodeChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="ShipCountry", Storage="_ShipCountry", DbType="NVarChar(15)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=14)] 

	public string ShipCountry
	{
		get
		{
			return this._ShipCountry;
		}
		set
		{
			if ((this._ShipCountry != value))
 			{
				this.OnShipCountryChanging(value);
				this.SendPropertyChanging();
				this._ShipCountry = value;
				this.SendPropertyChanged("ShipCountry");
				this.OnShipCountryChanged();
			}
		}
	}
[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Orders_Order_Details", Storage="_Order_Details", ThisKey="OrderID", OtherKey="OrderID")]
[global::System.Runtime.Serialization.DataMemberAttribute(Order=15, EmitDefaultValue=false)]

 	public EntitySet<Order_Detail> Order_Details
	{
		get
		{
			if ((this.serializing 
						&& (this._Order_Details.HasLoadedOrAssignedValues == false)))
			{
				return null;
			}
			return this._Order_Details;
		}
		set
		{
			this._Order_Details.Assign(value);
		}
	}
[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Orders_Movies", Storage="_Movie", ThisKey="MovieID", OtherKey="MovieID")]
[global::System.Runtime.Serialization.DataMemberAttribute(Order=16, EmitDefaultValue=false)]

 public Movie Movie
 {
	get
	{
		return this._Movie.Entity;
	}
	set
	{
		Movie previousValue = this._Movie.Entity;
		if (((previousValue != value) 
					|| (this._Movie.HasLoadedOrAssignedValue == false)))
		{
			this.SendPropertyChanging();
			if ((previousValue != null))
			{
				this._Movie.Entity = null;
				previousValue.Orders.Remove(this);
			}
			this._Movie.Entity = value;
			if ((value != null))
			{
				value.Orders.Add(this);
				this._MovieID = value.MovieID;
			}
              else
			{
				this._MovieID = default(string);
			}
			this.SendPropertyChanged("Movie");
		 }
 	}
 }
[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Orders_Shippers", Storage="_Shipper", ThisKey="ShipVia", OtherKey="ShipperID")]
[global::System.Runtime.Serialization.DataMemberAttribute(Order=16, EmitDefaultValue=false)]

 public Shipper Shipper
 {
	get
	{
		return this._Shipper.Entity;
	}
	set
	{
		Shipper previousValue = this._Shipper.Entity;
		if (((previousValue != value) 
					|| (this._Shipper.HasLoadedOrAssignedValue == false)))
		{
			this.SendPropertyChanging();
			if ((previousValue != null))
			{
				this._Shipper.Entity = null;
				previousValue.Orders.Remove(this);
			}
			this._Shipper.Entity = value;
			if ((value != null))
			{
				value.Orders.Add(this);
				this._ShipVia = value.ShipperID;
			}
              else
			{
				this._ShipVia = default(System.Nullable<int>);
			}
			this.SendPropertyChanged("Shipper");
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
	private void attach_Order_Details(Order_Detail entity)
	{
		this.SendPropertyChanging();
	entity.Order = this;
	}

	private void detach_Order_Details(Order_Detail entity)
	{
		this.SendPropertyChanging();
		entity.Order = null;
	}
	private void Initialize()
	{
		this._Order_Details = new EntitySet<Order_Detail>(new Action<Order_Detail>(this.attach_Order_Details), new Action<Order_Detail>(this.detach_Order_Details));
    this._Movie = default(EntityRef<Movie>);
    this._Shipper = default(EntityRef<Shipper>);
		OnCreated();
	}
	[global::System.Runtime.Serialization.OnDeserializingAttribute()]
	[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
	public void OnDeserializing(StreamingContext context)
	{
		this.Initialize();
	}
	[global::System.Runtime.Serialization.OnSerializingAttribute()]
	[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
	public void OnSerializing(StreamingContext context)
	{
		this.serializing = true;
	}
	[global::System.Runtime.Serialization.OnSerializedAttribute()]
	[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
	public void OnSerialized(StreamingContext context)
	{
		this.serializing = false;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="Products")]
[global::System.Runtime.Serialization.DataContractAttribute()]
public partial class Product   : INotifyPropertyChanging, INotifyPropertyChanged
 {
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
    private System.Nullable<int> _ProductID;
    private string _ProductName;
    private System.Nullable<int> _SupplierID;
    private System.Nullable<int> _CategoryID;
    private string _QuantityPerUnit;
    private System.Nullable<decimal> _UnitPrice;
    private System.Nullable<short> _UnitsInStock;
    private System.Nullable<short> _UnitsOnOrder;
    private System.Nullable<short> _ReorderLevel;
    private bool _Discontinued;
	private EntitySet<Order_Detail> _Order_Details;
	private EntityRef<Supplier> _Supplier;
	private EntityRef<Category> _Category;
	  private bool serializing;
   #region Extensibility Method Definitions
   partial void OnLoaded();
   partial void OnValidate(System.Data.Linq.ChangeAction action);
   partial void OnCreated();
    partial void OnProductIDChanging(System.Nullable<int> Value);
    partial void OnProductIDChanged();
    partial void OnProductNameChanging(string Value);
    partial void OnProductNameChanged();
    partial void OnSupplierIDChanging(System.Nullable<int> Value);
    partial void OnSupplierIDChanged();
    partial void OnCategoryIDChanging(System.Nullable<int> Value);
    partial void OnCategoryIDChanged();
    partial void OnQuantityPerUnitChanging(string Value);
    partial void OnQuantityPerUnitChanged();
    partial void OnUnitPriceChanging(System.Nullable<decimal> Value);
    partial void OnUnitPriceChanged();
    partial void OnUnitsInStockChanging(System.Nullable<short> Value);
    partial void OnUnitsInStockChanged();
    partial void OnUnitsOnOrderChanging(System.Nullable<short> Value);
    partial void OnUnitsOnOrderChanged();
    partial void OnReorderLevelChanging(System.Nullable<short> Value);
    partial void OnReorderLevelChanged();
    partial void OnDiscontinuedChanging(bool Value);
    partial void OnDiscontinuedChanged();
   #endregion
       public Product()
	{
		this.Initialize();
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="ProductID", Storage="_ProductID", DbType="Int NOT NULL IDENTITY",IsPrimaryKey=true, IsDbGenerated=true)]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=1)] 

	public System.Nullable<int> ProductID
	{
		get
		{
			return this._ProductID;
		}
		set
		{
			if ((this._ProductID != value))
 			{
				this.OnProductIDChanging(value);
				this.SendPropertyChanging();
				this._ProductID = value;
				this.SendPropertyChanged("ProductID");
				this.OnProductIDChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="ProductName", Storage="_ProductName", DbType="NVarChar(40) NOT NULL ",CanBeNull=false)]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=2)] 

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
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="SupplierID", Storage="_SupplierID", DbType="Int")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=3)] 

	public System.Nullable<int> SupplierID
	{
		get
		{
			return this._SupplierID;
		}
		set
		{
			if ((this._SupplierID != value))
 			{
				this.OnSupplierIDChanging(value);
				this.SendPropertyChanging();
				this._SupplierID = value;
				this.SendPropertyChanged("SupplierID");
				this.OnSupplierIDChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="CategoryID", Storage="_CategoryID", DbType="Int")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=4)] 

	public System.Nullable<int> CategoryID
	{
		get
		{
			return this._CategoryID;
		}
		set
		{
			if ((this._CategoryID != value))
 			{
				this.OnCategoryIDChanging(value);
				this.SendPropertyChanging();
				this._CategoryID = value;
				this.SendPropertyChanged("CategoryID");
				this.OnCategoryIDChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="QuantityPerUnit", Storage="_QuantityPerUnit", DbType="NVarChar(20)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=5)] 

	public string QuantityPerUnit
	{
		get
		{
			return this._QuantityPerUnit;
		}
		set
		{
			if ((this._QuantityPerUnit != value))
 			{
				this.OnQuantityPerUnitChanging(value);
				this.SendPropertyChanging();
				this._QuantityPerUnit = value;
				this.SendPropertyChanged("QuantityPerUnit");
				this.OnQuantityPerUnitChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="UnitPrice", Storage="_UnitPrice", DbType="Money")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=6)] 

	public System.Nullable<decimal> UnitPrice
	{
		get
		{
			return this._UnitPrice;
		}
		set
		{
			if ((this._UnitPrice != value))
 			{
				this.OnUnitPriceChanging(value);
				this.SendPropertyChanging();
				this._UnitPrice = value;
				this.SendPropertyChanged("UnitPrice");
				this.OnUnitPriceChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="UnitsInStock", Storage="_UnitsInStock", DbType="SmallInt")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=7)] 

	public System.Nullable<short> UnitsInStock
	{
		get
		{
			return this._UnitsInStock;
		}
		set
		{
			if ((this._UnitsInStock != value))
 			{
				this.OnUnitsInStockChanging(value);
				this.SendPropertyChanging();
				this._UnitsInStock = value;
				this.SendPropertyChanged("UnitsInStock");
				this.OnUnitsInStockChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="UnitsOnOrder", Storage="_UnitsOnOrder", DbType="SmallInt")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=8)] 

	public System.Nullable<short> UnitsOnOrder
	{
		get
		{
			return this._UnitsOnOrder;
		}
		set
		{
			if ((this._UnitsOnOrder != value))
 			{
				this.OnUnitsOnOrderChanging(value);
				this.SendPropertyChanging();
				this._UnitsOnOrder = value;
				this.SendPropertyChanged("UnitsOnOrder");
				this.OnUnitsOnOrderChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="ReorderLevel", Storage="_ReorderLevel", DbType="SmallInt")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=9)] 

	public System.Nullable<short> ReorderLevel
	{
		get
		{
			return this._ReorderLevel;
		}
		set
		{
			if ((this._ReorderLevel != value))
 			{
				this.OnReorderLevelChanging(value);
				this.SendPropertyChanging();
				this._ReorderLevel = value;
				this.SendPropertyChanged("ReorderLevel");
				this.OnReorderLevelChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="Discontinued", Storage="_Discontinued", DbType="bit")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=10)] 

	public bool Discontinued
	{
		get
		{
			return this._Discontinued;
		}
		set
		{
			if ((this._Discontinued != value))
 			{
				this.OnDiscontinuedChanging(value);
				this.SendPropertyChanging();
				this._Discontinued = value;
				this.SendPropertyChanged("Discontinued");
				this.OnDiscontinuedChanged();
			}
		}
	}
[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Products_Order_Details", Storage="_Order_Details", ThisKey="ProductID", OtherKey="ProductID")]
[global::System.Runtime.Serialization.DataMemberAttribute(Order=11, EmitDefaultValue=false)]

 	public EntitySet<Order_Detail> Order_Details
	{
		get
		{
			if ((this.serializing 
						&& (this._Order_Details.HasLoadedOrAssignedValues == false)))
			{
				return null;
			}
			return this._Order_Details;
		}
		set
		{
			this._Order_Details.Assign(value);
		}
	}
[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Products_Suppliers", Storage="_Supplier", ThisKey="SupplierID", OtherKey="SupplierID")]
[global::System.Runtime.Serialization.DataMemberAttribute(Order=12, EmitDefaultValue=false)]

 public Supplier Supplier
 {
	get
	{
		return this._Supplier.Entity;
	}
	set
	{
		Supplier previousValue = this._Supplier.Entity;
		if (((previousValue != value) 
					|| (this._Supplier.HasLoadedOrAssignedValue == false)))
		{
			this.SendPropertyChanging();
			if ((previousValue != null))
			{
				this._Supplier.Entity = null;
				previousValue.Products.Remove(this);
			}
			this._Supplier.Entity = value;
			if ((value != null))
			{
				value.Products.Add(this);
				this._SupplierID = value.SupplierID;
			}
              else
			{
				this._SupplierID = default(System.Nullable<int>);
			}
			this.SendPropertyChanged("Supplier");
		 }
 	}
 }
[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Products_Categories", Storage="_Category", ThisKey="CategoryID", OtherKey="CategoryID")]
[global::System.Runtime.Serialization.DataMemberAttribute(Order=12, EmitDefaultValue=false)]

 public Category Category
 {
	get
	{
		return this._Category.Entity;
	}
	set
	{
		Category previousValue = this._Category.Entity;
		if (((previousValue != value) 
					|| (this._Category.HasLoadedOrAssignedValue == false)))
		{
			this.SendPropertyChanging();
			if ((previousValue != null))
			{
				this._Category.Entity = null;
				previousValue.Products.Remove(this);
			}
			this._Category.Entity = value;
			if ((value != null))
			{
				value.Products.Add(this);
				this._CategoryID = value.CategoryID;
			}
              else
			{
				this._CategoryID = default(System.Nullable<int>);
			}
			this.SendPropertyChanged("Category");
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
	private void attach_Order_Details(Order_Detail entity)
	{
		this.SendPropertyChanging();
	entity.Product = this;
	}

	private void detach_Order_Details(Order_Detail entity)
	{
		this.SendPropertyChanging();
		entity.Product = null;
	}
	private void Initialize()
	{
		this._Order_Details = new EntitySet<Order_Detail>(new Action<Order_Detail>(this.attach_Order_Details), new Action<Order_Detail>(this.detach_Order_Details));
    this._Supplier = default(EntityRef<Supplier>);
    this._Category = default(EntityRef<Category>);
		OnCreated();
	}
	[global::System.Runtime.Serialization.OnDeserializingAttribute()]
	[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
	public void OnDeserializing(StreamingContext context)
	{
		this.Initialize();
	}
	[global::System.Runtime.Serialization.OnSerializingAttribute()]
	[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
	public void OnSerializing(StreamingContext context)
	{
		this.serializing = true;
	}
	[global::System.Runtime.Serialization.OnSerializedAttribute()]
	[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
	public void OnSerialized(StreamingContext context)
	{
		this.serializing = false;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="Shippers")]
[global::System.Runtime.Serialization.DataContractAttribute()]
public partial class Shipper   : INotifyPropertyChanging, INotifyPropertyChanged
 {
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
    private System.Nullable<int> _ShipperID;
    private string _CompanyName;
    private string _Phone;
	private EntitySet<Order> _Orders;
	  private bool serializing;
   #region Extensibility Method Definitions
   partial void OnLoaded();
   partial void OnValidate(System.Data.Linq.ChangeAction action);
   partial void OnCreated();
    partial void OnShipperIDChanging(System.Nullable<int> Value);
    partial void OnShipperIDChanged();
    partial void OnCompanyNameChanging(string Value);
    partial void OnCompanyNameChanged();
    partial void OnPhoneChanging(string Value);
    partial void OnPhoneChanged();
   #endregion
       public Shipper()
	{
		this.Initialize();
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="ShipperID", Storage="_ShipperID", DbType="Int NOT NULL IDENTITY",IsPrimaryKey=true, IsDbGenerated=true)]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=1)] 

	public System.Nullable<int> ShipperID
	{
		get
		{
			return this._ShipperID;
		}
		set
		{
			if ((this._ShipperID != value))
 			{
				this.OnShipperIDChanging(value);
				this.SendPropertyChanging();
				this._ShipperID = value;
				this.SendPropertyChanged("ShipperID");
				this.OnShipperIDChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="CompanyName", Storage="_CompanyName", DbType="NVarChar(40) NOT NULL ",CanBeNull=false)]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=2)] 

	public string CompanyName
	{
		get
		{
			return this._CompanyName;
		}
		set
		{
			if ((this._CompanyName != value))
 			{
				this.OnCompanyNameChanging(value);
				this.SendPropertyChanging();
				this._CompanyName = value;
				this.SendPropertyChanged("CompanyName");
				this.OnCompanyNameChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="Phone", Storage="_Phone", DbType="NVarChar(24)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=3)] 

	public string Phone
	{
		get
		{
			return this._Phone;
		}
		set
		{
			if ((this._Phone != value))
 			{
				this.OnPhoneChanging(value);
				this.SendPropertyChanging();
				this._Phone = value;
				this.SendPropertyChanged("Phone");
				this.OnPhoneChanged();
			}
		}
	}
[global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Shippers_Orders", Storage = "_Orders", ThisKey = "ShipperID", OtherKey = "ShipVia")]
[global::System.Runtime.Serialization.DataMemberAttribute(Order=4, EmitDefaultValue=false)]

 	public EntitySet<Order> Orders
	{
		get
		{
			if ((this.serializing 
						&& (this._Orders.HasLoadedOrAssignedValues == false)))
			{
				return null;
			}
			return this._Orders;
		}
		set
		{
			this._Orders.Assign(value);
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
	private void attach_Orders(Order entity)
	{
		this.SendPropertyChanging();
	entity.Shipper = this;
	}

	private void detach_Orders(Order entity)
	{
		this.SendPropertyChanging();
		entity.Shipper = null;
	}
	private void Initialize()
	{
		this._Orders = new EntitySet<Order>(new Action<Order>(this.attach_Orders), new Action<Order>(this.detach_Orders));
		OnCreated();
	}
	[global::System.Runtime.Serialization.OnDeserializingAttribute()]
	[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
	public void OnDeserializing(StreamingContext context)
	{
		this.Initialize();
	}
	[global::System.Runtime.Serialization.OnSerializingAttribute()]
	[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
	public void OnSerializing(StreamingContext context)
	{
		this.serializing = true;
	}
	[global::System.Runtime.Serialization.OnSerializedAttribute()]
	[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
	public void OnSerialized(StreamingContext context)
	{
		this.serializing = false;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="Suppliers")]
[global::System.Runtime.Serialization.DataContractAttribute()]
public partial class Supplier   : INotifyPropertyChanging, INotifyPropertyChanged
 {
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
    private System.Nullable<int> _SupplierID;
    private string _CompanyName;
    private string _ContactName;
    private string _ContactTitle;
    private string _Address;
    private string _City;
    private string _Region;
    private string _PostalCode;
    private string _Country;
    private string _Phone;
    private string _Fax;
    private string _HomePage;
	private EntitySet<Product> _Products;
	  private bool serializing;
   #region Extensibility Method Definitions
   partial void OnLoaded();
   partial void OnValidate(System.Data.Linq.ChangeAction action);
   partial void OnCreated();
    partial void OnSupplierIDChanging(System.Nullable<int> Value);
    partial void OnSupplierIDChanged();
    partial void OnCompanyNameChanging(string Value);
    partial void OnCompanyNameChanged();
    partial void OnContactNameChanging(string Value);
    partial void OnContactNameChanged();
    partial void OnContactTitleChanging(string Value);
    partial void OnContactTitleChanged();
    partial void OnAddressChanging(string Value);
    partial void OnAddressChanged();
    partial void OnCityChanging(string Value);
    partial void OnCityChanged();
    partial void OnRegionChanging(string Value);
    partial void OnRegionChanged();
    partial void OnPostalCodeChanging(string Value);
    partial void OnPostalCodeChanged();
    partial void OnCountryChanging(string Value);
    partial void OnCountryChanged();
    partial void OnPhoneChanging(string Value);
    partial void OnPhoneChanged();
    partial void OnFaxChanging(string Value);
    partial void OnFaxChanged();
    partial void OnHomePageChanging(string Value);
    partial void OnHomePageChanged();
   #endregion
       public Supplier()
	{
		this.Initialize();
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="SupplierID", Storage="_SupplierID", DbType="Int NOT NULL IDENTITY",IsPrimaryKey=true, IsDbGenerated=true)]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=1)] 

	public System.Nullable<int> SupplierID
	{
		get
		{
			return this._SupplierID;
		}
		set
		{
			if ((this._SupplierID != value))
 			{
				this.OnSupplierIDChanging(value);
				this.SendPropertyChanging();
				this._SupplierID = value;
				this.SendPropertyChanged("SupplierID");
				this.OnSupplierIDChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="CompanyName", Storage="_CompanyName", DbType="NVarChar(40) NOT NULL ",CanBeNull=false)]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=2)] 

	public string CompanyName
	{
		get
		{
			return this._CompanyName;
		}
		set
		{
			if ((this._CompanyName != value))
 			{
				this.OnCompanyNameChanging(value);
				this.SendPropertyChanging();
				this._CompanyName = value;
				this.SendPropertyChanged("CompanyName");
				this.OnCompanyNameChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="ContactName", Storage="_ContactName", DbType="NVarChar(30)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=3)] 

	public string ContactName
	{
		get
		{
			return this._ContactName;
		}
		set
		{
			if ((this._ContactName != value))
 			{
				this.OnContactNameChanging(value);
				this.SendPropertyChanging();
				this._ContactName = value;
				this.SendPropertyChanged("ContactName");
				this.OnContactNameChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="ContactTitle", Storage="_ContactTitle", DbType="NVarChar(30)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=4)] 

	public string ContactTitle
	{
		get
		{
			return this._ContactTitle;
		}
		set
		{
			if ((this._ContactTitle != value))
 			{
				this.OnContactTitleChanging(value);
				this.SendPropertyChanging();
				this._ContactTitle = value;
				this.SendPropertyChanged("ContactTitle");
				this.OnContactTitleChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="Address", Storage="_Address", DbType="NVarChar(60)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=5)] 

	public string Address
	{
		get
		{
			return this._Address;
		}
		set
		{
			if ((this._Address != value))
 			{
				this.OnAddressChanging(value);
				this.SendPropertyChanging();
				this._Address = value;
				this.SendPropertyChanged("Address");
				this.OnAddressChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="City", Storage="_City", DbType="NVarChar(15)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=6)] 

	public string City
	{
		get
		{
			return this._City;
		}
		set
		{
			if ((this._City != value))
 			{
				this.OnCityChanging(value);
				this.SendPropertyChanging();
				this._City = value;
				this.SendPropertyChanged("City");
				this.OnCityChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="Region", Storage="_Region", DbType="NVarChar(15)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=7)] 

	public string Region
	{
		get
		{
			return this._Region;
		}
		set
		{
			if ((this._Region != value))
 			{
				this.OnRegionChanging(value);
				this.SendPropertyChanging();
				this._Region = value;
				this.SendPropertyChanged("Region");
				this.OnRegionChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="PostalCode", Storage="_PostalCode", DbType="NVarChar(10)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=8)] 

	public string PostalCode
	{
		get
		{
			return this._PostalCode;
		}
		set
		{
			if ((this._PostalCode != value))
 			{
				this.OnPostalCodeChanging(value);
				this.SendPropertyChanging();
				this._PostalCode = value;
				this.SendPropertyChanged("PostalCode");
				this.OnPostalCodeChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="Country", Storage="_Country", DbType="NVarChar(15)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=9)] 

	public string Country
	{
		get
		{
			return this._Country;
		}
		set
		{
			if ((this._Country != value))
 			{
				this.OnCountryChanging(value);
				this.SendPropertyChanging();
				this._Country = value;
				this.SendPropertyChanged("Country");
				this.OnCountryChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="Phone", Storage="_Phone", DbType="NVarChar(24)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=10)] 

	public string Phone
	{
		get
		{
			return this._Phone;
		}
		set
		{
			if ((this._Phone != value))
 			{
				this.OnPhoneChanging(value);
				this.SendPropertyChanging();
				this._Phone = value;
				this.SendPropertyChanged("Phone");
				this.OnPhoneChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="Fax", Storage="_Fax", DbType="NVarChar(24)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=11)] 

	public string Fax
	{
		get
		{
			return this._Fax;
		}
		set
		{
			if ((this._Fax != value))
 			{
				this.OnFaxChanging(value);
				this.SendPropertyChanging();
				this._Fax = value;
				this.SendPropertyChanged("Fax");
				this.OnFaxChanged();
			}
		}
	}
 [global::System.Data.Linq.Mapping.ColumnAttribute(Name="HomePage", Storage="_HomePage", DbType="NVarChar(0)")]
 [global::System.Runtime.Serialization.DataMemberAttribute(Order=12)] 

	public string HomePage
	{
		get
		{
			return this._HomePage;
		}
		set
		{
			if ((this._HomePage != value))
 			{
				this.OnHomePageChanging(value);
				this.SendPropertyChanging();
				this._HomePage = value;
				this.SendPropertyChanged("HomePage");
				this.OnHomePageChanged();
			}
		}
	}
[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Suppliers_Products", Storage="_Products", ThisKey="SupplierID", OtherKey="SupplierID")]
[global::System.Runtime.Serialization.DataMemberAttribute(Order=13, EmitDefaultValue=false)]

 	public EntitySet<Product> Products
	{
		get
		{
			if ((this.serializing 
						&& (this._Products.HasLoadedOrAssignedValues == false)))
			{
				return null;
			}
			return this._Products;
		}
		set
		{
			this._Products.Assign(value);
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
	private void attach_Products(Product entity)
	{
		this.SendPropertyChanging();
	entity.Supplier = this;
	}

	private void detach_Products(Product entity)
	{
		this.SendPropertyChanging();
		entity.Supplier = null;
	}
	private void Initialize()
	{
		this._Products = new EntitySet<Product>(new Action<Product>(this.attach_Products), new Action<Product>(this.detach_Products));
		OnCreated();
	}
	[global::System.Runtime.Serialization.OnDeserializingAttribute()]
	[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
	public void OnDeserializing(StreamingContext context)
	{
		this.Initialize();
	}
	[global::System.Runtime.Serialization.OnSerializingAttribute()]
	[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
	public void OnSerializing(StreamingContext context)
	{
		this.serializing = true;
	}
	[global::System.Runtime.Serialization.OnSerializedAttribute()]
	[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
	public void OnSerialized(StreamingContext context)
	{
		this.serializing = false;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name = "Order Details Extended")]
[global::System.Runtime.Serialization.DataContractAttribute()]
public partial class OrderDetail : INotifyPropertyChanging, INotifyPropertyChanged
{
    private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
    private System.Nullable<float> _Discount;
    private System.Nullable<decimal> _ExtendedPrice;
    private System.Nullable<int> _OrderID;
    private System.Nullable<int> _ProductID;
    private string _ProductName;
    private System.Nullable<short> _Quantity;
    private System.Nullable<decimal> _UnitPrice;
    private bool serializing;
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDiscountChanging(System.Nullable<float> Value);
    partial void OnDiscountChanged();
    partial void OnExtendedPriceChanging(System.Nullable<decimal> Value);
    partial void OnExtendedPriceChanged();
    partial void OnOrderIDChanging(System.Nullable<int> Value);
    partial void OnOrderIDChanged();
    partial void OnProductIDChanging(System.Nullable<int> Value);
    partial void OnProductIDChanged();
    partial void OnProductNameChanging(string Value);
    partial void OnProductNameChanged();
    partial void OnQuantityChanging(System.Nullable<short> Value);
    partial void OnQuantityChanged();
    partial void OnUnitPriceChanging(System.Nullable<decimal> Value);
    partial void OnUnitPriceChanged();
    #endregion
    public OrderDetail()
    {
        this.Initialize();
    }
    [global::System.Data.Linq.Mapping.ColumnAttribute(Name = "Discount", Storage = "_Discount", DbType = "Real")]
    [global::System.Runtime.Serialization.DataMemberAttribute(Order = 1)]

    public System.Nullable<float> Discount
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
    [global::System.Data.Linq.Mapping.ColumnAttribute(Name = "ExtendedPrice", Storage = "_ExtendedPrice", DbType = "Money")]
    [global::System.Runtime.Serialization.DataMemberAttribute(Order = 2)]

    public System.Nullable<decimal> ExtendedPrice
    {
        get
        {
            return this._ExtendedPrice;
        }
        set
        {
            if ((this._ExtendedPrice != value))
            {
                this.OnExtendedPriceChanging(value);
                this.SendPropertyChanging();
                this._ExtendedPrice = value;
                this.SendPropertyChanged("ExtendedPrice");
                this.OnExtendedPriceChanged();
            }
        }
    }
    [global::System.Data.Linq.Mapping.ColumnAttribute(Name = "OrderID", Storage = "_OrderID", DbType = "Int")]
    [global::System.Runtime.Serialization.DataMemberAttribute(Order = 3)]

    public System.Nullable<int> OrderID
    {
        get
        {
            return this._OrderID;
        }
        set
        {
            if ((this._OrderID != value))
            {
                this.OnOrderIDChanging(value);
                this.SendPropertyChanging();
                this._OrderID = value;
                this.SendPropertyChanged("OrderID");
                this.OnOrderIDChanged();
            }
        }
    }
    [global::System.Data.Linq.Mapping.ColumnAttribute(Name = "ProductID", Storage = "_ProductID", DbType = "Int")]
    [global::System.Runtime.Serialization.DataMemberAttribute(Order = 4)]

    public System.Nullable<int> ProductID
    {
        get
        {
            return this._ProductID;
        }
        set
        {
            if ((this._ProductID != value))
            {
                this.OnProductIDChanging(value);
                this.SendPropertyChanging();
                this._ProductID = value;
                this.SendPropertyChanged("ProductID");
                this.OnProductIDChanged();
            }
        }
    }
    [global::System.Data.Linq.Mapping.ColumnAttribute(Name = "ProductName", Storage = "_ProductName", DbType = "NVarChar(40)")]
    [global::System.Runtime.Serialization.DataMemberAttribute(Order = 5)]

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
    [global::System.Data.Linq.Mapping.ColumnAttribute(Name = "Quantity", Storage = "_Quantity", DbType = "SmallInt")]
    [global::System.Runtime.Serialization.DataMemberAttribute(Order = 6)]

    public System.Nullable<short> Quantity
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
    [global::System.Data.Linq.Mapping.ColumnAttribute(Name = "UnitPrice", Storage = "_UnitPrice", DbType = "Money")]
    [global::System.Runtime.Serialization.DataMemberAttribute(Order = 7)]

    public System.Nullable<decimal> UnitPrice
    {
        get
        {
            return this._UnitPrice;
        }
        set
        {
            if ((this._UnitPrice != value))
            {
                this.OnUnitPriceChanging(value);
                this.SendPropertyChanging();
                this._UnitPrice = value;
                this.SendPropertyChanged("UnitPrice");
                this.OnUnitPriceChanged();
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
    private void Initialize()
    {
        OnCreated();
    }
    [global::System.Runtime.Serialization.OnDeserializingAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
    public void OnDeserializing(StreamingContext context)
    {
        this.Initialize();
    }
    [global::System.Runtime.Serialization.OnSerializingAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
    public void OnSerializing(StreamingContext context)
    {
        this.serializing = true;
    }
    [global::System.Runtime.Serialization.OnSerializedAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
    public void OnSerialized(StreamingContext context)
    {
        this.serializing = false;
    }
}
}
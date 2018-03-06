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

namespace QuickCanteen
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuickCanteenDB")]
	public partial class QuickCanteenDBMLDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertadmin_master(admin_master instance);
    partial void Updateadmin_master(admin_master instance);
    partial void Deleteadmin_master(admin_master instance);
    partial void Insertcanteen_master(canteen_master instance);
    partial void Updatecanteen_master(canteen_master instance);
    partial void Deletecanteen_master(canteen_master instance);
    partial void Insertfood_master(food_master instance);
    partial void Updatefood_master(food_master instance);
    partial void Deletefood_master(food_master instance);
    partial void Insertmenu_master(menu_master instance);
    partial void Updatemenu_master(menu_master instance);
    partial void Deletemenu_master(menu_master instance);
    partial void Insertorder_header(order_header instance);
    partial void Updateorder_header(order_header instance);
    partial void Deleteorder_header(order_header instance);
    partial void Insertstudent_master(student_master instance);
    partial void Updatestudent_master(student_master instance);
    partial void Deletestudent_master(student_master instance);
    #endregion
		
		public QuickCanteenDBMLDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SQLDS1ConStr"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QuickCanteenDBMLDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuickCanteenDBMLDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuickCanteenDBMLDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuickCanteenDBMLDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<admin_master> admin_masters
		{
			get
			{
				return this.GetTable<admin_master>();
			}
		}
		
		public System.Data.Linq.Table<canteen_master> canteen_masters
		{
			get
			{
				return this.GetTable<canteen_master>();
			}
		}
		
		public System.Data.Linq.Table<canteen_notification_master> canteen_notification_masters
		{
			get
			{
				return this.GetTable<canteen_notification_master>();
			}
		}
		
		public System.Data.Linq.Table<food_master> food_masters
		{
			get
			{
				return this.GetTable<food_master>();
			}
		}
		
		public System.Data.Linq.Table<menu_master> menu_masters
		{
			get
			{
				return this.GetTable<menu_master>();
			}
		}
		
		public System.Data.Linq.Table<order_header> order_headers
		{
			get
			{
				return this.GetTable<order_header>();
			}
		}
		
		public System.Data.Linq.Table<order_detail> order_details
		{
			get
			{
				return this.GetTable<order_detail>();
			}
		}
		
		public System.Data.Linq.Table<student_master> student_masters
		{
			get
			{
				return this.GetTable<student_master>();
			}
		}
		
		public System.Data.Linq.Table<student_notification_master> student_notification_masters
		{
			get
			{
				return this.GetTable<student_notification_master>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.admin_master")]
	public partial class admin_master : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _admin_id;
		
		private string _pass;
		
		private string _uname;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onadmin_idChanging(int value);
    partial void Onadmin_idChanged();
    partial void OnpassChanging(string value);
    partial void OnpassChanged();
    partial void OnunameChanging(string value);
    partial void OnunameChanged();
    #endregion
		
		public admin_master()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_admin_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int admin_id
		{
			get
			{
				return this._admin_id;
			}
			set
			{
				if ((this._admin_id != value))
				{
					this.Onadmin_idChanging(value);
					this.SendPropertyChanging();
					this._admin_id = value;
					this.SendPropertyChanged("admin_id");
					this.Onadmin_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pass", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string pass
		{
			get
			{
				return this._pass;
			}
			set
			{
				if ((this._pass != value))
				{
					this.OnpassChanging(value);
					this.SendPropertyChanging();
					this._pass = value;
					this.SendPropertyChanged("pass");
					this.OnpassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uname", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string uname
		{
			get
			{
				return this._uname;
			}
			set
			{
				if ((this._uname != value))
				{
					this.OnunameChanging(value);
					this.SendPropertyChanging();
					this._uname = value;
					this.SendPropertyChanged("uname");
					this.OnunameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.canteen_master")]
	public partial class canteen_master : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _canteen_id;
		
		private System.Nullable<long> _wallet;
		
		private System.TimeSpan _open_time;
		
		private System.TimeSpan _close_time;
		
		private System.Nullable<decimal> _rating;
		
		private System.Nullable<int> _order_limit;
		
		private long _ph_no;
		
		private string _uname;
		
		private string _pass;
		
		private string _email;
		
		private string _canteen_name;
		
		private System.Nullable<long> _feedback_count;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncanteen_idChanging(int value);
    partial void Oncanteen_idChanged();
    partial void OnwalletChanging(System.Nullable<long> value);
    partial void OnwalletChanged();
    partial void Onopen_timeChanging(System.TimeSpan value);
    partial void Onopen_timeChanged();
    partial void Onclose_timeChanging(System.TimeSpan value);
    partial void Onclose_timeChanged();
    partial void OnratingChanging(System.Nullable<decimal> value);
    partial void OnratingChanged();
    partial void Onorder_limitChanging(System.Nullable<int> value);
    partial void Onorder_limitChanged();
    partial void Onph_noChanging(long value);
    partial void Onph_noChanged();
    partial void OnunameChanging(string value);
    partial void OnunameChanged();
    partial void OnpassChanging(string value);
    partial void OnpassChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void Oncanteen_nameChanging(string value);
    partial void Oncanteen_nameChanged();
    partial void Onfeedback_countChanging(System.Nullable<long> value);
    partial void Onfeedback_countChanged();
    #endregion
		
		public canteen_master()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_canteen_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int canteen_id
		{
			get
			{
				return this._canteen_id;
			}
			set
			{
				if ((this._canteen_id != value))
				{
					this.Oncanteen_idChanging(value);
					this.SendPropertyChanging();
					this._canteen_id = value;
					this.SendPropertyChanged("canteen_id");
					this.Oncanteen_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_wallet", DbType="BigInt")]
		public System.Nullable<long> wallet
		{
			get
			{
				return this._wallet;
			}
			set
			{
				if ((this._wallet != value))
				{
					this.OnwalletChanging(value);
					this.SendPropertyChanging();
					this._wallet = value;
					this.SendPropertyChanged("wallet");
					this.OnwalletChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_open_time", DbType="Time NOT NULL")]
		public System.TimeSpan open_time
		{
			get
			{
				return this._open_time;
			}
			set
			{
				if ((this._open_time != value))
				{
					this.Onopen_timeChanging(value);
					this.SendPropertyChanging();
					this._open_time = value;
					this.SendPropertyChanged("open_time");
					this.Onopen_timeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_close_time", DbType="Time NOT NULL")]
		public System.TimeSpan close_time
		{
			get
			{
				return this._close_time;
			}
			set
			{
				if ((this._close_time != value))
				{
					this.Onclose_timeChanging(value);
					this.SendPropertyChanging();
					this._close_time = value;
					this.SendPropertyChanged("close_time");
					this.Onclose_timeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rating", DbType="Decimal(5,1)")]
		public System.Nullable<decimal> rating
		{
			get
			{
				return this._rating;
			}
			set
			{
				if ((this._rating != value))
				{
					this.OnratingChanging(value);
					this.SendPropertyChanging();
					this._rating = value;
					this.SendPropertyChanged("rating");
					this.OnratingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_order_limit", DbType="Int")]
		public System.Nullable<int> order_limit
		{
			get
			{
				return this._order_limit;
			}
			set
			{
				if ((this._order_limit != value))
				{
					this.Onorder_limitChanging(value);
					this.SendPropertyChanging();
					this._order_limit = value;
					this.SendPropertyChanged("order_limit");
					this.Onorder_limitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ph_no", DbType="BigInt NOT NULL")]
		public long ph_no
		{
			get
			{
				return this._ph_no;
			}
			set
			{
				if ((this._ph_no != value))
				{
					this.Onph_noChanging(value);
					this.SendPropertyChanging();
					this._ph_no = value;
					this.SendPropertyChanged("ph_no");
					this.Onph_noChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uname", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string uname
		{
			get
			{
				return this._uname;
			}
			set
			{
				if ((this._uname != value))
				{
					this.OnunameChanging(value);
					this.SendPropertyChanging();
					this._uname = value;
					this.SendPropertyChanged("uname");
					this.OnunameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pass", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string pass
		{
			get
			{
				return this._pass;
			}
			set
			{
				if ((this._pass != value))
				{
					this.OnpassChanging(value);
					this.SendPropertyChanging();
					this._pass = value;
					this.SendPropertyChanged("pass");
					this.OnpassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_canteen_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string canteen_name
		{
			get
			{
				return this._canteen_name;
			}
			set
			{
				if ((this._canteen_name != value))
				{
					this.Oncanteen_nameChanging(value);
					this.SendPropertyChanging();
					this._canteen_name = value;
					this.SendPropertyChanged("canteen_name");
					this.Oncanteen_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_feedback_count", DbType="BigInt")]
		public System.Nullable<long> feedback_count
		{
			get
			{
				return this._feedback_count;
			}
			set
			{
				if ((this._feedback_count != value))
				{
					this.Onfeedback_countChanging(value);
					this.SendPropertyChanging();
					this._feedback_count = value;
					this.SendPropertyChanged("feedback_count");
					this.Onfeedback_countChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.canteen_notification_master")]
	public partial class canteen_notification_master
	{
		
		private string _canteen_id;
		
		private System.Nullable<System.DateTime> _not_date;
		
		private string _message;
		
		public canteen_notification_master()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_canteen_id", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string canteen_id
		{
			get
			{
				return this._canteen_id;
			}
			set
			{
				if ((this._canteen_id != value))
				{
					this._canteen_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_not_date", DbType="DateTime")]
		public System.Nullable<System.DateTime> not_date
		{
			get
			{
				return this._not_date;
			}
			set
			{
				if ((this._not_date != value))
				{
					this._not_date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_message", DbType="NVarChar(50)")]
		public string message
		{
			get
			{
				return this._message;
			}
			set
			{
				if ((this._message != value))
				{
					this._message = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.food_master")]
	public partial class food_master : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _food_item_id;
		
		private string _name;
		
		private EntitySet<menu_master> _menu_masters;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onfood_item_idChanging(int value);
    partial void Onfood_item_idChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public food_master()
		{
			this._menu_masters = new EntitySet<menu_master>(new Action<menu_master>(this.attach_menu_masters), new Action<menu_master>(this.detach_menu_masters));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_food_item_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int food_item_id
		{
			get
			{
				return this._food_item_id;
			}
			set
			{
				if ((this._food_item_id != value))
				{
					this.Onfood_item_idChanging(value);
					this.SendPropertyChanging();
					this._food_item_id = value;
					this.SendPropertyChanged("food_item_id");
					this.Onfood_item_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="food_master_menu_master", Storage="_menu_masters", ThisKey="food_item_id", OtherKey="food_item_id")]
		public EntitySet<menu_master> menu_masters
		{
			get
			{
				return this._menu_masters;
			}
			set
			{
				this._menu_masters.Assign(value);
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
		
		private void attach_menu_masters(menu_master entity)
		{
			this.SendPropertyChanging();
			entity.food_master = this;
		}
		
		private void detach_menu_masters(menu_master entity)
		{
			this.SendPropertyChanging();
			entity.food_master = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.menu_master")]
	public partial class menu_master : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _canteen_id;
		
		private int _food_item_id;
		
		private System.Nullable<int> _qty;
		
		private System.Nullable<int> _rate;
		
		private EntityRef<food_master> _food_master;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncanteen_idChanging(int value);
    partial void Oncanteen_idChanged();
    partial void Onfood_item_idChanging(int value);
    partial void Onfood_item_idChanged();
    partial void OnqtyChanging(System.Nullable<int> value);
    partial void OnqtyChanged();
    partial void OnrateChanging(System.Nullable<int> value);
    partial void OnrateChanged();
    #endregion
		
		public menu_master()
		{
			this._food_master = default(EntityRef<food_master>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_canteen_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int canteen_id
		{
			get
			{
				return this._canteen_id;
			}
			set
			{
				if ((this._canteen_id != value))
				{
					this.Oncanteen_idChanging(value);
					this.SendPropertyChanging();
					this._canteen_id = value;
					this.SendPropertyChanged("canteen_id");
					this.Oncanteen_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_food_item_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int food_item_id
		{
			get
			{
				return this._food_item_id;
			}
			set
			{
				if ((this._food_item_id != value))
				{
					if (this._food_master.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onfood_item_idChanging(value);
					this.SendPropertyChanging();
					this._food_item_id = value;
					this.SendPropertyChanged("food_item_id");
					this.Onfood_item_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_qty", DbType="Int")]
		public System.Nullable<int> qty
		{
			get
			{
				return this._qty;
			}
			set
			{
				if ((this._qty != value))
				{
					this.OnqtyChanging(value);
					this.SendPropertyChanging();
					this._qty = value;
					this.SendPropertyChanged("qty");
					this.OnqtyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rate", DbType="Int")]
		public System.Nullable<int> rate
		{
			get
			{
				return this._rate;
			}
			set
			{
				if ((this._rate != value))
				{
					this.OnrateChanging(value);
					this.SendPropertyChanging();
					this._rate = value;
					this.SendPropertyChanged("rate");
					this.OnrateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="food_master_menu_master", Storage="_food_master", ThisKey="food_item_id", OtherKey="food_item_id", IsForeignKey=true)]
		public food_master food_master
		{
			get
			{
				return this._food_master.Entity;
			}
			set
			{
				food_master previousValue = this._food_master.Entity;
				if (((previousValue != value) 
							|| (this._food_master.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._food_master.Entity = null;
						previousValue.menu_masters.Remove(this);
					}
					this._food_master.Entity = value;
					if ((value != null))
					{
						value.menu_masters.Add(this);
						this._food_item_id = value.food_item_id;
					}
					else
					{
						this._food_item_id = default(int);
					}
					this.SendPropertyChanged("food_master");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.order_header")]
	public partial class order_header : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _order_id;
		
		private int _stu_id;
		
		private int _canteen_id;
		
		private System.Nullable<System.DateTime> _order_date;
		
		private decimal _amount;
		
		private string _status;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onorder_idChanging(int value);
    partial void Onorder_idChanged();
    partial void Onstu_idChanging(int value);
    partial void Onstu_idChanged();
    partial void Oncanteen_idChanging(int value);
    partial void Oncanteen_idChanged();
    partial void Onorder_dateChanging(System.Nullable<System.DateTime> value);
    partial void Onorder_dateChanged();
    partial void OnamountChanging(decimal value);
    partial void OnamountChanged();
    partial void OnstatusChanging(string value);
    partial void OnstatusChanged();
    #endregion
		
		public order_header()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_order_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int order_id
		{
			get
			{
				return this._order_id;
			}
			set
			{
				if ((this._order_id != value))
				{
					this.Onorder_idChanging(value);
					this.SendPropertyChanging();
					this._order_id = value;
					this.SendPropertyChanged("order_id");
					this.Onorder_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stu_id", DbType="Int NOT NULL")]
		public int stu_id
		{
			get
			{
				return this._stu_id;
			}
			set
			{
				if ((this._stu_id != value))
				{
					this.Onstu_idChanging(value);
					this.SendPropertyChanging();
					this._stu_id = value;
					this.SendPropertyChanged("stu_id");
					this.Onstu_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_canteen_id", DbType="Int NOT NULL")]
		public int canteen_id
		{
			get
			{
				return this._canteen_id;
			}
			set
			{
				if ((this._canteen_id != value))
				{
					this.Oncanteen_idChanging(value);
					this.SendPropertyChanging();
					this._canteen_id = value;
					this.SendPropertyChanged("canteen_id");
					this.Oncanteen_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_order_date", DbType="DateTime")]
		public System.Nullable<System.DateTime> order_date
		{
			get
			{
				return this._order_date;
			}
			set
			{
				if ((this._order_date != value))
				{
					this.Onorder_dateChanging(value);
					this.SendPropertyChanging();
					this._order_date = value;
					this.SendPropertyChanged("order_date");
					this.Onorder_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_amount", DbType="Money NOT NULL")]
		public decimal amount
		{
			get
			{
				return this._amount;
			}
			set
			{
				if ((this._amount != value))
				{
					this.OnamountChanging(value);
					this.SendPropertyChanging();
					this._amount = value;
					this.SendPropertyChanged("amount");
					this.OnamountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.order_detail")]
	public partial class order_detail
	{
		
		private int _order_id;
		
		private int _food_item_id;
		
		private System.Nullable<int> _qty;
		
		private decimal _rate;
		
		public order_detail()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_order_id", DbType="Int NOT NULL")]
		public int order_id
		{
			get
			{
				return this._order_id;
			}
			set
			{
				if ((this._order_id != value))
				{
					this._order_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_food_item_id", DbType="Int NOT NULL")]
		public int food_item_id
		{
			get
			{
				return this._food_item_id;
			}
			set
			{
				if ((this._food_item_id != value))
				{
					this._food_item_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_qty", DbType="Int")]
		public System.Nullable<int> qty
		{
			get
			{
				return this._qty;
			}
			set
			{
				if ((this._qty != value))
				{
					this._qty = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rate", DbType="Decimal(18,2) NOT NULL")]
		public decimal rate
		{
			get
			{
				return this._rate;
			}
			set
			{
				if ((this._rate != value))
				{
					this._rate = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.student_master")]
	public partial class student_master : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private string _college;
		
		private string _uname;
		
		private string _pass;
		
		private System.Nullable<long> _wallet;
		
		private System.DateTime _bdate;
		
		private System.Nullable<long> _ph_no;
		
		private string _email;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OncollegeChanging(string value);
    partial void OncollegeChanged();
    partial void OnunameChanging(string value);
    partial void OnunameChanged();
    partial void OnpassChanging(string value);
    partial void OnpassChanged();
    partial void OnwalletChanging(System.Nullable<long> value);
    partial void OnwalletChanged();
    partial void OnbdateChanging(System.DateTime value);
    partial void OnbdateChanged();
    partial void Onph_noChanging(System.Nullable<long> value);
    partial void Onph_noChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    #endregion
		
		public student_master()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_college", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string college
		{
			get
			{
				return this._college;
			}
			set
			{
				if ((this._college != value))
				{
					this.OncollegeChanging(value);
					this.SendPropertyChanging();
					this._college = value;
					this.SendPropertyChanged("college");
					this.OncollegeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uname", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string uname
		{
			get
			{
				return this._uname;
			}
			set
			{
				if ((this._uname != value))
				{
					this.OnunameChanging(value);
					this.SendPropertyChanging();
					this._uname = value;
					this.SendPropertyChanged("uname");
					this.OnunameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pass", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string pass
		{
			get
			{
				return this._pass;
			}
			set
			{
				if ((this._pass != value))
				{
					this.OnpassChanging(value);
					this.SendPropertyChanging();
					this._pass = value;
					this.SendPropertyChanged("pass");
					this.OnpassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_wallet", DbType="BigInt")]
		public System.Nullable<long> wallet
		{
			get
			{
				return this._wallet;
			}
			set
			{
				if ((this._wallet != value))
				{
					this.OnwalletChanging(value);
					this.SendPropertyChanging();
					this._wallet = value;
					this.SendPropertyChanged("wallet");
					this.OnwalletChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bdate", DbType="Date NOT NULL")]
		public System.DateTime bdate
		{
			get
			{
				return this._bdate;
			}
			set
			{
				if ((this._bdate != value))
				{
					this.OnbdateChanging(value);
					this.SendPropertyChanging();
					this._bdate = value;
					this.SendPropertyChanged("bdate");
					this.OnbdateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ph_no", DbType="BigInt")]
		public System.Nullable<long> ph_no
		{
			get
			{
				return this._ph_no;
			}
			set
			{
				if ((this._ph_no != value))
				{
					this.Onph_noChanging(value);
					this.SendPropertyChanging();
					this._ph_no = value;
					this.SendPropertyChanged("ph_no");
					this.Onph_noChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.student_notification_master")]
	public partial class student_notification_master
	{
		
		private string _student_id;
		
		private System.DateTime _not_date;
		
		private string _message;
		
		public student_notification_master()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_student_id", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string student_id
		{
			get
			{
				return this._student_id;
			}
			set
			{
				if ((this._student_id != value))
				{
					this._student_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_not_date", DbType="DateTime NOT NULL")]
		public System.DateTime not_date
		{
			get
			{
				return this._not_date;
			}
			set
			{
				if ((this._not_date != value))
				{
					this._not_date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_message", DbType="NVarChar(50)")]
		public string message
		{
			get
			{
				return this._message;
			}
			set
			{
				if ((this._message != value))
				{
					this._message = value;
				}
			}
		}
	}
}
#pragma warning restore 1591


using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using System.Configuration;
using System.IO;
using System.ComponentModel;
using Csla.Validation;
namespace Northwind.CSLA.Library
{
	/// <summary>
	///	ShipperOrders Generated by MyGeneration using the CSLA Object Mapping template
	/// </summary>
	[Serializable()]
	[TypeConverter(typeof(ShipperOrdersConverter))]
	public partial class ShipperOrders : BusinessListBase<ShipperOrders, ShipperOrder>, ICustomTypeDescriptor, IVEHasBrokenRules
	{
		#region Business Methods
		private string _ErrorMessage = string.Empty;
		public string ErrorMessage
		{
			get { return _ErrorMessage; }
		}
		// One To Many
		public ShipperOrder this[Order myOrder]
		{
			get
			{
				foreach (ShipperOrder order in this)
					if (order.OrderID == myOrder.OrderID)
						return order;
				return null;
			}
		}
		public new System.Collections.Generic.IList<ShipperOrder> Items
		{
			get { return base.Items; }
		}
		public ShipperOrder GetItem(Order myOrder)
		{
			foreach (ShipperOrder order in this)
				if (order.OrderID == myOrder.OrderID)
					return order;
			return null;
		}
		public ShipperOrder Add() // One to Many 
		{
			 ShipperOrder order = ShipperOrder.New();
			 this.Add(order);
			 return order;
		}
		public void Remove(Order myOrder)
		{
			foreach (ShipperOrder order in this)
			{
				if (order.OrderID == myOrder.OrderID)
				{
					Remove(order);
					break;
				}
			}
		}
		public bool Contains(Order myOrder)
		{
			foreach (ShipperOrder order in this)
				if (order.OrderID == myOrder.OrderID)
					return true;
			return false;
		}
		public bool ContainsDeleted(Order myOrder)
		{
			foreach (ShipperOrder order in DeletedList)
				if (order.OrderID == myOrder.OrderID)
					return true;
			return false;
		}
		#endregion
		#region ValidationRules
		public IVEHasBrokenRules HasBrokenRules
		{
			get
			{
				IVEHasBrokenRules hasBrokenRules=null;
				foreach(ShipperOrder shipperOrder in this)
					if ((hasBrokenRules = shipperOrder.HasBrokenRules) != null) return hasBrokenRules;
				return hasBrokenRules;
			}
		}
		public BrokenRulesCollection BrokenRules
		{
			get
			{
			IVEHasBrokenRules hasBrokenRules = HasBrokenRules;
			return (hasBrokenRules != null ? hasBrokenRules.BrokenRules : null);
			}
		}
		#endregion
		#region Factory Methods
		internal static ShipperOrders New()
		{
			return new ShipperOrders();
		}
		internal static ShipperOrders Get(SafeDataReader dr)
		{
			return new ShipperOrders(dr);
		}
		public static ShipperOrders GetByShipVia(int? shipVia)
		{
			try
			{
				return DataPortal.Fetch<ShipperOrders>(new ShipViaCriteria(shipVia));
			}
			catch (Exception ex)
			{
				throw new DbCslaException("Error on ShipperOrders.GetByShipVia", ex);
			}
		}
		private ShipperOrders()
		{
			MarkAsChild();
		}
		internal ShipperOrders(SafeDataReader dr)
		{
			MarkAsChild();
			Fetch(dr);
		}
		#endregion
		#region Data Access Portal
		// called to load data from the database
		private void Fetch(SafeDataReader dr)
		{
			this.RaiseListChangedEvents = false;
			while (dr.Read())
				this.Add(ShipperOrder.Get(dr));
			this.RaiseListChangedEvents = true;
		}
		[Serializable()]
		private class ShipViaCriteria
		{
			public ShipViaCriteria(int? shipVia)
			{
				_ShipVia = shipVia;
			}
			private int? _ShipVia;
			public int? ShipVia
			{
				get { return _ShipVia; }
				set { _ShipVia = value; }
			}
		}
		private void DataPortal_Fetch(ShipViaCriteria criteria)
		{
			this.RaiseListChangedEvents = false;
			Database.LogInfo("ShipperOrders.DataPortal_FetchShipVia", GetHashCode());
			try
			{
				using (SqlConnection cn = Database.Northwind_SqlConnection)
				{
					using (SqlCommand cm = cn.CreateCommand())
					{
						cm.CommandType = CommandType.StoredProcedure;
						cm.CommandText = "getOrdersByShipVia";
						cm.Parameters.AddWithValue("@ShipVia", criteria.ShipVia);
						using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
						{
							while (dr.Read()) this.Add(new ShipperOrder(dr));
						}
					}
				}
			}
			catch (Exception ex)
			{
				Database.LogException("ShipperOrders.DataPortal_FetchShipVia", ex);
				throw new DbCslaException("ShipperOrders.DataPortal_Fetch", ex);
			}
			this.RaiseListChangedEvents = true;
		}
		internal void Update(Shipper shipper)
		{
			this.RaiseListChangedEvents = false;
			try
			{
				// update (thus deleting) any deleted child objects
				foreach (ShipperOrder obj in DeletedList)
					obj.Delete();// TODO: Should this be SQLDelete
				// now that they are deleted, remove them from memory too
				DeletedList.Clear();
				// add/update any current child objects
				foreach (ShipperOrder obj in this)
				{
					if (obj.IsNew)
						obj.Insert(shipper);
					else
						obj.Update(shipper);
				}
			}
			finally
			{
				this.RaiseListChangedEvents = true;
			}
		}
		#endregion
		#region ICustomTypeDescriptor impl
		public String GetClassName()
		{ return TypeDescriptor.GetClassName(this, true); }
		public AttributeCollection GetAttributes()
		{ return TypeDescriptor.GetAttributes(this, true); }
		public String GetComponentName()
		{ return TypeDescriptor.GetComponentName(this, true); }
		public TypeConverter GetConverter()
		{ return TypeDescriptor.GetConverter(this, true); }
		public EventDescriptor GetDefaultEvent()
		{ return TypeDescriptor.GetDefaultEvent(this, true); }
		public PropertyDescriptor GetDefaultProperty()
		{ return TypeDescriptor.GetDefaultProperty(this, true); }
		public object GetEditor(Type editorBaseType)
		{ return TypeDescriptor.GetEditor(this, editorBaseType, true); }
		public EventDescriptorCollection GetEvents(Attribute[] attributes)
		{ return TypeDescriptor.GetEvents(this, attributes, true); }
		public EventDescriptorCollection GetEvents()
		{ return TypeDescriptor.GetEvents(this, true); }
		public object GetPropertyOwner(PropertyDescriptor pd)
		{ return this; }
		/// <summary>
		/// Called to get the properties of this type. Returns properties with certain
		/// attributes. this restriction is not implemented here.
		/// </summary>
		/// <param name="attributes"></param>
		/// <returns></returns>
		public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
		{ return GetProperties(); }
		/// <summary>
		/// Called to get the properties of this type.
		/// </summary>
		/// <returns></returns>
		public PropertyDescriptorCollection GetProperties()
		{
			// Create a collection object to hold property descriptors
			PropertyDescriptorCollection pds = new PropertyDescriptorCollection(null);
			// Iterate the list 
			for (int i = 0; i < this.Items.Count; i++)
			{
				// Create a property descriptor for the item and add to the property descriptor collection
				ShipperOrdersPropertyDescriptor pd = new ShipperOrdersPropertyDescriptor(this, i);
				pds.Add(pd);
			}
			// return the property descriptor collection
			return pds;
		}
		#endregion
	} // Class
	#region Property Descriptor
	/// <summary>
	/// Summary description for CollectionPropertyDescriptor.
	/// </summary>
	public partial class ShipperOrdersPropertyDescriptor : vlnListPropertyDescriptor
	{
		private ShipperOrder Item { get { return (ShipperOrder) _Item;} }
		public ShipperOrdersPropertyDescriptor(ShipperOrders collection, int index):base(collection, index){;}
	}
	#endregion
	#region Converter
	internal class ShipperOrdersConverter : ExpandableObjectConverter
	{
		public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destType)
		{
			if (destType == typeof(string) && value is ShipperOrders)
			{
				// Return department and department role separated by comma.
				return ((ShipperOrders) value).Items.Count.ToString() + " Orders";
			}
			return base.ConvertTo(context, culture, value, destType);
		}
	}
	#endregion
} // Namespace
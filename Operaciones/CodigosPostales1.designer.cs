﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Socios.Rest.Operaciones
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="uFacturaESQL")]
	public partial class CodigosPostalesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public CodigosPostalesDataContext() : 
				base(global::uFacturaEDatos.Properties.Settings.Default.uFacturaESQLConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CodigosPostalesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CodigosPostalesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CodigosPostalesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CodigosPostalesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CodigosPostale> CodigosPostales
		{
			get
			{
				return this.GetTable<CodigosPostale>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CodigosPostales")]
	public partial class CodigosPostale
	{
		
		private System.Nullable<int> _d_codigo;
		
		private string _d_asenta;
		
		private string _D_mnpio;
		
		private string _d_estado;
		
		private string _d_ciudad;
		
		public CodigosPostale()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_d_codigo", DbType="Int")]
		public System.Nullable<int> d_codigo
		{
			get
			{
				return this._d_codigo;
			}
			set
			{
				if ((this._d_codigo != value))
				{
					this._d_codigo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_d_asenta", DbType="NVarChar(255)")]
		public string d_asenta
		{
			get
			{
				return this._d_asenta;
			}
			set
			{
				if ((this._d_asenta != value))
				{
					this._d_asenta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_D_mnpio", DbType="NVarChar(255)")]
		public string D_mnpio
		{
			get
			{
				return this._D_mnpio;
			}
			set
			{
				if ((this._D_mnpio != value))
				{
					this._D_mnpio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_d_estado", DbType="NVarChar(255)")]
		public string d_estado
		{
			get
			{
				return this._d_estado;
			}
			set
			{
				if ((this._d_estado != value))
				{
					this._d_estado = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_d_ciudad", DbType="NVarChar(255)")]
		public string d_ciudad
		{
			get
			{
				return this._d_ciudad;
			}
			set
			{
				if ((this._d_ciudad != value))
				{
					this._d_ciudad = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace MvcApplication1.DB
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class demo_dbEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new demo_dbEntities object using the connection string found in the 'demo_dbEntities' section of the application configuration file.
        /// </summary>
        public demo_dbEntities() : base("name=demo_dbEntities", "demo_dbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new demo_dbEntities object.
        /// </summary>
        public demo_dbEntities(string connectionString) : base(connectionString, "demo_dbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new demo_dbEntities object.
        /// </summary>
        public demo_dbEntities(EntityConnection connection) : base(connection, "demo_dbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Tax_Enter> Tax_Enter
        {
            get
            {
                if ((_Tax_Enter == null))
                {
                    _Tax_Enter = base.CreateObjectSet<Tax_Enter>("Tax_Enter");
                }
                return _Tax_Enter;
            }
        }
        private ObjectSet<Tax_Enter> _Tax_Enter;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Tax_Enter EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTax_Enter(Tax_Enter tax_Enter)
        {
            base.AddObject("Tax_Enter", tax_Enter);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="demo_dbModel", Name="Tax_Enter")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Tax_Enter : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Tax_Enter object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static Tax_Enter CreateTax_Enter(global::System.Int32 id)
        {
            Tax_Enter tax_Enter = new Tax_Enter();
            tax_Enter.Id = id;
            return tax_Enter;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Tax_name
        {
            get
            {
                return _Tax_name;
            }
            set
            {
                OnTax_nameChanging(value);
                ReportPropertyChanging("Tax_name");
                _Tax_name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Tax_name");
                OnTax_nameChanged();
            }
        }
        private global::System.String _Tax_name;
        partial void OnTax_nameChanging(global::System.String value);
        partial void OnTax_nameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Tax_Percentage
        {
            get
            {
                return _Tax_Percentage;
            }
            set
            {
                OnTax_PercentageChanging(value);
                ReportPropertyChanging("Tax_Percentage");
                _Tax_Percentage = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Tax_Percentage");
                OnTax_PercentageChanged();
            }
        }
        private global::System.String _Tax_Percentage;
        partial void OnTax_PercentageChanging(global::System.String value);
        partial void OnTax_PercentageChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String gender
        {
            get
            {
                return _gender;
            }
            set
            {
                OngenderChanging(value);
                ReportPropertyChanging("gender");
                _gender = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("gender");
                OngenderChanged();
            }
        }
        private global::System.String _gender;
        partial void OngenderChanging(global::System.String value);
        partial void OngenderChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String date
        {
            get
            {
                return _date;
            }
            set
            {
                OndateChanging(value);
                ReportPropertyChanging("date");
                _date = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("date");
                OndateChanged();
            }
        }
        private global::System.String _date;
        partial void OndateChanging(global::System.String value);
        partial void OndateChanged();

        #endregion

    
    }

    #endregion

    
}
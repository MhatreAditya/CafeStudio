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
namespace CafeManagementSystem
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class CafeManagementSystemEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new CafeManagementSystemEntities object using the connection string found in the 'CafeManagementSystemEntities' section of the application configuration file.
        /// </summary>
        public CafeManagementSystemEntities() : base("name=CafeManagementSystemEntities", "CafeManagementSystemEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CafeManagementSystemEntities object.
        /// </summary>
        public CafeManagementSystemEntities(string connectionString) : base(connectionString, "CafeManagementSystemEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CafeManagementSystemEntities object.
        /// </summary>
        public CafeManagementSystemEntities(EntityConnection connection) : base(connection, "CafeManagementSystemEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
    }

    #endregion

    
}
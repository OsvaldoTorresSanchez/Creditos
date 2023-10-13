﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL_EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CreditosEntities : DbContext
    {
        public CreditosEntities()
            : base("name=CreditosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Credito> Creditoes { get; set; }
    
        public virtual int CreditoAdd(Nullable<decimal> importeCredito, Nullable<int> plazo, Nullable<decimal> tasaAnual)
        {
            var importeCreditoParameter = importeCredito.HasValue ?
                new ObjectParameter("ImporteCredito", importeCredito) :
                new ObjectParameter("ImporteCredito", typeof(decimal));
    
            var plazoParameter = plazo.HasValue ?
                new ObjectParameter("Plazo", plazo) :
                new ObjectParameter("Plazo", typeof(int));
    
            var tasaAnualParameter = tasaAnual.HasValue ?
                new ObjectParameter("TasaAnual", tasaAnual) :
                new ObjectParameter("TasaAnual", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreditoAdd", importeCreditoParameter, plazoParameter, tasaAnualParameter);
        }
    
        public virtual int CreditoDelete(Nullable<int> numeroCredito)
        {
            var numeroCreditoParameter = numeroCredito.HasValue ?
                new ObjectParameter("NumeroCredito", numeroCredito) :
                new ObjectParameter("NumeroCredito", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreditoDelete", numeroCreditoParameter);
        }
    
        public virtual ObjectResult<CreditoGetAll_Result> CreditoGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CreditoGetAll_Result>("CreditoGetAll");
        }
    
        public virtual int CreditoUpdate(Nullable<int> numeroCredito, Nullable<decimal> importeCredito, Nullable<int> plazo, Nullable<decimal> tasaAnual)
        {
            var numeroCreditoParameter = numeroCredito.HasValue ?
                new ObjectParameter("NumeroCredito", numeroCredito) :
                new ObjectParameter("NumeroCredito", typeof(int));
    
            var importeCreditoParameter = importeCredito.HasValue ?
                new ObjectParameter("ImporteCredito", importeCredito) :
                new ObjectParameter("ImporteCredito", typeof(decimal));
    
            var plazoParameter = plazo.HasValue ?
                new ObjectParameter("Plazo", plazo) :
                new ObjectParameter("Plazo", typeof(int));
    
            var tasaAnualParameter = tasaAnual.HasValue ?
                new ObjectParameter("TasaAnual", tasaAnual) :
                new ObjectParameter("TasaAnual", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreditoUpdate", numeroCreditoParameter, importeCreditoParameter, plazoParameter, tasaAnualParameter);
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.Models.EDMX
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PortalOdontoEntities : DbContext
    {
        public PortalOdontoEntities()
            : base("name=PortalOdontoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TB_Odontograma> TB_Odontograma { get; set; }
        public virtual DbSet<TB_Paciente> TB_Paciente { get; set; }
        public virtual DbSet<TB_Perguntas> TB_Perguntas { get; set; }
        public virtual DbSet<TB_Periograma> TB_Periograma { get; set; }
        public virtual DbSet<TB_Pessoa> TB_Pessoa { get; set; }
        public virtual DbSet<TB_Triagem> TB_Triagem { get; set; }
    }
}

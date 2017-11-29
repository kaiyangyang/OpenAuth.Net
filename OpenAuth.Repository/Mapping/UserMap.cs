﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OpenAuth.Repository.Models.Mapping
{
    public partial class UserMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<OpenAuth.Domain.User>
    {
        public UserMap()
        {
            // table
            ToTable("User", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.Account)
                .HasColumnName("Account")
                .HasMaxLength(255)
                .IsRequired();
            Property(t => t.Password)
                .HasColumnName("Password")
                .HasMaxLength(255)
                .IsRequired();
            Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(255)
                .IsRequired();
            Property(t => t.Sex)
                .HasColumnName("Sex")
                .IsRequired();
            Property(t => t.Status)
                .HasColumnName("Status")
                .IsRequired();
            Property(t => t.Type)
                .HasColumnName("Type")
                .IsRequired();
            Property(t => t.BizCode)
                .HasColumnName("BizCode")
                .HasMaxLength(255)
                .IsRequired();
            Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
                .IsRequired();
            Property(t => t.CrateId)
                .HasColumnName("CrateId")
                .HasMaxLength(50)
                .IsOptional();

            // Relationships
        }
    }
}
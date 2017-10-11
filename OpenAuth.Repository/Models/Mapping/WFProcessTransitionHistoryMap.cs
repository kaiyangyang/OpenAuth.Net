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
    public partial class WFProcessTransitionHistoryMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<OpenAuth.Domain.WFProcessTransitionHistory>
    {
        public WFProcessTransitionHistoryMap()
        {
            // table
            ToTable("WF_ProcessTransitionHistory", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.ProcessId)
                .HasColumnName("ProcessId")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.FromNodeId)
                .HasColumnName("fromNodeId")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.FromNodeType)
                .HasColumnName("fromNodeType")
                .IsOptional();
            Property(t => t.FromNodeName)
                .HasColumnName("fromNodeName")
                .HasMaxLength(200)
                .IsOptional();
            Property(t => t.ToNodeId)
                .HasColumnName("toNodeId")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.ToNodeType)
                .HasColumnName("toNodeType")
                .IsOptional();
            Property(t => t.ToNodeName)
                .HasColumnName("toNodeName")
                .HasMaxLength(200)
                .IsOptional();
            Property(t => t.TransitionSate)
                .HasColumnName("TransitionSate")
                .IsOptional();
            Property(t => t.IsFinish)
                .HasColumnName("isFinish")
                .IsOptional();
            Property(t => t.CreateDate)
                .HasColumnName("CreateDate")
                .IsOptional();
            Property(t => t.CreateUserId)
                .HasColumnName("CreateUserId")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.CreateUserName)
                .HasColumnName("CreateUserName")
                .HasMaxLength(50)
                .IsOptional();

            // Relationships
        }
    }
}

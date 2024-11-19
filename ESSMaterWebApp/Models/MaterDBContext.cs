using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ESSMaterWebApp.Models;

public partial class MaterDBContext : IdentityDbContext
{
    public MaterDBContext()
    {
    }

    public MaterDBContext(DbContextOptions<MaterDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appointment> Appointments { get; set; }

    
    public virtual DbSet<Diagnosis> Diagnoses { get; set; }

    public virtual DbSet<DonationInterest> DonationInterests { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<MediaContent> MediaContents { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<Questionnaire> Questionnaires { get; set; }

    public virtual DbSet<Response> Responses { get; set; }

   
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.ToTable("Appointment");

            entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");
        });

        

        modelBuilder.Entity<Diagnosis>(entity =>
        {
            entity.ToTable("Diagnosis");

            entity.HasOne(d => d.DiagnosisQuestionnaire).WithMany(p => p.Diagnoses)
                .HasForeignKey(d => d.DiagnosisQuestionnaireId)
                .HasConstraintName("FK_Diagnosis_Questionnaire");
        });

        modelBuilder.Entity<DonationInterest>(entity =>
        {
            entity.HasKey(e => e.DonationId).HasName("PK_DonationInterests");

            entity.ToTable("DonationInterest");

            entity.Property(e => e.DonationId).HasColumnName("DonationID");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("Employee");
        });

        modelBuilder.Entity<MediaContent>(entity =>
        {
            entity.HasKey(e => e.MediaId);

            entity.ToTable("MediaContent");

            entity.Property(e => e.Url).HasColumnName("URL");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.ToTable("Question");
        });

        modelBuilder.Entity<Questionnaire>(entity =>
        {
            entity.ToTable("Questionnaire");
        });

        modelBuilder.Entity<Response>(entity =>
        {
            entity.ToTable("Response");

            entity.Property(e => e.Response1).HasColumnName("Response");

            entity.HasOne(d => d.ResponseQuestion).WithMany(p => p.Responses)
                .HasForeignKey(d => d.ResponseQuestionId)
                .HasConstraintName("FK_Response_Question");

            entity.HasOne(d => d.ResponseQuestionnaire).WithMany(p => p.Responses)
                .HasForeignKey(d => d.ResponseQuestionnaireId)
                .HasConstraintName("FK_Response_Questionnaire1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

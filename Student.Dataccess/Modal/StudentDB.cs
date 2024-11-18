using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Student.Dataccess.Modal;

public partial class StudentDB : DbContext
{
    public StudentDB()
    {
    }

    public StudentDB(DbContextOptions<StudentDB> options)
        : base(options)
    {
    }

    public virtual DbSet<Addresss> Addresses { get; set; }

    public virtual DbSet<Courses> Courses { get; set; }

    public virtual DbSet<Enrollments> Enrollments { get; set; }

    public virtual DbSet<Fees> Fees { get; set; }

    public virtual DbSet<Logs> Logs { get; set; }

    public virtual DbSet<Rolestores> Rolestores { get; set; }

    public virtual DbSet<Streams> Streams { get; set; }

    public virtual DbSet<Students> Students { get; set; }

    public virtual DbSet<Subjects> Subjects { get; set; }

    public virtual DbSet<SubjectStreamCourses> SubjectStreamCourses { get; set; }

    public virtual DbSet<Tempaddresss> Tempaddresses { get; set; }

    public virtual DbSet<Users> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server=ep-soft-hat-a5xssbd4.us-east-2.aws.neon.tech;Port=5432;User Id=StudentDB_owner;Password=x6nlptdLcw5h;Database=StudentDB;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Addresss>(entity =>
        {
            entity.HasKey(e => e.Addressid).HasName("address_pkey");

            entity.ToTable("address", "StudentInfo");

            entity.Property(e => e.Addressid).HasColumnName("addressid");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .HasColumnName("country");
            entity.Property(e => e.Createdby)
                .HasMaxLength(255)
                .HasColumnName("createdby");
            entity.Property(e => e.Createdon)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdon");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(255)
                .HasColumnName("modifiedby");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("modifiedon");
            entity.Property(e => e.State)
                .HasMaxLength(100)
                .HasColumnName("state");
            entity.Property(e => e.Streetname)
                .HasMaxLength(255)
                .HasColumnName("streetname");
            entity.Property(e => e.Zipcode).HasColumnName("zipcode");
        });

        modelBuilder.Entity<Courses>(entity =>
        {
            entity.HasKey(e => e.Courseid).HasName("course_pkey");

            entity.ToTable("course", "StudentInfo");

            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Coursename)
                .HasMaxLength(255)
                .HasColumnName("coursename");
            entity.Property(e => e.Createdby)
                .HasMaxLength(255)
                .HasColumnName("createdby");
            entity.Property(e => e.Createdon)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdon");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(255)
                .HasColumnName("modifiedby");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("modifiedon");
            entity.Property(e => e.Streamid).HasColumnName("streamid");

            entity.HasOne(d => d.Stream).WithMany(p => p.Courses)
                .HasForeignKey(d => d.Streamid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("course_streamid_fkey");
        });

        modelBuilder.Entity<Enrollments>(entity =>
        {
            entity.HasKey(e => e.Enrollmentid).HasName("enrollment_pkey");

            entity.ToTable("enrollment", "StudentInfo");

            entity.Property(e => e.Enrollmentid).HasColumnName("enrollmentid");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Createdby)
                .HasMaxLength(255)
                .HasColumnName("createdby");
            entity.Property(e => e.Createdon)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdon");
            entity.Property(e => e.Enrollmentdate).HasColumnName("enrollmentdate");
            entity.Property(e => e.Enrollmentnumber)
                .HasDefaultValueSql("(nextval('\"StudentInfo\".enrollment_number_seq'::regclass) + 1000)")
                .HasColumnName("enrollmentnumber");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(255)
                .HasColumnName("modifiedby");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("modifiedon");
            entity.Property(e => e.Studentid).HasColumnName("studentid");

            entity.HasOne(d => d.Course).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.Courseid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("enrollment_courseid_fkey");

            entity.HasOne(d => d.Student).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.Studentid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("enrollment_studentid_fkey");
        });

        modelBuilder.Entity<Fees>(entity =>
        {
            entity.HasKey(e => e.Feeid).HasName("fees_pkey");

            entity.ToTable("fees", "StudentInfo");

            entity.Property(e => e.Feeid).HasColumnName("feeid");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Createdby)
                .HasMaxLength(255)
                .HasColumnName("createdby");
            entity.Property(e => e.Createdon)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdon");
            entity.Property(e => e.Feeamount)
                .HasPrecision(10, 2)
                .HasColumnName("feeamount");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(255)
                .HasColumnName("modifiedby");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("modifiedon");
            entity.Property(e => e.Paymentdate).HasColumnName("paymentdate");
            entity.Property(e => e.Studentid).HasColumnName("studentid");

            entity.HasOne(d => d.Course).WithMany(p => p.Fees)
                .HasForeignKey(d => d.Courseid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fees_courseid_fkey");

            entity.HasOne(d => d.Student).WithMany(p => p.Fees)
                .HasForeignKey(d => d.Studentid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fees_studentid_fkey");
        });

        modelBuilder.Entity<Logs>(entity =>
        {
            entity.HasKey(e => e.Logid).HasName("log_pkey");

            entity.ToTable("log", "StudentInfo");

            entity.Property(e => e.Logid).HasColumnName("logid");
            entity.Property(e => e.Action)
                .HasMaxLength(255)
                .HasColumnName("action");
            entity.Property(e => e.Createdby)
                .HasMaxLength(255)
                .HasColumnName("createdby");
            entity.Property(e => e.Createdon)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdon");
            entity.Property(e => e.Loglevel)
                .HasMaxLength(20)
                .HasColumnName("loglevel");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(255)
                .HasColumnName("modifiedby");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("modifiedon");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("timestamp");
            entity.Property(e => e.Users)
                .HasMaxLength(255)
                .HasColumnName("users");
        });

        modelBuilder.Entity<Rolestores>(entity =>
        {
            entity.HasKey(e => e.Roleid).HasName("rolestore_pkey");

            entity.ToTable("rolestore", "StudentInfo");

            entity.Property(e => e.Roleid).HasColumnName("roleid");
            entity.Property(e => e.Createdby)
                .HasMaxLength(255)
                .HasColumnName("createdby");
            entity.Property(e => e.Createdon)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdon");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(255)
                .HasColumnName("modifiedby");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("modifiedon");
            entity.Property(e => e.Rolename)
                .HasMaxLength(20)
                .HasColumnName("rolename");
        });

        modelBuilder.Entity<Streams>(entity =>
        {
            entity.HasKey(e => e.Streamid).HasName("stream_pkey");

            entity.ToTable("stream", "StudentInfo");

            entity.Property(e => e.Streamid).HasColumnName("streamid");
            entity.Property(e => e.Createdby)
                .HasMaxLength(255)
                .HasColumnName("createdby");
            entity.Property(e => e.Createdon)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdon");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(255)
                .HasColumnName("modifiedby");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("modifiedon");
            entity.Property(e => e.Streamname)
                .HasMaxLength(255)
                .HasColumnName("streamname");
        });

        modelBuilder.Entity<Students>(entity =>
        {
            entity.HasKey(e => e.Studentid).HasName("student_pkey");

            entity.ToTable("students", "StudentInfo");

            entity.Property(e => e.Studentid)
                .HasDefaultValueSql("nextval('\"StudentInfo\".student_studentid_seq'::regclass)")
                .HasColumnName("studentid");
            entity.Property(e => e.Addressid).HasColumnName("addressid");
            entity.Property(e => e.Createdby)
                .HasMaxLength(255)
                .HasColumnName("createdby");
            entity.Property(e => e.Createdon)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdon");
            entity.Property(e => e.Dateofbirth).HasColumnName("dateofbirth");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Firstname)
                .HasMaxLength(255)
                .HasColumnName("firstname");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .HasColumnName("gender");
            entity.Property(e => e.Lastname)
                .HasMaxLength(255)
                .HasColumnName("lastname");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(255)
                .HasColumnName("modifiedby");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("modifiedon");
            entity.Property(e => e.Phonenumber)
                .HasMaxLength(20)
                .HasColumnName("phonenumber");
            entity.Property(e => e.Tempaddressid).HasColumnName("tempaddressid");

            entity.HasOne(d => d.Address).WithMany(p => p.Students)
                .HasForeignKey(d => d.Addressid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("student_addressid_fkey");

            entity.HasOne(d => d.Tempaddress).WithMany(p => p.Students)
                .HasForeignKey(d => d.Tempaddressid)
                .HasConstraintName("student_tempaddressid_fkey");
        });

        modelBuilder.Entity<Subjects>(entity =>
        {
            entity.HasKey(e => e.Subjectid).HasName("subject_pkey");

            entity.ToTable("subject", "StudentInfo");

            entity.Property(e => e.Subjectid).HasColumnName("subjectid");
            entity.Property(e => e.Createdby)
                .HasMaxLength(255)
                .HasColumnName("createdby");
            entity.Property(e => e.Createdon)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdon");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(255)
                .HasColumnName("modifiedby");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("modifiedon");
            entity.Property(e => e.Subjectname)
                .HasMaxLength(255)
                .HasColumnName("subjectname");
        });

        modelBuilder.Entity<SubjectStreamCourses>(entity =>
        {
            entity.HasKey(e => new { e.Subjectid, e.Streamid, e.Courseid }).HasName("subject_stream_course_pkey");

            entity.ToTable("subject_stream_course", "StudentInfo");

            entity.Property(e => e.Subjectid).HasColumnName("subjectid");
            entity.Property(e => e.Streamid).HasColumnName("streamid");
            entity.Property(e => e.Courseid).HasColumnName("courseid");

            entity.HasOne(d => d.Course).WithMany(p => p.SubjectStreamCourses)
                .HasForeignKey(d => d.Courseid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("subject_stream_course_courseid_fkey");

            entity.HasOne(d => d.Stream).WithMany(p => p.SubjectStreamCourses)
                .HasForeignKey(d => d.Streamid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("subject_stream_course_streamid_fkey");

            entity.HasOne(d => d.Subject).WithMany(p => p.SubjectStreamCourses)
                .HasForeignKey(d => d.Subjectid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("subject_stream_course_subjectid_fkey");
        });

        modelBuilder.Entity<Tempaddresss>(entity =>
        {
            entity.HasKey(e => e.Tempaddressid).HasName("tempaddress_pkey");

            entity.ToTable("tempaddress", "StudentInfo");

            entity.Property(e => e.Tempaddressid).HasColumnName("tempaddressid");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .HasColumnName("country");
            entity.Property(e => e.Createdby)
                .HasMaxLength(255)
                .HasColumnName("createdby");
            entity.Property(e => e.Createdon)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdon");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(255)
                .HasColumnName("modifiedby");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("modifiedon");
            entity.Property(e => e.State)
                .HasMaxLength(100)
                .HasColumnName("state");
            entity.Property(e => e.Streetname)
                .HasMaxLength(255)
                .HasColumnName("streetname");
            entity.Property(e => e.Zipcode).HasColumnName("zipcode");
        });

        modelBuilder.Entity<Users>(entity =>
        {
            entity.HasKey(e => e.Userid).HasName("users_pkey");

            entity.ToTable("users", "StudentInfo");

            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Createdby)
                .HasMaxLength(255)
                .HasColumnName("createdby");
            entity.Property(e => e.Createdon)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("createdon");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .HasColumnName("lastname");
            entity.Property(e => e.Modifiedby)
                .HasMaxLength(255)
                .HasColumnName("modifiedby");
            entity.Property(e => e.Modifiedon)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("modifiedon");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.Roleid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("users_roleid_fkey");
        });
        modelBuilder.HasSequence("enrollment_number_seq", "StudentInfo");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

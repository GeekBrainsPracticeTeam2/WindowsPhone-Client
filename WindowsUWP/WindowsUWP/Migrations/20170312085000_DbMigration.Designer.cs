using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WindowsUWP;

namespace WindowsUWP.Migrations
{
    [DbContext(typeof(DBDictionary))]
    [Migration("20170312085000_DbMigration")]
    partial class DbMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("WindowsUWP.models.LastUpdate", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("TableName");

                    b.HasKey("ID");

                    b.ToTable("LastUpdates");
                });

            modelBuilder.Entity("WindowsUWP.models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("WindowsUWP.models.Site", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Url");

                    b.HasKey("ID");

                    b.ToTable("Sites");
                });
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RelacaoMuitosPMuitos.Data;

#nullable disable

namespace RelacaoMuitosPMuitos.Migrations
{
    [DbContext(typeof(RelacaoMPMContext))]
    partial class RelacaoMPMContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RelacaoMuitosPMuitos.Models.Post", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("RelacaoMuitosPMuitos.Models.PostTag", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<int?>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("PostsId")
                        .HasColumnType("int");

                    b.Property<int?>("TagId")
                        .HasColumnType("int");

                    b.Property<int>("TagsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTags");
                });

            modelBuilder.Entity("RelacaoMuitosPMuitos.Models.Tag", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("RelacaoMuitosPMuitos.Models.PostTag", b =>
                {
                    b.HasOne("RelacaoMuitosPMuitos.Models.Post", "Post")
                        .WithMany("PostTags")
                        .HasForeignKey("PostId");

                    b.HasOne("RelacaoMuitosPMuitos.Models.Tag", "Tag")
                        .WithMany("PostTags")
                        .HasForeignKey("TagId");

                    b.Navigation("Post");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("RelacaoMuitosPMuitos.Models.Post", b =>
                {
                    b.Navigation("PostTags");
                });

            modelBuilder.Entity("RelacaoMuitosPMuitos.Models.Tag", b =>
                {
                    b.Navigation("PostTags");
                });
#pragma warning restore 612, 618
        }
    }
}

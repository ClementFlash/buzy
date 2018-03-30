﻿// <auto-generated />
using Buzy.DataAccess;
using Buzy.DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Buzy.Migrations
{
    [DbContext(typeof(BusHelperContext))]
    partial class BusHelperContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Buzy.DataAccess.Model.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("assunto");

                    b.Property<string>("mensagem");

                    b.HasKey("Id");

                    b.ToTable("feedbacks");
                });

            modelBuilder.Entity("Buzy.DataAccess.Model.HistoricoSensor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("data");

                    b.Property<double>("latitude");

                    b.Property<double>("longitude");

                    b.Property<int?>("sensorId");

                    b.Property<int>("valor");

                    b.HasKey("Id");

                    b.HasIndex("sensorId");

                    b.ToTable("historicoSensores");
                });

            modelBuilder.Entity("Buzy.DataAccess.Model.PontoDeOnibus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("latitude");

                    b.Property<double>("longitude");

                    b.Property<string>("nome");

                    b.HasKey("Id");

                    b.ToTable("pontosDeOnibus");
                });

            modelBuilder.Entity("Buzy.DataAccess.Model.Sensor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("acao");

                    b.Property<int>("codigoLinha");

                    b.Property<int>("prefixo");

                    b.Property<int>("valor");

                    b.HasKey("Id");

                    b.ToTable("sensores");
                });

            modelBuilder.Entity("Buzy.DataAccess.Model.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("email");

                    b.Property<string>("nome");

                    b.Property<string>("senha");

                    b.Property<string>("telefone");

                    b.HasKey("Id");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("Buzy.DataAccess.Model.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("capacidadeSentados");

                    b.Property<int>("capacisadeEmPe");

                    b.Property<string>("nome");

                    b.HasKey("Id");

                    b.ToTable("veiculos");
                });

            modelBuilder.Entity("Buzy.DataAccess.Model.HistoricoSensor", b =>
                {
                    b.HasOne("Buzy.DataAccess.Model.Sensor", "sensor")
                        .WithMany()
                        .HasForeignKey("sensorId");
                });
#pragma warning restore 612, 618
        }
    }
}

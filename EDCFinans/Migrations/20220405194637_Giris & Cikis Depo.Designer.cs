﻿// <auto-generated />
using System;
using EDCFinans.Models.Finans;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EDCFinans.Migrations
{
    [DbContext(typeof(FinansContext))]
    [Migration("20220405194637_Giris & Cikis Depo")]
    partial class GirisCikisDepo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EDCFinans.Models.Finans.Depo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<int>("SehirId")
                        .HasColumnType("int");

                    b.Property<int>("SirketId")
                        .HasColumnType("int");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SehirId");

                    b.HasIndex("SirketId");

                    b.ToTable("Depo");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Fatura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<string>("FaturaNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FaturaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<float>("Fiyat")
                        .HasColumnType("real");

                    b.Property<float>("Kdv")
                        .HasColumnType("real");

                    b.Property<int>("ParaBirimId")
                        .HasColumnType("int");

                    b.Property<int?>("ParaBirimiId")
                        .HasColumnType("int");

                    b.Property<int>("SirketId")
                        .HasColumnType("int");

                    b.Property<float>("ToplamFiyat")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ParaBirimiId");

                    b.HasIndex("SirketId");

                    b.ToTable("Fatura");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.GelirGider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<int>("FaturaId")
                        .HasColumnType("int");

                    b.Property<int>("GelirGiderTurId")
                        .HasColumnType("int");

                    b.Property<int?>("GelirGiderTuruId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FaturaId")
                        .IsUnique();

                    b.HasIndex("GelirGiderTuruId");

                    b.ToTable("GelirGider");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.GelirGiderTuru", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("GelirGiderTuru");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Maas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("BrutMaas")
                        .HasColumnType("real");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<float>("NetMaas")
                        .HasColumnType("real");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonelId")
                        .IsUnique();

                    b.ToTable("Maas");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Meslek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Meslek");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.ParaBirimi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ParaBirimi");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Personel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<int>("MeslekId")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("İseGirisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("İstenCikisTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MeslekId");

                    b.ToTable("Personel");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Sehir", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<int>("UlkeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UlkeId");

                    b.ToTable("Sehir");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Siparis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CikisDepoId")
                        .HasColumnType("int");

                    b.Property<int?>("DepoId")
                        .HasColumnType("int");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<int>("FaturaId")
                        .HasColumnType("int");

                    b.Property<int>("GirisDepoId")
                        .HasColumnType("int");

                    b.Property<int>("SiparisDurumId")
                        .HasColumnType("int");

                    b.Property<int?>("SiparisId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepoId");

                    b.HasIndex("FaturaId");

                    b.HasIndex("SiparisDurumId");

                    b.HasIndex("SiparisId");

                    b.ToTable("Siparis");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.SiparisDetay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<int>("SiparisId")
                        .HasColumnType("int");

                    b.Property<int>("UrunDetayId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SiparisId");

                    b.HasIndex("UrunDetayId");

                    b.ToTable("SiparisDetay");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.SiparisDurum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("SiparisDurum");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Sirket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VergiNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sirket");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Stok", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<int>("DepoId")
                        .HasColumnType("int");

                    b.Property<int>("UrunDetayId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepoId");

                    b.HasIndex("UrunDetayId");

                    b.ToTable("Stok");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Ulke", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Ulke");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<int>("UrunKategoriId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UrunKategoriId");

                    b.ToTable("Urun");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.UrunDetay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Barkod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<string>("Marka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Renk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UrunId");

                    b.ToTable("UrunDetay");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.UrunKategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("UrunKategori");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Depo", b =>
                {
                    b.HasOne("EDCFinans.Models.Finans.Sehir", "Sehir")
                        .WithMany("Depolar")
                        .HasForeignKey("SehirId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EDCFinans.Models.Finans.Sirket", "Sirket")
                        .WithMany("Depolar")
                        .HasForeignKey("SirketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sehir");

                    b.Navigation("Sirket");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Fatura", b =>
                {
                    b.HasOne("EDCFinans.Models.Finans.ParaBirimi", "ParaBirimi")
                        .WithMany("Faturalar")
                        .HasForeignKey("ParaBirimiId");

                    b.HasOne("EDCFinans.Models.Finans.Sirket", "Sirket")
                        .WithMany("Faturalar")
                        .HasForeignKey("SirketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParaBirimi");

                    b.Navigation("Sirket");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.GelirGider", b =>
                {
                    b.HasOne("EDCFinans.Models.Finans.Fatura", "Fatura")
                        .WithOne("GelirGider")
                        .HasForeignKey("EDCFinans.Models.Finans.GelirGider", "FaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EDCFinans.Models.Finans.GelirGiderTuru", "GelirGiderTuru")
                        .WithMany("GelirGiderler")
                        .HasForeignKey("GelirGiderTuruId");

                    b.Navigation("Fatura");

                    b.Navigation("GelirGiderTuru");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Maas", b =>
                {
                    b.HasOne("EDCFinans.Models.Finans.Personel", "Personel")
                        .WithOne("Maas")
                        .HasForeignKey("EDCFinans.Models.Finans.Maas", "PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Personel", b =>
                {
                    b.HasOne("EDCFinans.Models.Finans.Meslek", "Meslek")
                        .WithMany("Personeller")
                        .HasForeignKey("MeslekId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meslek");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Sehir", b =>
                {
                    b.HasOne("EDCFinans.Models.Finans.Ulke", "Ulke")
                        .WithMany("Sehirler")
                        .HasForeignKey("UlkeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ulke");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Siparis", b =>
                {
                    b.HasOne("EDCFinans.Models.Finans.Depo", null)
                        .WithMany("Siparisler")
                        .HasForeignKey("DepoId");

                    b.HasOne("EDCFinans.Models.Finans.Fatura", "Fatura")
                        .WithMany("Siparisler")
                        .HasForeignKey("FaturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EDCFinans.Models.Finans.SiparisDurum", "SiparisDurum")
                        .WithMany("Siparisler")
                        .HasForeignKey("SiparisDurumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EDCFinans.Models.Finans.Siparis", null)
                        .WithMany("Siparisler")
                        .HasForeignKey("SiparisId");

                    b.Navigation("Fatura");

                    b.Navigation("SiparisDurum");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.SiparisDetay", b =>
                {
                    b.HasOne("EDCFinans.Models.Finans.Siparis", "Siparis")
                        .WithMany()
                        .HasForeignKey("SiparisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EDCFinans.Models.Finans.UrunDetay", "UrunDetay")
                        .WithMany("SiparisDetaylar")
                        .HasForeignKey("UrunDetayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Siparis");

                    b.Navigation("UrunDetay");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Stok", b =>
                {
                    b.HasOne("EDCFinans.Models.Finans.Depo", "Depo")
                        .WithMany("Stoklar")
                        .HasForeignKey("DepoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EDCFinans.Models.Finans.UrunDetay", "UrunDetay")
                        .WithMany("Stoklar")
                        .HasForeignKey("UrunDetayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Depo");

                    b.Navigation("UrunDetay");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Urun", b =>
                {
                    b.HasOne("EDCFinans.Models.Finans.UrunKategori", "UrunKategori")
                        .WithMany("Urunler")
                        .HasForeignKey("UrunKategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UrunKategori");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.UrunDetay", b =>
                {
                    b.HasOne("EDCFinans.Models.Finans.Urun", "Urun")
                        .WithMany("UrunDetaylar")
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Depo", b =>
                {
                    b.Navigation("Siparisler");

                    b.Navigation("Stoklar");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Fatura", b =>
                {
                    b.Navigation("GelirGider");

                    b.Navigation("Siparisler");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.GelirGiderTuru", b =>
                {
                    b.Navigation("GelirGiderler");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Meslek", b =>
                {
                    b.Navigation("Personeller");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.ParaBirimi", b =>
                {
                    b.Navigation("Faturalar");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Personel", b =>
                {
                    b.Navigation("Maas");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Sehir", b =>
                {
                    b.Navigation("Depolar");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Siparis", b =>
                {
                    b.Navigation("Siparisler");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.SiparisDurum", b =>
                {
                    b.Navigation("Siparisler");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Sirket", b =>
                {
                    b.Navigation("Depolar");

                    b.Navigation("Faturalar");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Ulke", b =>
                {
                    b.Navigation("Sehirler");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.Urun", b =>
                {
                    b.Navigation("UrunDetaylar");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.UrunDetay", b =>
                {
                    b.Navigation("SiparisDetaylar");

                    b.Navigation("Stoklar");
                });

            modelBuilder.Entity("EDCFinans.Models.Finans.UrunKategori", b =>
                {
                    b.Navigation("Urunler");
                });
#pragma warning restore 612, 618
        }
    }
}

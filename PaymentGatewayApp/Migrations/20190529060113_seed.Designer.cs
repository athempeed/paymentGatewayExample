﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PaymentGatewayApp.Repositories;

namespace PaymentGatewayApp.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20190529060113_seed")]
    partial class seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("PaymentGatewayApp.Models.Bank", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Banks");

                    b.HasData(
                        new { ID = 1, Name = "Maybank" },
                        new { ID = 2, Name = "CIMB Bank" },
                        new { ID = 3, Name = "Public Bank Berhad" },
                        new { ID = 4, Name = "RHB Bank" },
                        new { ID = 5, Name = "Hong Leong Bank" },
                        new { ID = 6, Name = "OCBC Bank Malaysia" },
                        new { ID = 7, Name = "HSBC Bank Malaysia" },
                        new { ID = 8, Name = "CitiBank Malaysia" },
                        new { ID = 9, Name = "Bank Muamalat Malaysia Berhad" },
                        new { ID = 10, Name = "Alliance Bank" }
                    );
                });

            modelBuilder.Entity("PaymentGatewayApp.Models.PaymentOption", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("PaymentOptions");

                    b.HasData(
                        new { ID = 1, Name = "Online Banking" },
                        new { ID = 2, Name = "Gateway Wallet" },
                        new { ID = 3, Name = "Debit/Credit Card" }
                    );
                });

            modelBuilder.Entity("PaymentGatewayApp.Models.Transaction", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<string>("BankName");

                    b.Property<int>("CVV");

                    b.Property<string>("Cardnumber");

                    b.Property<string>("MerchantId");

                    b.Property<string>("Reference");

                    b.Property<string>("TransactionMethod");

                    b.HasKey("ID");

                    b.ToTable("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}

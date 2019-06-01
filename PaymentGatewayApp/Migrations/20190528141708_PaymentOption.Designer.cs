﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PaymentGatewayApp.Repositories;

namespace PaymentGatewayApp.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20190528141708_PaymentOption")]
    partial class PaymentOption
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("PaymentGatewayApp.Models.PaymentOption", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("PaymentOptions");
                });
#pragma warning restore 612, 618
        }
    }
}

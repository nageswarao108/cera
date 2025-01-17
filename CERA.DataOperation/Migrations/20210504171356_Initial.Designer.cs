﻿// <auto-generated />
using System;
using CERA.DataOperation.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CERA.DataOperation.Migrations
{
    [DbContext(typeof(CeraDbContext))]
    [Migration("20210504171356_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CERA.Entities.Models.CeraAppServicePlans", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResourceGroupName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_AppServicePlans");
                });

            modelBuilder.Entity("CERA.Entities.Models.CeraCompliances", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssessmentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_Compliances");
                });

            modelBuilder.Entity("CERA.Entities.Models.CeraDisks", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResourceGroupName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("tbl_Disks");
                });

            modelBuilder.Entity("CERA.Entities.Models.CeraRateCard", b =>
                {
                    b.Property<string>("MeterId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EffectiveDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("IncludedQuantity")
                        .HasColumnType("real");

                    b.Property<string>("MeterCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MeterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MeterRegion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MeterStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MeterSubCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MeterId");

                    b.ToTable("tbl_RateCard");
                });

            modelBuilder.Entity("CERA.Entities.Models.CeraResourceGroups", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("provisioningstate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_ResourceGroups");
                });

            modelBuilder.Entity("CERA.Entities.Models.CeraResourceHealth", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AvailabilityState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResourceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_ResourceHealth");
                });

            modelBuilder.Entity("CERA.Entities.Models.CeraResources", b =>
                {
                    b.Property<int?>("ResourceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResourceGroupName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResourceProviderNameSpace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResourceType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Tags")
                        .HasColumnType("bit");

                    b.HasKey("ResourceID");

                    b.ToTable("tbl_Resources");
                });

            modelBuilder.Entity("CERA.Entities.Models.CeraSqlServer", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResourceGroupName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("tbl_SqlServer");
                });

            modelBuilder.Entity("CERA.Entities.Models.CeraStorageAccount", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResourceGroupName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("tbl_StorageAccounts");
                });

            modelBuilder.Entity("CERA.Entities.Models.CeraSubscription", b =>
                {
                    b.Property<string>("SubscriptionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenantID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubscriptionId");

                    b.ToTable("tbl_Subscription");
                });

            modelBuilder.Entity("CERA.Entities.Models.CeraTenants", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenantId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_Tenants");
                });

            modelBuilder.Entity("CERA.Entities.Models.CeraUsage", b =>
                {
                    b.Property<int?>("UsageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("additionalProperties")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("billingPeriodId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("chargesBilledSeparately")
                        .HasColumnType("bit");

                    b.Property<string>("consumedService")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("instanceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("instanceLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("instanceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isEstimated")
                        .HasColumnType("bit");

                    b.Property<string>("meterDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("meterId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("offerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("partNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("pretaxCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("resourceGuid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("subscriptionGuid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("subscriptionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("usageEnd")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("usageQuantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("usageStart")
                        .HasColumnType("datetime2");

                    b.HasKey("UsageId");

                    b.ToTable("tbl_UsageDetails");
                });

            modelBuilder.Entity("CERA.Entities.Models.CeraVM", b =>
                {
                    b.Property<int>("VMId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RegionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResourceGroupName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VMName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VMId");

                    b.ToTable("tbl_VirtualMachines");
                });

            modelBuilder.Entity("CERA.Entities.Models.CeraWebApps", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResourceGroupName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_WebApps");
                });

            modelBuilder.Entity("CERA.Entities.Models.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClientDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PrimaryAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrimaryPhone")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_Clients");
                });

            modelBuilder.Entity("CERA.Entities.Models.ClientCloudPlugin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClientId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ClientId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClientSecret")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid?>("PlugInId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenantId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId1");

                    b.HasIndex("PlugInId");

                    b.ToTable("tbl_ClientCloudPlugins");
                });

            modelBuilder.Entity("CERA.Entities.Models.CloudPlugIn", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AssemblyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CloudProviderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateEnabled")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DevContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DllPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullyQualifiedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ServiceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupportContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tbl_CloudPlugIns");
                });

            modelBuilder.Entity("CERA.Entities.Models.ClientCloudPlugin", b =>
                {
                    b.HasOne("CERA.Entities.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId1");

                    b.HasOne("CERA.Entities.Models.CloudPlugIn", "PlugIn")
                        .WithMany()
                        .HasForeignKey("PlugInId");

                    b.Navigation("Client");

                    b.Navigation("PlugIn");
                });
#pragma warning restore 612, 618
        }
    }
}

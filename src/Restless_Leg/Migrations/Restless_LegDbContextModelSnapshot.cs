using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Restless_Legs.Models;

namespace Restless_Leg.Migrations
{
    [DbContext(typeof(Restless_LegDbContext))]
    partial class Restless_LegDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Restless_Legs.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.HasKey("LocationId");

                    b.HasAnnotation("Relational:TableName", "Locations");
                });

            modelBuilder.Entity("Restless_Legs.Models.Posting", b =>
                {
                    b.Property<int>("PostingId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<int>("LocationId");

                    b.Property<string>("Title");

                    b.HasKey("PostingId");

                    b.HasAnnotation("Relational:TableName", "Postings");
                });

            modelBuilder.Entity("Restless_Legs.Models.Posting", b =>
                {
                    b.HasOne("Restless_Legs.Models.Location")
                        .WithMany()
                        .HasForeignKey("LocationId");
                });
        }
    }
}

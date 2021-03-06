// <auto-generated />
using CricMaze.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CricMaze.Server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CricMaze.Shared.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Highest")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Matches")
                        .HasColumnType("int");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Runs")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<int>("Wickets")
                        .HasColumnType("int");

                    b.HasKey("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            PlayerId = 1,
                            Country = "India",
                            FirstName = "Virat",
                            Highest = 183,
                            LastName = "Kohli",
                            Matches = 254,
                            Role = 0,
                            Runs = 12123,
                            TeamId = 1,
                            Wickets = 15
                        },
                        new
                        {
                            PlayerId = 2,
                            Country = "India",
                            FirstName = "Jasprit",
                            Highest = 26,
                            LastName = "Bumrah",
                            Matches = 90,
                            Role = 1,
                            Runs = 545,
                            TeamId = 2,
                            Wickets = 165
                        },
                        new
                        {
                            PlayerId = 3,
                            Country = "England",
                            FirstName = "Ben",
                            Highest = 139,
                            LastName = "Stokes",
                            Matches = 152,
                            Role = 2,
                            Runs = 5252,
                            TeamId = 3,
                            Wickets = 145
                        },
                        new
                        {
                            PlayerId = 4,
                            Country = "Australia",
                            FirstName = "David",
                            Highest = 160,
                            LastName = "Warner",
                            Matches = 205,
                            Role = 0,
                            Runs = 8989,
                            TeamId = 4,
                            Wickets = 11
                        },
                        new
                        {
                            PlayerId = 5,
                            Country = "West Indies",
                            FirstName = "Dwayne",
                            Highest = 114,
                            LastName = "Bravo",
                            Matches = 192,
                            Role = 2,
                            Runs = 4258,
                            TeamId = 5,
                            Wickets = 212
                        },
                        new
                        {
                            PlayerId = 6,
                            Country = "India",
                            FirstName = "Rishabh",
                            Highest = 87,
                            LastName = "Pant",
                            Matches = 69,
                            Role = 0,
                            Runs = 2152,
                            TeamId = 6,
                            Wickets = 0
                        },
                        new
                        {
                            PlayerId = 7,
                            Country = "South Africa",
                            FirstName = "Aiden",
                            Highest = 134,
                            LastName = "Markram",
                            Matches = 76,
                            Role = 0,
                            Runs = 2545,
                            TeamId = 7,
                            Wickets = 24
                        },
                        new
                        {
                            PlayerId = 8,
                            Country = "New Zealand",
                            FirstName = "Lockie",
                            Highest = 40,
                            LastName = "Ferguson",
                            Matches = 80,
                            Role = 1,
                            Runs = 824,
                            TeamId = 8,
                            Wickets = 146
                        });
                });

            modelBuilder.Entity("CricMaze.Shared.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            TeamId = 1,
                            TeamName = "RCB"
                        },
                        new
                        {
                            TeamId = 2,
                            TeamName = "Mumbai Indians"
                        },
                        new
                        {
                            TeamId = 3,
                            TeamName = "Rajasthan Royals"
                        },
                        new
                        {
                            TeamId = 4,
                            TeamName = "SRH"
                        },
                        new
                        {
                            TeamId = 5,
                            TeamName = "CSK"
                        },
                        new
                        {
                            TeamId = 6,
                            TeamName = "Delhi Capitals"
                        },
                        new
                        {
                            TeamId = 7,
                            TeamName = "Punjab Kings"
                        },
                        new
                        {
                            TeamId = 8,
                            TeamName = "KKR"
                        });
                });

            modelBuilder.Entity("CricMaze.Shared.Player", b =>
                {
                    b.HasOne("CricMaze.Shared.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });
#pragma warning restore 612, 618
        }
    }
}

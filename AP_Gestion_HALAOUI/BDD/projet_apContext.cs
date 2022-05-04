using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AP_Gestion_HALAOUI.BDD
{
    public partial class projet_apContext : DbContext
    {
        public projet_apContext()
        {
        }

        public projet_apContext(DbContextOptions<projet_apContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ivariable> Ivariables { get; set; }
        public virtual DbSet<Lieuxactivite> Lieuxactivites { get; set; }
        public virtual DbSet<Party> Parties { get; set; }
        public virtual DbSet<Salle> Salles { get; set; }
        public virtual DbSet<Temoignage> Temoignages { get; set; }
        public virtual DbSet<UsersAdmin> UsersAdmins { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }

      
        public void SetConnPriv(string conn)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            optionsBuilder.UseMySql("server=localhost;port=3306;user=root;database=projet_ap;", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.21-mysql"), o => o.CommandTimeout(100));
            }
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4");

            modelBuilder.Entity<Ivariable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ivariables");

                entity.HasIndex(e => e.Cle, "CLE")
                    .IsUnique();

                entity.Property(e => e.Cle)
                    .IsRequired()
                    .HasColumnName("CLE");

                entity.Property(e => e.Val)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("VAL");
            });

            modelBuilder.Entity<Lieuxactivite>(entity =>
            {
                entity.HasKey(e => e.IdLieu)
                    .HasName("PRIMARY");

                entity.ToTable("lieuxactivites");

                entity.Property(e => e.IdLieu).HasColumnName("idLieu");

                entity.Property(e => e.CodePostal).HasColumnType("mediumint");

                entity.Property(e => e.Ville)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Party>(entity =>
            {
                entity.ToTable("parties");

                entity.HasIndex(e => e.IdSalle, "id_salle");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DatePartie)
                    .HasColumnType("datetime")
                    .HasColumnName("date_partie");

                entity.Property(e => e.IdSalle).HasColumnName("id_salle");

                entity.Property(e => e.NbJoueurs).HasColumnName("nb_joueurs");

                entity.Property(e => e.NbObstacle).HasColumnName("nb_obstacle");

                entity.Property(e => e.NomPartie)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("nom_partie");

                entity.Property(e => e.Reussite).HasColumnName("reussite");
            });

            modelBuilder.Entity<Salle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("salles");

                entity.HasIndex(e => e.Localisation, "Localisation");

                entity.HasIndex(e => e.IdSalle, "idSalle")
                    .IsUnique();

                entity.Property(e => e.DescriptionPresentation)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Difficulte).HasColumnName("difficulte");

                entity.Property(e => e.IdSalle)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idSalle");

                entity.Property(e => e.ImagePresentation)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.NomSalle)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.LocalisationNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Localisation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Salles_ibfk_1");
            });

            modelBuilder.Entity<Temoignage>(entity =>
            {
                entity.ToTable("temoignages");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Auteur)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("auteur");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Type)
                    .HasColumnType("enum('Texte','Image')")
                    .HasColumnName("type");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<UsersAdmin>(entity =>
            {
                entity.ToTable("users_admin");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.Property(e => e.MotDePasse)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("mot_de_passe");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("nom");

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("prenom");
            });

            modelBuilder.Entity<Utilisateur>(entity =>
            {
                entity.ToTable("utilisateurs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Grade)
                    .HasColumnType("int")
                    .HasColumnName("grade");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Motdepasse)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("motdepasse");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

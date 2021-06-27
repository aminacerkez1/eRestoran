using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace eRestoran_API.Database
{
    public partial class IB140235Context : DbContext
    {
        public IB140235Context()
        {
        }

        public IB140235Context(DbContextOptions<IB140235Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Jelo> Jelo { get; set; }
        public virtual DbSet<Klijent> Klijent { get; set; }
        public virtual DbSet<Nabavka> Nabavka { get; set; }
        public virtual DbSet<NabavkaNamirnica> NabavkaNamirnica { get; set; }
        public virtual DbSet<NabavkaPice> NabavkaPice { get; set; }
        public virtual DbSet<Namirnica> Namirnica { get; set; }
        public virtual DbSet<Narudzba> Narudzba { get; set; }
        public virtual DbSet<NarudzbaJelo> NarudzbaJelo { get; set; }
        public virtual DbSet<Ocjena> Ocjena { get; set; }
        public virtual DbSet<Pice> Pice { get; set; }
        public virtual DbSet<Rezervacija> Rezervacija { get; set; }
        public virtual DbSet<Uloga> Uloga { get; set; }
        public virtual DbSet<VrstaJela> VrstaJela { get; set; }
        public virtual DbSet<Zaposlenik> Zaposlenik { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=IB140235;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jelo>(entity =>
            {
                entity.Property(e => e.JeloId).HasColumnName("JeloID");

                entity.Property(e => e.Naziv).IsRequired();

                entity.Property(e => e.VrstaJelaId).HasColumnName("VrstaJelaID");

                entity.HasOne(d => d.VrstaJela)
                    .WithMany(p => p.Jelo)
                    .HasForeignKey(d => d.VrstaJelaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Jelo_VrstaJela");
            });

            modelBuilder.Entity<Klijent>(entity =>
            {
                entity.Property(e => e.KlijentId).HasColumnName("KlijentID");

                entity.Property(e => e.Adresa).IsRequired();

                entity.Property(e => e.BrojTelefona).IsRequired();

                entity.Property(e => e.Ime).IsRequired();

                entity.Property(e => e.PasswordHash).IsRequired();

                entity.Property(e => e.PasswordSalt).IsRequired();

                entity.Property(e => e.Prezime).IsRequired();

                entity.Property(e => e.Username).IsRequired();
            });

            modelBuilder.Entity<Nabavka>(entity =>
            {
                entity.Property(e => e.NabavkaId).HasColumnName("NabavkaID");

                entity.Property(e => e.DatumNabavke).HasColumnType("datetime");

                entity.Property(e => e.ZaposlenikId).HasColumnName("ZaposlenikID");

                entity.HasOne(d => d.Zaposlenik)
                    .WithMany(p => p.Nabavka)
                    .HasForeignKey(d => d.ZaposlenikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nabavka_Zaposlenik");
            });

            modelBuilder.Entity<NabavkaNamirnica>(entity =>
            {
                entity.Property(e => e.NabavkaNamirnicaId).HasColumnName("NabavkaNamirnicaID");

                entity.Property(e => e.NabavkaId).HasColumnName("NabavkaID");

                entity.Property(e => e.NamirnicaId).HasColumnName("NamirnicaID");

                entity.HasOne(d => d.Nabavka)
                    .WithMany(p => p.NabavkaNamirnica)
                    .HasForeignKey(d => d.NabavkaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NabavkaNamirnica_Nabavka");

                entity.HasOne(d => d.Namirnica)
                    .WithMany(p => p.NabavkaNamirnica)
                    .HasForeignKey(d => d.NamirnicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NabavkaNamirnica_Namirnica");
            });

            modelBuilder.Entity<NabavkaPice>(entity =>
            {
                entity.Property(e => e.NabavkaPiceId).HasColumnName("NabavkaPiceID");

                entity.Property(e => e.NabavkaId).HasColumnName("NabavkaID");

                entity.Property(e => e.PiceId).HasColumnName("PiceID");

                entity.HasOne(d => d.Nabavka)
                    .WithMany(p => p.NabavkaPice)
                    .HasForeignKey(d => d.NabavkaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NabavkaPice_Nabavka");

                entity.HasOne(d => d.Pice)
                    .WithMany(p => p.NabavkaPice)
                    .HasForeignKey(d => d.PiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NabavkaPice_Pice");
            });

            modelBuilder.Entity<Namirnica>(entity =>
            {
                entity.Property(e => e.NamirnicaId).HasColumnName("NamirnicaID");

                entity.Property(e => e.Naziv).IsRequired();
            });

            modelBuilder.Entity<Narudzba>(entity =>
            {
                entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");

                entity.Property(e => e.DatumNarudzbe).HasColumnType("datetime");

                entity.Property(e => e.KlijentId).HasColumnName("KlijentID");

                entity.Property(e => e.VrijemeNarudzbe).IsRequired();

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Narudzba)
                    .HasForeignKey(d => d.KlijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Narudzba_Klijent");
            });

            modelBuilder.Entity<NarudzbaJelo>(entity =>
            {
                entity.Property(e => e.NarudzbaJeloId).HasColumnName("NarudzbaJeloID");

                entity.Property(e => e.JeloId).HasColumnName("JeloID");

                entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");

                entity.Property(e => e.PrilogJelaId).HasColumnName("PrilogJelaID");

                entity.HasOne(d => d.Jelo)
                    .WithMany(p => p.NarudzbaJelo)
                    .HasForeignKey(d => d.JeloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NarudzbaJelo_Jelo");

                entity.HasOne(d => d.Narudzba)
                    .WithMany(p => p.NarudzbaJelo)
                    .HasForeignKey(d => d.NarudzbaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NarudzbaJelo_Narudzba");

                entity.HasOne(d => d.PrilogJela)
                    .WithMany(p => p.NarudzbaJelo)
                    .HasForeignKey(d => d.PrilogJelaId)
                    .HasConstraintName("FK_NarudzbaJelo_Namirnica");
            });

            modelBuilder.Entity<Ocjena>(entity =>
            {
                entity.Property(e => e.OcjenaId).HasColumnName("OcjenaID");

                entity.Property(e => e.JeloId).HasColumnName("JeloID");

                entity.Property(e => e.KlijentId).HasColumnName("KlijentID");

                entity.Property(e => e.Ocjena1).HasColumnName("Ocjena");

                entity.HasOne(d => d.Jelo)
                    .WithMany(p => p.Ocjena)
                    .HasForeignKey(d => d.JeloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ocjena_Jelo");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Ocjena)
                    .HasForeignKey(d => d.KlijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ocjena_Klijent");
            });

            modelBuilder.Entity<Pice>(entity =>
            {
                entity.Property(e => e.PiceId).HasColumnName("PiceID");

                entity.Property(e => e.Naziv).IsRequired();
            });

            modelBuilder.Entity<Rezervacija>(entity =>
            {
                entity.Property(e => e.RezervacijaId).HasColumnName("RezervacijaID");

                entity.Property(e => e.DatumRezervacije).HasColumnType("datetime");

                entity.Property(e => e.KlijentId).HasColumnName("KlijentID");

                entity.Property(e => e.VrijemeRezervacije).IsRequired();

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Rezervacija)
                    .HasForeignKey(d => d.KlijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezervacija_Klijent");
            });

            modelBuilder.Entity<Uloga>(entity =>
            {
                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.Property(e => e.Naziv).IsRequired();
            });

            modelBuilder.Entity<VrstaJela>(entity =>
            {
                entity.Property(e => e.VrstaJelaId).HasColumnName("VrstaJelaID");

                entity.Property(e => e.Naziv).IsRequired();
            });

            modelBuilder.Entity<Zaposlenik>(entity =>
            {
                entity.Property(e => e.ZaposlenikId).HasColumnName("ZaposlenikID");

                entity.Property(e => e.DatumRodjenja).HasColumnType("datetime");

                entity.Property(e => e.DatumZaposlenja).HasColumnType("datetime");

                entity.Property(e => e.Ime).IsRequired();

                entity.Property(e => e.PasswordHash).IsRequired();

                entity.Property(e => e.PasswordSalt).IsRequired();

                entity.Property(e => e.Prezime).IsRequired();

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.Property(e => e.Username).IsRequired();

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.Zaposlenik)
                    .HasForeignKey(d => d.UlogaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zaposlenik_Uloga");
            });
        }
    }
}

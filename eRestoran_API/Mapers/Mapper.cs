
using AutoMapper;
using eRestoran.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran_API.Mapers
{
    public class Mapper: Profile
    {
        public Mapper()
        {
            CreateMap<Database.Zaposlenik, eRestoran.Model.Zaposlenik>();
            CreateMap<Database.Zaposlenik, ZaposlenikInsertRequest>().ReverseMap();
            CreateMap<Database.Uloga, eRestoran.Model.Uloga>();
            CreateMap<Database.Klijent, eRestoran.Model.Klijent>();
            CreateMap<Database.Klijent, KlijentInsertRequest>().ReverseMap();
            CreateMap<Database.Nabavka, eRestoran.Model.Nabavka>();
            CreateMap<Database.NabavkaPice, eRestoran.Model.NabavkaPice>();
            CreateMap<Database.Pice, eRestoran.Model.Pice>();
            CreateMap<Database.Pice, PiceInsertRequest>().ReverseMap();
            CreateMap<Database.NabavkaNamirnica, eRestoran.Model.NabavkaNamirnica>();
            CreateMap<Database.Namirnica, eRestoran.Model.Namirnica>();
            CreateMap<Database.Namirnica, NamirnicaInsertRequest>().ReverseMap();
            CreateMap<Database.Rezervacija, eRestoran.Model.Rezervacija>();
            CreateMap<Database.Rezervacija, RezervacijaInsertRequest>().ReverseMap();
            CreateMap<Database.Narudzba, eRestoran.Model.Narudzba>();
            CreateMap<Database.Narudzba, NarudzbaInsertRequest>().ReverseMap();
            CreateMap<Database.VrstaJela, eRestoran.Model.VrstaJela>();
            CreateMap<Database.Jelo, eRestoran.Model.Jelo>();
            CreateMap<Database.Jelo, JeloInsertRequest>().ReverseMap();
            CreateMap<Database.NarudzbaJelo, eRestoran.Model.NarudzbaJelo>();
            CreateMap<Database.Nabavka, NabavkaInsertRequest>().ReverseMap();
            CreateMap<Database.NabavkaNamirnica, NabavkaNamirnicaInsertRequest>().ReverseMap();
            CreateMap<Database.NabavkaPice, NabavkaPiceInsertRequest>().ReverseMap();
            

        }

    }
}

using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

namespace FilmesApi.Profiles
{
    public class CinemaProfile: Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDTO, Cinema>();
            CreateMap<Cinema, ReadCinemaDTO>()
                .ForMember(cinemaDto => cinemaDto.ReadEnderecoDto, 
                    opt => opt.MapFrom(cinema => cinema.Endereco));
            CreateMap<UpdateCinemaDTO, Cinema>();
        }
    }
}

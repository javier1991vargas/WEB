using AutoMapper;
using WebApAutores.DTOs;
using WebApAutores.Entidades;

namespace WebApAutores.Utilidades
{
    public class AutoMaperProfiles :Profile
    {
        public AutoMaperProfiles()
        {
            //desde donde queremos mapear-->(AutorCreacionDTOs) y el destino-->(Autor)
            CreateMap<AutorCreacionDTOs, Autor>();
            CreateMap<Autor, AutorDTO>();
            CreateMap<LibroCreacionDTO, Libro>();
            CreateMap<Libro, LibroDTO>();
            CreateMap<ComentariosCreacionDTO,Comentarios>();
            CreateMap<Comentarios, ComentarioDTO>();
         }
    }
}

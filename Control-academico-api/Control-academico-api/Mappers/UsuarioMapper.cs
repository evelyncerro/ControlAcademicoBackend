using Control_academico_api.DTOs;
using Control_academico_api.Models;

namespace Control_academico_api.Mappers;

public static class UsuarioMapper
{
    public static UsuarioDto ToDto(this Usuario entity)
    {
        return new UsuarioDto
        {
            Id = entity.Id,
            Nombre = entity.Nombre,
            Correo = entity.Correo,
            Rol = entity.Rol,
            UserUpdate = entity.UserUpdate ?? "api",

        };
    }

    public static Usuario ToEntity(this UsuarioCreateDto dto)
    {
        return new Usuario
        {
            Nombre = dto.Nombre,
            Correo = dto.Correo,
            Rol = dto.Rol,
            UserInsert = dto.UserInsert ?? "api"
        };
    }
}

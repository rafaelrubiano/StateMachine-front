namespace MudBlazorWebApp1.Client.Models.Dto;

public class SolicitudDto
{
    public int IdSolicitud { get; set; }
    public int IdEstado { get; set; }
    public string UsuarioRed { get; set; }
    public string UsuarioNombre { get; set; }
    public DateTime? Creado { get; set; }
    public List<EstadoDto> Estados { get; set; } = new();
}
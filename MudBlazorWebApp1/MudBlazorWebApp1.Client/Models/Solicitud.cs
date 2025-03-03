using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MudBlazorWebApp1.Client.Models;

public class Solicitud
{
    [Key]
    public int IdSolicitud { get; set; }
    [ForeignKey("Estado")]
    public int IdEstado { get; set; }
    public string UsuarioRed { get; set; }
    public string UsuarioNombre { get; set; }
    public DateTime? Creado { get; set; }
    public List<Estado> Estados { get; set; } = new();
}
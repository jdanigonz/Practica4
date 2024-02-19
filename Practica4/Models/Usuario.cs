using System;
using System.Collections.Generic;

namespace Practica4.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Celular { get; set; }

    public string? CarnetIdentidad { get; set; }

    public string? Direccion { get; set; }
}

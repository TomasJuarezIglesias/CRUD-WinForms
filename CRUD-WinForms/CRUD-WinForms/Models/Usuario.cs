using System;
using System.Collections.Generic;

namespace CRUD_WinForms.Models;

public partial class Usuario
{
    public int Dni { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public DateTime FechaNacimiento { get; set; }

    public int NumeroTelefono { get; set; }
}

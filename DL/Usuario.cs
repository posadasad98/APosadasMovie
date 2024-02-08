﻿using System;
using System.Collections.Generic;

namespace DL;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? ApellidoPaterno { get; set; }

    public string? ApellidoMaterno { get; set; }

    public string? UserName { get; set; }

    public string? Email { get; set; }

    public byte[]? Password { get; set; }

    public int? IdRol { get; set; }

    public string? Nombre { get; set; }

    public virtual Rol? IdRolNavigation { get; set; }
}

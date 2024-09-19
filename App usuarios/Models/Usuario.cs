using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App_usuarios.Models;

public partial class Usuario
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio.")]
    //[StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres.")] Si desea activar validacion por tamaño de texto no comente esta línea
    public string? Nombre { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio.")]
    //[StringLength(50, ErrorMessage = "El apellido no puede exceder los 50 caracteres.")] Si desea activar validacion por tamaño de texto no comente esta línea
    public string? Apellido { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio.")]
    //[RegularExpression(@"\d{8}", ErrorMessage = "El DNI debe tener exactamente 8 dígitos.")] Si desea activar validacion por tamaño de texto no comente esta línea
    public string? Dni { get; set; }
}

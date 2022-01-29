using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



public class TiempoItem
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]

    public string Municipio { get; set; }
    public string Region { get; set; }
    public string Fecha { get; set; }
    public string Temperatura { get; set; }
    public string TempMin { get; set; }
    public string TempMax { get; set; }
    public string TempMedia { get; set; }
    public string VelocidadViento { get; set; }
    public string PrecipitacionAcumulada { get; set; }
    public string Descripcion { get; set; }
    public string PathImg { get; set; }
    public string Latitud { get; set; }
    public string Longitud { get; set; }
    public string Humedad { get; set; }

}





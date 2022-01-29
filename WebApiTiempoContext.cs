using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;


public class WebApiTiempoContext : DbContext
{

    public WebApiTiempoContext(DbContextOptions<WebApiTiempoContext> options)
        : base(options)
    {
    }
    public DbSet<TiempoItem> TiempoItem { get; set; }
    public string connString { get; private set; }
    public WebApiTiempoContext()
    {
       
       // connString = $"Server=(localdb)\\mssqllocaldb;Database=WebApiTiempoContext;Trusted_Connection=True;MultipleActiveResultSets=true";
         connString = $"Server=185.60.40.210\\SQLEXPRESS,58015;Database=DB09Dani;User Id=sa;Password=Pa88word";
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(connString);
    }
}


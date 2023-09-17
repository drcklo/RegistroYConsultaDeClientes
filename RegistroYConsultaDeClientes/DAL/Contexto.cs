using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using RegistroYConsultaDeClientes.Model;
using System.Collections.Generic;
namespace RegistroYConsultaDeClientes.DAL;

public class Contexto: DbContext
{
    public DbSet<Clientes> Clientes { get; set; }

    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {

    }
}

       

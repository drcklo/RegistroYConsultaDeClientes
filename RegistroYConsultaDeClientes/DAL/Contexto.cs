using Microsoft.EntityFrameworkCore;
using RegistroYConsultaDeClientes.Model;
using System.Collections.Generic;
    namespace RegistroYConsultaDeClientes.DAL
{
    public class Contexto: DbContext
    {
public DbSet<Cliente> Clientes { get; set; }

        public Contexto(DbContextOptions<Contexto> options): base(options)
        {
        }
    }
}

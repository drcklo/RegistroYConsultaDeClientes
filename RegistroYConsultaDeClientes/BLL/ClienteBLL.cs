using Microsoft.EntityFrameworkCore;
using RegistroYConsultaDeClientes.DAL;
using RegistroYConsultaDeClientes.Model;

namespace RegistroYConsultaDeClientes.BLL
{
    public class ClienteBLL
    {
        private Contexto _contexto;
        public ClienteBLL(Contexto contexto)
        {
            _contexto = contexto;
        }

        public bool Existe(int? clientesId)
        {
            return _contexto.Clientes
                .Any(e => e.ClienteId == clientesId);
        }
        private bool Insertar(Cliente cliente)
        {
            _contexto.Clientes.Add(cliente);
            return _contexto.SaveChanges() > 0;
        }
        private bool Modificar(Cliente cliente)
        {
            _contexto.Entry(cliente).State = EntityState.Modified;
            return _contexto.SaveChanges() > 0;
        }
        public bool Guardar(Cliente cliente)
        {
            if (!Existe(cliente.ClienteId))
                return Insertar(cliente);
            else
                return Modificar(cliente);
        }
        public bool Eliminar(int? clientesId)
        {
            _contexto.Entry(clientesId).State = EntityState.Deleted;
            return _contexto.SaveChanges() > 0;
        }
        public Cliente? Buscar(int? clientesId)
        {
            return _contexto.Clientes
                .Where(o => o.ClienteId == clientesId)
                .AsNoTracking()
                .SingleOrDefault();
        }
    }
}

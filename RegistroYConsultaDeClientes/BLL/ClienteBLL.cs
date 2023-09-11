using RegistroYConsultaDeClientes.DAL;

namespace RegistroYConsultaDeClientes.BLL
{
    public class ClienteBLL
    {
        private Contexto _contexto;
        public ClienteBLL(Contexto contexto)
        {
            _contexto = contexto;
        }
    }
}

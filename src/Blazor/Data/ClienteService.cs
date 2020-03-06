using Blazor.Client.Data;
using Blazor.Client.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Data
{
    public class ClienteService
    {
        readonly Context _context = new Context();

        public void Add(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            SaveChanges();

        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            var retorno = new List<Cliente>(_context.Clientes);            

            return retorno;
        }

        public Cliente GetById(int id)
        {
            var query = _context.Clientes.Find(id);

            return query;
        }

        public void Update(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            SaveChanges();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}

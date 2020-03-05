using Blazor.Client.Data;
using Blazor.Client.Models;
using System.Collections.Generic;

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

        public IEnumerable<Cliente> GetAll()
        {

            return new List<Cliente>(_context.Clientes);
        }

        public Cliente GetById(int id)
        {

            var query = _context.Clientes.Find(id);

            return query;

        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}

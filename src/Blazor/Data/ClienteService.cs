using Blazor.Client.Data;
using Blazor.Client.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Data
{
    public class ClienteService
    {
        readonly Context _context = new Context();

        /// <summary>
        /// Add cliente to the memory database
        /// </summary>
        /// <param name="cliente">The Cliente object</param>
        public async Task AddAsync(Cliente cliente)
        {            
            await Task.Run(() => _context.Clientes.Add(cliente));

            SaveChanges();

        }

        /// <summary>
        /// Add cliente to the memory database
        /// </summary>
        /// <param name="cliente">The Cliente object</param>
        public void Add(Cliente cliente)
        {
            _context.Clientes.Add(cliente);            
            SaveChanges();

        }

        /// <summary>
        /// Get all Clientes from memory database
        /// </summary>
        /// <returns>A list of all Clientes</returns>
        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            List<Cliente> retorno;

            return await Task.Run(() => retorno =  new List<Cliente>(_context.Clientes));
            
        }

        /// <summary>
        /// Get all Clientes from memory database
        /// </summary>
        /// <returns>A list of all Clientes</returns>
        public IEnumerable<Cliente> GetAll()
        {
            List<Cliente> retorno = new List<Cliente>(_context.Clientes);

            return retorno;

        }

        /// <summary>
        /// Get the Cliente by its ID
        /// </summary>
        /// <param name="id">An integer ID</param>
        /// <returns></returns>
        public Cliente GetById(int id)
        {
            var query = _context.Clientes.Find(id);

            return query;
        }

        /// <summary>
        /// Get the Cliente by its ID
        /// </summary>
        /// <param name="id">An integer ID</param>
        /// <returns></returns>
        public async Task<Cliente> GetByIdAsync(int id)
        {
            Cliente cliente;

            return await Task.Run(() => cliente = _context.Clientes.Find(id));
        }

        /// <summary>
        /// Update the Cliente on memory database
        /// </summary>
        /// <param name="cliente">The Cliente object</param>
        public void Update(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            SaveChanges();
        }

        /// <summary>
        /// Update the Cliente on memory database
        /// </summary>
        /// <param name="cliente">The Cliente object</param>
        public async Task UpdateAsync(Cliente cliente)
        {
            await Task.Run(() => _context.Clientes.Update(cliente));

            SaveChanges();
        }

        /// <summary>
        /// Delete the Client on memory database
        /// </summary>
        /// <param name="cliente">The Cliente object</param>
        public void Delete(Cliente cliente)
        {
            _context.Clientes.Remove(cliente);
            SaveChanges();
        }

        /// <summary>
        /// Delete the Client on memory database
        /// </summary>
        /// <param name="cliente">The Cliente object</param>
        public async Task DeleteAsync(Cliente cliente)
        {
            await Task.Run(() => _context.Clientes.Remove(cliente));

            SaveChanges();
        }

        private int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}

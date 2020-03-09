using Blazor.Client.Models;
using Blazor.Data;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace Blazor.Test
{
    public class CrudTest
    {
        ClienteService _service;
        Cliente _cliente;

        [SetUp]
        public void Setup()
        {
            _service = new ClienteService();
            _cliente = new Cliente
            {
                Celular = "01010101",
                Cpf = "22222",
                Email = "teste",
                Endereco = "teste",
                Id = 1,
                Nome = "teste",
                Rg = "3313131",
                Telefone = "12121221"
            };
        }

        [Test]
        public void Should_Add_Cliente()
        {
            bool hasAdded = AddCliente(_cliente);

            Assert.IsTrue(hasAdded);
        }

        [Test]
        public async Task Should_Add_Cliente_Async()
        {
            bool hasAdded = await AddClienteAsync(_cliente);

            Assert.IsTrue(hasAdded);
        }

        [Test]
        public void Should_Edit_Cliente()
        {
            Cliente novoCliente = _service.GetById(_cliente.Id);

                novoCliente.Celular = "02020202";
                novoCliente.Cpf = "1111";
                novoCliente.Email = "teste2";
                novoCliente.Endereco = "teste2";                
                novoCliente.Nome = "teste2";
                novoCliente.Rg = "3323232";
                novoCliente.Telefone = "32323223";

            bool hasUpdated = EditCliente(novoCliente);

            Assert.IsTrue(hasUpdated);
        }

        [Test]
        public async Task Should_Edit_Cliente_Async()
        {
            Cliente novoCliente = await _service.GetByIdAsync(_cliente.Id);

            novoCliente.Celular = "02020202";
            novoCliente.Cpf = "1111";
            novoCliente.Email = "teste2";
            novoCliente.Endereco = "teste2";
            novoCliente.Nome = "teste2";
            novoCliente.Rg = "3323232";
            novoCliente.Telefone = "32323223";

            bool hasUpdated = await EditClienteAsync(novoCliente);

            Assert.IsTrue(hasUpdated);
        }

        [Test]
        public void Should_FDelete_Cliente()
        {
            Cliente novoCliente = _service.GetById(_cliente.Id);           

            bool hasDeleted = DeleteCliente(novoCliente);

            Assert.IsTrue(hasDeleted);
        }

        [Test]
        public async Task Should_FDelete_Cliente_Async()
        {
            Cliente novoCliente = await _service.GetByIdAsync(_cliente.Id);

            bool hasDeleted = await DeleteClienteAsync(novoCliente);

            Assert.IsTrue(hasDeleted);
        }


        #region Private Methods
        private bool AddCliente(Cliente cliente)
        {
            try
            {
                _service.Add(cliente);

                return true;
            }
            catch (Exception)
            {
                return false;
                
            }
        }

        private async Task<bool> AddClienteAsync(Cliente cliente)
        {
            try
            {
                await _service.AddAsync(cliente);

                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        private bool EditCliente(Cliente cliente)
        {
            try
            {
                _service.Update(cliente);

                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        private async Task<bool> EditClienteAsync(Cliente cliente)
        {
            try
            {
                await _service.UpdateAsync(cliente);

                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        private bool DeleteCliente(Cliente cliente)
        {
            try
            {
                _service.Delete(cliente);

                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        private async Task<bool> DeleteClienteAsync(Cliente cliente)
        {
            try
            {
                await _service.DeleteAsync(cliente);

                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }


        #endregion
    }
}
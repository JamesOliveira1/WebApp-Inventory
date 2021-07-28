using Store.Teste.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace Store.Teste.Data
{
    internal class DbInitializer : CreateDatabaseIfNotExists <StoreDataContext>
    {
        protected override void Seed(StoreDataContext context)
        {
            var epi = new TipoDeProduto() { Nome = "EPI" };
            var informatica = new TipoDeProduto() { Nome = "Informática" };
            var servicos = new TipoDeProduto() { Nome = "Serviços" };
            var equipamento = new TipoDeProduto() { Nome = "Equipamento" };
            var insumos = new TipoDeProduto() { Nome = "Insumos" };
            var outros =  new TipoDeProduto() { Nome = "Outros" };

            var produtos = new List<Produto>() {
                new Produto() { Nome= "Item01", Preco= 70.5M, Quantidade=85, TipoDeProduto = informatica},
                new Produto() { Nome= "Item02", Preco= 23.8M, Quantidade=25, TipoDeProduto = insumos},
                new Produto() { Nome= "Item03", Preco= 345.9M, Quantidade=1, TipoDeProduto = outros},
                new Produto() { Nome= "Item04", Preco= 59.0M, Quantidade=113, TipoDeProduto = servicos},
                new Produto() { Nome= "Item05", Preco= 199.9M, Quantidade=23, TipoDeProduto = equipamento},
                new Produto() { Nome= "Item06", Preco= 25.6M, Quantidade=7, TipoDeProduto = epi}
            };

            context.Produtos.AddRange(produtos);
            context.SaveChanges();
        }
    }
}
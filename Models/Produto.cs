using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Teste.Models
{
    [Table(nameof(Produto))]
    public class Produto:Entity
    {      

        [Required, Column(TypeName ="varchar"), StringLength(100)]
        public string Nome { get; set; }

        [Column(TypeName ="money")]
        public decimal Preco { get; set; }
                
        [Column("Quantidade")]
        public short Quantidade { get; set; }
          
        public int TipoDeProdutoId { get; set; }

        [ForeignKey(nameof(TipoDeProdutoId))]
        public virtual TipoDeProduto TipoDeProduto{ get; set; }

    }
}

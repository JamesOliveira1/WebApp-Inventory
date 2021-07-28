using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Teste.Models
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }

        public DateTime DataCadastro { get; set; } = DateTime.Now;

    }
}

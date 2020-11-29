using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Range(1,10,ErrorMessage ="Valor deve ser entre 1 e 500")]
        public int Quantidade { get; set; }

        public int CategoriaId { get; set; }// chave estrangeira

        public Categoria Categoria { get; set; } // relação de chave entres as tabelas

    }
}

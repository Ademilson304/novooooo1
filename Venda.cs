using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_de_multiplas_janelas
{
    public class Venda
    {
        public int id { get; set; }
        [DisplayName("id do Produto")] public int idProduto { get; set; }
        [DisplayName("Id do Cliente")] public int idCliente { get; set; }
        [DisplayName("Quantidade Vendida")] public int Quantidade { get; set; }
        [DisplayName("Porcentagem de desconto")] public int desconto { get; set; }

    }
}

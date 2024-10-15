using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_de_multiplas_janelas
{
    public class Cliente
    {
        [DisplayName("Id")] public int Id { get; set; }
        [DisplayName("Nome do Cliente")] public int nome { get; set; }
        [DisplayName("Número de Telefone")] public int fone { get; set; }
        [DisplayName("Endereço de E-mail")] public int Email { get; set; }
        [DisplayName("Endereço Fisico")] public int endereco { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaGit.Models
{
    public class AgendaPessoal
    {

        public int AgendaID { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string TelefoneFixo { get; set; }
        public string TelefoneCelular { get; set; }
        public string Email { get; set; }

    }
}
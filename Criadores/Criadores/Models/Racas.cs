using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Criadores.Models {

    /// <summary>
    /// Raça atribuida a um cão
    /// </summary>
    public class Racas {

        /// <summary>
        /// Identificador único de cada uma das Raças
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// identifica o nome da Raça
        /// </summary>
        public string Designacao { get; set; }
    }
}

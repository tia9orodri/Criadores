using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Criadores.Models {
    /// <summary>
    /// Lista de fotografias associadas a um cão
    /// </summary>
    public class Fotografias {

        /// <summary>
        /// Identificador unico da fotografia
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Fotografia de um cão
        /// </summary>
        public string Fotografia { get; set; }

        /// <summary>
        /// Data em que foto foi tirada
        /// </summary>
        public DateTime DataFoto { get; set; }

        /// <summary>
        /// Local onde foto foi tirada
        /// </summary>
        public string LocalFoto { get; set; }
    }
}

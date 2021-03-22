using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Criadores.Models {
    /// <summary>
    /// Identifica um criador 
    /// </summary>
    public class Criadores {

        /// <summary>
        /// Identificador único de um criador
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do Criador
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Nome comercial do criador
        /// </summary>
        public string NomeComercial { get; set; }

        /// <summary>
        /// Morada do criador
        /// </summary>
        public string Morada { get; set; }

        /// <summary>
        /// Codigo Postal do criador
        /// </summary>
        public int CodigoPostal { get; set; }

        /// <summary>
        /// Numero de telemovel do criador
        /// </summary>
        public int Telemovel { get; set; }

        /// <summary>
        /// Email do Criador
        /// </summary>
        public string Email { get; set; }
    }
}

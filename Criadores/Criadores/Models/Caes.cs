using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Criadores.Models {
    /// <summary>
    /// Descrição de cada um dos cães
    /// </summary>
    public class Caes {

        /// <summary>
        /// Identificador único de um cão
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do Cão
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Sexo do cão    
        /// M - Masculino
        /// F - Feminino
        /// </summary>
        public string Sexo { get; set; }

        /// <summary>
        /// Data de nascimento do cão
        /// </summary>
        public DateTime DataNasc { get; set; }

        /// <summary>
        /// Data de compra do cão
        /// </summary>
        public DateTime DataCompra { get; set; }

        /// <summary>
        /// Identificador LOP de um cão
        /// </summary>
        public string LOP { get; set; }

        //**************************************************************************

        /// <summary>
        /// FK para a raça do cão
        /// </summary>
        [ForeignKey("Raça")] //esta anotação indica que o atributo 'RACAFK' está a executar o mesmo que o atributo 'Raca', e que representa uma FK para
                                //a classe Raca
        public int RacaFK { get; set; } //atributo para usar no SGBD e no C#. Representa a FK para aRaça do cão
        public Racas Raca { get; set; } //atributo para ser usado no C#. Representa a FK para a Raça do cão
    }
}

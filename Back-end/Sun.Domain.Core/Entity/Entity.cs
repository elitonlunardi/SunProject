using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sun.Domain.Core
{
    /// <summary>
    /// Entidade base.
    /// </summary>
    public class Entity
    {
        /// <summary>
        /// Guid da entidade
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        /// <summary>
        /// Data de cadastro
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// Data de atualização
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// Compara dois objetos pelo Id
        /// </summary>
        /// <param name="obj">Objeto para ser comparado</param>
        /// <returns><seealso cref="bool"/> com true se os objetos forem iguais</returns>
        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity;

            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            return Id.Equals(compareTo.Id);
        }


    }
}

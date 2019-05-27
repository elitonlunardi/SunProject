using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Sun.Domain.Core;

namespace Sun.Domain
{

    /// <summary>
    /// Entidade Cidade
    /// </summary>
    public class City : Entity
    {
        /// <summary>
        /// Nome da cidade
        /// </summary>
        [MaxLength(150)]
        public string Name { get; set; }

        /// <summary>
        /// Lista de temperaturas da cidade
        /// </summary>
        public ICollection<Weather> Weathers { get; set; }

        /// <summary>
        /// Construtor para ser criado uma entidade Cidade
        /// </summary>
        /// <param name="name">Nome da
        /// cidade</param>
        /// <param name="weathers">Lista de temperaturas</param>
        public City(string name, ICollection<Weather> weathers)
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.Now;
            Name = name;
            Weathers = weathers;
        }
        /// <summary>
        /// Construtor sem parâmetros protected para o entity
        /// </summary>
        protected City() { }
    }
}

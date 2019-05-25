using System.Collections;
using System.Collections.Generic;
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
        public string Name { get; set; }
        /// <summary>
        /// Lista de temperaturas da cidade
        /// </summary>
        public ICollection<Weather> Weathers { get; set; }

        /// <summary>
        /// Construtor para ser criado uma entidade Cidade
        /// </summary>
        /// <param name="name">Nome da cidade</param>
        /// <param name="weathers">Lista de temperaturas</param>
        public City(string name, ICollection<Weather> weathers)
        {
            Name = name;
            Weathers = weathers;
        }
        /// <summary>
        /// Construtor sem parâmetros protected para o entity
        /// </summary>
        protected City() { }
    }
}

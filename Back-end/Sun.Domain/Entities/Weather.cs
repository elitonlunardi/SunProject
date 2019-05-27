using System;
using Sun.Domain.Core;

namespace Sun.Domain
{
    /// <summary>
    /// Entidade de Temperatura
    /// </summary>
    public class Weather : Entity
    {
        /// <summary>
        /// Data da temperatura.
        /// </summary>
        public DateTime Date { get; set; }

        public double Media { get; set; }

        public Guid CityId { get; set; }
        public virtual City City { get; set; }

        /// <summary>
        /// Construtor para ser criado uma entidade Temperatura.
        /// </summary>
        /// <param name="date">Data da temperatura</param>
        public Weather(DateTime date, double weather)
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.Now;
            Date = date;
            Media = weather;
        }

        /// <summary>
        /// Construtor sem parâmetros protected para o entity.
        /// </summary>
        protected Weather() { }

    }



}
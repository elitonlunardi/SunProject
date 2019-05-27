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
        /// <summary>
        /// Temperatura mínima do dia.
        /// </summary>
        public double Minimum { get; set; }
        /// <summary>
        /// Temperatura máxima do dia.
        /// </summary>
        public double Maximum { get; set; }

        public Guid CityId { get; set; }
        public virtual City City { get; set; }

        /// <summary>
        /// Construtor para ser criado uma entidade Temperatura.
        /// </summary>
        /// <param name="date">Data da temperatura</param>
        /// <param name="minimum">Temperatura mínima do dia.</param>
        /// <param name="maximum">Temperatura máxima do dia.</param>
        public Weather(DateTime date, double minimum, double maximum)
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.Now;
            Date = date;
            Minimum = minimum;
            Maximum = maximum;
        }
        /// <summary>
        /// Construtor sem parâmetros protected para o entity.
        /// </summary>
        protected Weather() { }

    }



}
using System;

namespace Sun.Application
{
    public class CityViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }

        public CityViewModel()
        {
            CreationDate = DateTime.Now;
        }
    }
}

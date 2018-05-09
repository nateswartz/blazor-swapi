using System.Collections.Generic;

namespace NateSwartz.Blazor.SwApi.Models
{
    public class PeopleResponse
    {
        public int count { get; set; }
        public List<Person> results { get; set; }
        public string next { get; set; }
    }

    public class Person
    {
        public string name { get; set; }
        public string hair_color { get; set; }
        public string image { get; set; }
        public string[] species { get; set; }
        public string species_name { get; set; }
    }
}

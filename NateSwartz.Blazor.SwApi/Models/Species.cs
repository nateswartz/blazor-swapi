using System.Collections.Generic;

namespace NateSwartz.Blazor.SwApi.Models
{
    public class SpeciesResponse
    {
        public int count { get; set; }
        public List<Species> results { get; set; }
        public string next { get; set; }
    }

    public class Species
    {
        public string name { get; set; }
        public string classification { get; set; }
        public string designation { get; set; }
        public string average_height { get; set; }
        public string skin_colors { get; set; }
        public string language { get; set; }

    }
}

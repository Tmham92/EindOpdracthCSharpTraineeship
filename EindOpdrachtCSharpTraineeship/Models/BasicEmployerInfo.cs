using System.Collections.Generic;

namespace EindOpdrachtCSharpTraineeship
{
    public class BasicEmployerInfo
    {
        bool HasProjectPosted { get; set; }
        int ID { get; set; }
        string Name { get; set; }
        List<int> ProjectList { get; set; }
    }
}
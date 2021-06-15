using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppMVC5DI
{
    
    public interface IDrugiService
    {
        string ZrobCos(string s);
    }

    public class DrugiService : IDrugiService
    {
        public string ZrobCos(string s)
        {
            return $"Robie cos: {s}";
        }
    }
}

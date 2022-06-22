using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace tpn7.EF.Logic.PokeApi
{
    public class PokeLogic
    {
        public async Task<string> Pikachu()
        {
            var httpClient = new HttpClient();
            return await httpClient.GetStringAsync("https://pokeapi.co/api/v2/pokemon/pikachu");
            

        }
    }
}

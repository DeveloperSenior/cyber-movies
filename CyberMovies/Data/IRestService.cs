using System.Collections.Generic;
using System.Threading.Tasks;

namespace CyberMovies
{
	public interface IRestService
	{
		Task<List<PokemonItem>> RefreshDataAsync (string pokemon);

	}
}

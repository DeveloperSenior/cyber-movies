using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CyberMovies
{
	public class PokemonItemManager
	{
		IRestService restService;

		public PokemonItemManager (IRestService service)
		{
			restService = service;
		}

		public Task<List<PokemonItem>> GetTasksAsync (string pokemon = "all")
		{
			return restService.RefreshDataAsync (pokemon);	
		}

	}
}

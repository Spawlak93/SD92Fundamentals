using _10_IntroToAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroToAPI
{
    class SWAPIService
    {
        //Creating a client to send and recieve HTTP messages
        private readonly HttpClient _httpClient = new HttpClient();

        //Get Person
        public async Task<Person> GetPersonAsync(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                Person person = await response.Content.ReadAsAsync<Person>();
                return person;
            }

            //If not success code
            return null;
        }

        //Get Film
        public async Task<Film> GetFilmAsync(string url)
        {
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsAsync<Film>();

            return null;
        }

        //Generic Get
        public async Task<T> GetAsync<T>(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                //We can pass T in for our type
                return await response.Content.ReadAsAsync<T>();
            }

            //Cant return null because not all types are nullable
            return default;
        }

        public async Task<SearchResult<T>> GetSearchResultAsync<T>(string category, string query)
        {
            HttpResponseMessage response = await _httpClient.GetAsync("https://swapi.dev/api/" + category + "/?search=" + query);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<SearchResult<T>>();
            }

            return default;
        }

        public async Task<SearchResult<Person>> GetPersonSearchAsync(string query)
        {
            return await GetSearchResultAsync<Person>("people", query);
        }
    }
}

using _10_IntroToAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroToAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();
            Console.ReadLine();

            //Creating our Task
            Task<HttpResponseMessage> responseTask = httpClient.GetAsync("https://swapi.dev/api/people/2");
            //Running task for results

            HttpResponseMessage response = responseTask.Result;


            if (response.IsSuccessStatusCode)
            {
                //Creating and running together. 
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);

                Person person = response.Content.ReadAsAsync<Person>().Result;

                Console.WriteLine(person.Height);
                Console.WriteLine(person.Name);

                foreach (string filmUrl in person.Films)
                {
                    HttpResponseMessage filmResponse = httpClient.GetAsync(filmUrl).Result;

                    if (filmResponse.IsSuccessStatusCode)
                    {
                        Film film = filmResponse.Content.ReadAsAsync<Film>().Result;

                        Console.WriteLine(film.Title);
                    }
                }

            }

            //Person personTwo = httpClient.GetAsync("https://swapi.dev/api/people/1").Result.Content.ReadAsAsync<Person>().Result;
            SWAPIService service = new SWAPIService();
            Person personTwo = service.GetPersonAsync("https://swapi.dev/api/people/1").Result;
            if (personTwo != null)
            {
                Console.WriteLine(personTwo.Name);
                foreach (string filmUrl in personTwo.Films)
                {
                    Film film = service.GetFilmAsync(filmUrl).Result;
                    Console.WriteLine(film.Title);
                }
            }


            Person personThree = service.GetAsync<Person>("https://swapi.dev/api/people/3").Result;
            var filmTwo = service.GetAsync<Film>("https://swapi.dev/api/films/3").Result;

            SearchResult<Person> skywalkers = service.GetSearchResultAsync<Person>("people", "skywalker").Result;

            SearchResult<Person> organas = service.GetPersonSearchAsync("organa").Result;
            while (true)
            {
                Console.WriteLine("Who would you like to search for");
                string lookup = Console.ReadLine();

                var searchResult = service.GetPersonSearchAsync(lookup).Result;
                foreach (Person person in searchResult.Results)
                {
                    Console.WriteLine(person.Name);
                }

            }


        }
    }
}

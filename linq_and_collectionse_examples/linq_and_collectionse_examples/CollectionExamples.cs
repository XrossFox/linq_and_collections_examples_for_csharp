using System.Collections;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace linq_and_collectionse_examples
{
    class CollectionExamples
    {
        private readonly HttpClient client = new HttpClient();

        public async Task arrayListExample() {
            ArrayList arrayList = new ArrayList();

            Console.WriteLine("Looking for some jokes...");

            for (int i = 0; i < 5; i++) {
                try
                {
                    var response = await client.GetStringAsync("https://api.chucknorris.io/jokes/random");
                    var values = JsonConvert.DeserializeObject<Dictionary<string, Object>>(response);
                    arrayList.Add(values["value"]);
                }
                catch (HttpRequestException e) {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }
            }

            Console.WriteLine("Jokes retrieved!");
            Console.WriteLine("Total Size of array: {0}", arrayList.Capacity);
            Console.WriteLine("Total Jokes: {0}", arrayList.Count);
            Console.WriteLine("The jokes are:");

            foreach (var i in arrayList) {
                Console.WriteLine(i);
            }

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        public async Task listExample() {
            
            List<string> listOfJokes = new List<string>();
            Console.WriteLine("Hai hai! Looking for more jokes");
            for(int i = 0; i < 5; i++) {
                try
                {
                    string response = await client.GetStringAsync("https://api.chucknorris.io/jokes/random");
                    Dictionary<string, Object> values = JsonConvert.DeserializeObject<Dictionary<string, Object>>(response);
                    listOfJokes.Add(values["value"].ToString());
                }
                catch (HttpRequestException e) {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }
            }

            Console.WriteLine("There are {0} Jokes.", listOfJokes.Count);

            foreach (string s in listOfJokes) {
                Console.WriteLine(s);
            }

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

    }
}

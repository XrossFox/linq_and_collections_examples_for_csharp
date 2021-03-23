using System;
using System.Threading.Tasks;

namespace linq_and_collectionse_examples
{
    class Program
    {
        private static readonly CollectionExamples examples = new CollectionExamples();
        
        static async Task Main(string[] args)
        {
            await examples.arrayListExample();
            await examples.listExample();
        }
    }
}

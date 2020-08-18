using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Story politicStory = new Story("New President", "Kanye West is the new President of the USA", "column"); 
            Story healthStory = new Story("Coronavirus", "Coronavirus is defeated", "research paper");
            Story gossipStory = new Story("Celebrity in Love", "Madonna has a new boyfriend", "review");
            Story[] _stories = {politicStory, healthStory, gossipStory};
            for (int i = 0; i < _stories.Length; i++)
            {
                Console.WriteLine(_stories[i]);
            }
           
            
            Newspaper n = new Newspaper();
            
            float newPrice = 50;
            n.SetPrice(newPrice);
            n.GetPrice();
            n.SetStories(_stories);
            n.GetStories();
            n.Read();
            Console.WriteLine(n);
            
            

                
        }
    }
}

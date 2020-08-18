using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    public class Newspaper
    {
        private Story[] _stories;
        private float price;
        

        public Story[] GetStories()
        {
            return this._stories;
        }
        public void SetStories(Story [] _stories) 
        {
            this._stories = _stories;
        }
        public float GetPrice()
        {
            return this.price;
        }
        public void SetPrice(float newPrice)
        {
            if (newPrice > 0)
            {
                this.price = newPrice;

            }
            else
            {
                Console.WriteLine("illegal price");
            }
            
        }
        public void Read()
        {
            Console.WriteLine($"Reading {_stories}");
        }

        

        public override string ToString()
        {
            return $"{base.ToString()} sories : {_stories}, price : {price} ";
        }
    }
}

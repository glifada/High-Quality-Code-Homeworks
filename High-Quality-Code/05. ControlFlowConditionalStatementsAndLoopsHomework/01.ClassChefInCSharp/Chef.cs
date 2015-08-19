// Refactor the following class using best practices for organizing straight-line code:

using System;

namespace _01.ClassChefInCSharp
{
    public class Chef
    {
        public void Cook()
        {
            Potato potato = GetPotato();
            Peel(potato);
            Cut(potato);

            Bowl bowl = GetBowl();
            bowl.Add(potato);

            Carrot carrot = GetCarrot();
            Peel(carrot);
            Cut(carrot);            
            bowl.Add(carrot);
        }

        private Potato GetPotato()
        {
            //...
        }

        private Carrot GetCarrot()
        {
            //...
        }
        
        private void Cut(Vegetable potato)
        {
            //...
        }

        private Bowl GetBowl()
        {
            //... 
        }                   
    }
}

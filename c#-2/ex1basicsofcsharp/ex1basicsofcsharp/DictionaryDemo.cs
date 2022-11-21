using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1basicsofcsharp
{
    internal class DictionaryDemo
    {
       public static void dicdemo1()
        {
            IDictionary<int,String> numberNames=new Dictionary<int,String>();
            numberNames.Add(1, "One");
            numberNames.Add(3, "Three");
            numberNames.Add(2, "Two");
            foreach(KeyValuePair<int,String> kvp in numberNames)
                Console.WriteLine("Key:{0},Value:{1}",kvp.Key,kvp.Value);
            var cities = new Dictionary<String, String>()
            {
                {"UK","London,Manchester,Birmingham" },
                {"USA","Chicago,New York,Washington" },
                {"India","Mumbai,New Delhi,Pune" }
            };
            foreach (var kvp in cities)
                Console.WriteLine("key:{0},value:{1}",kvp.Key,kvp.Value);
        }
        public static void dicdemo2()
        {
            var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };
            Console.WriteLine("ACCESSING");
            Console.WriteLine(cities["UK"]); 
            Console.WriteLine(cities["USA"]);
                                             
            
            Console.WriteLine("---access elements using for loop---");
           
            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",cities.ElementAt(i).Key,cities.ElementAt(i).Value);
            }
        }
        public static void dicdemo3() 
        {
            var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };

            cities["UK"] = "Liverpool, Bristol"; // update value of UK key
            cities["USA"] = "Los Angeles, Boston"; // update value of USA key
                                                   //cities["France"] = "Paris"; //throws run-time exception: KeyNotFoundException

            Console.WriteLine("UPDATE");
            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value:{1}", kvp.Key, kvp.Value);
        }
        public static void dicdemo4()
        {
            var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };
            Console.WriteLine("REMOVE");
            Console.WriteLine("Total Elements: {0}", cities.Count);

            cities.Remove("UK"); // removes UK 
                                 //cities.Remove("France"); //throws run-time exception: KeyNotFoundException

            if (cities.ContainsKey("France"))
            { // check key before removing it
                cities.Remove("France");
            }

            Console.WriteLine("Total Elements: {0}", cities.Count);

            cities.Clear(); //deletes all elements

            Console.WriteLine("Total Elements after Clear(): {0}", cities.Count);
        }
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wzorce_Projektowe.Observer;
using Wzorce_Projektowe.Iterator;
using Wzorce_Projektowe.MediatorSpace;
using Wzorce_Projektowe.Prototype;
using System.Net.NetworkInformation;
using Wzorce_Projektowe.Strategy;
using Wzorce_Projektowe.Template_Method;

namespace Wzorce_Projektowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WeatherData weather = new();
            //CurrentConditions current = new(weather);
            //StatisticsDisplay statistics = new(weather);
            //weather.Notify(new(weather.GetHumidity(), weather.GetTemperature(), weather.GetPressure()));
            //current.Display();
            //statistics.DisplayStats();
            //Task.Delay(1000).Wait();
            //weather.Notify(new(weather.GetHumidity(), weather.GetTemperature(), weather.GetPressure()));
            //current.Display();
            //statistics.DisplayStats();

            //List<TreeNode> nodes = [new(1), new(3), new(2)];
            //nodes[0].Left = nodes[2];
            //nodes[0].Right = nodes[1];
            ////BinaryTree2 tree = new(nodes);
            ////foreach (TreeNode i in tree)
            ////    Console.WriteLine(i.Val);
            //BinaryTree tree1 = new(nodes);
            //Console.WriteLine(tree1.GetNext().Val);
            //Console.WriteLine(tree1.GetNext().Val);


            //OrderProcesser processer = new();
            //OrderReceiver receiver = new();
            //OrderVerifier verifier = new();
            //OrderLogger logger = new OrderLogger();

            //Mediator mediator = new(receiver, verifier, processer, logger);
            //receiver.Mediator = mediator;
            //verifier.Mediator = mediator;
            //processer.Mediator = mediator;

            //receiver.ReceiveOrder();
            //verifier.VerifyOrder();
            //List<Multimedia> myMultimedia = [];
            //myMultimedia.Add(new Picture("1"));
            //myMultimedia.Add(new Music("2"));
            //myMultimedia.Add(new Movie("3"));

            //List<Multimedia> multimediaCopy = [];

            //foreach (var item in myMultimedia)
            //    multimediaCopy.Add(item.Clone());

            //myMultimedia.Add(new Picture("4"));
            //foreach (var item in multimediaCopy)
            //    Console.WriteLine(item.ToString());

            int[] arr1 = new int[9];
            int[] arr2 = new int[99];
            int[] arr3 = new int[101];
            Console.WriteLine(Context.GetContext(arr1));
            Console.WriteLine(Context.GetContext(arr2));
            Console.WriteLine(Context.GetContext(arr3));

            FightingPokemon pokemon = new FightingPokemon("test", 100, 20, 30);
            PoisonPokemon pokemon2 = new PoisonPokemon("test2", 100, 20, 30);
            Console.WriteLine(pokemon.CalcDamage());
            Console.WriteLine(pokemon2.CalcDamage());


        }
    }
}

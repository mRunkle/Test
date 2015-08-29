﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileNews_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Server & Connection creation
            Server phoneServer = new Server();
            Connection phoneServerConnection = new Connection(phoneServer);

            //News Feed creation
            PoliticalNewsFeed politicalNewsFeed = new PoliticalNewsFeed("A political story");
            phoneServerConnection.AddNewsFeed(politicalNewsFeed);
            SportsNewsFeed sportsNewsFeed = new SportsNewsFeed("A sports story");
            phoneServerConnection.AddNewsFeed(sportsNewsFeed);

            //Phone creation
            const int numberOfPhones = 3;

            List<Phone> phoneList = new List<Phone>();
            for (int i = 0; i < numberOfPhones; i++)
            {
                Phone phone = new Phone(i);
                phoneList.Add(phone);
            }

            //Create subscriptions
            phoneList[0].Subscribe(new PoliticalSubscription(new Subscription()));
            phoneList[1].Subscribe(new SportsSubscription(new Subscription()));
            phoneList[2].Subscribe(new PoliticalSubscription(new SportsSubscription(new Subscription())));

            //print each phones subscriptions
            Console.WriteLine("Phone Subscriptions");
            Console.WriteLine("-------------------");

            for (int i = 0; i < phoneList.Count; i++)
            {
                foreach (Subscription subscription in phoneList[i].PhoneSubscriptionList)
                {
                    Console.WriteLine("Phone " + i + " >> " + subscription.Description());
                }
            }

            //Connection add phones to server
            for (int i = 0; i < phoneList.Count; i++)
            {
                foreach (Subscription subscription in phoneList[i].PhoneSubscriptionList)
                {
                    phoneServerConnection.AddPhoneToServer(phoneList[i]);
                }
            }

            //print total subscriptions on server
            Console.WriteLine(Environment.NewLine + "Subscriptions on Server");
            Console.WriteLine("-----------------------");

            Console.WriteLine(phoneServer.TotalSubscriptions);
            Console.ReadLine();



            //UPDATER - random news page updates
            Random rnd = new Random();
            int randomSelectPagesToUpdate = rnd.Next(0, 3);

            Console.WriteLine("(random number used for update generation: " + randomSelectPagesToUpdate + ")");
            Console.WriteLine(Environment.NewLine);

            if (randomSelectPagesToUpdate == 0)
            {

            }
            else if (randomSelectPagesToUpdate % 2 == 0)
            {
                for (int i = 0; i < phoneServerConnection.NewsFeedList.Count; i += 2)
                {
                    phoneServerConnection.NewsFeedList[i].Content = "A new " + phoneServerConnection.NewsFeedList[i].PageName + " story.";
                    phoneServerConnection.NewsFeedList[i].NewContent = true;
                }
            }
            else
            {
                for (int i = 1; i < phoneServerConnection.NewsFeedList.Count; i += 2)
                {
                    phoneServerConnection.NewsFeedList[i].Content = "A new " + phoneServerConnection.NewsFeedList[i].PageName + " story.";
                    phoneServerConnection.NewsFeedList[i].NewContent = true;
                }
            }

            //DOES NEW CONTENT EXIST?
            foreach (NewsFeed newsFeed in phoneServerConnection.NewsFeedList)
            {
                Console.WriteLine(newsFeed.PageName + " new content: " + newsFeed.NewContent);
            }

            Console.WriteLine(Environment.NewLine);


            //WRITE PAGE CONTENT
            foreach (NewsFeed newsFeed in phoneServerConnection.NewsFeedList)
            {
                Console.WriteLine(newsFeed.Content);
            }


            //DEBUG
            Subscription testSubscription = new PoliticalSubscription(new SportsSubscription(new Subscription()));
            Console.WriteLine(Environment.NewLine + testSubscription.Description());


            Console.ReadLine();
        }
    }
}

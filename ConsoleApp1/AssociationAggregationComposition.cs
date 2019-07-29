using System;
using System.Collections.Generic;
using System.Text;

//https://medium.com/@ibrahimyengue/association-aggregation-and-composition-in-c-8cbeaa81201d

namespace ConsoleApp1
{
    class AssociationAggregationComposition
    {
        class Manager
        {
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;   
                }
            }

            private string name;
            

            public Manager(string name)
            {
                this.name = name;
            }

            public void logon(SwipeCard sc)
            {
                sc.Swipe(this);
            }

            //aggregation 
            List<Worker> list = new List<Worker>();

            //composition
            public Project project;
            public Manager()
            {
                project = new Project(this);
            }
            public double salary;
            

            public void Performance( bool p)
            {
                if (p == true)
                    project.isgood = true;
                else
                    project.isgood = false;
            }

        }

        class SwipeCard
        {
            private string card;

            public SwipeCard()
            {

            }
            public SwipeCard(string card)
            {
                this.card = card;
            }

            public string Card
            {
                get
                {
                    return Card;
                }
            }

            public void Swipe(Manager manager)
            {
                Console.WriteLine(manager.Name + " swiped card.");
            }
        }

        class Worker
        {
            private string name;

            public Worker() { }
            public Worker(string name) { this.name = name; }
            public string Name
            {
                get
                {
                    return name;
                }
      
            }
        }

        class Project
        {
            private Manager manager;
            public  bool isgood = false;
            public Project (Manager manager)
            {
                this.manager = manager;
            }

            public bool Isgood
            {
                get { return isgood; }
                set { isgood = value;
                    if (value)
                        this.manager.salary++;
                    else
                        this.manager.salary--;
                }
            }
        }

        public void runCode()
        {
            Manager manager = new Manager("Bob");
            SwipeCard card = new SwipeCard("Oza18");
            

            //association 
            manager.logon(card);
            card.Swipe(manager);

            //composition
            manager.Performance(true);
            Project project = new Project(manager);

        }

    }
}

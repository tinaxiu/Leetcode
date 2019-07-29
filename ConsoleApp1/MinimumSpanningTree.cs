using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    class MinimumSpanningTree
    {
        public void runCode()
        {
            Connection c1 = new Connection("A", "D", 1);
            Connection c2 = new Connection("A", "B", 3);
            Connection c3 = new Connection("D", "B", 3);
            Connection c4 = new Connection("B", "C", 1);
            Connection c5 = new Connection("C", "D", 1);
            Connection c6 = new Connection("E", "D", 6);
            Connection c7 = new Connection("C", "E", 5);
            Connection c8 = new Connection("C", "F", 4);
            Connection c9 = new Connection("E", "F", 2);
            List<Connection> list = new List<Connection>();
            list.Add(c1);
            list.Add(c2);
            list.Add(c3);
            list.Add(c4);
            list.Add(c5);
            list.Add(c6);
            list.Add(c7);
            list.Add(c8);
            list.Add(c9);

            List<Connection> result = findMinimum(list);
            
        }
        public class Connection
        {
            public string city1;
            public string city2;
            public int cost;
            public Connection(string a, string b, int c)
            {
                city1 = a;
                city2 = b;
                cost = c;
            }
        }  

        public class UnionFind
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            int setNum;
            public UnionFind()
            {
                map = new Dictionary<string, int>();
                setNum = 0;
            }

            public bool union(Connection con)
            {
                if (!map.ContainsKey(con.city1) && !map.ContainsKey(con.city2))
                {
                    map.Add(con.city1, setNum);
                    map.Add(con.city2, setNum);
                    setNum++;
                    return true;
                }

                if(map.ContainsKey(con.city1) && !map.ContainsKey(con.city2))
                {
                    map.Add(con.city2, map[con.city1]);
                    return true;
                }

                if(map.ContainsKey(con.city2) && !map.ContainsKey(con.city1))
                {
                    map.Add(con.city1, map[con.city2]);
                    return true;
                }

                if (map.ContainsKey(con.city2) && map.ContainsKey(con.city1))
                {
                    if (map[con.city1] == map[con.city2])
                        return false;

                    for (int i =0; i< map.Count; i++)
                    {
                        List<string> cities = new List<string>();
                        foreach (string city in map.Keys)
                            if (map[city] == map[con.city1])
                                cities.Add(city + " " + con.city2);
                        foreach (string city in cities)
                        {
                            map[city.Split(" ")[0]] = map[city.Split(" ")[1]];
                        }
                            
                    }
                    return true;

                }
                return true;
            }
        }
        public List<Connection> findMinimum(List<Connection> list)
        {
            List<Connection> res = new List<Connection>();
            if (list == null || list.Count == 0)
                return res;

            UnionFind uf = new UnionFind();

            list.Sort(
                delegate (Connection c1, Connection c2)
                {
                    int comapre = c1.cost.CompareTo(c2.cost);
                    if (comapre == 0)
                    {
                        return c2.cost.CompareTo(c1.cost);
                    }
                    return comapre;
                }
                );
            foreach (Connection c in list)
            {
                if (uf.union(c))
                    res.Add(c);
            }

            res.Sort(
                delegate (Connection c1, Connection c2)
                {
                    int comapre = c1.cost.CompareTo(c2.cost);
                    if (comapre == 0)
                    {
                        return c2.cost.CompareTo(c1.cost);
                    }
                    return comapre;
                }
                );
            return res;


        }
    }
}

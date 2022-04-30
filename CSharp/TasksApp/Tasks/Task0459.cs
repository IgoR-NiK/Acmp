using System;
using System.Collections.Generic;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 459 - "Нить Ариадны"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 49%)
    /// 
    /// Тезею из лабиринта Минотавра помог выйти клубок ниток. Вы можете вместо клубка использовать персональный компьютер.
    /// Требуется написать программу, которая вводит маршрут Тезея в лабиринте и находит кратчайший обратный путь, 
    /// по которому Тезей сможет выйти из лабиринта, не заходя в тупики и не делая петель.
    /// 
    /// Входные данные
    /// Входной файл INPUT.TXT содержит маршрут Тезея, который представлен строкой, состоящей из букв: N, S, W, E и длиной от 1 до 200.
    /// 
    /// Буквы означают:
    /// N - один "шаг" на север,
    /// S - один "шаг" на юг,
    /// W - один "шаг" на запад,
    /// E - один "шаг" на восток.
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT записывается аналогично входному файлу найденный обратный путь. 
    /// Если маршрут неоднозначен, то следует выбирать согласно следующему приоритету: N, E, S, W. 
    /// </summary>   
    public class Task0459
    {
        private static readonly List<Node> Nodes = new List<Node>();

        public static void Main()
        {
            GetInputData(out var input);

            var result = Solve(input);

            PrintResult(result);
        }

        private static void GetInputData(out string input)
        {
            input = Console.ReadLine();
        }

        public static string Solve(string input)
        {
            var startI = 0;
            var startJ = 0;

            // Устанавливаем связи между квадратами, по которым можно идти  
            var i = 0;
            var j = 0;
            foreach (var ch in input)
            {        
                var foundNode = GetNodeByCoordinates(i, j);
                Node nextNode;
                switch (ch)
                {
                    case 'N':                        
                        i--;
                        nextNode = GetNodeByCoordinates(i, j);
                        foundNode.NodeNorth = nextNode;
                        nextNode.NodeSouth = foundNode;
                        break;
                    case 'S':
                        i++;
                        nextNode = GetNodeByCoordinates(i, j);
                        foundNode.NodeSouth = nextNode;
                        nextNode.NodeNorth = foundNode;
                        break;
                    case 'W':
                        j--;
                        nextNode = GetNodeByCoordinates(i, j);
                        foundNode.NodeWest = nextNode;
                        nextNode.NodeEast = foundNode;
                        break;
                    case 'E':
                        j++;
                        nextNode = GetNodeByCoordinates(i, j);
                        foundNode.NodeEast = nextNode;
                        nextNode.NodeWest = foundNode;
                        break;
                }
            }

            var finishI = i;
            var finishJ = j;

            // Помечаем стартовую ячейку = 1
            var d = 1;
            SetNodeDistanceFromCenter(startI, startJ, d);

            // Распространение волны
            do
            {
                foreach (var node in GetNodesWithDistanceFromCenter(d))
                {
                    if (node.NodeNorth != null && node.NodeNorth.DistanceFromCenter == 0)
                    {
                        node.NodeNorth.DistanceFromCenter = d + 1;
                    }
                    if (node.NodeSouth != null && node.NodeSouth.DistanceFromCenter == 0)
                    {
                        node.NodeSouth.DistanceFromCenter = d + 1;
                    }
                    if (node.NodeEast != null && node.NodeEast.DistanceFromCenter == 0)
                    {
                        node.NodeEast.DistanceFromCenter = d + 1;
                    }           
                    if (node.NodeWest != null && node.NodeWest.DistanceFromCenter == 0)
                    {
                        node.NodeWest.DistanceFromCenter = d + 1;
                    }
                }
                d++;
            } while (CheckNodeDistanceFromCenter(finishI, finishJ, 0));

            // Восстановление пути
            var output = "";
            var curNode = GetNodeByCoordinates(finishI, finishJ);
            do
            {
                if (curNode.NodeNorth != null && curNode.NodeNorth.DistanceFromCenter == curNode.DistanceFromCenter - 1)
                {
                    curNode = curNode.NodeNorth;
                    output += "N";
                }
                else if (curNode.NodeEast != null && curNode.NodeEast.DistanceFromCenter == curNode.DistanceFromCenter - 1)
                {
                    curNode = curNode.NodeEast;
                    output += "E";
                }
                else if (curNode.NodeSouth != null && curNode.NodeSouth.DistanceFromCenter == curNode.DistanceFromCenter - 1)
                {
                    curNode = curNode.NodeSouth;
                    output += "S";
                }
                else if (curNode.NodeWest != null && curNode.NodeWest.DistanceFromCenter == curNode.DistanceFromCenter - 1)
                {
                    curNode = curNode.NodeWest;
                    output += "W";
                }
            } while (!(curNode.I == startI && curNode.J == startJ));

            return output;
        }

        private static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }

        private static Node GetNodeByCoordinates(int i, int j)
        {
            foreach(var node in Nodes)
            {
                if(node.I == i && node.J == j)
                {
                    return node;
                }
            }

            var newNode = new Node(i, j);
            Nodes.Add(newNode);

            return newNode;
        }

        private static void SetNodeDistanceFromCenter(int i, int j, int d)
        {
            var node = GetNodeByCoordinates(i, j);
            node.DistanceFromCenter = d;
        }

        private static bool CheckNodeDistanceFromCenter(int i, int j, int d)
        {
            var node = GetNodeByCoordinates(i, j);
            return node.DistanceFromCenter == d;
        }

        private static List<Node> GetNodesWithDistanceFromCenter(int d)
        {
            var nodesWithDistanceFromCenter = new List<Node>();

            foreach (var node in Nodes)
            {
                if (node.DistanceFromCenter == d)
                {
                    nodesWithDistanceFromCenter.Add(node);
                }
            }

            return nodesWithDistanceFromCenter;
        }
    }

    internal class Node
    {
        public int I { get; set; }
        public int J { get; set; }
        public int DistanceFromCenter { get; set; }

        public Node NodeNorth { get; set; }
        public Node NodeSouth { get; set; }
        public Node NodeEast { get; set; }
        public Node NodeWest { get; set; }

        public Node(int i, int j)
        {
            I = i;
            J = j;
        }
    }   
}
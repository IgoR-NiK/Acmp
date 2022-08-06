﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace TasksApp.Tasks
{
    /// <summary>
    /// Задача 252 - "Сортировка масс"
    /// (Время: 1 сек. Память: 16 Мб Сложность: 44%)
    /// 
    /// Как известно, Россия является одним из ведущих экспортеров нефти. Разные страны мира, от достаточно больших до сравнительно маленьких,
    /// нуждаются в этой нефти как в воздухе. В ее состав в больших количествах входят ароматические углеводороды, которые обуславливают ее высокое качество.
    /// Доставка нефти в пункт назначения осуществляется с помощью нефтепровода. Считается, что количество нефти, отправленное в страну назначения,
    /// равно количеству полученной нефти. На самом деле это, конечно, не так. Как и многое другое, нефть воруют некоторые несознательные личности.
    /// Причем неофициально считается, что больше нефти воруют в нефтепроводах тех стран, куда нефти посылается больше
    /// (может быть, несознательные личности считают, что приносят, таким образом, меньше ущерба, кто знает...).
    /// Официальное руководство компании «Русская Нефть» решило узнать, правдивый это слух или нет, чтобы усилить (а может просто установить)
    /// охрану на тех нефтепроводах, где больше всего воруют нефть.
    ///
    /// Для этого им нужно отсортировать нефтепроводы по количеству нефти, которая протекает в направлении какой-то страны за сутки.
    /// У компании «Русская Нефть», как и у любой уважающей себя компании, есть несколько штатных программистов, и руководство предложило им решить эту,
    /// в сущности, нетрудную задачу. Но программистов поставило в тупик то, что данные о количестве нефти представлены в разных единицах измерения
    /// (начиная от граммов и заканчивая тоннами).
    ///
    /// Поэтому они решили найти человека, который был бы в силах решить эту задачу за них, и обещают взять его на работу
    /// в эту перспективную и процветающую компанию. Решите задачу, и, кто знает, может, повезет именно Вам?
    /// 
    /// Входные данные
    /// В первой строке входного файла INPUT.TXT находится целое число N (1 ≤ N ≤ 1000) — количество нефтепроводов.
    /// В каждой из следующих N строк находится количество (точнее — масса) нефти, транспортированной по соответствующему нефтепроводу за сутки,
    /// по одному в строке. Масса нефти задана целым числом от 1 до 10000 с указанием соответствующей единицы измерения.
    /// Число и единица измерения разделены ровно одним пробелом. Единица измерения задается одной из трех букв: g (граммы), p (пуды), t (тонны),
    /// причем перед этой буквой может стоять одна из приставок: m (милли-), k (кило-), M (мега-), G (гига-).
    /// Напомним, что эти приставки обозначают умножение единицы измерения на 10^–3, 10^3, 10^6 и 10^9 соответственно. 1 пуд = 16380 граммов, 1 тонна = 10^6 граммов.
    /// 
    /// Выходные данные
    /// В выходной файл OUTPUT.TXT выведите N строк, в которых должны быть записаны массы нефти в порядке неубывания.
    /// Каждая строка должна описывать массу нефти в одном из нефтепроводов. Массы должны быть описаны в том же формате,
    /// в котором записаны во входном файле. Приоритет равных масс, записанных в разных форматах должен соответствовать порядку, в котором они следуют во входном файле.
    /// </summary>
    public static class Task0252
    {
        public enum Unit : ulong
        {
            mg, g, kg, Mg, Gg,
            mp, p, kp, Mp, Gp,
            mt, t, kt, Mt, Gt
        }
        
        private static readonly Dictionary<Unit, decimal> UnitValueMap = new Dictionary<Unit, decimal>
        {
            [Unit.mg] = 1,
            [Unit.g] = 1000,
            [Unit.kg] = 1000000,
            [Unit.Mg] = 1000000000,
            [Unit.Gg] = 1000000000000,
            [Unit.mp] = 16380,
            [Unit.p] = 16380000,
            [Unit.kp] = 16380000000,
            [Unit.Mp] = 16380000000000,
            [Unit.Gp] = 16380000000000000,
            [Unit.mt] = 1000000,
            [Unit.t] = 1000000000,
            [Unit.kt] = 1000000000000,
            [Unit.Mt] = 1000000000000000,
            [Unit.Gt] = 1000000000000000000
        };

        public static void Main()
        {
            GetInputData(out var masses);

            var result = Solve(masses);

            PrintResult(result);  
        }

        private static void GetInputData(out Mass[] masses)
        {
            var n = int.Parse(Console.ReadLine());

            masses = new Mass[n];
            
            for (var i = 0; i < n; i++)
            {
                var str = Console.ReadLine().Split();
                masses[i] = new Mass
                {
                    Number = int.Parse(str[0]),
                    Unit = (Unit)Enum.Parse(typeof(Unit), str[1])
                };
            }
        }

        public static Mass[] Solve(Mass[] masses)
        {
            return masses.OrderBy(it => it).ToArray();
        }

        private static void PrintResult(Mass[] result)
        {
            foreach (var res in result)
            {
                Console.WriteLine($"{res.Number} {res.Unit}");
            }
        }

        public struct Mass : IEquatable<Mass>, IComparable<Mass>
        {
            public int Number { get; set; }
            
            public Unit Unit { get; set; }

            private decimal TotalMg => Number * UnitValueMap[Unit];

            public override string ToString()
            {
                return $"{Number} {Unit} = {TotalMg} mg";
            }

            public int CompareTo(Mass other)
            {
                return TotalMg.CompareTo(other.TotalMg);
            }

            public bool Equals(Mass other)
            {
                return Number == other.Number && Unit == other.Unit;
            }

            public override bool Equals(object obj)
            {
                return obj is Mass other && Equals(other);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    return (Number * 397) ^ UnitValueMap[Unit].GetHashCode();
                }
            }
        }
    }
}
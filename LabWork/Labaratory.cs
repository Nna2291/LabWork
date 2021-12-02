using DotLiquid;
using System;
using System.Collections.Generic;

namespace Application
{

    public class ForHTML: Drop
    {
        private string _fn;
        private string _sn;
        private string _eq;
        private string _aim;
        private string _n;
        private string _g;

        public string FirstName { get => _fn; set => _fn = value; }
        public string SecondName { get => _sn; set => _sn = value; }
        public string Equipment { get => _eq; set => _eq = value; }
        public string Aim { get => _aim; set => _aim = value; }
        public string Name { get => _n; set => _n = value; }
        public string Group { get => _g; set => _g = value; }

        public ForHTML(string first_name, string second_name, string equipment, string aim, string name, string group) 
        {
            FirstName = first_name;
            SecondName = second_name;
            Equipment = equipment;
            Aim = aim;
            Name = name;
            Group = group;
        }


    }
    public class Science : Drop
    {
        private string type_road;
        private string number;
        private double pogrN;
        private double pogrF;
        private string normal_reaction;
        private double normal_reaction_graph;
        private string force;
        private double force_graph;

        public double Pogr_N { get => pogrN; set => pogrN = value; }
        public double Pogr_F { get => pogrF; set => pogrF = value; }
        public string Type_road { get => type_road; set => type_road = value; }
        public string Number { get => number; set => number = value; }
        public string Normal_reaction { get => normal_reaction; set => normal_reaction = value; }
        public double Normal_reaction_graph { get => normal_reaction_graph; set => normal_reaction_graph = value; }
        public string Force { get => force; set => force = value; }
        public double Force_graph { get => force_graph; set => force_graph = value; }

        public Science(string _type_road, string _number, double _pogrn, double _pogrf, string _normal_reaction,
            double _normal_reaction_graph, string _force, double _force_graph)
        {
            Pogr_N = _pogrn;
            Pogr_F = _pogrf;
            Type_road = _type_road;
            Number = _number;
            Normal_reaction = _normal_reaction;
            Force = _force;
            Normal_reaction_graph = _normal_reaction_graph;
            Force_graph = _force_graph;
        }
    }
    public class Labaratory
    {
        public string WorkName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Group { get; set; }
        public string Name { get; set; }
        public string Aim { get; set; }
        public string Equipment { get; set; }
        public List<Science> Dim { get; set; }


    }
}

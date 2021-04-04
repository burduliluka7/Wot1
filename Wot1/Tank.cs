using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;


namespace ConsoleApp2
{
    public class Tank
    {
        public string TankName { get; private set; }
        public int[,] TankArm { get; private set; } = new int[8, 8];
        public int Penetr { get; private set; }
        public int Dmg { get; private set; }
        public int Health { get; private set; }
        public string Arm { get; private set; }
        //constructor
        public Tank(string name, int penetr, int dmg, int Hp)
        {
            TankName = name;
            Penetr = penetr;
            Dmg = dmg;
            Health = Hp;

            Random rnd = new Random();
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    TankArm[i, j] = rnd.Next(290, 350);
                    Arm += TankArm[i, j].ToString() + " ";
                }
                Arm += Environment.NewLine;
            }
        }
        public string GetInfo()
        {

            string result = JsonConvert.SerializeObject(new { TankName, Penetr, Dmg, Health });
            return result + "\n" + Arm;
        }
        public string MakeShot(Tank enemytank, int i, int j)
        {

            if (Penetr > enemytank.TankArm[i, j])
            {
                enemytank.Health -= Dmg;
                return "you penetrated their armor!!";
            }
            else
            {
                return "We didn't penetrate their armor!! :( :( ";
            }

        }
        public string TakeShot(Tank enemytank)
        {
            Random rnd = new Random();
            int comp_i = rnd.Next(1, 5), comp_j = rnd.Next(1, 5);
            if (enemytank.Penetr > TankArm[comp_i, comp_j])
            {
                Health -= enemytank.Dmg;
                return $"Oponent penetrated you at index [{comp_i} , {comp_j}], where your armor was: {TankArm[comp_i, comp_j]}, and Op's penetration was {enemytank.Penetr} ";
            }
            else
            {
                return $"Oponent DIDN'T penetrated you at index [{comp_i} , {comp_j}], where your armor was: {TankArm[comp_i, comp_j]} , and Op's penetration was {enemytank.Penetr} ";
            }
        }
    }
}

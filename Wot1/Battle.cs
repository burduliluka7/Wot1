using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wot1
{
    public class Battle
    {
        public readonly IEnumerable<Tank> Tanks;
        public ILogger Logger { get; protected set; }
        public Battle(ICollection<Tank> tanks, ILogger logger)
        {
            Tanks = tanks;
            Logger = logger;
        }
        public void Start()
        {
            foreach (var tank in Tanks)
            {

            }
            Logger.Log("alo alo alo ismis?");
        }
    }
}

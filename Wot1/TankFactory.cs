using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Text;
using LumenWorks.Framework.IO.Csv;
using System.IO;
namespace Wot1
{
    public class TankFactory
    {
        public IEnumerable<Tank> Create(int user_tank_num, string path)
        {

         
            if (user_tank_num == 1)
            {
                path += @"\279.csv";
                //return new Tank("", 1, 1, 1);
            }
           else if (user_tank_num == 2)
            {
                path += @"\907.csv";

            }
          else
             {
                path += @"\Chief.csv";
             }
            var csvTable = new System.Data.DataTable();

            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(path)), true))
            {
                csvTable.Load(csvReader);
            }
         

      yield return new Tank(csvTable.Rows[0][0].ToString(), Convert.ToInt32(csvTable.Rows[0][1]), Convert.ToInt32(csvTable.Rows[0][2]), Convert.ToInt32(csvTable.Rows[0][3] ));
        }
    }
}
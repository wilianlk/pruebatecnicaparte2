using AppPunto2.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AppPunto2.controllers
{
    internal class ListdataController
    {
        List<Listdata> listDatos = new List<Listdata>();

        public void addListdata(Listdata listdata)
        {
            if(listdata != null)
            {
                listDatos.Add(listdata);
            }
        }

        public string showList()
        {
            string text = "lista \n";
            foreach(Listdata listdata in listDatos)
            {
                text += "id: " + listdata.Id + "\n";
                text += "id: " + listdata.Name + "\n";
            }
            return text;
        }

        public string showRepeatedList()
        {
            string text = "";
            bool repetidos = false;

            for (var x = 0; x < listDatos.Count; x++)
            {
                string a = listDatos[x].Name;
                int ind = listDatos[x].Id;
                int c = x + 1;

                for (int y = c; y < listDatos.Count; y++)
                {
                    string b = listDatos[y].Name;
                    int ind2 = listDatos[x].Id;
                   

                    if (a == b)
                    {
                        repetidos = true;

                        System.Console.WriteLine("El dato nombre " + a + " esta repetido en la lista"+ "\n");
                    }    
                }
            }

            if (repetidos == false)
            {
                
                System.Console.WriteLine("No hay datos repetidos en la lista.","\n");
            }

            return text;
        }

        public void showListlowesttohighest()
        {
            string text = "lista \n";

            var lord_ = listDatos.OrderBy(o => o.Id).ToList();

            foreach (var grouping in lord_)
            {
                text += "Id: " + grouping.Id + "\n";
                text += "Name: " + grouping.Name + "\n";
            }

            Console.WriteLine(CultureInfo.InvariantCulture.TextInfo.ToTitleCase("\nlos elementos ordenados de menor a mayor son:" + text));

        }
        public void showListhighesttolowest()
        {
            string text = "lista \n";

            var lord_ = listDatos.OrderByDescending(o => o.Id).ToList();

            foreach (var grouping in lord_)
            {
                text += "Id: " + grouping.Id + "\n";
                text += "Name: " + grouping.Name + "\n";
            }

            Console.WriteLine(CultureInfo.InvariantCulture.TextInfo.ToTitleCase("\nLos Elementos ordenados de mayor a menor son:" + text));
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Cache;
using System.Web;


namespace AppJSON
{
    public partial class Form1 : Form
    {
        private static string path = @"C:\Users\keila\source\repos\AppJSON\AppJSON\example.json";
        public Form1()
        {
            InitializeComponent();
            var person = GetPersons();
            SerializeJsonFile(person);
        }

        public static void SerializeJsonFile(List<Person> person)
        {
            string personJson = JsonConvert.SerializeObject(person.ToArray(), Formatting.Indented);
            File.WriteAllText(path, personJson);
        }
        public static List<Person> GetPersons()
        {
            List<Person> person = new List<Person>
            { 
                new Person
                {
                    Name = "Keila",
                    LastName = "de la Torre",
                    Age = "22",
                    Gender = "Female"
                },
                new Person
                {
                    Name = "Luis",
                    LastName = "Fabela",
                    Age = "19",
                    Gender = "Male"
                },
                new Person
                {
                    Name = "Yadira",
                    LastName = "Quiroz",
                    Age = "19",
                    Gender = "Female"
                },
                new Person
                {
                    Name = "Daylin",
                    LastName = "Cruz",
                    Age = "20",
                    Gender = "Female"
                },
                new Person
                {
                    Name = "Carlos",
                    LastName = "Torres",
                    Age = "19",
                    Gender = "Male"
                },
            };
            return person;
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            dgwData.DataSource = GetPersons();
        }
          
    }
}

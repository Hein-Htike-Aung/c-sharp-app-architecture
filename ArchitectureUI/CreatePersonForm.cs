using ArchitectureLibrary.Enumeration;
using ArchitectureLibrary.Model;
using ArchitectureLibrary.Service;
using ArchitectureLibrary.Service.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchitectureUI
{
    public partial class CreatePersonForm : Form
    {

        private PersonService personService;

        public CreatePersonForm()
        {
            InitializeComponent();

            personService = new PersonServiceImpl();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Person person = new Person();
            person.Name = "Xiaoting";
            person.Phone = "00934343434";
            person.Email = "xiao@gmail.com";
            person.GPA = double.Parse("8.9");
            person.Asset = decimal.Parse("2000");
            person.Active = true;
            person.DOB = DateTime.Parse(dateValue.Text);
            person.Gender = Gender.FEMALE;

            personService.Create(person);

            MessageBox.Show("Successed");
        }
    }
}

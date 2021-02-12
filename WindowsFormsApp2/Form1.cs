using Microsoft.Extensions.DependencyInjection;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            var scope = Installer.Init();
            var personService = scope.GetRequiredService<IPersonService>();
            var eventService = scope.GetRequiredService<IEventService>();
            var eventPersonService = scope.GetRequiredService<IEventPersonService>();
            richTextBox1.Text += "\nИгроки:\n\n";
            richTextBox1.Text += personService.GetPerson(1).Name + " " + personService.GetPerson(1).Position + " " + personService.GetPerson(1).PersonType + "\n";
            richTextBox1.Text += personService.GetPerson(2).Name + " " + personService.GetPerson(2).Position + " " + personService.GetPerson(2).PersonType + "\n";
            richTextBox1.Text += personService.GetPerson(3).Name + " " + personService.GetPerson(3).Position + " " + personService.GetPerson(3).PersonType + "\n";
            richTextBox1.Text += "\nСобытия:\n\n";

            richTextBox1.Text += "Первое:\n";
            richTextBox1.Text += eventService.GetEvent(2).DateTime.Date.ToString() + " " + eventService.GetEvent(2).EventType.ToString() + "\n";
            richTextBox1.Text += "Состав:\n";
            eventService.GetPersonsByEventId(2).ForEach(x => richTextBox1.Text += x.Name + "\n") ;
            richTextBox1.Text += "\nВторое:\n";
            richTextBox1.Text += eventService.GetEvent(5).DateTime.Date.ToString() + " " + eventService.GetEvent(5).EventType.ToString() + "\n";
            richTextBox1.Text += "Состав:\n";
            eventService.GetPersonsByEventId(5).ForEach(x => richTextBox1.Text += x.Name + "\n");
            richTextBox1.Text += "\nТретье:\n";
            richTextBox1.Text += eventService.GetEvent(6).DateTime.Date.ToString() + " " + eventService.GetEvent(6).EventType.ToString() + "\n";
            richTextBox1.Text += "Состав:\n";
            eventService.GetPersonsByEventId(6).ForEach(x => richTextBox1.Text += x.Name + "\n");

        }
    }
}

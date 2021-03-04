using Domain;
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
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            var scope = Installer.Init();
            var personService = scope.GetRequiredService<IPersonService>();
            var eventService = scope.GetRequiredService<IEventService>();

            richTextBox1.Text += "\nИгрок:\n";
            richTextBox1.Text += personService.Get(2).ToString() + "\n";
            
            richTextBox1.Text += "\nСобытие:\n";
            richTextBox1.Text += eventService.Get(5).ToString() + "\n";

            richTextBox1.Text += "\nИгрок и его события:\n";
            richTextBox1.Text += personService.Get(1).ToString() + "\n";
            personService.GetEventsByPersonId(1).ForEach(x => richTextBox1.Text += x.ToString() + "\n");

            richTextBox1.Text += "\nСобытие и его игроки:\n";
            richTextBox1.Text += eventService.Get(4).ToString() + "\n";
            eventService.GetPersonsByEventId(4).ForEach(x=>richTextBox1.Text +=x.ToString() + "\n");

            personService.Add("dfkjsdjfl", Domain.Enum.PersonType.Footboller, Domain.Enum.Composition.Main, Domain.Enum.Position.Forward);

            personService.Update("dfkjsdjfl", Domain.Enum.PersonType.Trainer, Domain.Enum.Composition.Main, Domain.Enum.Position.Forward);

            //eventService.Remove(2);

        }

    }
}

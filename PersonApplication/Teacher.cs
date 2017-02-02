using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    //aliluokka
    class Teacher : Person
    {
        public string Room { get; set; }

        public Teacher()
        {

        }

        //Viedään firstname ja lastname yliluokkaan käyttäen base.
        public Teacher(string firstname, string lastname, string room)
            : base(firstname,lastname)
        {
            Room = room;
        }

        public void TeahcerMethod()
        {
            Console.WriteLine("This method belongs to teacher");
        }

        public override string ToString()
        {
            //base.ToString() on yliluokan metodi eli Personin ToString(). Lisätään Room.
            //base viittaa yliluokkaan eli tässä Person-luokkaan.
            return base.ToString()+ " " + Room;
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_7
{
    internal class Song
    {
        string name; //название песни
        string author; //автор песни
        Song prev; //связь с предыдущей песней в списке

        //метод для заполнения поля name
        public void Name(string name)
        {
            this.name = name;
        }

        //метод для заполнения поля author
        public void Author(string author)
        {
            this.author = author;
        }

        //метод для заполнения поля prev
        public void Prev(Song prev)
        {
            this.prev = prev;
        }

        //метод для печати названия песни и ее исполнителя
        public void Title()
        {
            Console.WriteLine(name + " - " + author);
        }
        //метод, который сравнивает между собой два объекта-песни:
        public override bool Equals(object d)
        {
            if (d == null)
            {
                return false;
            }

            if (d.GetType() != GetType())
            {
                return false;
            }

            Song otherSong = (Song)d;
            return name.Equals(otherSong.name) && author.Equals(otherSong.author);
        }

    }
}

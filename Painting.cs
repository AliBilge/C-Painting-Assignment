using System;

namespace Painting_Assignment
{
    class Painting
    {
        private string name;
        private string artist;
        private string medium;
        private int year;

        public string PaintingName { 
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string PaintingArtist {
            get
            {
                return artist;
            }
            set
            {
                artist = value;
            }
        }

        public string PaintingMedium {
            get
            {
                return medium;
            }
            set
            {
                medium = value;
            }
        }

        public int PaintingYear {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public virtual void style()
        {
            Console.WriteLine("Painting Styles");
        }
    }
    class Classic : Painting
    {
        public override void style()
        {
            Console.WriteLine("Classic Oil Painting");
        }
    }
     class Program
            {
                    static void Main(string[] args)
                {
                    Painting classicPainting = new Painting();

                    classicPainting.PaintingName = "Death of the Dragon";
                    classicPainting.PaintingArtist = "Invincible Archer";
                    classicPainting.PaintingMedium = "Oil Painting";
                    classicPainting.PaintingYear = 1453;

                    Console.WriteLine("Name: " + classicPainting.PaintingName);
                    Console.WriteLine("Artist: " + classicPainting.PaintingArtist);
                    Console.WriteLine("Medium: " + classicPainting.PaintingMedium);
                    Console.WriteLine("Year: " +  classicPainting.PaintingYear);
                }
            }  
}

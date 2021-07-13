using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    //enum for our Maturity Rating
    public enum MaturityRating
    {
        G = 1,
        PG,
        PG_13,
        R,
        NC_17,
        TV_G,
        TV_MA
    }
    public class StreamingContent
    {
        //POCO *Plain Old C# Object

        //Properties
        //Title
        public string Title { get; set; }
        //Description
        public string Description { get; set; }
        public int StarRating { get; set; }
        public bool IsFamilyFriendly
        {
            get
            {
                switch(TypeOfMaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.TV_G:
                        return true;
                    case MaturityRating.PG_13:
                    case MaturityRating.R:
                    case MaturityRating.NC_17:
                    case MaturityRating.TV_MA:
                    default:
                        return false;
                }
            }
        }
        public string Genre { get; set; }
        public MaturityRating TypeOfMaturityRating { get; set; }


        //Constructors (generally these go at the top but they can go anywhere in the class)
        //Constructor Empty

        public List<int> Ratings { get; set; }
        public StreamingContent() { }
        //Constructor Full
        public StreamingContent(string title, string desc, int starRating, string genre, MaturityRating typeOfMaturity)
        {
            Title = title;
            Description = desc;
            StarRating = starRating;
            Genre = genre;
            TypeOfMaturityRating = typeOfMaturity;
        }
    }
}


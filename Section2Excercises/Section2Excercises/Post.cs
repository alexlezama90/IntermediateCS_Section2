using System;
using System.Collections.Generic;
using System.Text;

namespace Section2Excercises
{
    public class Post
    {
        public string Title { get; private set; }
        public string Description { get; set; }
        public DateTime CreationDateTime { get; private set; }
        public int Votes { get; private set; }

        public Post(string title, DateTime creationDateTime)
        {
            Title = title;
            CreationDateTime = creationDateTime;
            Votes = 0;
        }

        public void Vote (bool upvote)
        {
            Votes = (upvote) ? ++Votes : --Votes;
        }
    }
}

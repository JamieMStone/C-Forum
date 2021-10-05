using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        User Jamie = new User("JamieS13");
        User Georgia = new User("GeorgiaS");

        Console.WriteLine("New weird User: " + Jamie.username);

        Forum Garden = new Forum("Garden");

        Post Flower = new Post(Garden, "This is a flower", "02/05/2021", Jamie, "Lovely Flower");
        Console.WriteLine(Flower.title);

        Post Tree = new Post(Garden, "This is a tree", "02/05/2021", Georgia, "Big Tree");

        Comment comment1 = new Comment(Flower, "02/05/2021", Jamie, "Nice");
        Comment comment2 = new Comment(Flower, "03/05/2021", Jamie, "Cool!");
        Comment comment3 = new Comment(Flower, "04/05/2021", Jamie, "Not good :(");

        //Get flower comments
        Flower.getComments();
        
        //Forum posts
        Garden.getPosts();

        //Jamie posts
        Jamie.getPosts();

    }
}


using System;
using System.Collections.Generic;


class Post{

    public List<Comment> comments = new List<Comment>();
    public Post(Forum forum, string title, string date, User author, string text){
        this.forum = forum;
        this.title = title;
        this.date = date;
        this.author = author;
        this.text = text;
        author.posts.Add(this);
        forum.posts.Add(this);
        
    }


    public Forum forum
    {get; set;}

    
    
    public string title
    {get; set;}
    public string date
    {get; set;}
    public User author
    {get; set;}
    public string text
    {get; set;}
    


    public void getComments(){
        Console.WriteLine("//");
        Console.WriteLine(this.title + " has the following comments:");
        foreach (Comment value in comments){
            Console.WriteLine(value.author + " commented at " + value.date + ":");
            Console.WriteLine(value.text);
        }
    }
}
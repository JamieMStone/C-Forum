using System;
using System.Collections.Generic;

class Forum {

    public List<Post> posts = new List<Post>();

    public Forum(string title){
        this.title = title;
        
    }

    public string title
        { get; set; }

    public void getPosts(){
        Console.WriteLine("//");
        Console.WriteLine(this.title + " has the following posts:");
        foreach(Post value in posts){
            Console.WriteLine(value.title);
        }
    }

}
using System;
using System.Collections.Generic;

class User {
    
    public List<Post> posts = new List<Post>();

    public User(string username){
        this.username = username;
    }

    public string username
    { get; set; }


    public void getPosts(){
        Console.WriteLine("//");
        Console.WriteLine(this.username + " has the following posts:");
        foreach(Post value in posts){
            Console.WriteLine(value.title);
        }
    }

}
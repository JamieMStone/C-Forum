using System;
using System.Collections.Generic;

class Comment{

    public Comment(Post post, string date, User author, string text){
        this.post = post;
        this.date = date;
        this.author = author.username;
        this.text = text;
        post.comments.Add(this);
    }

    public Post post
    { get; set; }

    public string date
    { get; set; }
    public string author
    { get; set; }

    public string text
    { get; set; }


}
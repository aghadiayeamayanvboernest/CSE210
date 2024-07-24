using System.Transactions;

public class Video 
{
    public string _title { get; set;}
    public string _author {get; set;}
    public int _length{ get; set;} // lenght in seconds 
     private List<Comment> Comments { get; set;}

    //Constructor to initialize a vedio object
    public Video(string title, string author, int lenght)
    {
        _title = title;
        _author = author;
        _length = lenght;
        Comments = new List<Comment>();
    }

    //Method to add comment to the video
    public void AddComment(Comment comment)
    {
        Comments .Add(comment);
    }

    //Method to get the number of commentts on the video 
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    //Method to get the list of comments 
    public List<Comment> GetComments()
    {
        return Comments;
    }
    
}
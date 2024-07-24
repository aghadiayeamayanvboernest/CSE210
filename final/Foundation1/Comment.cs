public class Comment 
{
    public string _commenterName{ get; set; }
    public string _text { get; set;}

    // This set of code is the constuctor to initialize a comment object 
    public Comment (string CommenterName, string Text)
    {
        _commenterName = CommenterName;
        _text = Text;
    }
}
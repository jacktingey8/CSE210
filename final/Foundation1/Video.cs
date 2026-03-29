using System.Dynamic;

class Video
{
    public List<Comment> _commentList= new List<Comment>();
    private double _length;
    private string _author;
    private string _title;

    public double GetLength(){return _length;}
    public string GetAuthor(){return _author;}
    public string GetTitle(){return _title;}

    private void SetLength(double length){_length=length;}
    private void SetAuthor(string author){_author= author;}
    private void SetTitle(string title){_title=title;} 

    public Video(string title,string author,double length){SetAuthor(author);SetTitle(title);SetLength(length);}

    public int GetCommentCount(){return _commentList.Count;}

    public string GetVideoInfo(){return $"Title:{_title} - Author:{_author} - Length(seconds):{_length}";}

}
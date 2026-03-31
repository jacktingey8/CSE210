
class Event
{

    // have an Event Title, Description, Date, Time, and Address.
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title=title; _description=description; _date=date; _time=time; _address=address;
    }
    
    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetCompiledAddress()}";
    }
    public virtual string GetFullDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetCompiledAddress()}";
    }
    public string GetShortDescription()
    {
        return $"Event Type: {this.GetType().Name}\nTitle: {_title}\nDate: {_date}";
    }
  

}
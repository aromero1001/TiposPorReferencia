public record Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(int id, string name, string description, string subject)
    {
        Id = id;
        Name = name;
        Description = description;
        Subject = subject;
    }
}

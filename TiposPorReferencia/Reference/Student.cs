public sealed record Student : Person
{
    public string Course { get; set; }
    public Student(int id, string name, string description, string course)
    {
        Id = id;
        Name = name;
        Description = description;
        Course = course;
    }
}

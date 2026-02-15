public record Person
{ 
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    // Permite la desconstrucción: (id, name, description) = personInstance;
    public void Deconstruct(out int id, out string name, out string description)
    {
        id = Id;
        name = Name;
        description = Description;
    }
}

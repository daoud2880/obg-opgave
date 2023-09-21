namespace obg_opgave;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int  Price { get; set; }

    public override string ToString()
    {
        return $"{Id},{Title},{Price}";
    }

    public void ValidateTitle()
    {

    }

}


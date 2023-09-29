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
        if (Title == null)
        {
            throw new ArgumentNullException("Cannot be null");
        }
        if (Title.Length < 3)
        {
            throw new ArgumentException("Must be longer than 3 characthers");
        }
    }

    public void ValidatePrice()
    {
        if (Price <= 0 || Price > 1200)
        {
            throw new ArgumentOutOfRangeException("Price cannot be less than 0 or higher than 1200");
        }
    }

    public void ValidateAll()
    {
        ValidatePrice();
        ValidateTitle();
    }

}


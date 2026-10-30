namespace games4youDomain;

public interface IOrtRepository 
{
    public List<Ort> GetAllOrts();

    public List<Ort> GetOrtById(int id);

    public List<Ort> CreateOrt(Ort ort);

    public bool UpdateOrt(int id, Ort ort);

    public bool DeleteOrt(int id);

}
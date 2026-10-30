namespace games4youDomain; 

public class OrtRepository : IOrtRepository
{
    private OrtContext _context; 
    
    public OrtRepository(OrtContext context)
    {
        _context = context;
    }

    public List<Ort> GetAllOrts()
    {
        return _context.Orts.ToList();
    }

    public List<Ort> GetOrtById(int id)
    {
        return _context.Orts.Where(o => o.Id == id).ToList();
    }

    public List<Ort> CreateOrt(Ort ort)
    {
        int nextId =_context.Orts.Any() ? _context.Orts.Max(o => o.Id) + 1 : 1;
        var newOrt = new Ort
        {
            Id = nextId,
            PLZ = ort.PLZ,
            Bezeichnung = ort.Bezeichnung
        };
        
        _context.Orts.Add(newOrt);
        _context.SaveChanges();
        return _context.Orts.ToList();
    }

    public bool UpdateOrt( int id, Ort ort)
    {
        var ortToUpdate = _context.Orts.FirstOrDefault(o => o.Id == id);
        if (ort.Id == null) return false;

        ortToUpdate.PLZ = ort.PLZ;
        ortToUpdate.Bezeichnung = ort.Bezeichnung;

        _context.SaveChanges();
        return true;
    }

    public bool DeleteOrt(int id)
    {
        var ortToDelete = _context.Orts.FirstOrDefault(o => o.Id == id);
        if (ortToDelete == null) return false; 
        _context.Orts.Remove(ortToDelete);
        _context.SaveChanges();
        return true;
    }

}
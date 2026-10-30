namespace games4youDomain;

public interface IUserService 
{ /// <summary>
  /// Get all users from the database
  /// </summary>    
    public List <Ort> GetAllOrts();
    /// <summary>
    /// Get a user by their ID
    /// </summary>
    public Ort? GetById(int id);
    /// <summary>
    ///     
    /// </summary>
    /// <param name="createUserDto"></param>
    /// <returns></returns>
    public Ort CreateOrt(CreateOrtDto createOrtDto);
    /// <summary>
    ///     
    /// </summary>
    /// <param name="id"></param>
    /// <param name="updateUserDto"></param>
    /// <returns></returns>
    public bool UpdateOrt(int id, UpdateOrtDto updateOrtDto);
    /// <summary>
    ///     
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public bool DeleteOrt(int id);
}
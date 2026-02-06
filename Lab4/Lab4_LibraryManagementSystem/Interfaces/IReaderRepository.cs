using System.Collections.Generic;

public interface IReaderRepository
{
    Reader FindById(string id);
    void AddReader(Reader reader);
    List<Reader> GetAllReaders();
}

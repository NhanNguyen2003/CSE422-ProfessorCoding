using System.Collections.Generic;
using System.Linq;

public class ReaderRepository : IReaderRepository
{
    private List<Reader> readers = new List<Reader>();

    public void AddReader(Reader reader)
    {
        readers.Add(reader);
    }

    public Reader FindById(string id)
    {
        return readers.FirstOrDefault(r => r.Id == id);
    }

    public List<Reader> GetAllReaders()
    {
        return readers;
    }
}

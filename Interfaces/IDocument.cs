using System.Collections.Generic;
using Documents_Lukashevich.Classes;

namespace Documents_Lukashevich.Interfaces
{
    public interface IDocument
    {
        void Save(bool Update = false);
        List<DocumentContext> AllDocuments();
        void Delete();
    }
}
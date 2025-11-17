using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Documents_Lukashevich;
using System.Threading.Tasks;

namespace Documents_Lukashevich.Interfaces
{
    public interface IDocument
    {
        void Save(bool Update = false);

        List<Documents_Lukashevich.Classes.DocumentContext> AllDocuments();

        void Delete();
    }
}

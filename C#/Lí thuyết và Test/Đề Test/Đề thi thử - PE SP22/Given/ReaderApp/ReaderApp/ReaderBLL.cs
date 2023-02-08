using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ReaderApp
{
    class ReaderBLL
    {
        ReaderDAL daReader;

        public ReaderBLL()
        {
            daReader = new ReaderDAL();
        }

        public DataTable getAll()
        {
            return daReader.getAll();
        }

        public bool Insert(Reader reader)
        {
            return daReader.Insert(reader);
        }

        public bool Update(Reader reader)
        {
            return daReader.Update(reader);
        }

        public bool Delete(Reader reader)
        {
            return daReader.Delete(reader);
        }
    }
}

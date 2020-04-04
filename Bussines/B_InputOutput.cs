using DataAcces;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Bussines
{
    public class B_InputOutput
    {
        public List<InputOutputEntity> InputOutputList()
        {
            using (var db = new InventaryContext())
            {
                return db.InputOutputs.ToList();
            }
        }

        public void CreateInputOutput(InputOutputEntity inout)
        {
            using (var db = new InventaryContext())
            {
                db.InputOutputs.Add(inout);
                db.SaveChanges();
            }
        }

        public void UpdateInputOutput(InputOutputEntity inuout)
        {
            using (var db = new InventaryContext())
            {
                db.InputOutputs.Update(inuout);
                db.SaveChanges();
            }
        }
    }
}
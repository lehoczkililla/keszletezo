using Hotcakes.Commerce.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAFF.Modules.Dnn.DAFF.ReceptValaszto.Models;
using DotNetNuke.Data;
using DotNetNuke.Framework;
using System.Reflection;


namespace DAFF.Modules.Dnn.DAFF.ReceptValaszto.Components
{
    internal interface IReceptManager
    {
        IEnumerable<Recept> GetRecepts();
        Recept GetRecept(int itemId, int moduleId);
        Recept GetRecept(int itemId);
    }

    internal class ReceptManager : ServiceLocator<IReceptManager, ReceptManager>, IReceptManager
    {
        
        protected override Func<IReceptManager> GetFactory()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Recept> GetRecepts()
        {
            IEnumerable<Recept> t;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Recept>();
                t = rep.Get();
            }
            return t;
        }

        public Recept GetRecept(int itemId, int moduleId)
        {
            Recept t;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Recept>();
                t = rep.GetById(itemId, moduleId);
            }
            return t;
        }

        public Recept GetRecept(int itemId)
        {
            Recept t;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Recept>();
                t = rep.GetById(itemId);
            }
            return t;
        }
    }

  
}
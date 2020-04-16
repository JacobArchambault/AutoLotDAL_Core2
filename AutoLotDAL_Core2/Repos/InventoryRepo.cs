using AutoLotDAL_Core2.EF;
using AutoLotDAL_Core2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoLotDAL_Core2.Repos
{
    public class InventoryRepo : BaseRepo<Inventory>, IInventoryRepo
    {
        public InventoryRepo(AutoLotContext context) : base(context)
        {
        }
        public override List<Inventory> GetAll() => GetAll(x => x.PetName, true).ToList();
        public List<Inventory> GetPinkCars() => GetSome(x => x.Color == "Pink");

        public List<Inventory> GetRelatedData()
        {
            throw new NotImplementedException();
        }

        public List<Inventory> Search(string searchString)
        {
            throw new NotImplementedException();
        }
    }
}

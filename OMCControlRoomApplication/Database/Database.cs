using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMCControlRoomApplication
{
    public partial class ControlDataContext
    {
        public List<Item> GetItems()
        {
            try
            {
                return GetTable<Item>().Where(x=>x.StatusId>0).ToList();
            }
            catch (Exception ex) { OMCControl.HandleException(ex); return null; }
        }

        public Item GetItem(int Id)
        {
            try
            {
                var items = GetTable<Item>().Where(x => x.Id == Id);
                if (items.Count()>0)
                    return items.First();
                else
                    return null;

            }
            catch (Exception ex) { OMCControl.HandleException(ex); return null; }
        }
    }
}

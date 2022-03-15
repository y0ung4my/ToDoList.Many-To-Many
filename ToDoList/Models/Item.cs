using System.Collections.Generic;
using System.Linq;

namespace ToDoList.Models
{
    public class Item
    {
        public Item()
        {
            this.JoinEntities = new HashSet<CategoryItem>();
        }

        public int ItemId { get; set; }
        public string Description { get; set; }
        public bool Completed {get; set; }
        public string DateDue { get; set; }

        public virtual ICollection<CategoryItem> JoinEntities { get;}

    }
}
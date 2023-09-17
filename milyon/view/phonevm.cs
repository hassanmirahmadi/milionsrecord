using milyon.models;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milyon.view
{
    public class Phonevm
    {
        public ObservableCollection<Mobile> details { get; } = new ObservableCollection<Mobile>();

        public void LoadData(List<Mobile> detailss)
        {
            details.Clear();
            if (detailss != null)



                foreach (var item in detailss)
                    details.Add(item);

        }
    }
}

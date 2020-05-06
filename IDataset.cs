using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace lv5
{
    interface IDataset
    {
        ReadOnlyCollection<List<string>> GetData();
    }
}

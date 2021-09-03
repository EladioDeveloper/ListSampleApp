using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListSample.Models
{
    public class PlaceGroup : ObservableCollection<Place>
    {
        public PlaceGroup(string groupName)
        {
            GroupName = groupName;
        }
        public string GroupName { get; }
        public string GroupInitial => GroupName.Substring(0);
    }
}

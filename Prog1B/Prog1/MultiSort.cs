//Program 4. MultiSort class
//By: Chad Tracy
//This program sorts the test data by type and then title.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    class MultiSort : IComparer<LibraryItem>
    {
        //pre condition: none
        //post condition: sorts by type and then title
        public int Compare(LibraryItem item1, LibraryItem item2)
        {
            //two objects to be sorted
            LibraryItem libraryItem1 = (LibraryItem)item1;
            LibraryItem libraryItem2 = (LibraryItem)item2;

            if (libraryItem1 == null && libraryItem2 == null) 
                return 0;
            if (libraryItem1 == null) 
                return 1;
            if (libraryItem2 == null) 
                return -1;
            

            
            //sorts by type first. Uses CompareTo to compare the types and see where they are in comparison to eachc other (before, proceeding, after)
            int typeCompare = libraryItem1.GetType().FullName.CompareTo(libraryItem2.GetType().FullName);
            if (typeCompare != 0)
                return typeCompare;
            //sorts by title after type
            int titleCompare = libraryItem1.Title.CompareTo(libraryItem2.Title);
            if (titleCompare != 0)
                return titleCompare;

            else
                return 0;
        }
    }
}

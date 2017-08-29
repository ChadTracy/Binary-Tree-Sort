//Prgram 4. Binary Tree sorting
//By: Chad Tracy





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    class CopyrightDesc : IComparer<LibraryItem>
    {
        //pre condition: none
        //post condition: sorts items by their copyright year in descending order
        public int Compare(LibraryItem item1, LibraryItem item2)
        {
            LibraryItem libItem1 = (LibraryItem)item1;
            LibraryItem libItem2 = (LibraryItem)item2;

            //
            if (libItem1.CopyrightYear < libItem2.CopyrightYear)
                return 1;
            if (libItem1.CopyrightYear > libItem2.CopyrightYear)
                return -1;
            else
                return 0;

            
 
            
        }
    }
}

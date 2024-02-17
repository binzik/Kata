using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu5
{
    public class PaginationHelper<T>
    {
        public string GetTestDescription()
        {
            return "For this exercise you will be strengthening your page-fu mastery. You will complete the PaginationHelper class, which is a utility class helpful for querying paging information related to an array.\r\n\r\nThe class is designed to take in an array of values and an integer indicating how many items will be allowed per each page. The types of values contained within the collection/array are not relevant.\r\n\r\nThe following are some examples of how this class is used:\r\n\r\nvar helper = new PaginationHelper<char>(new List<char>{'a', 'b', 'c', 'd', 'e', 'f'}, 4);\r\nhelper.PageCount; // should == 2\r\nhelper.ItemCount; // should == 6\r\nhelper.PageItemCount(0); // should == 4\r\nhelper.PageItemCount(1); // last page - should == 2\r\nhelper.PageItemCount(2); // should == -1 since the page is invalid\r\n\r\n// pageIndex takes an item index and returns the page that it belongs on\r\nhelper.PageIndex(5); // should == 1 (zero based index)\r\nhelper.PageIndex(2); // should == 0\r\nhelper.PageIndex(20); // should == -1\r\nhelper.PageIndex(-10); // should == -1";
        }



        // TODO: Complete this class

        /// <summary>
        /// Constructor, takes in a list of items and the number of items that fit within a single page
        /// </summary>
        /// <param name="collection">A list of items</param>
        /// <param name="itemsPerPage">The number of items that fit within a single page</param>
        public PaginationHelper(IList<T> collection, int itemsPerPage)
        {
            this.ItemCount = collection.Count;
            this.PageCount = ;
        }

        private int CountPagesForItems(int items, int itemsPerPage)
        {
            int restItems = items;
            int pages = 0;
            while (restItems > itemsPerPage)
            {
                restItems = items - itemsPerPage;
                if()
            }
        }
        /// <summary>
        /// The number of items within the collection
        /// </summary>
        public int ItemCount
        {
            get; set;
        }

        /// <summary>
        /// The number of pages
        /// </summary>
        public int PageCount
        {
            get; set;
        }

        /// <summary>
        /// Returns the number of items in the page at the given page index 
        /// </summary>
        /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
        /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
        public int PageItemCount(int pageIndex)
        {
            if (pageIndex+1 > PageCount) return -1;

            return 0;
        }

        /// <summary>
        /// Returns the page index of the page containing the item at the given item index.
        /// </summary>
        /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
        /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
        public int PageIndex(int itemIndex)
        {
            return 0;
        }
    }
}

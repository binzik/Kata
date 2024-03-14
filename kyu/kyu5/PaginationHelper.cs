using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kyu.kyu5
{
    // Course: https://www.codewars.com/kata/515bb423de843ea99400000a/train/csharp
    //Status: Complete
    public class PaginationHelper<T>
    {
        public string GetTestDescription()
        {
            return "For this exercise you will be strengthening your page-fu mastery. You will complete the PaginationHelper class, which is a utility class helpful for querying paging information related to an array.\r\n\r\nThe class is designed to take in an array of values and an integer indicating how many items will be allowed per each page. The types of values contained within the collection/array are not relevant.\r\n\r\nThe following are some examples of how this class is used:\r\n\r\nvar helper = new PaginationHelper<char>(new List<char>{'a', 'b', 'c', 'd', 'e', 'f'}, 4);\r\nhelper.PageCount; // should == 2\r\nhelper.ItemCount; // should == 6\r\nhelper.PageItemCount(0); // should == 4\r\nhelper.PageItemCount(1); // last page - should == 2\r\nhelper.PageItemCount(2); // should == -1 since the page is invalid\r\n\r\n// pageIndex takes an item index and returns the page that it belongs on\r\nhelper.PageIndex(5); // should == 1 (zero based index)\r\nhelper.PageIndex(2); // should == 0\r\nhelper.PageIndex(20); // should == -1\r\nhelper.PageIndex(-10); // should == -1";
        }

        // TODO: Complete this class
        private IList<T> _collection;
        private int _itemsPerPage;
        //private IList<List<T>> _pages;
        /// <summary>
        /// Constructor, takes in a list of items and the number of items that fit within a single page
        /// </summary>
        /// <param name="collection">A list of items</param>
        /// <param name="itemsPerPage">The number of items that fit within a single page</param>
        public PaginationHelper(IList<T> collection, int itemsPerPage)
        {
            this._collection = collection;
            this._itemsPerPage = itemsPerPage;

            //this._pages = new List<List<T>>();

            //List<T> items = new List<T>();
            //int itemsInPage = 0;
            //int itemIndex = 0;
            //foreach (var item in collection)
            //{
                
            //    items.Add(item);
            //    itemsInPage++;
            //    itemIndex++;

            //    if(itemsInPage == _itemsPerPage || itemIndex==collection.Count)
            //    {
            //        _pages.Add(items);
            //        items.Clear();
            //        itemsInPage = 0;
            //    }
            //}
        }

        /// <summary>
        /// The number of items within the collection
        /// </summary>
        public int ItemCount
        {
            get
            {
                return _collection.Count;
            }
        }

        /// <summary>
        /// The number of pages
        /// </summary>
        public int PageCount
        {
            get
            {
                int pagesCount = _collection.Count / _itemsPerPage;
                if (_collection.Count % _itemsPerPage != 0)
                    pagesCount++;
                return pagesCount;
            }
        }

        /// <summary>
        /// Returns the number of items in the page at the given page index 
        /// </summary>
        /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
        /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
        public int PageItemCount(int pageIndex)
        {
            pageIndex += 1;
            if (pageIndex <= PageCount && pageIndex>0)
            {
                if(this._collection.Count % _itemsPerPage == 0)
                {
                    return this._itemsPerPage;
                }
                else
                {
                    if (pageIndex < PageCount)
                    {
                        return this._itemsPerPage;
                    }
                    else return (this._collection.Count % this._itemsPerPage);
                }
            }
            else return -1;
        }

        /// <summary>
        /// Returns the page index of the page containing the item at the given item index.
        /// </summary>
        /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
        /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
        public int PageIndex(int itemIndex)
        {
            //if (this._collection.Count - 1 >= itemIndex && itemIndex > 0)
            //{
            //    int page = (itemIndex / this._itemsPerPage);
            //    if ((itemIndex % this._itemsPerPage) != 0) page++;
            //    return page - 1;
            //}
            //else if (itemIndex == 0) return 0;
            //else return -1;

            if (this._collection.Count == 0)
            {
                return -1;
            }
            else if (-1 < itemIndex && this._collection.Count > itemIndex)
            {
                int page = (itemIndex / this._itemsPerPage);
                if ((itemIndex % this._itemsPerPage) != 0)
                {
                    page++;
                    return page - 1;
                }
                return page;

            }
            else
                return -1;
        }
    }
}

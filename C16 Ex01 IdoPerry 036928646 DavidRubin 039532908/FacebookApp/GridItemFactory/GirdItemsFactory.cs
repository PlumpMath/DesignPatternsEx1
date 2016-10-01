using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApp.GridItemFactory
{
    using FacebookApp.Interfaces;

    using FacebookWrapper.ObjectModel;

    public class GirdItemsFactory
    {
        public static GridItems CreateGirdItems<T>(FacebookObjectCollection<T> i_FacebookObjectCollection)
            where T : class
        {
            List<IGridItem> createdGridItems = new List<IGridItem>();

            if (i_FacebookObjectCollection != null)
            {
                foreach (T collectionItem in i_FacebookObjectCollection)
                {
                    if (collectionItem is User)
                    {
                        createdGridItems.Add(new GridUser(collectionItem as User));
                    }

                    if (collectionItem is Album)
                    {
                        createdGridItems.Add(new GridAlbum(collectionItem as Album));
                    }
                }
            }

            return new GridItems(createdGridItems);
        }
    }
}
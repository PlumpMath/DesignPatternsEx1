using System;
using System.Collections.Generic;

namespace FacebookApp.GridItemFactory
{
    using System.Collections;
    using System.Drawing.Text;
    using System.Windows.Forms;

    using FacebookApp.Interfaces;

    public class GridItems : IEnumerable<IGridItem>
    {
        private List<IGridItem> m_GridItems;

        public RetrivalStrategy Strategy { get; set; }

        public int Count
        {
            get
            {
                return m_GridItems.Count;
            }
        }

        public IGridItem this[int index]
        {
            get
            {
                return m_GridItems[index];
            }
        }

        public GridItems(List<IGridItem> i_GridItems)
        {
            m_GridItems = i_GridItems;
        }

        public GridItems(List<IGridItem> i_GridItems, RetrivalStrategy i_Strategy)
        {
            m_GridItems = i_GridItems;
            Strategy = i_Strategy;
        }

        public IEnumerator<IGridItem> GetEnumerator()
        {
            return new Iterator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class Iterator : IEnumerator<IGridItem>
        {
            private int m_Index;

            private int m_StartingNumberOfItems;

            private List<IGridItem> m_GridItems;

            private IGridItem m_CurrentItem;

            private RetrivalStrategy m_Strategy;

            public Iterator(GridItems i_GridItems)
            {
                m_Strategy = i_GridItems.Strategy;
                m_Index = m_Strategy.StartingIndex - 1;
                m_GridItems = i_GridItems.m_GridItems;
                m_StartingNumberOfItems = m_GridItems.Count;
            }

            public IGridItem Current
            {
                get
                {
                    return m_CurrentItem;
                }
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                bool hasNext = false;
                if (m_GridItems.Count != m_StartingNumberOfItems)
                {
                    throw new InvalidOperationException();
                }

                ++m_Index;
                if (m_Index < m_GridItems.Count && m_Index < (m_Strategy.StartingIndex + m_Strategy.NumberOfItems))
                {
                    m_CurrentItem = m_GridItems[m_Index];
                    hasNext = true;
                }

                return hasNext;
            }

            public void Reset()
            {
                if (m_GridItems.Count != m_StartingNumberOfItems)
                {
                    throw new InvalidOperationException();
                }

                m_Index = m_Strategy.StartingIndex - 1;
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }
        }

        public class RetrivalStrategy
        {
            public RetrivalStrategy(int i_StartingIndex, int i_NumberOfItems)
            {
                StartingIndex = i_StartingIndex;
                NumberOfItems = i_NumberOfItems;
            }

            public int StartingIndex { get; set; }

            public int NumberOfItems { get; set; }
        }
    }
}
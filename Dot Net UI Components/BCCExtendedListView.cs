using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BCC.DotNetUI.Components
{
    public class BCCExtendedListView : ListView
    {
        public int LimitDisplayNumber { get; set; }
        public bool IgnoreDoubleClickCheck { get; set; }
        public bool EnableAutomaticScroll { get; set; }
        private bool CheckFromDoubleClick { get; set; }
        public int MaxNumberWhenPaused { get; set; }
        public bool ReactToLogLevel { get; set; }
        public int LogLevelColumnIndicator { get; set; }
        public LoggingLevel LogLevel { get; set; }

        private int sortColumn = -1;
        private bool paused = false;
        private List<ListViewItem> pauseList = new List<ListViewItem>();

        public event onItemAddedEventHandler onItemAdded;
        public delegate void onItemAddedEventHandler(ListViewItem item);
        public event onPausedEventHandler onPaused;
        public delegate void onPausedEventHandler();
        public event onUnPausedEventHandler onUnPaused;
        public delegate void onUnPausedEventHandler();

        public enum LoggingLevel
        {
            Debug = 0,
            Info = 1
        }

        public object IsPaused
        {
            get { return paused; }
        }

        public BCCExtendedListView()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.View = View.Details;
            this.GridLines = true;
            this.FullRowSelect = true;
            this.ColumnClick += DataColumnClick;
        }

        protected override void OnItemCheck(ItemCheckEventArgs ice)
        {
            if (IgnoreDoubleClickCheck)
            {
                if (this.CheckFromDoubleClick)
                {
                    ice.NewValue = ice.CurrentValue;
                    this.CheckFromDoubleClick = false;
                }
                else
                {
                    base.OnItemCheck(ice);
                }
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (IgnoreDoubleClickCheck)
            {
                if ((e.Button == MouseButtons.Left) && (e.Clicks > 1))
                {
                    this.CheckFromDoubleClick = true;
                }
            }
            base.OnMouseDown(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (IgnoreDoubleClickCheck)
            {
                this.CheckFromDoubleClick = false;
            }
            base.OnKeyDown(e);
        }

        private void DataColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != sortColumn)
            {
                sortColumn = e.Column;
                this.Sorting = SortOrder.Ascending;
            }
            else
            {
                if (this.Sorting == SortOrder.Ascending)
                {
                    this.Sorting = SortOrder.Descending;
                }
                else
                {
                    this.Sorting = SortOrder.Ascending;
                }
            }
            this.Sort();
            this.ListViewItemSorter = new ListViewItemComparer(e.Column, this.Sorting);
            //this.SetSortIcon(e.Column, this.Sorting);
        }

        private void AutomaticScroll()
        {
            if (EnableAutomaticScroll)
            {
                this.EnsureVisible(this.Items.Count - 1);
            }
        }

        public void PauseInput()
        {
            if (paused == false)
            {
                paused = true;
                pauseList.Clear();
                this.BackColor = Color.FloralWhite;
                AutomaticScroll();                
                this.Update();
                if (onPaused != null)
                {
                    onPaused();
                }
            }
        }

        public void StepNextLogLine()
        {
            if (paused)
            {
                if (pauseList.Count > 0)
                {
                    ListViewItem addItem = pauseList.First();
                    this.Items.Add(addItem);
                    this.EnsureVisible(this.Items.Count - 1);
                    this.Update();
                    pauseList.Remove(addItem);
                    if (pauseList.Count == 0)
                    {
                        ResumeInput();
                    }
                }
                else
                {
                    ResumeInput();
                }
            }
        }

        public void ResumeInput()
        {
            if (paused)
            {
                paused = false;
                foreach (ListViewItem item in pauseList)
                {
                    LimitAdd(item);
                    this.EnsureVisible(this.Items.Count - 1);
                    this.Update();
                }
                pauseList.Clear();
                this.BackColor = Color.White;
                if (onUnPaused != null)
                {
                    onUnPaused();
                }
            }
        }

        public void ResumeInputSkipPreviousLines()
        {
            if (paused)
            {
                paused = false;
                this.EnsureVisible(this.Items.Count - 1);
                this.Update();
                pauseList.Clear();
                this.BackColor = Color.White;
                if (onUnPaused != null)
                {
                    onUnPaused();
                }
            }
        }

        public ListViewItem LimitAdd(ListViewItem value)
        {
            ListViewItem item = value;
            if (paused)
            {
                pauseList.Add(item);
                if (pauseList.Count >= MaxNumberWhenPaused & MaxNumberWhenPaused > 0)
                {
                    ResumeInput();
                }
            }
            else
            {
                if (LimitDisplayNumber > 0)
                {
                    if (this.Items.Count == LimitDisplayNumber)
                    {
                        this.Items.RemoveAt(0);
                    }
                }
                bool addItem = true;
                if (ReactToLogLevel & LogLevelColumnIndicator > -1)
                {
                    string checkLevel = item.SubItems[LogLevelColumnIndicator].Text.ToLower();
                    if (LogLevel == LoggingLevel.Info)
                    {
                        if (!checkLevel.Equals("info"))
                        {
                            addItem = false;
                        }
                    }
                }
                if (addItem)
                {
                    this.Items.Add(item);
                    AutomaticScroll();
                    if (onItemAdded != null)
                    {
                        onItemAdded(value);
                    }
                }
            }
            return item;
        }

        public class ListViewItemComparer : IComparer
        {

            private int col;

            private SortOrder order = SortOrder.Ascending;
            public ListViewItemComparer()
            {
                col = 0;
                this.order = SortOrder.Ascending;
            }

            public ListViewItemComparer(int column, SortOrder order)
            {
                col = column;
                this.order = order;
            }

            public int Compare(object x, object y)
            {
                int returnVal = -1;
                //returnVal = String.Compare(((ListViewItem)x).SubItems(col).Text, ((ListViewItem)y).SubItems(col).Text);
                if (order == SortOrder.Descending)
                {
                    returnVal *= -1;
                }
                return returnVal;
            }

        }
    }
}

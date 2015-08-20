using System;

namespace SplitviewUWP.Models
{
    public class MenuItem
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public Type View { get; set; }

        public MenuItem(string icon, string title, Type view)
        {
            Icon = icon;
            Title = title;
            View = view;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagsNoteConsole
{
    public class Note
    {
        private string title;
        List<string> tags;
        DateTime createDate;
        DateTime lastModify;

        public string Title { get => title; set => title = value; }
        public List<string> Tags { get => tags; set => tags = value; }
        public DateTime CreateDate { get => createDate; set => createDate = value; }
        public DateTime LastModify { get => lastModify; set => lastModify = value; }

        public Note()
        {
            createDate = DateTime.Now;
            lastModify = DateTime.Now;
        }

        public Note(string title, List<string> tags)
        {
            Title = title;
            Tags = tags;
        }

    }
}

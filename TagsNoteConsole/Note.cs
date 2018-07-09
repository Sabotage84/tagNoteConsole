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

        public Note(string title, List<string> tags): this()
        {
            Title = title;
            Tags = tags;
        }

        public override bool Equals(object obj)
        {
            Note _note = obj as Note;
            if (_note == null)
            {
                Console.WriteLine("Преобразование прошло неудачно");
            }
            else
            {
                if (_note.Title == Title /*&& _note.CreateDate==CreateDate*/)
                {
                    return _note.tags.SequenceEqual(tags);
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            var hashCode = -51452015;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(title);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<string>>.Default.GetHashCode(tags);
            hashCode = hashCode * -1521134295 + createDate.GetHashCode();
            hashCode = hashCode * -1521134295 + lastModify.GetHashCode();
            return hashCode;
        }
    }
}

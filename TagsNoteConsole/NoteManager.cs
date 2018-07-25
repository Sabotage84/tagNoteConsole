using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagsNoteConsole
{
    public class NoteManager
    {
        private List<Note> notes;

        public NoteManager()
        {
            Notes = new List<Note>();
        }

        public NoteManager(List<Note> _notes)
        {
            Notes = _notes;
        }

        public List<Note> Notes { get => notes; private set => notes = value; }

        public void AddNote(Note newNote)
        {
            Notes.Add(newNote);
        }

        public void AddNote(string title, List<string> tags)
        {
            Notes.Add(new Note(title, tags));
        }

        public void DeleteNote(Note note)
        {
            Notes.Remove(note);
        }

        public List<Note> SearchByTagsAND(List<string> searchTags)
        {
            List<Note> tempList = new List<Note>();

            foreach (var item in Notes)
            {
                IEnumerable<string> inter = item.Tags.Intersect(searchTags);
                if (inter.Count() == searchTags.Count)
                    tempList.Add(item);
            }

            return tempList;
        }

        public List<Note> SearchByTagsOR(List<string> searchTags)
        {
            List<Note> tempList = new List<Note>();

            foreach (var item in Notes)
            {
                IEnumerable<string> inter = item.Tags.Intersect(searchTags);
                if (inter.Count() >= 1)
                    tempList.Add(item);
            }
            return tempList;
        }

        public List<Note> SearchByTagsNOT(List<string> searchTags)
        {
            List<Note> tempList = new List<Note>();

            foreach (var item in Notes)
            {
                IEnumerable<string> inter = item.Tags.Intersect(searchTags);
                if (inter.Count() == 0)
                    tempList.Add(item);
            }
            return tempList;
        }

        public List<Note> AdvanceSearch(List<string> listAnd=null, List<string> listOR=null, List<string> listNot=null)
        {
            List<Note> tempList = notes;
            NoteManager nm = new NoteManager(tempList);
            if (listAnd != null)
            {
                tempList = nm.SearchByTagsAND(listAnd);
                nm = new NoteManager(tempList);
            }
            if (listOR!=null)
            {
                tempList = nm.SearchByTagsOR(listOR);
                nm = new NoteManager(tempList);
            }
            if (listNot!=null)
            {
                tempList = nm.SearchByTagsNOT(listNot);
               // nm = new NoteManager(tempList);
            }
            
            return tempList;
        }

    }
}

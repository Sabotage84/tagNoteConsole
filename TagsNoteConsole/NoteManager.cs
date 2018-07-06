using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagsNoteConsole
{
    public class NoteManager
    {
        public List<Note> notes;

        public NoteManager()
        {
            notes = new List<Note>();
        }

        public NoteManager(List<Note> _notes)
        {
            notes = _notes;
        }

        public void AddNote(Note newNote)
        {
            notes.Add(newNote);
        }

        public void AddNote(string title, List<string> tags)
        {
            notes.Add(new Note(title, tags));
        }

        public void DeleteNote(Note note)
        {
            notes.Remove(note);
        }

    }
}

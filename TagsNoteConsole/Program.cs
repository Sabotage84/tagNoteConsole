using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagsNoteConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тестовый вариант программы заметок!");

            NoteManager nm = new NoteManager();

            nm.AddNote("test1", new List<string> { "not", "and", "or", "xor" });
            nm.AddNote("test2", new List<string> { "not", "and", "or" });
            nm.AddNote("test3", new List<string> { "not", "and" });
            nm.AddNote("test4", new List<string> { "not" });
            nm.AddNote("test5", new List<string> { "and", "or", "xor" });
            nm.AddNote("test6", new List<string> { "or", "xor" });
            nm.AddNote("test7", new List<string> { "xor" });
            nm.AddNote("test8", new List<string> { "not", "xor" });
            nm.AddNote("test9", new List<string> { "not", "and", "xor" });
            nm.AddNote("test10", new List<string> { "not", "or", "xor" });
            nm.AddNote("test11", new List<string> { "and", "or" });
            nm.AddNote("test12", new List<string> { "and", "xor" });
            nm.AddNote("test13", new List<string> { "not", "or" });
            nm.AddNote("test14", new List<string> { });

            nm.SearchByTagsAND(new List<string> { "not", "or" });

            Console.ReadKey();
        }
    }
}

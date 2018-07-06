using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagsNoteConsole;

namespace UnitTestProject2
{
    /// <summary>
    /// Сводное описание для NoteManagerTest
    /// </summary>
    [TestClass]
    public class NoteManagerTest
    {

        [TestMethod]
        public void TestAddNote()
        {
            NoteManager testManager = new NoteManager();
            Note note = new Note("testAdd", new List<string> { "tag33", "TAG44" });
            testManager.AddNote(note);
            Assert.IsTrue(testManager.notes.Contains(note));
        }

        [TestMethod]
        public void TestAddNote2()
        {
            NoteManager testManager = new NoteManager();
            
            testManager.AddNote("testAdd", new List<string> { "tag33", "TAG44" });

            Note note = new Note("testAdd", new List<string> { "tag33", "TAG44"});
            Assert.IsTrue(testManager.notes.Count==1);
        }

        [TestMethod]
        public void TestDeleteNote()
        {
            NoteManager testManager = new NoteManager();

            testManager.AddNote("testAdd", new List<string> { "tag33", "TAG44" });

            Note note = new Note("testAdd", new List<string> { "tag33", "TAG44" });

            testManager.DeleteNote(note);
            Assert.IsTrue(testManager.notes.Count == 0);
        }
    }
}

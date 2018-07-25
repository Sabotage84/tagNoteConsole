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
        NoteManager testerManager;

        [TestInitialize]
        public void Init()
        {
            testerManager = new NoteManager();
            testerManager.AddNote("test1", new List<string> { "not", "and", "or", "xor"});
            testerManager.AddNote("test2", new List<string> { "not", "and", "or"});
            testerManager.AddNote("test3", new List<string> { "not", "and"});
            testerManager.AddNote("test4", new List<string> { "not"});
            testerManager.AddNote("test5", new List<string> { "and", "or", "xor" });
            testerManager.AddNote("test6", new List<string> { "or", "xor" });
            testerManager.AddNote("test7", new List<string> { "xor" });
            testerManager.AddNote("test8", new List<string> { "not", "xor" });
            testerManager.AddNote("test9", new List<string> { "not", "and", "xor" });
            testerManager.AddNote("test10", new List<string> { "not", "or", "xor" });
            testerManager.AddNote("test11", new List<string> { "and", "or" });
            testerManager.AddNote("test12", new List<string> { "and", "xor" });
            testerManager.AddNote("test13", new List<string> { "not", "or" });
            testerManager.AddNote("test14", new List<string> { });
        }

        [TestMethod]
        public void TestAddNote()
        {
            NoteManager testManager = new NoteManager();
            Note note = new Note("testAdd", new List<string> { "tag33", "TAG44" });
            testManager.AddNote(note);
            Assert.IsTrue(testManager.Notes.Contains(note));
        }

        [TestMethod]
        public void TestAddNote2()
        {
            NoteManager testManager = new NoteManager();
            
            testManager.AddNote("testAdd", new List<string> { "tag33", "TAG44" });

            Note note = new Note("testAdd", new List<string> { "tag33", "TAG44"});
            Assert.IsTrue(testManager.Notes.Count==1);
        }

        [TestMethod]
        public void TestDeleteNote()
        {
            NoteManager testManager = new NoteManager();

            testManager.AddNote("testAdd", new List<string> { "tag33", "TAG44" });
            Assert.IsTrue(testManager.Notes.Count == 1);
            Note note = new Note("testAdd", new List<string> { "tag33", "TAG44" });
            testManager.DeleteNote(note);
            Assert.IsTrue(testManager.Notes.Count == 0);
        }

        [TestMethod]
        public void TestDeleteNote2()
        {
            NoteManager testManager = new NoteManager();
            testManager.AddNote("testAdd", new List<string> { "tag33", "TAG44" });
            Note note2 = testManager.Notes[0];
            Assert.IsTrue(testManager.Notes.Count == 1);
            Note note = new Note("testAdd", new List<string> { "tag3", "TAG44" });
            testManager.DeleteNote(note);
            Assert.IsFalse(testManager.Notes.Count == 0);
            testManager.AddNote("testAdd", new List<string> { "tag33", "TAG44" });
            Assert.IsTrue(testManager.Notes.Count == 2);
            testManager.DeleteNote(note2);
            Assert.IsTrue(testManager.Notes.Count == 1);
        }

        [TestMethod]
        public void Testsetup()
        {
            Assert.AreEqual(14, testerManager.Notes.Count);
        }

        [TestMethod]
        public void TestSearchByTagsAND()
        {
            List<Note> list1 = testerManager.SearchByTagsAND(new List<string> {"not", "and" });
            List<Note> list2 = testerManager.SearchByTagsAND(new List<string> {"xor", "or" });
            List<Note> list3 = testerManager.SearchByTagsAND(new List<string> { "not", "xor"});

            Assert.AreEqual(4, list1.Count);
            Assert.AreEqual(4, list2.Count);
            Assert.AreEqual(4, list3.Count);
        }

        [TestMethod]
        public void TestSearchByTagsOR()
        {
            List<Note> list1 = testerManager.SearchByTagsOR(new List<string> { "not", "and" });
            List<Note> list2 = testerManager.SearchByTagsOR(new List<string> { "xor", "or" });
            List<Note> list3 = testerManager.SearchByTagsOR(new List<string> { "not", "xor" });

            Assert.AreEqual(11, list1.Count);
            Assert.AreEqual(11, list2.Count);
            Assert.AreEqual(12, list3.Count);
        }

        [TestMethod]
        public void TestSearchByTagsNOT()
        {
            List<Note> list1 = testerManager.SearchByTagsNOT(new List<string> { "not", "and" });
            List<Note> list2 = testerManager.SearchByTagsNOT(new List<string> { "xor", "or" });
            List<Note> list3 = testerManager.SearchByTagsNOT(new List<string> { "not", "xor" });

            Assert.AreEqual(3, list1.Count);
            Assert.AreEqual(3, list2.Count);
            Assert.AreEqual(2, list3.Count);
        }

        [TestMethod]
        public void TestAdvancedSearch()
        {
            List <string> listAND = new List<string> { "not", "and" };
            List<string> listOR = new List<string> { "xor", "and" };
            List<string> listNOT = new List<string> { "or"};


            List<Note> list1 = testerManager.AdvanceSearch(listAND,listOR,listNOT);
            //List<Note> list2 = testerManager.SearchByTagsNOT(new List<string> { "xor", "or" });
            //List<Note> list3 = testerManager.SearchByTagsNOT(new List<string> { "not", "xor" });

            Assert.AreEqual(2, list1.Count);
            //Assert.AreEqual(3, list2.Count);
            //Assert.AreEqual(2, list3.Count);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagsNoteConsole;

namespace UnitTests
{
    [TestClass]
    public class NoteTest
    {
        [TestMethod]
        public void TestNoteBaseConstructor()
        {
            Note note = new Note();
            Assert.AreEqual(DateTime.Now, note.CreateDate);
        }
        [TestMethod]
        public void TestLastModify()
        {
            Note note = new Note();
            Assert.AreEqual(DateTime.Now, note.LastModify);
        }

        [TestMethod]
        public void TestNoteConstructor()
        {
            Note note = new Note("title1", new System.Collections.Generic.List<string> { "tag1", "tag2"});
            Assert.AreEqual("title1", note.Title);
            Assert.AreEqual("tag1", note.Tags[0]);
            Assert.AreEqual("tag2", note.Tags[1]);
        }

    }
}

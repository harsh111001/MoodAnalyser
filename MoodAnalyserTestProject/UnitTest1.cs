using MoodAnalyserDemo;
namespace MoodAnalyserTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SadShouldReturnSad()
        {
            //arrange
            string expected = "sad";
            string message = "i am sad";
            MoodAnalyser mood = new MoodAnalyser(message);

            //act
            string actual = mood.analyseMood();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HappyShouldReturnHappy()
        {
            //arrange
            string expected = "happy";
            string message = "i am happy";
            MoodAnalyser mood = new MoodAnalyser(message);

            //act
            string actual = mood.analyseMood();

            //assert
            Assert.AreEqual(expected, actual);
        }
        //[TestMethod]
        //[DataRow(null)]
        //public void NullShouldReturnHappy(string message)
        //{
        //    //arrange
        //    string expected = "happy";
        //    MoodAnalyser mood = new MoodAnalyser(message);

        //    //act
        //    string actual = mood.analyseMood();

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
        [TestMethod]
        public void EmptyShouldReturnExceptionindicatingEmpty()
        {
            try
            {
                string message = "";
                MoodAnalyser obj=new MoodAnalyser(message);
                string actual = obj.analyseMood();
            }catch(MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Message should not be empty", e.Message);
            }
        }
        [TestMethod]
        [DataRow(null)]
        public void NullShouldReturnExceptionindicatingNull(string message)
        {
            try
            {
                MoodAnalyser obj = new MoodAnalyser(message);
                string actual = obj.analyseMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Message should not be null", e.Message);
            }
        }
    }
}
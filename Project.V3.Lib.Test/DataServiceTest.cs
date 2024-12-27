using Project.V3.Lib;

namespace Project.V3.Lib.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Table ds = new Table();
            ds.LoadTable(Path.Combine(new string[] { Path.GetTempPath(), "Sprint7", "TestTable.csv" }));

            //var res = ds.GetTable();
            //var res2 = ds.GetBy("NameOfBook");
            //var res3 = ds.DelColumn("NameOfBook");
            //var res4 = ds.DelLine(2);
            //var res5 = ds.ChangeCell(1, 1, "Иностранный язык");
            //var res6 = ds.AddLine();
            var res7 = ds.SortBy("id", true);
            var res8 = ds.Search("yazik");

            Table ds2 = new Table();
            ds2.LoadTable(Path.Combine(new string[] { Path.GetTempPath(), "Sprint7", "TestTable2.csv" }));

            var res9 = ds2.ChartCount("Кабинет");
            var res10 = ds2.ChartSum("Кабинет", "id");
            var res11 = ds2.GetKeys();
            { }
        }
    }
}
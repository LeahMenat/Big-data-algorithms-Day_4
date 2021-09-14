using System;
using System.Collections.Generic;
using Dijkstra_implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DijkstraUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] p = new int[] { 1 };
            Edge1<string>[] e = new Edge1<string>[] {
                new Edge1<string>("Herzliya", "Modi'in", 2),
                new Edge1<string>("Herzliya","Tel Aviv", 10),
                new Edge1<string>( "Modi'in","Jerusalem", 8),
                new Edge1<string>( "Modi'in","Tel Aviv", 6),
                new Edge1<string>("Tel Aviv","Jerusalem", 1)
            };

            LinkedList<Vertice<string>> retGraph = Graph<string>.ArrayOfAdjacencyList(e, "Herzliya");
            if (retGraph.Count != 4) Assert.Fail("expect retGraph.Count to be 4 and actual: " + retGraph.Count);
            foreach (var item in retGraph)
            {
                switch (item.Name)
                {
                    case "Herzliya":if (item.Dist != 0) Assert.Fail("Herzliya dist not equals 0");
                        break;
                    case "Modi'in":
                        if (item.Dist != 2) Assert.Fail("Modi'in dist not equals 2");
                        break;
                    case "Tel Aviv":
                        if (item.Dist != 8) Assert.Fail("Tel Aviv dist not equals 8");
                        break;
                    case "Jerusalem":
                        if (item.Dist != 9) Assert.Fail("Jerusalem dist not equals 9");
                        break;
                    default:Assert.Fail("invalid value");
                        break;
                }
            }
        }
    }
}

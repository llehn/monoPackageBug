using System.IO.Packaging;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var package = Package.Open("broken.nupkg");
            var rels = package.GetRelationshipsByType("anonymous");
        }
    }
}

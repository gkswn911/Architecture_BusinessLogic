public interface INode
{
void Print();
}
public class AnotherNode
{
public void Output()
{
Console.WriteLine("Output");
}
}
public class Node : INode
{
public void Print()
{
Console.WriteLine("Node");
}
}
public class Adapter : INode
{
private AnotherNode node = new AnotherNode();
public void Print()
{
node.Output();
}
}
class Program
{
static void Main(string[] args)
{
var list = new List<INode>();

list.Add(new Adapter());
list.Add(new Node());
foreach (var node in list)
{
node.Print();
}
Console.WriteLine("Press any key...");
Console.ReadKey();
}
}


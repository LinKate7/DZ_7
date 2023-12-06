
interface IChristmasTree
{
    public string DecorationsType { get; set; }
    public string GarlandType { get; set; }
    void Decorate();
}

class ChristmasTree : IChristmasTree
{
    public string DecorationsType { get; set; }
    public string GarlandType { get; set; }
    public void Decorate()
    {
        Console.WriteLine("Regular Christmas Tree is decorated.");
    }
}

class TreeDecorator : IChristmasTree
{
    public string DecorationsType
    {
        get { return _tree.DecorationsType; }
        set { _tree.DecorationsType = value; }
    }

    public string GarlandType
    {
        get { return _tree.GarlandType; }
        set { _tree.GarlandType = value; }
    }

    IChristmasTree _tree;

    public TreeDecorator (IChristmasTree tree)
    {
        _tree = tree;
    }
    public virtual void Decorate()
    {
        Console.WriteLine("Christmas Tree is decorated");
    }
}

class DecorationsTreeDecorator: TreeDecorator
{
   
    public DecorationsTreeDecorator (IChristmasTree tree, string decorations) : base (tree)
    {
        DecorationsType = decorations;
    }
    public override void Decorate()
    {
        
        Console.WriteLine($"The Christmas Tree is decorated with {DecorationsType}" );
    }
}

class GarlandTreeDecorator : TreeDecorator
{

    public GarlandTreeDecorator (IChristmasTree tree, string garland) : base(tree)
    {
        GarlandType = garland;
    }
    public override void Decorate()
    {

        Console.WriteLine($"The Christmas Tree is decorated with {GarlandType}");
    }

}

class Program
{
    static void Main(string[] args)
    {
        IChristmasTree tree1 = new ChristmasTree();
        string garland1 = "multicolor";
        TreeDecorator dec = new GarlandTreeDecorator(tree1, garland1);
        dec.Decorate();
        string decorations = "red bulbs";
        dec = new DecorationsTreeDecorator(tree1, decorations);
        dec.Decorate();
    }
}

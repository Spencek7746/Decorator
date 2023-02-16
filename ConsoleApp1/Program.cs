interface Widget
{
    public void draw();
}

abstract class Decorator : Widget
{
    Widget wid;
    public Decorator(Widget w)
    {
        wid = w;
    }

    public void draw()
    {
        Console.WriteLine("Drawing in Decorator");
    }
}

public class TextField : Widget
{
    int width;
    int height;

    public TextField(int w , int h)
    {
        width = w; height = h;
    }

    public void draw()
    {
        Console.WriteLine("Drawing in TextField");
    }
}

class BorderDecorator : Decorator
{
    public BorderDecorator(Widget w) : base(w)
    {
        base.Equals(w);
    }

    public void draw()
    {
        base.draw();
        Console.WriteLine("BorderDecorator");
    }
}

class ScrollDecorator : Decorator
{
    public ScrollDecorator(Widget w) : base(w)
    {
        base.Equals(w);
    }

    public void draw()
    {
        base.draw();
        Console.WriteLine("ScrollDecorator");
    }
}

class Program
{
    static void Main(String[] args)
    {
        TextField text = new TextField(10, 10);
        BorderDecorator decorator = new BorderDecorator(text);
        decorator.draw();
        ScrollDecorator scroll = new ScrollDecorator(text);
        scroll.draw();

        Console.ReadLine();
    }
}


namespace CollinearityLib;

public struct Vector2D
{
    public int X { get; set; }
    public int Y { get; set; }

    public Vector2D() { }

    public Vector2D(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Vector2D(Vector2D vector)
    {
        this.X = vector.X;
        this.Y = vector.Y;
    }
}

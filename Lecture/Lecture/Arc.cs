namespace Lecture;

public struct Arc
{
    // Value types are almost always immutable
    // Should be read only and set in the constructor

    public Arc(int angle, int length)
    {
        Angle = angle;
        Length = length;
    }
    int Angle { get; }
    int Length { get; }
}

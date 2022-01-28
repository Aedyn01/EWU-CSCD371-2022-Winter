namespace Lecture;
public enum Grade
{
    // If the enum does not support 0, add "None" to the top
    None, 
    F = 1,
    D,
    C,
    B,
    A
}

[Flags]
public enum FileAttribute : int
{
    None, 
    Hidden,
    ReadOnly,
    System = Hidden & ReadOnly
}

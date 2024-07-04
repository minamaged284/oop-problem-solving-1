namespace assignment_1
{
    [Flags]
    public enum Permissions : byte
    {
        read = 1, write = 2, delete = 4, execute = 8
    }
}

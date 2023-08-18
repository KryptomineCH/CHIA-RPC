[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
sealed class ExperimentalAttribute : Attribute
{
    public string Reason { get; }

    public ExperimentalAttribute(string reason)
    {
        Reason = reason;
    }
}
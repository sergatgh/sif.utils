namespace SIF.Utils.Forms.Common;

public delegate void ResultEventHandler<T>(object? sender, ResultEventArgs<T> e);

public class ResultEventArgs<T>(T result) : EventArgs
{
    public T Result { get; set; } = result;

    public static implicit operator ResultEventArgs<T>(T arg)
    {
        return new ResultEventArgs<T>(arg);
    }
}
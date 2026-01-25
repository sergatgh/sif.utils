namespace SIF.Utils.Forms.Common
{
    public class LongOperationState : IDisposable
    {
        public LongOperationState()
        {
            Cursor.Current = Cursors.WaitCursor;
        }

        public void Dispose()
        {
            Cursor.Current = Cursors.Default;
        }
    }
}

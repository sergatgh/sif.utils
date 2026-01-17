namespace SIF.Utils.Forms.Common
{
    public class LongOperationState : IDisposable
    {
        private readonly UserControl _control;

        public LongOperationState(UserControl control)
        {
            _control = control;
            control.Cursor = Cursors.WaitCursor;
        }

        public void Dispose()
        {
            _control.Cursor = Cursors.Default;
        }
    }
}

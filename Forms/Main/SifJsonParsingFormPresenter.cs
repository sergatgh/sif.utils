namespace SIF.Utils.Forms.Main;

public class SifJsonParsingFormPresenter(SifJsonParsingForm view)
{
    private readonly Stack<MainViewPageType> _stateStack = new();

    public MainViewPageType CurrentState => _stateStack.Any() ? _stateStack.Peek() : MainViewPageType.None;

    public void UpdateView(MainViewPageType state)
    {
        ShowState(state);

        if (state != CurrentState) _stateStack.Push(state);
    }

    public void GoHome()
    {
        _stateStack.Clear();
        UpdateView(MainViewPageType.Initial);
    }

    protected void ShowState(MainViewPageType state, bool back = false)
    {
        HideAllPanels();

        switch (state)
        {
            case MainViewPageType.Initial:
                view.MainSelectFilePanel.Visible = true;
                break;

            case MainViewPageType.FileSelected:
                view.MainJsonViewer.Visible = true;
                break;

            case MainViewPageType.SetPropertiesForNewPsScript:
                view.MainScriptRunnerForm.Visible = true;
                break;

            case MainViewPageType.ChooseFormat:
                view.MainChooseExportFormat.Visible = true;
                view.MainChooseExportFormat.GenerateExportScript();
                break;

            case MainViewPageType.ErrorText:
                view.MainFileParsingError.Visible = true;
                break;

            case MainViewPageType.JsonBuilder:
                view.MainJsonBuilder.Visible = true;
                break;

            default:
                throw new ArgumentOutOfRangeException(nameof(state), state, null);
        }
    }

    public void GoBack()
    {
        if (_stateStack.Count <= 1) return;
        // Pop current state
        _stateStack.Pop();
        // Get previous state
        var previousState = _stateStack.Peek();
        ShowState(previousState, true);
    }

    public void HideAllPanels()
    {
        view.Controls.OfType<Control>().Where(x => x.Name.StartsWith("Main")).ToList().ForEach(panel => panel.Visible = false);
    }
}
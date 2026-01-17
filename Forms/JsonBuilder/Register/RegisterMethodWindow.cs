namespace SIF.Utils.Forms.JsonBuilder.Register;

public partial class RegisterMethodWindow : Form
{
    public RegisterMethodWindow()
    {
        InitializeComponent();
    }

    public RegisterMethodModel GetRegisterMethodModel()
    {
        return new RegisterMethodModel
        {
            PowershellFunction = txtPowershellFunction.TextInput,
            RegisterAs = txtRegisterAs.TextInput,
        };
    }

    public void SetRegisterMethodModel(RegisterMethodModel model)
    {
        txtPowershellFunction.TextInput = model.PowershellFunction;
        txtRegisterAs.TextInput = model.RegisterAs;
    }
}
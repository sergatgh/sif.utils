namespace SIF.Utils.Forms.SelectFile;

partial class SelectJsonFileDialog
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        selectFileForm = new SelectFileForm();
        SuspendLayout();
        //
        // selectFileForm
        //
        selectFileForm.AllowRawJson = true;
        selectFileForm.AllowUrl = true;
        selectFileForm.Dock = DockStyle.Fill;
        selectFileForm.Location = new Point(0, 0);
        selectFileForm.Name = "selectFileForm";
        selectFileForm.Size = new Size(1026, 591);
        selectFileForm.TabIndex = 0;
        //
        // SelectJsonFileDialog
        //
        ClientSize = new Size(1026, 591);
        Controls.Add(selectFileForm);
        FormBorderStyle = FormBorderStyle.Sizable;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "SelectJsonFileDialog";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Select File";
        ResumeLayout(false);
    }

    private SelectFileForm selectFileForm;
}

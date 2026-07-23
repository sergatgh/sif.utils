using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks;
using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks.Controls.SIF;
using SIF.Utils.Helpers;
using SIF.Utils.Properties;
using System.ComponentModel;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder;

public static class SifFrameworkTasks
{
    public static List<TaskInfo> Tasks { get; } =
    [
        new TaskInfo { Source = "SIF", Image = Resources.app_pool_icon, Name = "AppPool", ControlFactory = CreateAppPoolEditor },
        new TaskInfo { Source = "SIF", Image = Resources.command_5515389, Name = "Command", ControlFactory = CreateCommandEditor },
        new TaskInfo { Source = "SIF", Image = Resources.copy_icon, Name = "Copy", ControlFactory = CreateCopyEditor },
        new TaskInfo { Source = "SIF", Image = Resources.service_8473597, Name = "CreateService", ControlFactory = CreateCreateServiceEditor },
        new TaskInfo { Source = "SIF", Image = Resources.download_189249, Name = "DownloadFile", ControlFactory = CreateDownloadFileEditor },
        new TaskInfo { Source = "SIF", Image = Resources.folder_logo_icon, Name = "EnsurePath", ControlFactory = CreateEnsurePathEditor },
        new TaskInfo { Source = "SIF", Image = Resources.permission, Name = "FilePermissions", ControlFactory = CreateFilePermissionsEditor },
        new TaskInfo { Source = "SIF", Image = Resources.local_network, Name = "HostHeader", ControlFactory = CreateHostHeaderEditor },
        new TaskInfo { Source = "SIF", Image = Resources.http, Name = "HttpRequest", ControlFactory = CreateHttpRequestEditor },
        new TaskInfo { Source = "SIF", Image = Resources.icons8_xml_file_64, Name = "InsertXml", ControlFactory = CreateInsertXmlEditor },
        new TaskInfo { Source = "SIF", Image = Resources.export_xml_64, Name = "IoXml", ControlFactory = CreateIoXmlEditor },
        new TaskInfo { Source = "SIF", Image = Resources.management_service, Name = "ManageService", ControlFactory = CreateManageServiceEditor },
        //new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "ManageSolrConfig" },
        //new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "ManageSolrCore" },
        new TaskInfo { Source = "SIF", Image = Resources.manage_sorl_schema, Name = "ManageSolrSchema", ControlFactory = CreateManageSolrSchemaEditor },
        new TaskInfo { Source = "SIF", Image = Resources.new_certificate, Name = "NewRootCertificate", ControlFactory = CreateNewRootCertificateEditor },
        new TaskInfo { Source = "SIF", Image = Resources.signed_certificate, Name = "NewSignedCertificate", ControlFactory = CreateNewSignedCertificateEditor },
        new TaskInfo { Source = "SIF", Image = Resources.remove_app_pool, Name = "RemoveAppPool", ControlFactory = CreateRemoveAppPoolEditor },
        new TaskInfo { Source = "SIF", Image = Resources.remove_service, Name = "RemoveService", ControlFactory = CreateRemoveServiceEditor },
        new TaskInfo { Source = "SIF", Image = Resources.delete_database, Name = "RemoveSqlDatabase", ControlFactory = CreateRemoveSqlDatabaseEditor },
        new TaskInfo { Source = "SIF", Image = Resources.remove_xml_icon, Name = "RemoveXml", ControlFactory = CreateRemoveXmlEditor },
        new TaskInfo { Source = "SIF", Image = Resources.edit_xml_file, Name = "SetXml", ControlFactory = CreateSetXmlEditor },
        new TaskInfo { Source = "SIF", Image = Resources.url, Name = "SitecoreUrl", ControlFactory = CreateSitecoreUrlEditor },
        new TaskInfo { Source = "SIF", Image = Resources.transformation, Name = "TransformXmlDoc", ControlFactory = CreateTransformXmlDocEditor },
        new TaskInfo { Source = "SIF", Image = Resources.zip, Name = "Unpack", ControlFactory = CreateUnpackEditor },
        new TaskInfo { Source = "SIF", Image = Resources.dll, Name = "UpdateBindingRedirects", ControlFactory = CreateUpdateBindingRedirectsEditor },
        new TaskInfo { Source = "SIF", Image = Resources.deployment, Name = "WebDeploy", ControlFactory = CreateWebDeployEditor },
        new TaskInfo { Source = "SIF", Image = Resources.link, Name = "WebRequest", ControlFactory = CreateWebRequestEditor },
        new TaskInfo { Source = "SIF", Image = Resources.website_logo_icon, Name = "WebSite", ControlFactory = CreateWebSiteEditor },
    ];

    private static string GetParam(List<TaskParameterModel> parameters, string name) =>
        parameters.FirstOrDefault(p => p.Name == name)?.Value ?? string.Empty;

    private static string[] DecodeArray(string value)
    {
        if (string.IsNullOrEmpty(value)) return [];
        if (value.TrimStart().StartsWith('['))
        {
            try
            {
                return JsonSerializer.Deserialize<string[]>(value) ?? [];
            }
            catch
            {
                // fall through
            }
        }

        return value.Split('\n', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
    }

    private static readonly JsonSerializerOptions EncodeOptions = new() { Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };

    private static string EncodeArray(IEnumerable<string> lines) => JsonSerializer.Serialize(lines.ToArray(), EncodeOptions);

    private static Dictionary<string, string> DecodeDictionary(string value)
    {
        if (string.IsNullOrEmpty(value)) return [];
        try
        {
            return JsonSerializer.Deserialize<Dictionary<string, string>>(value) ?? [];
        }
        catch
        {
            return [];
        }
    }

    private static string EncodeDictionary(Dictionary<string, string> dict) => JsonSerializer.Serialize(dict, EncodeOptions);

    /// <summary>Config function values from ConfigFunctionBuilderDialog come back quoted as JSON string
    /// literals (e.g. "hello"). Attribute dictionary values are stored raw and later re-encoded via
    /// EncodeDictionary, which would otherwise escape those quotes instead of treating them as delimiters.
    /// Stripping them here keeps a plain literal value plain.</summary>
    private static string StripSurroundingQuotes(string value) =>
        value.Length >= 2 && value.StartsWith('"') && value.EndsWith('"') ? value[1..^1] : value;

    private static TaskEditor CreateEditor(IReadOnlyDictionary<string, string> defaults, EventHandler<ParameterSectionEditEventArgs> onEdit)
    {
        var editor = new TaskEditor();
        editor.SetDefaultParameters(defaults);
        editor.EnableSectionEditButton = true;
        editor.SectionEditRequested += onEdit;
        return editor;
    }

    // AppPool

    private static TaskEditor CreateAppPoolEditor() =>
        CreateEditor(new Dictionary<string, string> { ["Name"] = "sc10.local" }, (_, e) => EditAppPoolSection(e.Section));

    private static void EditAppPoolSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new AppPoolTaskDialog { nameInput = { TextInput = GetParam(parameters, "Name") } };
        using var form = new EditSectionDialogForm(dialog, "Edit App Pool");
        if (form.ShowDialog() != DialogResult.OK) return;

        section.UpdateParameters([new TaskParameterModel { Name = "Name", Value = dialog.nameInput.TextInput }]);
    }

    // Command

    private static TaskEditor CreateCommandEditor() =>
        CreateEditor(new Dictionary<string, string>
        {
            ["Path"] = "notepad",
            ["Arguments"] = EncodeArray(["/W", "C:\\certificates\\README"]),
        }, (_, e) => EditCommandSection(e.Section));

    private static void EditCommandSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new CommandTaskDialog
        {
            commandPathText = { Text = GetParam(parameters, "Path") },
            propertiesText = { Lines = DecodeArray(GetParam(parameters, "Arguments")) },
        };
        using var form = new EditSectionDialogForm(dialog, "Edit Command");
        if (form.ShowDialog() != DialogResult.OK) return;

        section.UpdateParameters([
            new TaskParameterModel { Name = "Path", Value = dialog.commandPathText.Text },
            new TaskParameterModel { Name = "Arguments", Value = EncodeArray(dialog.propertiesText.Lines) },
        ]);
    }

    // Copy

    private static TaskEditor CreateCopyEditor() =>
        CreateEditor(new Dictionary<string, string> { ["Source"] = "notepad", ["Destination"] = "" }, (_, e) => EditCopySection(e.Section));

    private static void EditCopySection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new CopyTaskDialog
        {
            sourcePathText = { Text = GetParam(parameters, "Source") },
            destinationText = { Text = GetParam(parameters, "Destination") },
        };
        using var form = new EditSectionDialogForm(dialog, "Edit Copy");
        if (form.ShowDialog() != DialogResult.OK) return;

        section.UpdateParameters([
            new TaskParameterModel { Name = "Source", Value = dialog.sourcePathText.Text },
            new TaskParameterModel { Name = "Destination", Value = dialog.destinationText.Text },
        ]);
    }

    // CreateService

    private static TaskEditor CreateCreateServiceEditor() =>
        CreateEditor(new Dictionary<string, string>(), (_, e) => EditCreateServiceSection(e.Section));

    private static void EditCreateServiceSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new CreateServiceTaskDialog
        {
            serviceNameInput = { TextInput = GetParam(parameters, "Name") },
            executablePath = { TextInput = GetParam(parameters, "Path") },
            executableParameters = { TextInput = string.Join("\r\n", DecodeArray(GetParam(parameters, "Arguments"))) },
            serviceType = { Text = GetParam(parameters, "StartupType") },
            serviceDescription = { TextInput = GetParam(parameters, "Description") },
            displayNameInput = { TextInput = GetParam(parameters, "DisplayName") },
        };
        using var form = new EditSectionDialogForm(dialog, "Edit Create Service");
        if (form.ShowDialog() != DialogResult.OK) return;

        var updated = new List<TaskParameterModel>();
        if (dialog.serviceNameInput.TextInput.Length > 0) updated.Add(new TaskParameterModel { Name = "Name", Value = dialog.serviceNameInput.TextInput });
        if (dialog.executablePath.TextInput.Length > 0) updated.Add(new TaskParameterModel { Name = "Path", Value = dialog.executablePath.TextInput });
        if (dialog.executableParameters.TextInput.Length > 0) updated.Add(new TaskParameterModel { Name = "Arguments", Value = EncodeArray(dialog.executableParameters.Lines) });
        if (dialog.serviceType.Text.Length > 0) updated.Add(new TaskParameterModel { Name = "StartupType", Value = dialog.serviceType.Text });
        if (dialog.serviceDescription.TextInput.Length > 0) updated.Add(new TaskParameterModel { Name = "Description", Value = dialog.serviceDescription.TextInput });
        if (dialog.displayNameInput.TextInput.Length > 0) updated.Add(new TaskParameterModel { Name = "DisplayName", Value = dialog.displayNameInput.TextInput });
        section.UpdateParameters(updated);
    }

    // DownloadFile

    private static TaskEditor CreateDownloadFileEditor() =>
        CreateEditor(new Dictionary<string, string>
        {
            ["SourceUri"] = "https://download.microsoft.com/download/b/d/8/bd882ec4-12e0-481a-9b32-0fae8e3c0b78/WebDeploy_x86_en-US.msi",
            ["DestinationPath"] = "C:\\test\\WebDeploy_x86_en-US.msi",
        }, (_, e) => EditDownloadFileSection(e.Section));

    private static void EditDownloadFileSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new DownloadFileTaskDialog
        {
            sourceTextInput = { TextInput = GetParam(parameters, "SourceUri") },
            destinationPathInput = { TextInput = GetParam(parameters, "DestinationPath") },
            hashInput = { TextInput = GetParam(parameters, "Hash") },
        };
        var algorithm = GetParam(parameters, "Algorithm");
        if (!string.IsNullOrEmpty(algorithm)) dialog.hashComboBox.SelectedItem = algorithm;

        using var form = new EditSectionDialogForm(dialog, "Edit Download File");
        if (form.ShowDialog() != DialogResult.OK) return;

        var updated = new List<TaskParameterModel>();
        if (dialog.sourceTextInput.HasText) updated.Add(new TaskParameterModel { Name = "SourceUri", Value = dialog.sourceTextInput.TextInput });
        if (dialog.destinationPathInput.HasText) updated.Add(new TaskParameterModel { Name = "DestinationPath", Value = dialog.destinationPathInput.TextInput });
        if (dialog.hashInput.HasText) updated.Add(new TaskParameterModel { Name = "Hash", Value = dialog.hashInput.TextInput });
        if (dialog.hashComboBox.SelectedItem != null) updated.Add(new TaskParameterModel { Name = "Algorithm", Value = dialog.hashComboBox.SelectedItem.ToString()! });
        section.UpdateParameters(updated);
    }

    // EnsurePath

    private static TaskEditor CreateEnsurePathEditor() =>
        CreateEditor(new Dictionary<string, string>(), (_, e) => EditEnsurePathSection(e.Section));

    private static void EditEnsurePathSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new EnsurePathTaskDialog
        {
            cleanText = { Lines = DecodeArray(GetParam(parameters, "Clean")) },
            ensureText = { Lines = DecodeArray(GetParam(parameters, "Exists")) },
        };
        using var form = new EditSectionDialogForm(dialog, "Edit Ensure Path");
        if (form.ShowDialog() != DialogResult.OK) return;

        var updated = new List<TaskParameterModel>();
        if (dialog.cleanText.Lines.Length > 0) updated.Add(new TaskParameterModel { Name = "Clean", Value = EncodeArray(dialog.cleanText.Lines) });
        if (dialog.ensureText.Lines.Length > 0) updated.Add(new TaskParameterModel { Name = "Exists", Value = EncodeArray(dialog.ensureText.Lines) });
        section.UpdateParameters(updated);
    }

    // FilePermissions

    private static TaskEditor CreateFilePermissionsEditor() =>
        CreateEditor(new Dictionary<string, string>
        {
            ["Path"] = "C:\\inetpub\\wwwroot\\sc1041.sc\\App_Config",
            ["Rights"] = "[]",
        }, (_, e) => EditFilePermissionsSection(e.Section));

    private static void EditFilePermissionsSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new FilePermissionsTaskDialog { filePathInput = { TextInput = GetParam(parameters, "Path") } };
        var rightsJson = GetParam(parameters, "Rights");
        if (!string.IsNullOrEmpty(rightsJson))
        {
            try
            {
                var rights = JsonSerializer.Deserialize<List<AccessRightSelection>>(rightsJson);
                if (rights != null) dialog.LoadAccessRights(rights);
            }
            catch
            {
                // ignore malformed data
            }
        }

        using var form = new EditSectionDialogForm(dialog, "Edit File Permissions");
        if (form.ShowDialog() != DialogResult.OK) return;

        section.UpdateParameters([
            new TaskParameterModel { Name = "Path", Value = dialog.filePathInput.TextInput },
            new TaskParameterModel { Name = "Rights", Value = JsonSerializer.Serialize(dialog.AccessRights) },
        ]);
    }

    // HostHeader

    private static TaskEditor CreateHostHeaderEditor() =>
        CreateEditor(new Dictionary<string, string>
        {
            ["Hostname"] = "sc1041.sc",
            ["IPAddress"] = "127.0.0.1",
            ["Action"] = "Add",
        }, (_, e) => EditHostHeaderSection(e.Section));

    private static void EditHostHeaderSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new HostHeaderTaskDialog
        {
            hostNameText = { TextInput = GetParam(parameters, "Hostname") },
            ipAddressText = { TextInput = GetParam(parameters, "IPAddress") },
        };
        dialog.addEntryButton.Checked = GetParam(parameters, "Action") != "Remove";
        dialog.removeEntryButton.Checked = !dialog.addEntryButton.Checked;

        using var form = new EditSectionDialogForm(dialog, "Edit Host Header");
        if (form.ShowDialog() != DialogResult.OK) return;

        var updated = new List<TaskParameterModel>
        {
            new() { Name = "Hostname", Value = dialog.hostNameText.TextInput },
        };
        if (dialog.ipAddressText.HasText) updated.Add(new TaskParameterModel { Name = "IPAddress", Value = dialog.ipAddressText.TextInput });
        updated.Add(new TaskParameterModel { Name = "Action", Value = dialog.addEntryButton.Checked ? "Add" : "Remove" });
        section.UpdateParameters(updated);
    }

    // HttpRequest

    private static TaskEditor CreateHttpRequestEditor() =>
        CreateEditor(new Dictionary<string, string> { ["Uri"] = "www.github.com" }, (_, e) => EditHttpRequestSection(e.Section));

    private static void EditHttpRequestSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new HttpRequestTaskDialog
        {
            hostNameText = { TextInput = GetParam(parameters, "Uri") },
            contentTypeText = { TextInput = GetParam(parameters, "ContentType") },
            actionText = { Text = GetParam(parameters, "Action") },
        };

        var statusCode = GetParam(parameters, "ExpectedStatusCode");
        if (!string.IsNullOrEmpty(statusCode) && decimal.TryParse(statusCode, out var statusValue))
        {
            dialog.checkBox1.Checked = true;
            dialog.statusNumber.Value = statusValue;
        }

        var requestParameters = DecodeDictionary(GetParam(parameters, "Parameters"));
        dialog.taskParameterModelBindingSource.DataSource = new BindingList<TaskParameterModel>(
            requestParameters.Select(kv => new TaskParameterModel { Name = kv.Key, Value = kv.Value }).ToList());

        using var form = new EditSectionDialogForm(dialog, "Edit HTTP Request");
        if (form.ShowDialog() != DialogResult.OK) return;

        var updated = new List<TaskParameterModel>
        {
            new() { Name = "Uri", Value = dialog.hostNameText.TextInput },
        };
        if (dialog.contentTypeText.HasText) updated.Add(new TaskParameterModel { Name = "ContentType", Value = dialog.contentTypeText.TextInput });
        if (dialog.actionText.Text.Length > 0) updated.Add(new TaskParameterModel { Name = "Action", Value = dialog.actionText.Text });
        if (dialog.checkBox1.Checked) updated.Add(new TaskParameterModel { Name = "ExpectedStatusCode", Value = dialog.statusNumber.Value.ToString() });

        var updatedParameters = new Dictionary<string, string>();
        foreach (DataGridViewRow row in dialog.parametersDataGrid.Rows)
        {
            if (row.IsNewRow) continue;
            var key = row.Cells[0].Value?.ToString() ?? string.Empty;
            var value = row.Cells[1].Value?.ToString() ?? string.Empty;
            if (!string.IsNullOrEmpty(key)) updatedParameters[key] = value;
        }
        if (updatedParameters.Count > 0) updated.Add(new TaskParameterModel { Name = "Parameters", Value = EncodeDictionary(updatedParameters) });

        section.UpdateParameters(updated);
    }

    // InsertXml

    private static TaskEditor CreateInsertXmlEditor() =>
        CreateEditor(new Dictionary<string, string>
        {
            ["FilePath"] = "C:\\inetpub\\wwwroot\\sc1041.sc\\App_Config\\ConnectionStrings.config",
            ["XPath"] = "//connectionStrings",
            ["Xml"] = "<add name=\"core\" connectionString=\"Data Source=.;Initial Catalog=sc1041_Core;User ID=coreuser;Password=b\" />",
        }, (_, e) => EditInsertXmlSection(e.Section));

    private static void EditInsertXmlSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new InsertXmlTaskDialog
        {
            filePathInput = { TextInput = GetParam(parameters, "FilePath") },
            xpathTextInput = { TextInput = GetParam(parameters, "XPath") },
            xmlInput = { TextInput = GetParam(parameters, "Xml") },
        };
        using var form = new EditSectionDialogForm(dialog, "Edit Insert XML");
        if (form.ShowDialog() != DialogResult.OK) return;

        var updated = new List<TaskParameterModel>();
        if (dialog.filePathInput.HasText) updated.Add(new TaskParameterModel { Name = "FilePath", Value = dialog.filePathInput.TextInput });
        if (dialog.xpathTextInput.HasText) updated.Add(new TaskParameterModel { Name = "XPath", Value = dialog.xpathTextInput.TextInput });
        if (dialog.xmlInput.HasText) updated.Add(new TaskParameterModel { Name = "Xml", Value = dialog.xmlInput.TextInput });
        section.UpdateParameters(updated);
    }

    // IoXml

    private static TaskEditor CreateIoXmlEditor() =>
        CreateEditor(new Dictionary<string, string>
        {
            ["RootDirectoryPath"] = "C:\\inetpub\\wwwroot\\sc1041.sc\\App_Config\\Include",
            ["IoXmlPath"] = "",
        }, (_, e) => EditIoXmlSection(e.Section));

    private static void EditIoXmlSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new IoXmlTaskDialog
        {
            folderPathInput = { TextInput = GetParam(parameters, "RootDirectoryPath") },
            xpathTextInput = { TextInput = GetParam(parameters, "IoXmlPath") },
        };
        using var form = new EditSectionDialogForm(dialog, "Edit IO XML");
        if (form.ShowDialog() != DialogResult.OK) return;

        section.UpdateParameters([
            new TaskParameterModel { Name = "RootDirectoryPath", Value = dialog.folderPathInput.TextInput },
            new TaskParameterModel { Name = "IoXmlPath", Value = dialog.xpathTextInput.TextInput },
        ]);
    }

    // ManageService

    private static TaskEditor CreateManageServiceEditor() =>
        CreateEditor(new Dictionary<string, string> { ["Name"] = "" }, (_, e) => EditManageServiceSection(e.Section));

    private static void EditManageServiceSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new ManageServiceTaskDialog
        {
            nameText = { TextInput = GetParam(parameters, "Name") },
            displayNameText = { TextInput = GetParam(parameters, "DisplayName") },
            descriptionText = { TextInput = GetParam(parameters, "Description") },
            statusText = { Text = GetParam(parameters, "Status") },
            serviceType = { Text = GetParam(parameters, "StartupType") },
            postDelayNumber = { Text = GetParam(parameters, "PostDelay") },
        };
        using var form = new EditSectionDialogForm(dialog, "Edit Manage Service");
        if (form.ShowDialog() != DialogResult.OK) return;

        var updated = new List<TaskParameterModel>
        {
            new() { Name = "Name", Value = dialog.nameText.TextInput },
        };
        if (!string.IsNullOrWhiteSpace(dialog.displayNameText.TextInput)) updated.Add(new TaskParameterModel { Name = "DisplayName", Value = dialog.displayNameText.TextInput });
        if (!string.IsNullOrWhiteSpace(dialog.descriptionText.TextInput)) updated.Add(new TaskParameterModel { Name = "Description", Value = dialog.descriptionText.TextInput });
        if (!string.IsNullOrEmpty(dialog.postDelayNumber.Text)) updated.Add(new TaskParameterModel { Name = "PostDelay", Value = dialog.postDelayNumber.Text });
        if (!string.IsNullOrWhiteSpace(dialog.statusText.Text)) updated.Add(new TaskParameterModel { Name = "Status", Value = dialog.statusText.Text });
        if (!string.IsNullOrWhiteSpace(dialog.serviceType.Text)) updated.Add(new TaskParameterModel { Name = "StartupType", Value = dialog.serviceType.Text });
        section.UpdateParameters(updated);
    }

    // ManageSolrSchema

    private static TaskEditor CreateManageSolrSchemaEditor() =>
        CreateEditor(new Dictionary<string, string>
        {
            ["Address"] = "https://localhost:8983/solr",
            ["Core"] = "sitecore_master_index",
            ["ArgumentsFile"] = "C:\\schema.json",
            ["RetryCount"] = "3",
            ["RetryDelay"] = "2000",
            ["RequestTimeout"] = "0",
        }, (_, e) => EditManageSolrSchemaSection(e.Section));

    private static void EditManageSolrSchemaSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new ManageSolrSchemaTaskDialog
        {
            addressTextBox = { TextInput = GetParam(parameters, "Address") },
            coreTextBox = { TextInput = GetParam(parameters, "Core") },
            argumentsFileTextBox = { TextInput = GetParam(parameters, "ArgumentsFile") },
        };
        if (decimal.TryParse(GetParam(parameters, "RetryCount"), out var retryCount)) dialog.retryCount.Value = retryCount;
        if (decimal.TryParse(GetParam(parameters, "RetryDelay"), out var retryDelay)) dialog.retryDelay.Value = retryDelay;
        if (decimal.TryParse(GetParam(parameters, "RequestTimeout"), out var requestTimeout)) dialog.requestTimeout.Value = requestTimeout;

        using var form = new EditSectionDialogForm(dialog, "Edit Manage Solr Schema");
        if (form.ShowDialog() != DialogResult.OK) return;

        section.UpdateParameters([
            new TaskParameterModel { Name = "Address", Value = dialog.addressTextBox.TextInput },
            new TaskParameterModel { Name = "Core", Value = dialog.coreTextBox.TextInput },
            new TaskParameterModel { Name = "ArgumentsFile", Value = dialog.argumentsFileTextBox.TextInput },
            new TaskParameterModel { Name = "RetryCount", Value = dialog.retryCount.Value.ToString() },
            new TaskParameterModel { Name = "RetryDelay", Value = dialog.retryDelay.Value.ToString() },
            new TaskParameterModel { Name = "RequestTimeout", Value = dialog.requestTimeout.Value.ToString() },
        ]);
    }

    // NewRootCertificate

    private static TaskEditor CreateNewRootCertificateEditor() =>
        CreateEditor(new Dictionary<string, string>
        {
            ["DnsName"] = "sc1041.sc",
            ["StoreLocation"] = "LocalMachine",
            ["FriendlyName"] = "Local Certificate for Sitecore 10.4.1",
            ["Name"] = "sc1041-certificate",
        }, (_, e) => EditNewRootCertificateSection(e.Section));

    private static void EditNewRootCertificateSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new NewRootCertificateTaskDialog
        {
            dnsNameText = { TextInput = GetParam(parameters, "DnsName") },
            friendlyName = { TextInput = GetParam(parameters, "FriendlyName") },
            pathForCertificate = { TextInput = GetParam(parameters, "Path") },
            fileName = { TextInput = GetParam(parameters, "Name") },
            passwordText = { TextInput = GetParam(parameters, "Password") },
            IncludePrivateKey = { Checked = GetParam(parameters, "IncludePrivateKey") == "True" },
        };
        var storeLocation = GetParam(parameters, "StoreLocation");
        dialog.storeLocation.Text = storeLocation switch
        {
            "CurrentUser" => "Current User",
            "LocalMachine" => "Local Machine",
            _ => storeLocation,
        };

        using var form = new EditSectionDialogForm(dialog, "Edit New Root Certificate");
        if (form.ShowDialog() != DialogResult.OK) return;

        var updated = new List<TaskParameterModel>();
        if (!string.IsNullOrWhiteSpace(dialog.dnsNameText.TextInput)) updated.Add(new TaskParameterModel { Name = "DnsName", Value = dialog.dnsNameText.TextInput });
        if (!string.IsNullOrWhiteSpace(dialog.storeLocation.Text)) updated.Add(new TaskParameterModel { Name = "StoreLocation", Value = dialog.storeLocation.Text.Replace(" ", "") });
        if (!string.IsNullOrWhiteSpace(dialog.friendlyName.TextInput)) updated.Add(new TaskParameterModel { Name = "FriendlyName", Value = dialog.friendlyName.TextInput });
        if (!string.IsNullOrWhiteSpace(dialog.pathForCertificate.TextInput)) updated.Add(new TaskParameterModel { Name = "Path", Value = dialog.pathForCertificate.TextInput });
        if (!string.IsNullOrWhiteSpace(dialog.fileName.TextInput)) updated.Add(new TaskParameterModel { Name = "Name", Value = dialog.fileName.TextInput });
        if (!string.IsNullOrWhiteSpace(dialog.passwordText.TextInput)) updated.Add(new TaskParameterModel { Name = "Password", Value = dialog.passwordText.TextInput });
        if (dialog.IncludePrivateKey.Checked) updated.Add(new TaskParameterModel { Name = "IncludePrivateKey", Value = "true" });
        section.UpdateParameters(updated);
    }

    // NewSignedCertificate

    private static TaskEditor CreateNewSignedCertificateEditor() =>
        CreateEditor(new Dictionary<string, string>
        {
            ["Signer"] = "1234567890ABCDEF00001234567890ABCDEF0000",
            ["DnsName"] = "sc1041.sc",
            ["StoreLocation"] = "LocalMachine",
            ["FriendlyName"] = "Local Certificate for Sitecore 10.4.1",
            ["Name"] = "sc1041-certificate",
        }, (_, e) => EditNewSignedCertificateSection(e.Section));

    private static void EditNewSignedCertificateSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new NewSignedCertificateTaskDialog
        {
            signerText = { TextInput = GetParam(parameters, "Signer") },
            dnsNameText = { TextInput = GetParam(parameters, "DnsName") },
            friendlyName = { TextInput = GetParam(parameters, "FriendlyName") },
            pathForCertificate = { TextInput = GetParam(parameters, "Path") },
            fileName = { TextInput = GetParam(parameters, "Name") },
            passwordText = { TextInput = GetParam(parameters, "Password") },
            IncludePrivateKey = { Checked = GetParam(parameters, "IncludePrivateKey") == "True" },
        };
        var signerValue = dialog.signerText.TextInput;
        var match = System.Text.RegularExpressions.Regex.Match(signerValue, @"^\[GetCertificate\('(.*)'\)\]$");
        if (match.Success) dialog.signerText.TextInput = match.Groups[1].Value;

        var storeLocation = GetParam(parameters, "StoreLocation");
        dialog.storeLocation.Text = storeLocation switch
        {
            "CurrentUser" => "Current User",
            "LocalMachine" => "Local Machine",
            _ => storeLocation,
        };

        using var form = new EditSectionDialogForm(dialog, "Edit New Signed Certificate");
        if (form.ShowDialog() != DialogResult.OK) return;

        var updated = new List<TaskParameterModel>
        {
            new() { Name = "Signer", Value = $"[GetCertificate('{dialog.signerText.TextInput}')]" },
        };
        if (!string.IsNullOrWhiteSpace(dialog.dnsNameText.TextInput)) updated.Add(new TaskParameterModel { Name = "DnsName", Value = dialog.dnsNameText.TextInput });
        if (!string.IsNullOrWhiteSpace(dialog.storeLocation.Text)) updated.Add(new TaskParameterModel { Name = "StoreLocation", Value = dialog.storeLocation.Text.Replace(" ", "") });
        if (!string.IsNullOrWhiteSpace(dialog.friendlyName.TextInput)) updated.Add(new TaskParameterModel { Name = "FriendlyName", Value = dialog.friendlyName.TextInput });
        if (!string.IsNullOrWhiteSpace(dialog.pathForCertificate.TextInput)) updated.Add(new TaskParameterModel { Name = "Path", Value = dialog.pathForCertificate.TextInput });
        if (!string.IsNullOrWhiteSpace(dialog.fileName.TextInput)) updated.Add(new TaskParameterModel { Name = "Name", Value = dialog.fileName.TextInput });
        if (!string.IsNullOrWhiteSpace(dialog.passwordText.TextInput)) updated.Add(new TaskParameterModel { Name = "Password", Value = dialog.passwordText.TextInput });
        if (dialog.IncludePrivateKey.Checked) updated.Add(new TaskParameterModel { Name = "IncludePrivateKey", Value = "true" });
        section.UpdateParameters(updated);
    }

    // RemoveAppPool

    private static TaskEditor CreateRemoveAppPoolEditor() =>
        CreateEditor(new Dictionary<string, string> { ["Name"] = "sc10.local" }, (_, e) => EditRemoveAppPoolSection(e.Section));

    private static void EditRemoveAppPoolSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new RemoveAppPoolTaskDialog { nameInput = { TextInput = GetParam(parameters, "Name") } };
        using var form = new EditSectionDialogForm(dialog, "Edit Remove App Pool");
        if (form.ShowDialog() != DialogResult.OK) return;

        section.UpdateParameters([new TaskParameterModel { Name = "Name", Value = dialog.nameInput.TextInput }]);
    }

    // RemoveService

    private static TaskEditor CreateRemoveServiceEditor() =>
        CreateEditor(new Dictionary<string, string> { ["Name"] = "sc10.local" }, (_, e) => EditRemoveServiceSection(e.Section));

    private static void EditRemoveServiceSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new RemoveServiceTaskDialog { nameInput = { TextInput = GetParam(parameters, "Name") } };
        using var form = new EditSectionDialogForm(dialog, "Edit Remove Service");
        if (form.ShowDialog() != DialogResult.OK) return;

        section.UpdateParameters([new TaskParameterModel { Name = "Name", Value = dialog.nameInput.TextInput }]);
    }

    // RemoveSqlDatabase

    private static TaskEditor CreateRemoveSqlDatabaseEditor() =>
        CreateEditor(new Dictionary<string, string>
        {
            ["ServerName"] = "(local)",
            ["DatabaseName"] = EncodeArray(["sc1041_Master"]),
            ["UserName"] = "sa",
            ["Password"] = "b",
        }, (_, e) => EditRemoveSqlDatabaseSection(e.Section));

    private static void EditRemoveSqlDatabaseSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new RemoveSqlDatabaseTaskDialog
        {
            nameInput = { TextInput = GetParam(parameters, "ServerName") },
            databasesInput = { TextInput = string.Join("\r\n", DecodeArray(GetParam(parameters, "DatabaseName"))) },
            userNameInput = { TextInput = GetParam(parameters, "UserName") },
            passwordInput = { TextInput = GetParam(parameters, "Password") },
        };
        using var form = new EditSectionDialogForm(dialog, "Edit Remove SQL Database");
        if (form.ShowDialog() != DialogResult.OK) return;

        section.UpdateParameters([
            new TaskParameterModel { Name = "ServerName", Value = dialog.nameInput.TextInput },
            new TaskParameterModel { Name = "DatabaseName", Value = EncodeArray(dialog.databasesInput.Lines) },
            new TaskParameterModel { Name = "UserName", Value = dialog.userNameInput.TextInput },
            new TaskParameterModel { Name = "Password", Value = dialog.passwordInput.TextInput },
        ]);
    }

    // RemoveXml

    private static TaskEditor CreateRemoveXmlEditor() =>
        CreateEditor(new Dictionary<string, string> { ["FilePath"] = "", ["XPath"] = "" }, (_, e) => EditRemoveXmlSection(e.Section));

    private static void EditRemoveXmlSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new RemoveXmlTaskDialog
        {
            filePathInput = { TextInput = GetParam(parameters, "FilePath") },
            xPathInput = { TextInput = GetParam(parameters, "XPath") },
            ignoreNoMatchesCheckbox = { Checked = GetParam(parameters, "IgnoreNoMatches") == "True" },
        };
        using var form = new EditSectionDialogForm(dialog, "Edit Remove XML");
        if (form.ShowDialog() != DialogResult.OK) return;

        var updated = new List<TaskParameterModel>
        {
            new() { Name = "FilePath", Value = dialog.filePathInput.TextInput },
            new() { Name = "XPath", Value = dialog.xPathInput.TextInput },
        };
        if (dialog.ignoreNoMatchesCheckbox.Checked) updated.Add(new TaskParameterModel { Name = "IgnoreNoMatches", Value = "true" });
        section.UpdateParameters(updated);
    }

    // SetXml

    private static TaskEditor CreateSetXmlEditor() =>
        CreateEditor(new Dictionary<string, string> { ["FilePath"] = "", ["XPath"] = "" }, (_, e) => EditSetXmlSection(e.Section));

    private static void EditSetXmlSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new SetXmlTaskDialog
        {
            filePathInput = { TextInput = GetParam(parameters, "FilePath") },
            xPathInput = { TextInput = GetParam(parameters, "XPath") },
            elementText = { TextInput = GetParam(parameters, "Element") },
            valueInput = { TextInput = GetParam(parameters, "Value") },
            GetAvailableVariableNames = section.GetAvailableVariableNames,
            GetAvailableParameterNames = section.GetAvailableParameterNames,
            GetRegisteredConfigFunctions = section.GetRegisteredConfigFunctions,
        };
        var attributes = DecodeDictionary(GetParam(parameters, "Attributes"));
        foreach (var (key, value) in attributes)
        {
            dialog.parametersDataGrid.Rows.Add(key, value);
        }

        using var form = new EditSectionDialogForm(dialog, "Edit Set XML");
        if (form.ShowDialog() != DialogResult.OK) return;

        var updated = new List<TaskParameterModel>
        {
            new() { Name = "FilePath", Value = dialog.filePathInput.TextInput },
            new() { Name = "XPath", Value = dialog.xPathInput.TextInput },
        };
        if (!string.IsNullOrWhiteSpace(dialog.elementText.TextInput)) updated.Add(new TaskParameterModel { Name = "Element", Value = dialog.elementText.TextInput });
        if (!string.IsNullOrWhiteSpace(dialog.valueInput.TextInput)) updated.Add(new TaskParameterModel { Name = "Value", Value = dialog.valueInput.TextInput });

        var updatedAttributes = new Dictionary<string, string>();
        foreach (DataGridViewRow row in dialog.parametersDataGrid.Rows)
        {
            if (row.IsNewRow) continue;
            var key = row.Cells[0].Value?.ToString() ?? string.Empty;
            var value = StripSurroundingQuotes(row.Cells[1].Value?.ToString() ?? string.Empty);
            if (!string.IsNullOrEmpty(key)) updatedAttributes[key] = value;
        }
        if (updatedAttributes.Count > 0) updated.Add(new TaskParameterModel { Name = "Attributes", Value = EncodeDictionary(updatedAttributes) });

        section.UpdateParameters(updated);
    }

    // SitecoreUrl

    private static TaskEditor CreateSitecoreUrlEditor() =>
        CreateEditor(new Dictionary<string, string>
        {
            ["SitecoreInstanceRoot"] = "https://sc1041.sc/",
            ["SitecoreActionPath"] = "sitecore/admin/showconfig.aspx",
            ["Username"] = "admin",
            ["Password"] = "b",
        }, (_, e) => EditSitecoreUrlSection(e.Section));

    private static void EditSitecoreUrlSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new SitecoreUrlTaskDialog
        {
            urlInput = { TextInput = GetParam(parameters, "SitecoreInstanceRoot") },
            pathInput = { TextInput = GetParam(parameters, "SitecoreActionPath") },
            usernameInput = { TextInput = GetParam(parameters, "Username") },
            passwordInput = { TextInput = GetParam(parameters, "Password") },
        };
        using var form = new EditSectionDialogForm(dialog, "Edit Sitecore URL");
        if (form.ShowDialog() != DialogResult.OK) return;

        section.UpdateParameters([
            new TaskParameterModel { Name = "SitecoreInstanceRoot", Value = dialog.urlInput.TextInput },
            new TaskParameterModel { Name = "SitecoreActionPath", Value = dialog.pathInput.TextInput },
            new TaskParameterModel { Name = "Username", Value = dialog.usernameInput.TextInput },
            new TaskParameterModel { Name = "Password", Value = dialog.passwordInput.TextInput },
        ]);
    }

    // TransformXmlDoc

    private static TaskEditor CreateTransformXmlDocEditor() =>
        CreateEditor(new Dictionary<string, string> { ["RootDirectoryPath"] = "", ["XdtDirectory"] = "" }, (_, e) => EditTransformXmlDocSection(e.Section));

    private static void EditTransformXmlDocSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new TransformXmlDocTaskDialog
        {
            filePathInput = { TextInput = GetParam(parameters, "RootDirectoryPath") },
            xPathInput = { TextInput = GetParam(parameters, "XdtDirectory") },
        };
        using var form = new EditSectionDialogForm(dialog, "Edit Transform XML Doc");
        if (form.ShowDialog() != DialogResult.OK) return;

        section.UpdateParameters([
            new TaskParameterModel { Name = "RootDirectoryPath", Value = dialog.filePathInput.TextInput },
            new TaskParameterModel { Name = "XdtDirectory", Value = dialog.xPathInput.TextInput },
        ]);
    }

    // Unpack

    private static TaskEditor CreateUnpackEditor() =>
        CreateEditor(new Dictionary<string, string> { ["Source"] = "C:\\source.zip", ["Destination"] = "C:\\dist\\" }, (_, e) => EditUnpackSection(e.Section));

    private static void EditUnpackSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new UnpackTaskDialog
        {
            sourceInput = { TextInput = GetParam(parameters, "Source") },
            destinationInput = { TextInput = GetParam(parameters, "Destination") },
        };
        using var form = new EditSectionDialogForm(dialog, "Edit Unpack");
        if (form.ShowDialog() != DialogResult.OK) return;

        section.UpdateParameters([
            new TaskParameterModel { Name = "Source", Value = dialog.sourceInput.TextInput },
            new TaskParameterModel { Name = "Destination", Value = dialog.destinationInput.TextInput },
        ]);
    }

    // UpdateBindingRedirects

    private static TaskEditor CreateUpdateBindingRedirectsEditor() =>
        CreateEditor(new Dictionary<string, string>
        {
            ["SitePath"] = "C:\\inetpub\\wwwroot\\sc1041.sc\\App_Data\\jobs\\continuous\\ProcessingEngine",
            ["BinariesFolder"] = "C:\\inetpub\\wwwroot\\sc1041.sc\\App_Data\\jobs\\continuous\\ProcessingEngine",
        }, (_, e) => EditUpdateBindingRedirectsSection(e.Section));

    private static void EditUpdateBindingRedirectsSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new UpdateBindingRedirectsTaskDialog
        {
            siteFolder = { TextInput = GetParam(parameters, "SitePath") },
            binFolder = { TextInput = GetParam(parameters, "BinariesFolder") },
            configsFolder = { TextInput = string.Join("\r\n", GetParam(parameters, "ConfigFilesToPatch").Split(';', StringSplitOptions.RemoveEmptyEntries)) },
        };
        using var form = new EditSectionDialogForm(dialog, "Edit Update Binding Redirects");
        if (form.ShowDialog() != DialogResult.OK) return;

        var updated = new List<TaskParameterModel>
        {
            new() { Name = "SitePath", Value = dialog.siteFolder.TextInput },
        };
        if (!string.IsNullOrWhiteSpace(dialog.binFolder.TextInput)) updated.Add(new TaskParameterModel { Name = "BinariesFolder", Value = dialog.binFolder.TextInput });
        if (!string.IsNullOrWhiteSpace(dialog.configsFolder.TextInput)) updated.Add(new TaskParameterModel { Name = "ConfigFilesToPatch", Value = string.Join(";", dialog.configsFolder.Lines) });
        section.UpdateParameters(updated);
    }

    // WebDeploy

    private static TaskEditor CreateWebDeployEditor() =>
        CreateEditor(new Dictionary<string, string> { ["Verb"] = "sync" }, (_, e) => EditWebDeploySection(e.Section));

    private static void EditWebDeploySection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new WebDeployTaskDialog
        {
            actionText = { Text = GetParam(parameters, "Verb") },
            pathToDeploy = { TextInput = GetParam(parameters, "Path") },
            argsJson = { TextInput = GetParam(parameters, "Arguments").Or("{ }") },
        };
        using var form = new EditSectionDialogForm(dialog, "Edit Web Deploy");
        if (form.ShowDialog() != DialogResult.OK) return;

        var updated = new List<TaskParameterModel>
        {
            new() { Name = "Verb", Value = dialog.actionText.Text },
        };
        if (!string.IsNullOrWhiteSpace(dialog.pathToDeploy.TextInput)) updated.Add(new TaskParameterModel { Name = "Path", Value = dialog.pathToDeploy.TextInput });
        if (!string.IsNullOrWhiteSpace(dialog.argsJson.TextInput)) updated.Add(new TaskParameterModel { Name = "Arguments", Value = dialog.argsJson.TextInput });
        section.UpdateParameters(updated);
    }

    // WebRequest

    private static TaskEditor CreateWebRequestEditor() =>
        CreateEditor(new Dictionary<string, string>
        {
            ["Uri"] = "https://sc1041.sc",
            ["RetryCount"] = "3",
            ["RetryDelay"] = "2000",
            ["RequestTimeout"] = "0",
        }, (_, e) => EditWebRequestSection(e.Section));

    private static void EditWebRequestSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new WebRequestTaskDialog { addressTextBox = { TextInput = GetParam(parameters, "Uri") } };
        if (decimal.TryParse(GetParam(parameters, "RetryCount"), out var retryCount)) dialog.retryCount.Value = retryCount;
        if (decimal.TryParse(GetParam(parameters, "RetryDelay"), out var retryDelay)) dialog.retryDelay.Value = retryDelay;
        if (decimal.TryParse(GetParam(parameters, "RequestTimeout"), out var requestTimeout)) dialog.requestTimeout.Value = requestTimeout;

        using var form = new EditSectionDialogForm(dialog, "Edit Web Request");
        if (form.ShowDialog() != DialogResult.OK) return;

        section.UpdateParameters([
            new TaskParameterModel { Name = "Uri", Value = dialog.addressTextBox.TextInput },
            new TaskParameterModel { Name = "RetryCount", Value = dialog.retryCount.Value.ToString() },
            new TaskParameterModel { Name = "RetryDelay", Value = dialog.retryDelay.Value.ToString() },
            new TaskParameterModel { Name = "RequestTimeout", Value = dialog.requestTimeout.Value.ToString() },
        ]);
    }

    // WebSite

    private static TaskEditor CreateWebSiteEditor() =>
        CreateEditor(new Dictionary<string, string>
        {
            ["Name"] = "sc10.local",
            ["PhysicalPath"] = "C:\\inetpub\\wwwroot\\sc10.local",
            ["Port"] = "80",
            ["ApplicationPool"] = "sc10.local",
            ["HostName"] = "sc10.local",
            ["IPAddress"] = "*",
        }, (_, e) => EditWebSiteSection(e.Section));

    private static void EditWebSiteSection(ParameterSectionControl section)
    {
        var parameters = section.GetParameters();
        var dialog = new WebSiteTaskDialog
        {
            nameInput = { TextInput = GetParam(parameters, "Name") },
            pathInput = { TextInput = GetParam(parameters, "PhysicalPath") },
            portInput = { TextInput = GetParam(parameters, "Port") },
            appPoolInput = { TextInput = GetParam(parameters, "ApplicationPool") },
            hostInput = { TextInput = GetParam(parameters, "HostName") },
            ipAddressInput = { TextInput = GetParam(parameters, "IPAddress") },
        };
        using var form = new EditSectionDialogForm(dialog, "Edit Website");
        if (form.ShowDialog() != DialogResult.OK) return;

        var updated = new List<TaskParameterModel>
        {
            new() { Name = "Name", Value = dialog.nameInput.TextInput },
            new() { Name = "PhysicalPath", Value = dialog.pathInput.TextInput },
            new() { Name = "Port", Value = dialog.portInput.TextInput },
            new() { Name = "ApplicationPool", Value = dialog.appPoolInput.TextInput },
        };
        if (!string.IsNullOrEmpty(dialog.hostInput.TextInput)) updated.Add(new TaskParameterModel { Name = "HostName", Value = dialog.hostInput.TextInput });
        if (!string.IsNullOrEmpty(dialog.ipAddressInput.TextInput)) updated.Add(new TaskParameterModel { Name = "IPAddress", Value = dialog.ipAddressInput.TextInput });
        section.UpdateParameters(updated);
    }
}

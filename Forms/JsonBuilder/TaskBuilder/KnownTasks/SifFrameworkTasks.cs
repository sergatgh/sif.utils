
using SIF.Utils.Forms.JsonBuilder.TaskBuilder.KnownTasks;
using SIF.Utils.Properties;

namespace SIF.Utils.Forms.JsonBuilder.TaskBuilder;
public static class SifFrameworkTasks
{
    public static List<TaskInfo> Tasks { get; } =
    [
        new TaskInfo { Source = "SIF", Image = Resources.app_pool_icon, Name = "AppPool", ControlFactory = () => new AppPoolTask() },
        new TaskInfo { Source = "SIF", Image = Resources.command_5515389, Name = "Command", ControlFactory = () => new CommandTask() },
        new TaskInfo { Source = "SIF", Image = Resources.copy_icon, Name = "Copy", ControlFactory = () => new CopyTask() },
        new TaskInfo { Source = "SIF", Image = Resources.service_8473597, Name = "CreateService", ControlFactory = () => new CreateServiceTask() },
        new TaskInfo { Source = "SIF", Image = Resources.download_189249, Name = "DownloadFile", ControlFactory = () => new DownloadFileTask() },
        new TaskInfo { Source = "SIF", Image = Resources.folder_logo_icon, Name = "EnsurePath", ControlFactory = () => new EnsurePathTask() },
        new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "FilePermissions" },
        new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "HostHeader" },
        new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "HttpRequest" },
        new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "ImportCertificate" },
        new TaskInfo { Source = "SIF", Image = Resources.icons8_xml_file_64, Name = "InsertXml", ControlFactory = () => new InsertXmlTask() },
        new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "InstallPSModule" },
        new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "InstallSitecoreConfiguration" },
        new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "InvokeSqlcmd" },
        new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "IoXml" },
        new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "ManageService" },
        new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "ManageSolrConfig" },
        new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "ManageSolrCore" },
        new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "ManageSolrSchema" },
        new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "NewRootCertificate" },
        new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "NewSignedCertificate" },
        new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "RemoveService" },
        new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "RemoveSqlDatabase" },
        new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "RemoveXml" },
        new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "SetXml" },
        new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "SitecoreConfiguration" },
        new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "SitecoreUrl" },
        new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "TransformXmlDoc" },
        new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "Unpack" },
        new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "UpdateBindingRedirects" },
        new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "WebDeploy" },
        new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "WebRequest" },
        new TaskInfo { Source = "SIF", Image = Resources.website_logo_icon, Name = "WebSite", ControlFactory = () => new WebSiteTask() },
    ];
}

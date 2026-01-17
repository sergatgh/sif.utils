
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
        new TaskInfo { Source = "SIF", Image = Resources.permission, Name = "FilePermissions", ControlFactory = () => new FilePermissionsTask() },
        new TaskInfo { Source = "SIF", Image = Resources.local_network, Name = "HostHeader", ControlFactory = () => new HostHeaderTask() },
        new TaskInfo { Source = "SIF", Image = Resources.http, Name = "HttpRequest", ControlFactory = () => new HttpRequestTask() },
        new TaskInfo { Source = "SIF", Image = Resources.icons8_xml_file_64, Name = "InsertXml", ControlFactory = () => new InsertXmlTask() },
        new TaskInfo { Source = "SIF", Image = Resources.export_xml_64, Name = "IoXml", ControlFactory = () => new IoXmlTask() },
        new TaskInfo { Source = "SIF", Image = Resources.management_service, Name = "ManageService", ControlFactory = () => new ManageServiceTask() },
        //new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "ManageSolrConfig" },
        //new TaskInfo { Source = "SIF", Image = Resources.DefaultTaskIcon, Name = "ManageSolrCore" },
        new TaskInfo { Source = "SIF", Image = Resources.manage_sorl_schema, Name = "ManageSolrSchema", ControlFactory = () => new ManageSolrSchemaTask() },
        new TaskInfo { Source = "SIF", Image = Resources.new_certificate, Name = "NewRootCertificate", ControlFactory = () => new NewRootCertificateTask() },
        new TaskInfo { Source = "SIF", Image = Resources.signed_certificate, Name = "NewSignedCertificate", ControlFactory = () => new NewSignedCertificateTask() },
        new TaskInfo { Source = "SIF", Image = Resources.remove_app_pool, Name = "RemoveAppPool", ControlFactory = () => new RemoveAppPoolTask() },
        new TaskInfo { Source = "SIF", Image = Resources.remove_service, Name = "RemoveService", ControlFactory = () => new RemoveServiceTask() },
        new TaskInfo { Source = "SIF", Image = Resources.delete_database, Name = "RemoveSqlDatabase", ControlFactory = () => new RemoveSqlDatabaseTask() },
        new TaskInfo { Source = "SIF", Image = Resources.remove_xml_icon, Name = "RemoveXml", ControlFactory = () => new RemoveXmlTask() },
        new TaskInfo { Source = "SIF", Image = Resources.edit_xml_file, Name = "SetXml", ControlFactory = () => new SetXmlTask() },
        new TaskInfo { Source = "SIF", Image = Resources.url, Name = "SitecoreUrl", ControlFactory = () => new SitecoreUrlTask() },
        new TaskInfo { Source = "SIF", Image = Resources.transformation, Name = "TransformXmlDoc", ControlFactory = () => new TransformXmlDocTask() },
        new TaskInfo { Source = "SIF", Image = Resources.zip, Name = "Unpack", ControlFactory = () => new UnpackTask() },
        new TaskInfo { Source = "SIF", Image = Resources.dll, Name = "UpdateBindingRedirects", ControlFactory = () => new UpdateBindingRedirectsTask() },
        new TaskInfo { Source = "SIF", Image = Resources.deployment, Name = "WebDeploy", ControlFactory = () => new WebDeployTask() },
        new TaskInfo { Source = "SIF", Image = Resources.link, Name = "WebRequest", ControlFactory = () => new WebRequestTask() },
        new TaskInfo { Source = "SIF", Image = Resources.website_logo_icon, Name = "WebSite", ControlFactory = () => new WebSiteTask() },
    ];
}

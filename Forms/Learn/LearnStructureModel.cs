using SIF.Utils.Properties;

namespace SIF.Utils.Forms.Learn;

public static class LearnStructureModel
{
    public static Dictionary<string, List<LearnPageMenuModel>> Menu = new()
    {
        ["Articles"] =
        [
            new LearnPageMenuModel { Name = "A Clear Start", Image = Resources.copy_icon, FileFactory = () => Resources.sif_clear_start },
            new LearnPageMenuModel { Name = "First Task", Image = Resources.copy_icon, FileFactory = () => Resources.sif_custom_task_article },
            new LearnPageMenuModel { Name = "Uninstalls", Image = Resources.copy_icon, FileFactory =() => Resources.sif_uninstall_include_article, },
            new LearnPageMenuModel { Name = "Config functions", Image = Resources.copy_icon, FileFactory =() => Resources.sif_other_adds_article },
        ],
        ["Youtube videos"] =
        [
            new LearnPageMenuModel { Name = "Tasks", Image = Resources.copy_icon, FileFactory = () => Resources.sif_youtube_tasks },
            new LearnPageMenuModel { Name = "Config functions", Image = Resources.copy_icon, FileFactory = () => Resources.sif_youtube_configfunctions },
            new LearnPageMenuModel { Name = "Parameters", Image = Resources.copy_icon, FileFactory = () => Resources.sif_parameters_youtube  },
            new LearnPageMenuModel { Name = "Variables", Image = Resources.copy_icon, FileFactory =() => Resources.sif_variables_youtube },
        ],
        ["Other"] =
        [
            new LearnPageMenuModel { Name = "Official docs", Image = Resources.copy_icon, FileFactory = () => Resources.official_sif_docs },
        ],
    };
}

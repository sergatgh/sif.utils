using SIF.Utils.Properties;

namespace SIF.Utils.Forms.Learn
{
    public class LearnPageMenuModel
    {
        public Image Image { get => field ?? Resources.DefaultTaskIcon; set => field = value; }

        public string Name { get; set; } = string.Empty;

        public Func<byte[]>? FileFactory { get; set; }
    }
}

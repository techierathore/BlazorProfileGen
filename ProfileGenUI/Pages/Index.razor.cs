using Markdig;
using Microsoft.AspNetCore.Components;

namespace ProfileGenUI.Pages
{
    public partial class Index : ComponentBase
    {
        protected string DefaultTabName = "Header";

        public string ProfileBody { get; set; } = string.Empty;
        public string ProfilePreview => Markdown.ToHtml(ProfileBody);
    }
}

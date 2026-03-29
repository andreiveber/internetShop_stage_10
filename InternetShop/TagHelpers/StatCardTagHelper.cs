using Microsoft.AspNetCore.Razor.TagHelpers;

namespace InternetShop.TagHelpers
{
    [HtmlTargetElement("statcard")]
    public class StatCardTagHelper : TagHelper
    {
        public string Title { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public string Color { get; set; } = "primary";
        public string Url { get; set; } = string.Empty;
        public string LinkText { get; set; } = "";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = null;

            string linkHtml = string.IsNullOrEmpty(Url)
                ? $"<span class='text-white'>{LinkText}</span>"
                : $"<a href='{Url}' class='text-white'>{LinkText} →</a>";

            output.Content.AppendHtml($@"
                <div class='col-md-3 mb-3'>
                    <div class='card text-white bg-{Color} h-100'>
                        <div class='card-body'>
                            <h5 class='card-title'>{Title}</h5>
                            <p class='card-text display-4'>{Value}</p>
                            {linkHtml}
                        </div>
                    </div>
                </div>
            ");
        }
    }
}
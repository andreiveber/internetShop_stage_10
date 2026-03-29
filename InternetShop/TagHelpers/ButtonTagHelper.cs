using Microsoft.AspNetCore.Razor.TagHelpers;

namespace InternetShop.TagHelpers
{
    [HtmlTargetElement("btn")]
    public class ButtonTagHelper : TagHelper
    {
        public string Text { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string Type { get; set; } = "primary";
        public string Size { get; set; } = "";
        public bool Outline { get; set; } = false;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = null;

            string btnClass = "btn";

            if (Outline)
            {
                btnClass += $" btn-outline-{Type}";
            }
            else
            {
                btnClass += $" btn-{Type}";
            }

            if (!string.IsNullOrEmpty(Size))
            {
                btnClass += $" btn-{Size}";
            }

            output.Content.AppendHtml($"<a href='{Url}' class='{btnClass}' role='button'>{Text}</a>");
        }
    }
}
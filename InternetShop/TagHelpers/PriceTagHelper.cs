using Microsoft.AspNetCore.Razor.TagHelpers;

namespace InternetShop.TagHelpers
{
    [HtmlTargetElement("price")]
    public class PriceTagHelper : TagHelper
    {
        public decimal Value { get; set; }
        public bool Bold { get; set; } = true;
        public string Color { get; set; } = "primary";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = null;

            string classAttr = Bold ? "fw-bold" : "";
            if (!string.IsNullOrEmpty(Color))
            {
                classAttr += $" text-{Color}";
            }

            output.Content.AppendHtml($"<span class='{classAttr.Trim()}'>{Value.ToString("C")}</span>");
        }
    }
}
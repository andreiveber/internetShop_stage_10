using Microsoft.AspNetCore.Razor.TagHelpers;

namespace InternetShop.TagHelpers
{
    [HtmlTargetElement("advantage")]
    public class AdvantageCardTagHelper : TagHelper
    {
        public string Title { get; set; } = string.Empty;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = null;
            output.Content.AppendHtml($@"
                <div class='col-md-3 col-sm-6 mb-3'>
                    <div class='card h-100'>
                        <div class='card-body'>
                            <h5 class='card-title'>{Title}</h5>
                        </div>
                    </div>
                </div>
            ");
        }
    }
}
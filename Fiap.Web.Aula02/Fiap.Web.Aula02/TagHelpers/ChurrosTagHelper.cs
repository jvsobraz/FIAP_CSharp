using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Fiap.Web.Aula02.TagHelpers
{
    public class ChurrosTagHelper : TagHelper
    {
        public string? Texto { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            //Setar o class
            output.Attributes.SetAttribute("class", "btn btn-primary");
            //Setar o conte�do do bot�o
            output.Content.SetContent(string.IsNullOrEmpty(Texto) ? "Cadastrar" : Texto);
        }
    }
}
using System;
using ceTe.DynamicPDF;
using ceTe.DynamicPDF.PageElements;
using ceTe.DynamicPDF.Xmp;

namespace CustomXmpSchemas.Examples
{
    class CustomSchemaExample
    {
        internal static void Run(string outputFilePath)
        {
            Document document = new Document();
            Page page = new Page();
            Label label = new Label("This PDF has a custom XMP schema.", 10, 10, 300, 20);
            page.Elements.Add(label);
            document.Pages.Add(page);

            XmpMetadata metadata = new XmpMetadata();
            metadata.AddSchema(new CustomSchema("John", DateTime.Now));
            document.XmpMetadata = metadata;

            document.Draw(outputFilePath);
        }
    }
}

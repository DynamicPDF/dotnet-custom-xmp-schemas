using System;
using ceTe.DynamicPDF;
using ceTe.DynamicPDF.PageElements;
using ceTe.DynamicPDF.Xmp;

namespace CustomXmpSchemas
{

    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            Page page = new Page();
            Label label = new Label("This PDF has a custom XMP schema", 10, 10, 300, 20);
            page.Elements.Add(label);
            document.Pages.Add(page);

            CustomSchema schema = new CustomSchema
            {
                UserName = "John",
                CreationDate = DateTime.Now
            };

            XmpMetadata metadata = new XmpMetadata();
            metadata.AddSchema(schema);
            document.XmpMetadata = metadata;

            document.Draw(@"CustomSchema.pdf");
        }
    }

    public class CustomSchema : XmpSchema
    {
        public CustomSchema() { }

        public String UserName { get; set; }

        public DateTime? CreationDate { get; set; }

        protected override void Draw(XmpWriter xwriter)
        {
            xwriter.BeginDescription("http://ns.adobe.com/xap/1.0/", "xmp", " ");
            if (UserName != null) xwriter.Draw("\t\t<xmp:CreatedBy>" + UserName + "</xmp:CreatedBy>\n");
            if (CreationDate != null)
            {
                xwriter.Draw("\t\t<xmp:DateCreated>" + CreationDate.Value.ToUniversalTime() + "</xmp:DateCreated>\n");
            }
            xwriter.Draw("\t\t<xmp:CreatorTool>" + xwriter.Producer + "</xmp:CreatorTool>\n");
            xwriter.Draw("\t\t<xmp:MetadataDate>" + xwriter.Date.ToUniversalTime() + "</xmp:MetadataDate>\n");
            xwriter.EndDescription();
        }
    }

}

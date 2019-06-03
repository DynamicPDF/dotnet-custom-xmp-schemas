using System;
using ceTe.DynamicPDF.Xmp;

namespace CustomXmpSchemas.Examples
{
    class CustomSchema : XmpSchema
    {
        private string userName;
        private DateTime creationDate;

        public CustomSchema(string userName, DateTime creationDate)
        {
            this.userName = userName;
            this.creationDate = creationDate;
        }

        protected override void Draw(XmpWriter xwriter)
        {
            xwriter.BeginDescription("http://ns.adobe.com/xap/1.0/", "xmp", " ");
            if (userName != null) xwriter.Draw("\t\t<xmp:CreatedBy>" + userName + "</xmp:CreatedBy>\n");
            xwriter.Draw("\t\t<xmp:DateCreated>" + creationDate.ToUniversalTime() + "</xmp:DateCreated>\n");
            xwriter.Draw("\t\t<xmp:CreatorTool>" + xwriter.Producer + "</xmp:CreatorTool>\n");
            xwriter.Draw("\t\t<xmp:MetadataDate>" + xwriter.Date.ToUniversalTime() + "</xmp:MetadataDate>\n");
            xwriter.EndDescription();
        }
    }
}

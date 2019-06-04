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

        protected override void Draw(XmpWriter xmpWriter)
        {
            xmpWriter.BeginDescription("http://ns.adobe.com/xap/1.0/", "xmp", " ");
            if (userName != null) xmpWriter.Draw("\t\t<xmp:CreatedBy>" + userName + "</xmp:CreatedBy>\n");
            xmpWriter.Draw("\t\t<xmp:DateCreated>" + creationDate.ToString("yyyy-MM-dd'T'HH:mm:sszzz") + "</xmp:DateCreated>\n");
            xmpWriter.Draw("\t\t<xmp:CreatorTool>" + xmpWriter.Producer + "</xmp:CreatorTool>\n");
            xmpWriter.Draw("\t\t<xmp:MetadataDate>" + xmpWriter.Date.ToLocalTime().ToString("yyyy-MM-dd'T'HH:mm:sszzz") + "</xmp:MetadataDate>\n");
            xmpWriter.EndDescription();
        }
    }
}

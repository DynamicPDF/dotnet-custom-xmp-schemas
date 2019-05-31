using System;
using ceTe.DynamicPDF;
using ceTe.DynamicPDF.Merger;

/* This example requires one of these licenses or higher to remove the watermark:
 *   * DynamicPDF Merger Standard for .NET
 *   * DynamicPDF Core Suite Standard for .NET
*/

namespace MergePDFBookmarks.Examples
{
    class DefaultBehaviorExample
    {
        internal static void Run(string outputFilePath)
        {
            MergeDocument document = new MergeDocument(Util.GetResourcePath("test-doc-a.pdf"));
            document.Append(Util.GetResourcePath("test-doc-b.pdf"));
            document.Append(Util.GetResourcePath("test-doc-c.pdf"));
            document.Draw(outputFilePath);
        }
    }
}

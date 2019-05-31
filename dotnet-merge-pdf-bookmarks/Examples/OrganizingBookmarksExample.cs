using System;
using ceTe.DynamicPDF;
using ceTe.DynamicPDF.Merger;

/* This example requires one of these licenses or higher to remove the watermark:
 *   * DynamicPDF Merger Professional for .NET
 *   * DynamicPDF Core Suite Professional for .NET
*/

namespace MergePDFBookmarks.Examples
{
    class OrganizingBookmarksExample
    {
        internal static void Run(string outputFilePath)
        {
            MergeDocument document = new MergeDocument();

            AppendDoc(document, "test-doc-a.pdf", "Document A");
            AppendDoc(document, "test-doc-b.pdf", "Document B");
            AppendDoc(document, "test-doc-c.pdf", "Document C");

            document.Draw(outputFilePath);
        }

        private static void AppendDoc(MergeDocument document, string fileName, string parentBookmarkText)
        {
            MergeOptions mergeOptions = MergeOptions.Append;
            Outline outline = document.Outlines.Add(parentBookmarkText, new XYDestination(document.Pages.Count + 1, 0, 0));
            mergeOptions.RootOutline = outline;
            document.Append(Util.GetResourcePath(fileName), mergeOptions);
        }

    }
}

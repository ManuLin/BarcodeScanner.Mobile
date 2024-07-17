using BarcodeScanner.Mobile.Maui.Shared;

namespace BarcodeScanner.Mobile
{
    public class OCRResult
    {
        public bool Success { get; set; }

        public string AllText { get; set; }

        public IList<OCRElement> Elements { get; set; } = new List<OCRElement>();

        public IList<string> Lines { get; set; } = new List<string>();
    }
}
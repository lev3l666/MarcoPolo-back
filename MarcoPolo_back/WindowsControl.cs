using System;

namespace MarcoPolo_back
{
    public class WindowsControl
    {
        public WindowsControl(string text, string tagName, string BoundingRectangle, string RuntimeId, string AutomationId, bool enabled, bool displayed, bool IsModal, bool IsTopmost)
        {
            this.Text = text;
            this.TagName = tagName;
            this.BoundingRectangle = BoundingRectangle;
            this.RuntimeId = RuntimeId;
            this.AutomationId = AutomationId;
            this.Enabled = enabled;
            this.Displayed = displayed;
            this.IsModal = IsModal;
            this.IsTopmost = IsTopmost;
        }

        public string Text { get; set; }

        public string TagName { get; set; }

        public string BoundingRectangle { get; set; }

        public string RuntimeId { get; set; }

        public string AutomationId { get; set; }

        public bool Enabled { get; set; }

        public bool Displayed { get; set; }

        public bool IsModal { get; set; }

        public bool IsTopmost { get; set; }
    }
}

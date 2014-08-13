using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLRenderer
{
    class HTMLElement : IElement
    {
        private IList<IElement> childElements;

        public HTMLElement(string name)
        {
            this.Name = name;
            this.childElements = new List<IElement>();
        }
        public HTMLElement(string name, string textContent):this(name)
        {
            this.TextContent = textContent;
        }
        public string Name { get; private set; }

        public virtual string TextContent { get; set; }

        public IEnumerable<IElement> ChildElements { get { return this.childElements; } }

        public void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public virtual void Render(StringBuilder output)
        {
            if (!string.IsNullOrWhiteSpace(this.Name))
            {
                output.AppendFormat("<{0}>", this.Name);
            }
            if (!string.IsNullOrWhiteSpace(this.TextContent))
            {
                StringBuilder txtContent = new StringBuilder();
                foreach (var textChar in this.TextContent)
                {
                    if (textChar == '<')
                    {
                        txtContent.Append("&lt;");
                    }
                    else if (textChar == '>')
                    {
                        txtContent.Append("&gt;");
                    }
                    else if (textChar == '&')
                    {
                        txtContent.Append("&amp;");
                    }
                    else
                    {
                        txtContent.Append(textChar);
                    }
                }
                output.Append(txtContent.ToString());
            }
            foreach (var childElement in this.ChildElements)
            {
                output.Append(childElement);
            }
            if (!string.IsNullOrWhiteSpace(this.Name))
            {
                output.AppendFormat("</{0}>", this.Name);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            this.Render(output);
            return output.ToString();
        }
    }
}

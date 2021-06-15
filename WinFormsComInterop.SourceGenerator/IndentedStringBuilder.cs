namespace WinFormsComInterop.SourceGenerator
{
    using System;
    using System.Linq;
    using System.Text;

    internal sealed class IndentedStringBuilder
    {
        private const byte IndentSize = 4;
        private readonly StringBuilder builder;
        private byte depthLevel;

        /// <summary>
        /// Initializes a new instance of the <see cref="IndentedStringBuilder"/> class.
        /// </summary>
        /// <param name="content">Initial content for the string builder.</param>
        public IndentedStringBuilder(string content = "")
        {
            this.builder = new StringBuilder(content);
        }

        public void Append(string value)
        {
            this.WriteIndent();
            this.builder.Append(value);
        }

        public void Append(IndentedStringBuilder value)
        {
            var lines = value.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (var line in lines.Take(lines.Length - 1))
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    this.AppendLine();
                }
                else
                {
                    this.AppendLine(line);
                }
            }
        }

        public void AppendLine()
        {
            this.builder.AppendLine();
        }

        public void AppendLine(string value)
        {
            this.WriteIndent();
            this.builder.AppendLine(value);
        }

        public void PushIndent()
        {
            this.depthLevel++;
        }

        public void PopIndent()
        {
            if (this.depthLevel == 0)
            {
                throw new InvalidOperationException("Cannot pop at depthlevel 0");
            }

            this.depthLevel--;
        }

        /// <inheritdoc/>
        public override string ToString() => this.builder.ToString();

        private void WriteIndent()
        {
            if (this.depthLevel > 0)
            {
                this.builder.Append(' ', this.depthLevel * IndentSize);
            }
        }
    }
}

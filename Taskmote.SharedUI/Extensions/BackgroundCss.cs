using System;
using System.Text;

namespace Taskmote.SharedUI.Extensions
{
    public enum BGSize
    {
        auto,
        cover,
        contain,
    }

    public interface ICssBuilder
    {
        public void Add(string part);
        public string ToCss();
    }

    public class Css : ICssBuilder
    {
        public static ICssBuilder Build() => new Css();

        StringBuilder _builder = new StringBuilder();
        public void Add(string part) => _builder.Append(part + ";");
        public string ToCss() => _builder.ToString();
    }

    public static class CssBackground
    {
        const string BACKGROUNDCOLOR = "background-color: {0}";
        const string BACKGROUNDSIZE = "background-size: {0}";
        

        public static ICssBuilder BGColor(this ICssBuilder cssBuilder, string value)
        {
            cssBuilder.Add(string.Format(BACKGROUNDCOLOR, value));
            return cssBuilder;
        }

        public static ICssBuilder BGSize(this ICssBuilder cssBuilder, BGSize value)
        {
            cssBuilder.Add(string.Format(BACKGROUNDCOLOR, value.ToString()));
            return cssBuilder;
        }
    }

}


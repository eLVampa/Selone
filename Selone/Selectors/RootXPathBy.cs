﻿namespace Kontur.Selone.Selectors
{
    public class RootXPathBy : XPathBy
    {
        public RootXPathBy(string xpath) : base(xpath)
        {
        }

        public XPathBy Tag(string tag)
        {
            return Concat(tag);
        }

        public XPathBy AnyTag()
        {
            return Concat("*");
        }
    }
}
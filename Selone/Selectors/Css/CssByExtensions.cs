﻿using System;
using OpenQA.Selenium;

namespace Kontur.Selone.Selectors.Css
{
    public static class CssByExtensions
    {
        public static CssBy Css(this ByDummy dummy, string css = null)
        {
            return new CssBy(css);
        }

        public static ItemBy FixedBy(this CssBy cssBy, Func<CssBy, IWebElement, int, By> fix)
        {
            return new ItemBy(cssBy, (e, i) => fix(cssBy, e, i));
        }

        public static ItemBy FixedByAttribute(this CssBy cssBy, string name)
        {
            return cssBy.WithAttribute(name).FixedBy((css, e, i) => css.WithAttribute(name, e.GetAttribute(name)));
        }

        public static ItemBy FixedByIndex(this CssBy cssBy)
        {
            return cssBy.FixedBy((css, e, i) => css.WithIndex(i));
        }
    }
}
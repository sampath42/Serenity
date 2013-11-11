﻿namespace Serenity.Reporting
{
    using jQueryApi;

    public class ReportsPage : Widget
    {
        public ReportsPage(jQueryObject div)
            : base(div)
        {
            //Nt.resizeDivToWindow(div, 500, 10);
            //InitAutoLayout();

            J(".report-link").Click(ReportLinkClick);
        }

        private void ReportLinkClick(jQueryEvent e)
        {
            e.PreventDefault();

            var dialog = new ReportDialog(new ReportDialogOptions
            {
                ReportKey = J(e.Target).GetDataValue("key").As<string>()
            });
        }
    }
}
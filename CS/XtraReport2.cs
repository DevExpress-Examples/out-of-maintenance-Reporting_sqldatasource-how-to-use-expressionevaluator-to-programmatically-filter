using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.DataAccess.Native.Sql;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Sql.DataApi;

namespace dxSample {
    public partial class XtraReport2 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport2() {
            InitializeComponent();
        }
        string FilterExpression{
            get {
                return String.Format("CategoryName == '{0}'", this.Parameters["categoryName"].Value);
            }
        }
        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            e.Cancel = !IsFit();
        }

        private bool IsFit() {
            ResultRow rr = this.GetCurrentRow() as ResultRow;

            IResultSet resultSet = (this.DataSource as SqlDataSource).Result as DevExpress.DataAccess.Sql.DataApi.IResultSet;
            ITable tableProd = null;
            resultSet.TryGetTable("CategoryProducts", out tableProd);
            DevExpress.Data.Filtering.CriteriaOperator filter = DevExpress.Data.Filtering.CriteriaOperator.Parse(FilterExpression);
            DevExpress.Data.Filtering.Helpers.ExpressionEvaluator evaluator = new DevExpress.Data.Filtering.Helpers.ExpressionEvaluator((((ITypedList)tableProd).GetItemProperties(null)), filter);
            bool isFit = evaluator.Fit(rr);
            return isFit;
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            e.Cancel = !IsFit();
        }
    }
}

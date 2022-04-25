using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Koutei.UserControl
{
    public partial class UC01board : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region "保留ボードに付箋データ設定"

        /// <summary>
        /// 保留ボードに付箋データ設定
        /// </summary>
        /// <param name="dtFusen"></param>
        public void SetPendingFusenBoardData()
        {
            pnlFusen.CssClass = "UC02FusenInfoDiv PendingBoardDiv";
            divPendingHeader.Style.Add("display", "block");
            lblPendingHeader.Text = Session["BoardName"].ToString();
            lblPendingHeader_ID.Text = Session["BoardID"].ToString();
            
            divFusenList.Style.Add("background-color", "rgb(197,224,245)");
        }

        #endregion

    }
}
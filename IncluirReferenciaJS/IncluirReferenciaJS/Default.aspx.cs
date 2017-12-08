using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IncluirReferenciaJS
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.TxtCEP.Attributes.Add("onkeypress", $"Mascara('CEP', {this.TxtCEP.ClientID});");
        }
    }
}
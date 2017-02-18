using RelatoriosTags.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RelatoriosTags.ViewModels
{
public class RelatoriosTagsViewModel
{
    public string Tag { get; set; }

    public IEnumerable<RelatorioTagModels> RelatoriosTags { get; set; }
}
}
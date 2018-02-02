using Sitecore.Data;
using Sitecore.Form.Core.Client.Data.Submit;
using Sitecore.Workflows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.Form.Submit
{
  public class CreateItem: Sitecore.Form.Submit.CreateItem
  {
    protected override void CreateItemByFields(ID formid, AdaptedResultList fields)
    {
      using (new WorkflowContextStateSwitcher(WorkflowContextState.Enabled))
      {
        base.CreateItemByFields(formid, fields);
      }
    }
  }
}
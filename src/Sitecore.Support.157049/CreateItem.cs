using Sitecore.Data;
using Sitecore.WFFM.Abstractions.Actions;

namespace Sitecore.Support.Form.Submit
{
    public class CreateItem : Sitecore.Form.Submit.CreateItem
    {
        protected override void CreateItemByFields(ID formid, AdaptedResultList fields)
        {
            using (new Workflows.WorkflowContextStateSwitcher(Workflows.WorkflowContextState.Enabled))
            {
                base.CreateItemByFields(formid, fields);
            }
        }
    }
}
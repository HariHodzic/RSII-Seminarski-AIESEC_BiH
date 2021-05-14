using AiesecBiH.IServices;
using AiesecBiH.Services;

namespace AiesecBiH.Controllers
{
    public class FunctionalFieldsController : BaseCRUDController<Model.FunctionalField,object,Model.Update.FunctionalField,Model.Insert.FunctionalField>
    {
        public FunctionalFieldsController(IFunctionalFieldService service):base(service)
        {
        }
    }
}

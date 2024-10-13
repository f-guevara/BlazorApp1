using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public interface IImplantService
    {
        List<Implant> GetAllImplants();
        void AddImplant(Implant implant);
        void UpdateImplant(Implant implant);
        void DeleteImplant(int implantId);
    }
}

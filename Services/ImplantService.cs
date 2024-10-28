using BlazorApp1.Models;
using BlazorApp1.Services;
using System.Text.Json;

public class ImplantService : IImplantService
{
    private readonly string _filePath = "implants.json";

    public List<Implant> GetAllImplants()
    {
        if (!File.Exists(_filePath))
            return new List<Implant>();

        var json = File.ReadAllText(_filePath);
        return JsonSerializer.Deserialize<List<Implant>>(json) ?? new List<Implant>();
    }

    public void AddImplant(Implant implant)
    {
        var implants = GetAllImplants();
        implant.Id = implants.Count == 0 ? 1 : implants.Max(i => i.Id) + 1;
        implants.Add(implant);
        SaveImplants(implants);
    }

    public void UpdateImplant(Implant implant)
    {
        var implants = GetAllImplants();
        var existingImplant = implants.FirstOrDefault(i => i.Id == implant.Id);
        if (existingImplant != null)
        {
            existingImplant.McmId = implant.McmId;
            existingImplant.Name = implant.Name;
            existingImplant.System = implant.System;
            existingImplant.Type = implant.Type;
            existingImplant.Price = implant.Price;
            SaveImplants(implants);
        }
    }

    public void DeleteImplant(int implantId)
    {
        var implants = GetAllImplants();
        implants.RemoveAll(i => i.Id == implantId);
        SaveImplants(implants);
    }

    private void SaveImplants(List<Implant> implants)
    {
        var json = JsonSerializer.Serialize(implants);
        File.WriteAllText(_filePath, json);
    }
}


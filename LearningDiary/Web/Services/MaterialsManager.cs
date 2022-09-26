using Materials.Core.DTOs;
using Newtonsoft.Json;

namespace Web.Services
{
    public class MaterialsManager: IMaterialsManager
    {
        private readonly HttpClient _httpClient;

        public MaterialsManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task AddMaterial(CreateMaterialDTO material)
        {
            JsonContent content = JsonContent.Create(material);
            var result = await _httpClient.PostAsync("http://localhost:5020/Diary/AddMaterial", content);
        }

        public async Task<List<ReadMaterialDTO>> FetchAllMaterials()
        {
            var response =  await _httpClient.GetAsync("http://localhost:5020/Diary/GetAll");
            if (response.IsSuccessStatusCode)
            {
                Newtonsoft.Json.JsonSerializer serializer = new();
                return serializer.Deserialize<List<ReadMaterialDTO>>(new JsonTextReader(new StringReader(await response.Content.ReadAsStringAsync())));

            }
            return null;
        }
    }
}

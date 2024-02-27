using EKartWeb.Extensions;
using EKartWeb.Models;
using EKartWeb.Repositories.Interfaces;

namespace EKartWeb.Repositories
{
    public class CatalogService : ICatalogService
    {
        private readonly HttpClient _client;

        public CatalogService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<CatalogModel>> GetCatalog()
        {
            var response = await _client.GetAsync("/api/v1/Catalog");
            return await response.ReadContentAs<List<CatalogModel>>();

            // return ProductContext.Products;
        }

        public async Task<CatalogModel> GetCatalog(string id)
        {
            var response = await _client.GetAsync($"/Catalog/{id}");
            return await response.ReadContentAs<CatalogModel>();
        }

        public async Task<IEnumerable<CatalogModel>> GetCatalogByCategory(string category)
        {
            var response = await _client.GetAsync($"/api/v1/Catalog/GetProductByCategory/{category}");
            return await response.ReadContentAs<List<CatalogModel>>();
        }

        public async Task<CatalogModel> CreateCatalog(CatalogModel model)
        {
            var response = await _client.PostAsJson($"/api/v1/Catalog", model);
            if (response.IsSuccessStatusCode)
                return await response.ReadContentAs<CatalogModel>();
            else
            {
                throw new Exception("Something went wrong when calling api.");
            }
        }
    }

    //Demo Data
    public static class ProductContext
    {
        public static readonly List<CatalogModel> Products = new List<CatalogModel>
        {
            new CatalogModel()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "IPhone X",
                Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                ImageFile = "product-1.png",
                Price = 950.00M,
                Category = "Smart Phone",
                Summary = "Summary"
            },
            new CatalogModel()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Samsung 10",
                Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                ImageFile = "product-2.png",
                Price = 840.00M,
                Category = "Smart Phone",
                Summary = "Summary"
            },
            new CatalogModel()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Huawei Plus",
                Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                ImageFile = "product-3.png",
                Price = 650.00M,
                Category = "White Appliances",
                Summary = "Summary"
            },
            new CatalogModel()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Xiaomi Mi 9",
                Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                ImageFile = "product-4.png",
                Price = 470.00M,
                Category = "White Appliances",
                Summary = "Summary"
            },
            new CatalogModel()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "HTC U11+ Plus",
                Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                ImageFile = "product-5.png",
                Price = 380.00M,
                Category = "Smart Phone",
                Summary = "Summary"
            },
            new CatalogModel()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "LG G7 ThinQ EndofCourse",
                Description = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                ImageFile = "product-6.png",
                Price = 240.00M,
                Category = "Home Kitchen",
                Summary = "Summary"
            }
        };
    }
}

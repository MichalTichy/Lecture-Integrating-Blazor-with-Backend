using CookBook.ApiClients;
using CookBook.BL.Common.Facades;
using CookBook.Common.Installers;
using Microsoft.Extensions.DependencyInjection;

namespace CookBook.WEB.BL
{
    public class BLWebInstaller : IInstaller
    {
        public void Install(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IIngredientClient, IngredientClient>();
            serviceCollection.AddSingleton<IRecipeClient, RecipeClient>();
        }
    }
}
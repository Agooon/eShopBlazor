using eShop.UseCases.PluginInterfaces;
using eShop.UseCases.PluginInterfaces.UI;
using eShop.UseCases.ViewProductScreen.Interfaces;

namespace eShop.UseCases.ViewProductScreen
{
    public class AddProductToCartUseCase : IAddProductToCartUseCase
    {
        private readonly IProductRepository productRepository;
        private readonly IShoppingCart shoppingCart;

        public AddProductToCartUseCase(IProductRepository productRepository,
            IShoppingCart shoppingCart)
        {
            this.productRepository = productRepository;
            this.shoppingCart = shoppingCart;
        }
        public async void Execute(int productId)
        {
            var product = productRepository.GetProduct(productId);
            await shoppingCart.AddProductAsync(product);
        }
    }
}

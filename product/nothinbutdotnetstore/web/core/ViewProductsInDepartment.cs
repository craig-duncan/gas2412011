using System;
using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.web.model;

namespace nothinbutdotnetstore.web.core
{
    public class ViewProductsInDepartment : ApplicationCommand
    {
        ProductRepository repository;
        Renderer renderer;

        public ViewProductsInDepartment(ProductRepository product_repository, Renderer renderer)
        {
            this.renderer = renderer;
            this.repository = product_repository;
        }

        public void run(Request request)
        {
            renderer.display(repository.get_products_in_department(request.map<Department>()));
        }
    }
}
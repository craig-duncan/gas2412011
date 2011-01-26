using System.Collections.Generic;
using Machine.Specifications;
using Machine.Specifications.DevelopWithPassion.Rhino;
using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.web.core;
using nothinbutdotnetstore.web.model;
using Rhino.Mocks;

namespace nothinbutdotnetstore.specs.web.core
{
    public class ViewProductsInDepartmentSpecs 
    {
        public abstract class concern : Observes<ApplicationCommand,
                                            ViewProductsInDepartment>
        {
        }

        public class when_run : concern
        {
            Establish c = () =>
            {
                request = an<Request>();
                product_repository = the_dependency<ProductRepository>();
                the_products_in_department = new List<Product>();
                the_parent_department = new Department();

                renderer = the_dependency<Renderer>();

                request.Stub(x => x.map<Department>()).Return(the_parent_department);


                product_repository.Stub(x => x.get_products_in_department(the_parent_department))
                    .Return(the_products_in_department);
            };

            Because b = () =>
                sut.run(request);

            It should_tell_the_renderer_to_display_the_set_of_products = () =>
                renderer.received(x => x.display(the_products_in_department));

            static Request request;
            static ProductRepository product_repository;
            static Renderer renderer;
            static IEnumerable<Product> the_products_in_department;
            static Department the_parent_department;
        }
    }
}
 using Machine.Specifications;
 using Machine.Specifications.DevelopWithPassion.Rhino;
 using nothinbutdotnetstore.infrastructure.containers;

namespace nothinbutdotnetstore.specs.infrastructure
{   
    public class BasicDependencyContainerSpecs
    {
        public abstract class concern : Observes<DependencyContainer,
                                            BasicDependencyContainer>
        {
        
        }

        [Subject(typeof(BasicDependencyContainer))]
        public class when_container_is_called : concern
        {
//            It should_tell_the_renderer_to_display_the_set_of_main_deparments = () =>
//                renderer.received(x => x.display(the_main_departments));

//                        Because b = () => { result = sut.matches(request); };

            Because b = () => {
                result = sut.a<string>();
            };

            It should_return_a_valid_impl = () =>
                result.ShouldBeAn<string>();

            static string result;        

                
        }
    }
}

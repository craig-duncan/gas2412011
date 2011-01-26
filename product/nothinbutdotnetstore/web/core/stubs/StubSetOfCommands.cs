using System.Collections;
using System.Collections.Generic;
using nothinbutdotnetstore.web.model;

namespace nothinbutdotnetstore.web.core.stubs
{
    public class StubSetOfCommands : IEnumerable<RequestCommand>
    {
        public IEnumerator<RequestCommand> GetEnumerator()
        {
            yield return new DefaultRequestCommand(x => true, 
            new ViewMainDepartments());


        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
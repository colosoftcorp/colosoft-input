using System.Collections.Generic;

namespace Colosoft.Input
{
    public interface IPatchInput
    {
        void AddChange(string property);

        IEnumerable<string> GetChanges();

        void ResetChanges();
    }
}

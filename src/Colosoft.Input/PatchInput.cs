using System.Collections.Generic;
using System.Linq;

namespace Colosoft.Input
{
    public abstract class PatchInput : IPatchInput
    {
        private readonly List<string> properties = new List<string>();

        protected PatchInput()
        {
        }

        public void AddChange(string property)
        {
            if (!this.properties.Contains(property))
            {
                this.properties.Add(property);
            }
        }

        public IEnumerable<string> GetChanges() =>
            this.properties.AsEnumerable();

        public void ResetChanges() =>
            this.properties.Clear();
    }
}

using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private List<Action> onRestoreLocalByRefs = new List<Action>();

        private void RegisterLocalByRef(Action onRestore)
        {
            onRestoreLocalByRefs.Add(onRestore);
        }

        private void OnRestoreLocalByRefs()
        {
            foreach (Action a in onRestoreLocalByRefs)
                a();
            onRestoreLocalByRefs.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inzendatu_Version1
{
    interface Interface1
    {
        void Send();
        string Name { get; }
        string GetTextAjouter { get ; }
        int GetButtonChoiceNumber { get; }
        string GetTextPositionAdd { get; }
        string GetTextBeforeOrAfter { get; }
        string GetTextAfterFirstMaj { get ; }
        int GetDe { get; }
        int GetA { get; }
        string ModificationText(string inp);
        string ModificationTextNuméro(string inp, int index, int count);
    }
}

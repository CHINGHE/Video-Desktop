
using System.Windows.Forms.Design;

namespace SCREEN_CAPTURE
{
    public class ColorBoxDesginer : ControlDesigner
    {
        public override SelectionRules SelectionRules
        {
            get
            {
                return base.SelectionRules & ~SelectionRules.AllSizeable;
            }
        }
    }
}

using System;
using XamCore.ObjCRuntime;
using XamCore.Foundation;

namespace XamCore.AppKit {

	public partial class NSSliderTouchBarItem {
		// If you modify, also search for other copies
		NSObject target;
		Selector action;

		public event EventHandler Activated {
			add {
				target = ActionDispatcher.SetupAction (Target, value);
				action = ActionDispatcher.Action;
				MarkDirty ();
				Target = target;
				Action = action;
			}

			remove {
				ActionDispatcher.RemoveAction (Target, value);
				target = null;
				action = null;
				MarkDirty ();
			}
		}


	}
}


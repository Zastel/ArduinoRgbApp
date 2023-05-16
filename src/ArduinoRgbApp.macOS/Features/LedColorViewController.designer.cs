// WARNING
//
// This file has been generated automatically by Rider IDE
//   to store outlets and actions made in Xcode.
// If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ArduinoRgbApp.macOS.Features
{
	[Register ("LedColorViewController")]
	partial class LedColorViewController
	{
		[Outlet]
		AppKit.NSSlider blueSlider { get; set; }

		[Outlet]
		AppKit.NSTextField blueTextField { get; set; }

		[Outlet]
		AppKit.NSColorWell colorPreviewWell { get; set; }

		[Outlet]
		AppKit.NSSlider greenSlider { get; set; }

		[Outlet]
		AppKit.NSTextField greenTextField { get; set; }

		[Outlet]
		AppKit.NSTextField hexColorTextField { get; set; }

		[Outlet]
		AppKit.NSSlider redSlider { get; set; }

		[Outlet]
		AppKit.NSTextField redTextField { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (redTextField != null) {
				redTextField.Dispose ();
				redTextField = null;
			}

			if (greenTextField != null) {
				greenTextField.Dispose ();
				greenTextField = null;
			}

			if (blueTextField != null) {
				blueTextField.Dispose ();
				blueTextField = null;
			}

			if (redSlider != null) {
				redSlider.Dispose ();
				redSlider = null;
			}

			if (greenSlider != null) {
				greenSlider.Dispose ();
				greenSlider = null;
			}

			if (blueSlider != null) {
				blueSlider.Dispose ();
				blueSlider = null;
			}

			if (hexColorTextField != null) {
				hexColorTextField.Dispose ();
				hexColorTextField = null;
			}

			if (colorPreviewWell != null) {
				colorPreviewWell.Dispose ();
				colorPreviewWell = null;
			}

		}
	}
}

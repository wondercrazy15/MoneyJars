// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MoneyJars.iOS
{
    [Register ("GuideView")]
    partial class GuideView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnNext { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSkip { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UICollectionView clvGuide { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPageControl pageControl { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewExtraSpace { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewMain { get; set; }

        [Action ("btnNextClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnNextClicked (UIKit.UIButton sender);

        [Action ("btnSkipClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnSkipClicked (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnNext != null) {
                btnNext.Dispose ();
                btnNext = null;
            }

            if (btnSkip != null) {
                btnSkip.Dispose ();
                btnSkip = null;
            }

            if (clvGuide != null) {
                clvGuide.Dispose ();
                clvGuide = null;
            }

            if (pageControl != null) {
                pageControl.Dispose ();
                pageControl = null;
            }

            if (viewExtraSpace != null) {
                viewExtraSpace.Dispose ();
                viewExtraSpace = null;
            }

            if (viewMain != null) {
                viewMain.Dispose ();
                viewMain = null;
            }
        }
    }
}
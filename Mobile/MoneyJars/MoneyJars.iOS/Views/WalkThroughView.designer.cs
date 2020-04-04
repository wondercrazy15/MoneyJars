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
    [Register ("WalkThroughView")]
    partial class WalkThroughView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnNext { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UICollectionView clvWalkThrough { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPageControl pageControl { get; set; }

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

            if (clvWalkThrough != null) {
                clvWalkThrough.Dispose ();
                clvWalkThrough = null;
            }

            if (pageControl != null) {
                pageControl.Dispose ();
                pageControl = null;
            }
        }
    }
}
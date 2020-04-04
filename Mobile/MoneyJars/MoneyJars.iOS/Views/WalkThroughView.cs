using CoreGraphics;
using Foundation;
using MoneyJars.Core.Helper;
using MoneyJars.Core.ViewModels;
using MoneyJars.iOS.Views;
using System;
using System.Collections.Generic;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class WalkThroughView : BaseView<WalkThroughViewModel>, IUICollectionViewDelegate, IUICollectionViewDataSource, IUICollectionViewDelegateFlowLayout
    {

        List<Dictionary<string, string>> walkThroughList = new List<Dictionary<string, string>>();

        public WalkThroughView (IntPtr handle) : base (handle)
        {
        }

        public WalkThroughView()
        {
        }

        public override void ViewDidLoad()
        {
            //Set Colors
            SetColors();


            //base.ViewDidLoad();
            Dictionary<string, string> first = new Dictionary<string, string>();
            first.Add("Title", "Just 2 minutes a day!");
            first.Add("Message", "Using Money Jars to make your spending habit well-planned");

            Dictionary<string, string> second = new Dictionary<string, string>();
            second.Add("Title", "The 6-Jar principle");
            second.Add("Message", "Allocate your income into 6 jars for different purposes");

            Dictionary<string, string> third = new Dictionary<string, string>();
            third.Add("Title", "Auto split income");
            third.Add("Message", "Based on the default ratio that can be customized in jar setting");

            walkThroughList.Add(first);
            walkThroughList.Add(second);
            walkThroughList.Add(third);

            clvWalkThrough.Delegate = this;
            clvWalkThrough.DataSource = this;

        }

        private void SetColors()
        {

            View.BackgroundColor = GlobalConst.App_Extra_Space_Color;
            
            clvWalkThrough.BackgroundColor = GlobalConst.App_Primary_Color;
            btnNext.BackgroundColor = GlobalConst.App_Buttons_Color;
            pageControl.CurrentPageIndicatorTintColor = GlobalConst.App_Buttons_Color;
            pageControl.TintColor = GlobalConst.App_Text_Color;
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);


        }

        public override UIStatusBarStyle PreferredStatusBarStyle()
        {
            return UIStatusBarStyle.LightContent;
        }

        partial void btnSkipClicked(UIButton sender)
        {
            SelectCurrencyView vc = Storyboard.InstantiateViewController("SelectCurrencyView") as SelectCurrencyView;
            NavigationController.PushViewController(vc, true);
        }

        partial void btnNextClicked(UIButton sender)
        {
            if(pageControl.CurrentPage == 2)
            {
                SelectCurrencyView vc = Storyboard.InstantiateViewController("SelectCurrencyView") as SelectCurrencyView;
                NavigationController.PushViewController(vc, true);
                return;
            }
            NSIndexPath indexPath = NSIndexPath.FromRowSection(pageControl.CurrentPage + 1, 0);
            clvWalkThrough.ScrollToItem(indexPath, UICollectionViewScrollPosition.None, true);
        }

        public nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return walkThroughList.Count;
        }

        public UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            WalkThroughCell cell = clvWalkThrough.DequeueReusableCell("WalkThroughCell", indexPath) as WalkThroughCell;

            Dictionary<string, string> data = walkThroughList[indexPath.Row];
            cell.UpdateCell(data);

            return cell;
        }

        [Export("collectionView:layout:sizeForItemAtIndexPath:")]
        public CGSize GetSizeForItem(UICollectionView collectionView, UICollectionViewLayout layout, NSIndexPath indexPath)
        {
            return new CGSize(collectionView.Frame.Size.Width, collectionView.Frame.Size.Height);
        }

        [Export("scrollViewDidScroll:")]
        public void Scrolled(UIScrollView scrollView)
        {
            int currentIndex = (int)(clvWalkThrough.ContentOffset.X / clvWalkThrough.Frame.Size.Width);
            pageControl.CurrentPage = currentIndex;
            Console.WriteLine(currentIndex);
        }

    }
}
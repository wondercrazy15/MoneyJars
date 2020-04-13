using CoreGraphics;
using Foundation;
using MoneyJars.Core.ViewModels;
using MoneyJars.iOS.Helper;
using MoneyJars.iOS.Views;
using System;
using System.Collections.Generic;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class GuideView : BaseView<GuideViewModel>, IUICollectionViewDelegate, IUICollectionViewDataSource, IUICollectionViewDelegateFlowLayout
    {

        List<Dictionary<string, string>> guideList = new List<Dictionary<string, string>>();

        public GuideView (IntPtr handle) : base (handle)
        {
        }

        public GuideView()
        {
        }

        public override void ViewDidLoad()
        {
            SetColors();

            LoadData();
        }


        public override UIStatusBarStyle PreferredStatusBarStyle()
        {
            return UIStatusBarStyle.LightContent;
        }

        private void LoadData()
        {
            Dictionary<string, string> first = new Dictionary<string, string>();
            first.Add("Title", "Just 2 minutes a day!");
            first.Add("Message", "Using Money Jars to make your spending habit well-planned");

            Dictionary<string, string> second = new Dictionary<string, string>();
            second.Add("Title", "The 6-Jar principle");
            second.Add("Message", "Allocate your income into 6 jars for different purposes");

            Dictionary<string, string> third = new Dictionary<string, string>();
            third.Add("Title", "Auto split income");
            third.Add("Message", "Based on the default ratio that can be customized in jar setting");

            Dictionary<string, string> four = new Dictionary<string, string>();
            four.Add("Title", "Necessities");
            four.Add("Message", "Suggestion: 50-60% * Purpose: to maintain your daily life * Example: Rent, bills, groceries, etc.");

            Dictionary<string, string> five = new Dictionary<string, string>();
            five.Add("Title", "Education");
            five.Add("Message", "Suggestion: 5-20% * Purpose: to invest in personal growth to increase your future income * Example: a new language study, updated speciality class, etc.");

            Dictionary<string, string> six = new Dictionary<string, string>();
            six.Add("Title", "Saving");
            six.Add("Message", "Suggestion: 5-20% * Purpose: for more upgraded purchases or emergency * Example: a car, an operation, your child education, etc.");

            Dictionary<string, string> seven = new Dictionary<string, string>();
            seven.Add("Title", "Play");
            seven.Add("Message", "Suggestion: 5-15% * Purpose: to bring you joy and in return encourage you to earn more * Example: Cinema, shopping, a vacation, etc.");

            Dictionary<string, string> eight = new Dictionary<string, string>();
            eight.Add("Title", "Investment");
            eight.Add("Message", "Suggestion: 5-20% * Purpose: to benefit your future financial oppurtunitites * Example: trading stocks, becoming a shareholder, or opening a restaurant, etc.");

            Dictionary<string, string> nine = new Dictionary<string, string>();
            nine.Add("Title", "Dat lai ma tein te moi");
            nine.Add("Message", "Suggestion: 5-10% * Purpose: to support other person then making happier * Example: donation, charity, help offers to your surroundings, etc.");

            guideList.Add(first);
            guideList.Add(second);
            guideList.Add(third);
            guideList.Add(four);
            guideList.Add(five);
            guideList.Add(six);
            guideList.Add(seven);
            guideList.Add(eight);
            guideList.Add(nine);

            clvGuide.Delegate = this;
            clvGuide.DataSource = this;
        }

        private void SetColors()
        {
            viewExtraSpace.BackgroundColor = Constants.App_Extra_Space_Color;

            viewMain.BackgroundColor = Constants.App_Primary_Color;

            clvGuide.BackgroundColor = Constants.App_Primary_Color;

            btnNext.BackgroundColor = Constants.App_Buttons_Color;
            btnNext.SetTitleColor(Constants.App_Text_Color, UIControlState.Normal);
            pageControl.CurrentPageIndicatorTintColor = Constants.App_Buttons_Color;
            pageControl.TintColor = Constants.App_Text_Color;
        }

        partial void btnNextClicked(UIButton sender)
        {
            if (pageControl.CurrentPage == 8)
            {
                NavigationController.PopViewController(true);
                return;
            }
            NSIndexPath indexPath = NSIndexPath.FromRowSection(pageControl.CurrentPage + 1, 0);
            clvGuide.ScrollToItem(indexPath, UICollectionViewScrollPosition.None, true);
        }

        partial void btnSkipClicked(UIButton sender)
        {
            NavigationController.PopViewController(true);
        }


        public nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return guideList.Count;
        }

        public UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            WalkThroughCell cell = clvGuide.DequeueReusableCell("WalkThroughCell", indexPath) as WalkThroughCell;

            Dictionary<string, string> data = guideList[indexPath.Row];
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
            int currentIndex = (int)(clvGuide.ContentOffset.X / clvGuide.Frame.Size.Width);
            pageControl.CurrentPage = currentIndex;
            Console.WriteLine(currentIndex);
        }

    }
}
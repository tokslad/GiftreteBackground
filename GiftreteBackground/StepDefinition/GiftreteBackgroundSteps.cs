using GiftreteBackground.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace GiftreteBackground.StepDefinition
{
    [Binding]
    public class GiftreteBackgroundSteps
    {
        GiftreteBackgroundPage giftreteBackgroundPage;
        public GiftreteBackgroundSteps()
        {
            giftreteBackgroundPage = new GiftreteBackgroundPage(); 
        }


        [Given(@"I navigate to site ""(.*)""")]
        public void GivenINavigateToSite(string url)
        {
            giftreteBackgroundPage.NavigateToWebsite(url);
            
        }

        [When(@"I enter click on Post item")]
        public void WhenIEnterClickOnPostItem()
        {
            giftreteBackgroundPage.ClickOnPostItem();
        }

        [When(@"I enter item name ""(.*)""")]
        public void WhenIEnterItemName(string dog)
        {
            giftreteBackgroundPage.EnterItemName(dog);
        }

        [When(@"I enter Item description ""(.*)""")]
        public void WhenIEnterItemDescription(string dog)
        {
            giftreteBackgroundPage.EnterItemDescription(dog);
        }

        [When(@"I click on item category")]
        public void WhenIClickOnItemCategory()
        {
            giftreteBackgroundPage.ClickOnItemCategory();
        }

        [When(@"I selecct Games from the dropdown")]
        public void WhenISelecctGamesFromTheDropdown()
        {
            giftreteBackgroundPage.SelectGame();
        }

        [When(@"I click on Item type")]
        public void WhenIClickOnItemType()
        {
            giftreteBackgroundPage.ClickOnItemType();
        }

        [When(@"I select Wanted")]
        public void WhenISelectWanted()
        {
            giftreteBackgroundPage.SelectItemType();   
        }

        [When(@"I enter item weight ""(.*)""")]
        public void WhenIEnterItemWeight(int P0)
        {
            giftreteBackgroundPage.EnterWeight();
        }

        [When(@"I enter location ""(.*)""")]
        public void WhenIEnterLocation(string boo)
        {
            giftreteBackgroundPage.IEnterMyLocation(boo);
        }

        [When(@"I click on item image")]
        public void WhenIClickOnItemImage()
        {
            giftreteBackgroundPage.ItemImages();
        }

        [When(@"I click on choose file")]
        public void WhenIClickOnChooseFile()
        {
            giftreteBackgroundPage.uploadFile();
        }

        [When(@"I click on Add item")]
        public void WhenIClickOnAddItem()
        {
            giftreteBackgroundPage.ClickOnAddItem();   
        }

        [When(@"I enter email ""(.*)""")]
        public void WhenIEnterEmail(string yogi)
        {
            giftreteBackgroundPage.EnterEmail(yogi);
        }
        
        [When(@"I enter password ""(.*)""")]
        public void WhenIEnterPassword(string woo)
        {
            giftreteBackgroundPage.EnterPassword(woo);
        }
        
        [When(@"I click on remember me box")]
        public void WhenIClickOnRememberMeBox()
        {
            giftreteBackgroundPage.RememberMeBox();
        }
        
        [When(@"I click on sign in")]
        public void WhenIClickOnSignIn()
        {
            giftreteBackgroundPage.ClickOnSignIn();
        }
        
        [When(@"I click on posted items")]
        public void WhenIClickOnPostedItems()
        {
            giftreteBackgroundPage.ClickOnPostItem();
        }
        
        [Then(@"my post should be successfully created")]
        public void ThenMyPostShouldBeSuccessfullyCreated()
        {
            Assert.That(giftreteBackgroundPage.IsPageDisplayed); 
        }
        

        [When(@"I click on my posted item")]
        public void WhenIClickOnMyPostedItem()
        {
           giftreteBackgroundPage.ClickMyPostedItems();
        }

        [Then(@"I should be able to see my post items")]
        public void ThenIShouldBeAbleToSeeMyPostItems()
        {
            Assert.That(giftreteBackgroundPage.IsMyPostedItemsDisplayed);
        }










    }
}

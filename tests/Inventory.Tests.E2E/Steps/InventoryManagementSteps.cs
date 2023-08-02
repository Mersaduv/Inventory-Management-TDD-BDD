using System;
using FluentAssertions;
using Inventory.Application.Contract;
using Inventory.Tests.E2E.Tools;
using Newtonsoft.Json;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;


namespace Inventory.Tests.E2E.Steps
{
    [Binding]
    public class InventoryManagementSteps
    {
        private bool _postResult = false;
        private DefineInventory _command;

        [Given(@"I Want To Add The Following Inventory")]
        public void GivenIWantToAddTheFollowingInventory(Table table)
        {
            _command = table.CreateInstance<DefineInventory>();
        }

        [When(@"I Try To Define This Inventory")]
        public void WhenITryToDefineThisInventory()
        {
            var restClient = new RestClient(HostConstants.Endpoint);
            var restRequest = new RestRequest("/Inventory");
            restRequest.AddJsonBody(_command);
            var response = restClient.Post(restRequest);
            _postResult = (bool)Convert.ChangeType(response.Content, typeof(bool));
        }

        [Then(@"The Inventory Should Be Created")]
        public void ThenTheInventoryShouldBeCreated()
        {
            _postResult.Should().BeTrue();
        }

        [Then(@"It Should Be Empty")]
        public void ThenItShouldBeEmpty()
        {
        }
    }
}
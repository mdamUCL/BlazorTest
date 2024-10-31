using System.Diagnostics.Metrics;
using AngleSharp.Diffing.Extensions;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using BlazorDemo.Pages;
using Bunit;
using Xunit;

namespace TestProject2
{
       
    public class CalculatorComponentTests: TestContext
    {
        [Fact]
        public void AddNumbers_ShouldAddPositiveNumbers()
        {
            var component = RenderComponent<BlazorDemo.Pages.Calculator>();
            component.Find("input[name='number1']").Change("2") ;
            component.Find("input[name='number2']").Change("3");
            var addButton = component.Find("button[name='AddNumbers']");
            addButton.Click();
            string finalresult="";
            component.Find("input[name='total']").TryGetAttrValue("value",out finalresult);
            Assert.Equal("5", finalresult);
        }
        [Fact]
        public void SubNumbers_ShouldSubPositiveNumbers()
        {
            var component = RenderComponent<BlazorDemo.Pages.Calculator>();
            component.Find("input[name='number1']").Change("5");
            component.Find("input[name='number2']").Change("3");
            var addButton = component.Find("button[name='SubtractNumbers']");
            addButton.Click();
            string finalresult = "";
            component.Find("input[name='total']").TryGetAttrValue("value", out finalresult);
            Assert.Equal("2", finalresult);
        }
    }
}

using As.Core.MVC.ModelBinding.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace As.Core.MVC.ModelBinding.CustomModelBinder
{
	public class MyCustomModelBinder : IModelBinder
	{
		public Task BindModelAsync(ModelBindingContext bindingContext)
		{
			var name = bindingContext.ValueProvider.GetValue("Name") .ToString();
			var message = bindingContext.ValueProvider.GetValue("Message").ToString();

			var model1 = bindingContext.HttpContext.Request.Body.ToString();

			bindingContext.Result = ModelBindingResult.Success(new Contact() {  Name ="You entered -" + name, Message= "This got overriden"});

			return Task.CompletedTask;
		}
	}
}

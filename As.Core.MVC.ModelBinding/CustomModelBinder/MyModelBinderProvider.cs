using As.Core.MVC.ModelBinding.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace As.Core.MVC.ModelBinding.CustomModelBinder;

public class MyModelBinderProvider : IModelBinderProvider   //Registered in start up
{
	public IModelBinder? GetBinder(ModelBinderProviderContext context)
	{
		if (context.Metadata.ModelType == typeof(Contact))
		{
			return new MyCustomModelBinder();
		}

		return null;
	}
}

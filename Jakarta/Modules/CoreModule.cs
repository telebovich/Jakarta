using System;
using Ninject.Activation;
using Ninject.Modules;

namespace Jakarta
{
	public class CoreModule: NinjectModule 
	{
		public override void Load()
		{
			Bind<IBlogPostPreviewRepository>().To<BlogPostPreviewRepository> ();
			Bind<IBlogService> ().To<BlogService> ();
		}
	}
}


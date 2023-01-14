using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Form1SubPage
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), DebuggerNonUserCode, CompilerGenerated]
	internal class Resource
	{
		private static ResourceManager resourceMan;

		private static CultureInfo resourceCulture;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resource.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("Form1Res2", typeof(Form1Res2).Assembly);
					Resource.resourceMan = resourceManager;
				}
				return Resource.resourceMan;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resource.resourceCulture;
			}
			set
			{
				Resource.resourceCulture = value;
			}
		}

		internal static Bitmap AboutUsButtonDown
		{
			get
			{
				object @object = Resource.ResourceManager.GetObject("AboutUsButtonDown", Resource.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap AboutUsButtonUp
		{
			get
			{
				object @object = Resource.ResourceManager.GetObject("AboutUsButtonUp", Resource.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static byte[] Alien_bull
		{
			get
			{
				object @object = Resource.ResourceManager.GetObject("Alien_bull", Resource.resourceCulture);
				return (byte[])@object;
			}
		}

		internal static Bitmap DonateButtonDown
		{
			get
			{
				object @object = Resource.ResourceManager.GetObject("DonateButtonDown", Resource.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap ExitButtonDown
		{
			get
			{
				object @object = Resource.ResourceManager.GetObject("ExitButtonDown", Resource.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap ImageEditorButtonDown
		{
			get
			{
				object @object = Resource.ResourceManager.GetObject("ImageEditorButtonDown", Resource.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap NandButtonDown
		{
			get
			{
				object @object = Resource.ResourceManager.GetObject("NandButtonDown", Resource.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap ReadMeButtonDown
		{
			get
			{
				object @object = Resource.ResourceManager.GetObject("ReadMeButtonDown", Resource.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal static Bitmap RGBButtonDown
		{
			get
			{
				object @object = Resource.ResourceManager.GetObject("RGBButtonDown", Resource.resourceCulture);
				return (Bitmap)@object;
			}
		}

		internal Resource()
		{
		}
	}
}

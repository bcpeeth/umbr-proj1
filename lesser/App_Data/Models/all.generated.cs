using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder;
using  Umbraco.ModelsBuilder.Umbraco;
[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "4110180479432999")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------















namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>HomePage</summary>
	[PublishedContentModel("homePage")]
	public partial class HomePage : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "homePage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public HomePage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HomePage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Body Text: The main content f the page
		///</summary>
		[ImplementPropertyType("bodyText")]
		public IHtmlString BodyText
		{
			get { return this.GetPropertyValue<IHtmlString>("bodyText"); }
		}

		///<summary>
		/// Footer Text: Copyright notice for the footer.
		///</summary>
		[ImplementPropertyType("footerText")]
		public string FooterText
		{
			get { return this.GetPropertyValue<string>("footerText"); }
		}

		///<summary>
		/// Page Title: The main title of the page (e.g. Flexim Foundation)
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return this.GetPropertyValue<string>("pageTitle"); }
		}
	}

	/// <summary>News</summary>
	[PublishedContentModel("news")]
	public partial class News : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "news";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public News(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<News, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Blocks
		///</summary>
		[ImplementPropertyType("blocks")]
		public IEnumerable<IPublishedContent> Blocks
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("blocks"); }
		}

		///<summary>
		/// Intro Content
		///</summary>
		[ImplementPropertyType("introContent")]
		public string IntroContent
		{
			get { return this.GetPropertyValue<string>("introContent"); }
		}

		///<summary>
		/// Intro Title
		///</summary>
		[ImplementPropertyType("introTitle")]
		public string IntroTitle
		{
			get { return this.GetPropertyValue<string>("introTitle"); }
		}
	}

	/// <summary>Projects</summary>
	[PublishedContentModel("projects")]
	public partial class Projects : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "projects";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Projects(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Projects, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Projects Intro Content
		///</summary>
		[ImplementPropertyType("projectsIntroContent")]
		public IHtmlString ProjectsIntroContent
		{
			get { return this.GetPropertyValue<IHtmlString>("projectsIntroContent"); }
		}

		///<summary>
		/// Projects Intro Title
		///</summary>
		[ImplementPropertyType("projectsIntroTitle")]
		public string ProjectsIntroTitle
		{
			get { return this.GetPropertyValue<string>("projectsIntroTitle"); }
		}

		///<summary>
		/// Project Team Image 1
		///</summary>
		[ImplementPropertyType("projectTeamImage1")]
		public IPublishedContent ProjectTeamImage1
		{
			get { return this.GetPropertyValue<IPublishedContent>("projectTeamImage1"); }
		}

		///<summary>
		/// Project Team Image 2
		///</summary>
		[ImplementPropertyType("projectTeamImage2")]
		public IPublishedContent ProjectTeamImage2
		{
			get { return this.GetPropertyValue<IPublishedContent>("projectTeamImage2"); }
		}

		///<summary>
		/// Project Team Image 3
		///</summary>
		[ImplementPropertyType("projectTeamImage3")]
		public IPublishedContent ProjectTeamImage3
		{
			get { return this.GetPropertyValue<IPublishedContent>("projectTeamImage3"); }
		}

		///<summary>
		/// Project Team Name 1
		///</summary>
		[ImplementPropertyType("projectTeamName1")]
		public string ProjectTeamName1
		{
			get { return this.GetPropertyValue<string>("projectTeamName1"); }
		}

		///<summary>
		/// Project Team Name 2
		///</summary>
		[ImplementPropertyType("projectTeamName2")]
		public string ProjectTeamName2
		{
			get { return this.GetPropertyValue<string>("projectTeamName2"); }
		}

		///<summary>
		/// Project Team Name 3
		///</summary>
		[ImplementPropertyType("projectTeamName3")]
		public string ProjectTeamName3
		{
			get { return this.GetPropertyValue<string>("projectTeamName3"); }
		}

		///<summary>
		/// Project Team Text 1
		///</summary>
		[ImplementPropertyType("projectTeamText1")]
		public IHtmlString ProjectTeamText1
		{
			get { return this.GetPropertyValue<IHtmlString>("projectTeamText1"); }
		}

		///<summary>
		/// Project Team Text 2
		///</summary>
		[ImplementPropertyType("projectTeamText2")]
		public IHtmlString ProjectTeamText2
		{
			get { return this.GetPropertyValue<IHtmlString>("projectTeamText2"); }
		}

		///<summary>
		/// Project Team Text 3
		///</summary>
		[ImplementPropertyType("projectTeamText3")]
		public IHtmlString ProjectTeamText3
		{
			get { return this.GetPropertyValue<IHtmlString>("projectTeamText3"); }
		}

		///<summary>
		/// Project Type 1
		///</summary>
		[ImplementPropertyType("projectType1")]
		public IHtmlString ProjectType1
		{
			get { return this.GetPropertyValue<IHtmlString>("projectType1"); }
		}

		///<summary>
		/// Project Type 2
		///</summary>
		[ImplementPropertyType("projectType2")]
		public IHtmlString ProjectType2
		{
			get { return this.GetPropertyValue<IHtmlString>("projectType2"); }
		}

		///<summary>
		/// Project Type 3
		///</summary>
		[ImplementPropertyType("projectType3")]
		public IHtmlString ProjectType3
		{
			get { return this.GetPropertyValue<IHtmlString>("projectType3"); }
		}

		///<summary>
		/// Project Type 4
		///</summary>
		[ImplementPropertyType("projectType4")]
		public IHtmlString ProjectType4
		{
			get { return this.GetPropertyValue<IHtmlString>("projectType4"); }
		}

		///<summary>
		/// Project Type Title 1
		///</summary>
		[ImplementPropertyType("projectTypeTitle1")]
		public string ProjectTypeTitle1
		{
			get { return this.GetPropertyValue<string>("projectTypeTitle1"); }
		}

		///<summary>
		/// Project Type Title 2
		///</summary>
		[ImplementPropertyType("projectTypeTitle2")]
		public string ProjectTypeTitle2
		{
			get { return this.GetPropertyValue<string>("projectTypeTitle2"); }
		}

		///<summary>
		/// Project Type Title 3
		///</summary>
		[ImplementPropertyType("projectTypeTitle3")]
		public string ProjectTypeTitle3
		{
			get { return this.GetPropertyValue<string>("projectTypeTitle3"); }
		}

		///<summary>
		/// Project Type Title 4
		///</summary>
		[ImplementPropertyType("projectTypeTitle4")]
		public string ProjectTypeTitle4
		{
			get { return this.GetPropertyValue<string>("projectTypeTitle4"); }
		}
	}

	/// <summary>Information</summary>
	[PublishedContentModel("information")]
	public partial class Information : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "information";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Information(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Information, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Block - Text</summary>
	[PublishedContentModel("blockText")]
	public partial class BlockText : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "blockText";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BlockText(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BlockText, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Text Content
		///</summary>
		[ImplementPropertyType("textContent")]
		public IHtmlString TextContent
		{
			get { return this.GetPropertyValue<IHtmlString>("textContent"); }
		}

		///<summary>
		/// title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}
	}

	/// <summary>Block - Image</summary>
	[PublishedContentModel("blockImage")]
	public partial class BlockImage : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "blockImage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BlockImage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BlockImage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public IPublishedContent Image
		{
			get { return this.GetPropertyValue<IPublishedContent>("image"); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}



// EOF

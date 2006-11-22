
namespace BooCompiler.Tests
{
	using NUnit.Framework;
	
	[TestFixture]		
	public class GenericsTestFixture : AbstractCompilerTestCase
	{
		override protected void RunCompilerTestCase(string name)
		{
			if (System.Environment.Version.Major < 2) Assert.Ignore("Test requires .net 2.");
			System.ResolveEventHandler resolver = InstallAssemblyResolver(System.IO.Path.GetDirectoryName(name));
			try
			{
				base.RunCompilerTestCase(name);
			}
			finally
			{
				RemoveAssemblyResolver(resolver);
			}
		}

		[Test]
		public void callable_1()
		{
			RunCompilerTestCase(@"c:\projects\boo\tests\testcases\net2\generics\callable-1.boo");
		}
		
		[Test]
		public void callable_2()
		{
			RunCompilerTestCase(@"c:\projects\boo\tests\testcases\net2\generics\callable-2.boo");
		}
		
		[Test]
		public void collections_1()
		{
			RunCompilerTestCase(@"c:\projects\boo\tests\testcases\net2\generics\collections-1.boo");
		}
		
		[Test]
		public void collections_2()
		{
			RunCompilerTestCase(@"c:\projects\boo\tests\testcases\net2\generics\collections-2.boo");
		}
		
		[Test]
		public void enumerable_type_inference_1()
		{
			RunCompilerTestCase(@"c:\projects\boo\tests\testcases\net2\generics\enumerable-type-inference-1.boo");
		}
		
		[Test]
		public void enumerable_type_inference_2()
		{
			RunCompilerTestCase(@"c:\projects\boo\tests\testcases\net2\generics\enumerable-type-inference-2.boo");
		}
		
		[Test]
		public void enumerable_type_inference_4()
		{
			RunCompilerTestCase(@"c:\projects\boo\tests\testcases\net2\generics\enumerable-type-inference-4.boo");
		}
		
		[Test]
		public void enumerable_type_inference_5()
		{
			RunCompilerTestCase(@"c:\projects\boo\tests\testcases\net2\generics\enumerable-type-inference-5.boo");
		}
		
		[Test]
		public void interface_1()
		{
			RunCompilerTestCase(@"c:\projects\boo\tests\testcases\net2\generics\interface-1.boo");
		}
		
		[Test]
		public void mixed_1()
		{
			RunCompilerTestCase(@"c:\projects\boo\tests\testcases\net2\generics\mixed-1.boo");
		}
		
		[Test]
		public void mixed_2()
		{
			RunCompilerTestCase(@"c:\projects\boo\tests\testcases\net2\generics\mixed-2.boo");
		}
		
		[Test]
		public void mixed_3()
		{
			RunCompilerTestCase(@"c:\projects\boo\tests\testcases\net2\generics\mixed-3.boo");
		}
		
		[Test]
		public void mixed_4()
		{
			RunCompilerTestCase(@"c:\projects\boo\tests\testcases\net2\generics\mixed-4.boo");
		}
		
		[Test]
		public void name_resolution_1()
		{
			RunCompilerTestCase(@"c:\projects\boo\tests\testcases\net2\generics\name-resolution-1.boo");
		}
		
		[Test]
		public void override_1()
		{
			RunCompilerTestCase(@"c:\projects\boo\tests\testcases\net2\generics\override-1.boo");
		}
		
		[Test]
		public void type_reference_1()
		{
			RunCompilerTestCase(@"c:\projects\boo\tests\testcases\net2\generics\type-reference-1.boo");
		}
		
		[Test]
		public void type_reference_2()
		{
			RunCompilerTestCase(@"c:\projects\boo\tests\testcases\net2\generics\type-reference-2.boo");
		}
		
		[Test]
		public void type_reference_3()
		{
			RunCompilerTestCase(@"c:\projects\boo\tests\testcases\net2\generics\type-reference-3.boo");
		}
		
	}
}

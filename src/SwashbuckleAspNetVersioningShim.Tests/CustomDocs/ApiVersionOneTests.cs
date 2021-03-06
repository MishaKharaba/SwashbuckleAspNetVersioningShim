using FluentAssertions;
using SwashbuckleAspNetVersioningShim.Tests.Fixtures.CustomDocs;
using Xunit;

namespace SwashbuckleAspNetVersioningShim.Tests.CustomDocs
{
    public class ApiVersionOneTests : IClassFixture<ApiVersionOneFixture>
    {
        private ApiVersionOneFixture _fixture;

        public ApiVersionOneTests(ApiVersionOneFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void SwaggerDocumentInfoVersionShouldBeOnePointZero()
        {
            string infoVersion = _fixture.SwaggerDocument?.info?.version;
            infoVersion.Should().Be("1.0");
        }

        [Fact]
        public void SwaggerDocumentShouldContainHelloWorldPath()
        {
            var helloWorldPathKey = _fixture?.SwaggerDocument?.paths?["/api/v1.0/helloworld"];
            ((object)helloWorldPathKey).Should().NotBeNull("there should be hello world path");
        }

        [Fact]
        public void HelloWorldPathShouldHaveGetMethod()
        {
            var helloWorldPathKey = _fixture?.SwaggerDocument?.paths?["/api/v1.0/helloworld"];
            ((object)helloWorldPathKey).Should().NotBeNull("there should be hello world path");
            ((object)helloWorldPathKey?.get).Should().NotBeNull("this should support get");
        }

        [Fact]
        public void HelloWorldPathShouldNotHavePostMethod()
        {
            var helloWorldPathKey = _fixture?.SwaggerDocument?.paths?["/api/v1.0/helloworld"];
            ((object)helloWorldPathKey).Should().NotBeNull("there should be hello world path");
            ((object)helloWorldPathKey?.post).Should().BeNull("this method only supports get");
        }

        [Fact]
        public void HelloWorldPathShouldNotHaveDeleteMethod()
        {
            var helloWorldPathKey = _fixture?.SwaggerDocument?.paths?["/api/v1.0/helloworld"];
            ((object)helloWorldPathKey).Should().NotBeNull("there should be hello world path");
            ((object)helloWorldPathKey?.delete).Should().BeNull("this method only supports get");
        }

        [Fact]
        public void HelloWorldPathShouldNotHavePatchMethod()
        {
            var helloWorldPathKey = _fixture?.SwaggerDocument?.paths?["/api/v1.0/helloworld"];
            ((object)helloWorldPathKey).Should().NotBeNull("there should be hello world path");
            ((object)helloWorldPathKey?.patch).Should().BeNull("this method only supports get");
        }

        [Fact]
        public void HelloWorldPathShouldNotHavePutMethod()
        {
            var helloWorldPathKey = _fixture?.SwaggerDocument?.paths?["/api/v1.0/helloworld"];
            ((object)helloWorldPathKey).Should().NotBeNull("there should be hello world path");
            ((object)helloWorldPathKey?.put).Should().BeNull("this method only supports get");
        }

        [Fact]
        public void HelloWorldGetMethodsOperationIdShouldBeApiHelloWorldGet()
        {
            var helloWorldPathKey = _fixture?.SwaggerDocument?.paths?["/api/v1.0/helloworld"];
            ((object)helloWorldPathKey).Should().NotBeNull("there should be hello world path");
            ((object)helloWorldPathKey?.get).Should().NotBeNull("this should support get");
            ((object)helloWorldPathKey?.get?.operationid).ToString().Should().Be("apihelloworldget");
        }

        [Fact]
        public void HelloWorldGetCustomMethodsOperationIdShouldBeHelloWorldCustomOperationName()
        {
            var helloWorldPathKey = _fixture?.SwaggerDocument?.paths?["/api/v1.0/helloworld/{id}"];
            ((object)helloWorldPathKey).Should().NotBeNull("there should be get hello world by id path");
            ((object)helloWorldPathKey?.get).Should().NotBeNull("this should support get");
            ((object)helloWorldPathKey?.get?.operationid).ToString().Should().Be("helloworldcustomoperationname");
        }

        [Fact]
        public void SwaggerDocumentShouldContainValuesPath()
        {
            var valuesPathKey = _fixture?.SwaggerDocument?.paths?["/api/v1.0/values"];
            ((object)valuesPathKey).Should().NotBeNull("there should be values path");
        }

        [Fact]
        public void ValuesPathShouldHaveGetMethod()
        {
            var valuesPathKey = _fixture?.SwaggerDocument?.paths?["/api/v1.0/values"];
            ((object)valuesPathKey).Should().NotBeNull("there should be values path");
            ((object)valuesPathKey?.get).Should().NotBeNull("this should support get");
        }

        [Fact]
        public void ValuesPathShouldNotHavePostMethod()
        {
            var valuesPathKey = _fixture?.SwaggerDocument?.paths?["/api/v1.0/values"];
            ((object)valuesPathKey).Should().NotBeNull("there should be values path");
            ((object)valuesPathKey?.post).Should().BeNull("this method only supports get");
        }

        [Fact]
        public void ValuesPathShouldNotHaveDeleteMethod()
        {
            var valuesPathKey = _fixture?.SwaggerDocument?.paths?["/api/v1.0/values"];
            ((object)valuesPathKey).Should().NotBeNull("there should be values path");
            ((object)valuesPathKey?.delete).Should().BeNull("this method only supports get");
        }

        [Fact]
        public void ValuesPathShouldNotHavePatchMethod()
        {
            var valuesPathKey = _fixture?.SwaggerDocument?.paths?["/api/v1.0/values"];
            ((object)valuesPathKey).Should().NotBeNull("there should be values path");
            ((object)valuesPathKey?.patch).Should().BeNull("this method only supports get");
        }

        [Fact]
        public void ValuesPathShouldNotHavePutMethod()
        {
            var valuesPathKey = _fixture?.SwaggerDocument?.paths?["/api/v1.0/values"];
            ((object)valuesPathKey).Should().NotBeNull("there should be values path");
            ((object)valuesPathKey?.put).Should().BeNull("this method only supports get");
        }

        [Fact]
        public void ValuesGetMethodsOperationIdShouldBeApiValuesGet()
        {
            var valuesPathKey = _fixture?.SwaggerDocument?.paths?["/api/v1.0/values"];
            ((object)valuesPathKey).Should().NotBeNull("there should be values path");
            ((object)valuesPathKey?.get).Should().NotBeNull("this should support get");
            ((object)valuesPathKey?.get?.operationid).ToString().Should().Be("apivaluesget");
        }

        [Fact]
        public void ValuesGetByIdMethodsOperationIdShouldBeApiValuesByIdGet()
        {
            var valuesPathKey = _fixture?.SwaggerDocument?.paths?["/api/v1.0/values/{id}"];
            ((object)valuesPathKey).Should().NotBeNull("there should be values path");
            ((object)valuesPathKey?.get).Should().NotBeNull("this should support get");
            ((object)valuesPathKey?.get?.operationid).ToString().Should().Be("apivaluesbyidget");
        }

        [Fact]
        public void SwaggerDocumentTitleShouldMatchConfiguredValue()
        {
            string documentTitle = _fixture?.SwaggerDocument?.info?.title;
            documentTitle.Should().NotBeNull("there should be a document title");
            documentTitle.Should().Be("welcome to the documentation for version 1.0 of my api", "because that's what's specified in the Swagger versioning configuration");
        }
    }
}

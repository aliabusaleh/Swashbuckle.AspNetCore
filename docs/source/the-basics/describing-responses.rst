Describing Responses
====================

An API specification needs to specify the responses for all API operations. Each operation must have at least one response defined, usually a successful response. A response is defined by its HTTP status code and the data returned in the response body and/or headers. To learn more about how responses are described by the OpenAPI Specification, checkout out the `OpenAPI docs here <https://swagger.io/docs/specification/describing-responses/>`_.

Implicit Responses
------------------

By default, Swashbuckle will generate a "200" response for *all* operations. Additionally, if the action returns a response DTO then this will be used to generate a "schema" for the response body.

For example, given the following action method:

    .. literalinclude:: ..\..\..\test\WebSites\TheBasics\Controllers\UsersController.cs
        :language: csharp
        :start-at: [HttpGet]
        :end-at: public
        :dedent: 8

    .. literalinclude:: ..\..\..\test\WebSites\TheBasics\Models\User.cs
        :language: csharp
        :start-at: public class User
        :lines: 1-4
        :dedent: 4

Swashbuckle will generate the following responses:

    .. literalinclude:: ..\..\..\test\WebSites\TheBasics\swagger.yaml
        :language: yaml
        :start-after: operationId: GetAllUsers
        :end-before: x-foo:
        :dedent: 6

Explicit Responses
------------------

If you need to specify a different status code and/or additional responses, or your actions return ``IActionResult`` instead of a response DTO, you can describe responses explicitly by annotating the action *or controller* with the ``ProducesResponseType`` and/or ``ProducesDefaultResponseType`` attributes that ship with ASP.NET Core.

For example, given the following action method:

    .. literalinclude:: ..\..\..\test\WebSites\TheBasics\Controllers\ProductsController.cs
        :language: csharp
        :start-at: [HttpGet]
        :end-at: public
        :dedent: 8

Swashbuckle will generate the following responses:

    .. literalinclude:: ..\..\..\test\WebSites\TheBasics\swagger.yaml
        :language: yaml
        :start-after: operationId: GetAllProducts
        :end-before: x-foo:
        :dedent: 6


.. note:: When using explicit responses, you MUST specify a response for *every* response code you want documented. That is, the default "200" response will NOT be automatically generated if the action or controller is annotated with one or more response type attributes.
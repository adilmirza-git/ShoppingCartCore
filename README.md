<h1>A Checkout REST API Service</h1>
<p>Develop a service that accepts the list of products and returns the total price.</p>
<p><strong>Prerequisites</strong></p>
<ul>
<li>Visual Studio 2019 16.4.0</li>
<li>ASP.NET Core 3.1</li>
<li>Docker Desktop</li>
<li>Postman</li>
<li>Node</li>
<li>Newman</li>
</ul>
<p><strong>Approach:</strong></p>
<p>This service is developed using .NET Core Web API project template and supports Docker implementation. Idea is to develop a Microservice that is scalable and platform independant.&nbsp;The Test Automation is done using Postman, Node and Newman. Idea is to have a commandline that can be integrated with build pipeline like Jenkins or Azure to offer automated testing and facilitate continious integration.</p>
<p>For this project the inventory data is in the Json File "Inventories data"</p>
<p>General Solution Architecture Guidelines and improvements that can be done when building the overall solution.</p>
<ul>
<li>To be developed as Microservice</li>
<li>Should be Platform Independant - .NET Core supports Linux, Windows and MacOS</li>
<li>Offer Docker or Spring Boot Support. Containers to be managed using&nbsp; Kubernates</li>
<li>Solution should be Database Independant</li>
<li>Extensive Logging - including the incoming/outgoing and business events capturing. Can Leverage from Non SQL Databases like MongoDB for storing the Json data and advance analytics tools like ElasticSearch or Splunk for data analytics purpose</li>
<li>Ensure compliance to regulatory standards like PCI-DSS when dealing with Card Information</li>
<li>Implement JWT Authentication or Integrate with Third Party OAuth Provider</li>
<li>Integrate with Third Party softwares to manage the passwords like Vault ( HashiCorp.&nbsp;</li>
<li>APIGateway to be added on top of the service to offer scability, manage load and AB Testing</li>
<li>Implement JWT Token based Authentication&nbsp;</li>
<li>Implement Versioning</li>
<li>Branching of the development</li>
<li>Implement HMAC message with Shared Key to Ensure authenticity of message</li>
<li>Implement Adaptors to connect to downstream systems and connectors for data analytics for data push and Business Rules engines for price calcualtions.</li>
<li>Implement&nbsp; Logging</li>
</ul>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>

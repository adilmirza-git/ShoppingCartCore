<h1>A Checkout REST API Service</h1>
<p>Develop a service that accepts a list of products and returns the total price.&nbsp;</p>
<p><strong>Prerequisites - Rest API</strong></p>
<ul>
<li>Visual Studio 2019 16.4.0</li>
<li>ASP.NET Core 3.1</li>
<li>Docker Desktop (Not Essential) - You can choose to run the application on IIS Express</li>
</ul>
<p><strong>Prerequisites - Test Automation</strong></p>
<ul>
<li>Postman</li>
<li>Node</li>
<li><a href="https://blog.postman.com/installing-newman-on-windows/" target="_blank" rel="noopener">Newman</a>&nbsp;(Click on link to know the npm command to install Newman.&nbsp;&nbsp;</li>
</ul>
<p>&nbsp;</p>
<p><strong>Running Automated Test:</strong></p>
<p>Test Json Packages are included as part of the solution. Post Running the Service on IIS Port 8080 the below command line to be run on windows command prompt to run the Automated Test.&nbsp;</p>
<p><strong>Using command prompt locate on the folder containing the JSON collection and then run the below command to run the autmated test.</strong></p>
<p><strong>"newman run ShoppingCart.postman_collection.json -e ShoppingCart-Test-Env.postman_environment.json"</strong></p>
<p>&nbsp;</p>
<p><strong>Development Approach:</strong></p>
<p>This service is developed using .NET Core Web API project template with Docker support. Idea is to develop a Microservice that is scalable and platform independant.&nbsp;The Test Automation is done using Postman, Node and Newman. Idea is to have a commandline that can be integrated with build pipeline like Jenkins or Azure to offer automated testing and facilitate continious integration.</p>
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

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
<p>JSON Packages are included as part of the solution. The Rest API service must be up and running on Port 8080 for the automated test to work.</p>
<p>To run the automated test - Execute the below command on Windows command prompt.&nbsp;</p>
<p><em>1. Open command prompt </em></p>
<p><em>2. Locate on the folder containing the JSON collection and then run the below command to run the automated test.</em></p>
<p><em>3. Run the command "newman run ShoppingCart.postman_collection.json -e ShoppingCart-Test-Env.postman_environment.json"</em></p>
<p>&nbsp;</p>
<p><strong>Development Approach:</strong></p>
<p>This service is developed using .NET Core Web API project template with Docker support. Idea is to develop a Microservice that is scalable and platform independent.&nbsp;The Test Automation are developed using Postman and can be executed using Newman command line. It is important to have command line that can be integrated with build pipeline like Jenkins or Azure DevOps to offer automated testing and facilitate continuous integration.</p>
<p>For this project the inventory data is in the Json File "Inventories data"</p>
<p>&nbsp;</p>
<p><strong>Solution Architecture Guidelines and Improvements:<br /><br /></strong>The below needs to be considered when building the overall solution and making it future proof.</p>
<ul>
<li>To be developed as Microservice</li>
<li>Should be Platform Independent - .NET Core supports Linux, Windows and MacOS</li>
<li>Offer Docker or Spring Boot Support. Containers to be managed using&nbsp; Kubernates</li>
<li>Solution should be Database Independant</li>
<li>Extensive Logging - including the incoming/outgoing and business events capturing. Can Leverage from Non SQL Databases like MongoDB for storing the Json data and advance analytics tools like ElasticSearch or Splunk for data analytics purpose</li>
<li>Ensure compliance to regulatory standards like PCI-DSS when dealing with Card Information</li>
<li>Implement JWT Authentication or Integrate with Third Party OAuth Provider</li>
<li>Integrate with third party software to manage the passwords like Vault ( HashiCorp).&nbsp;</li>
<li>APIGateway to be added on top of the service to offer scalability, manage load and AB Testing</li>
<li>Implement JWT Token based Authentication&nbsp;</li>
<li>Implement Versioning</li>
<li>Branching of the development</li>
<li>Implement HMAC message with Shared Key to Ensure authenticity of message</li>
<li>Implement Adaptors to connect to downstream systems and connectors for data analytics for data push and Business Rules engines for price calculations.</li>
<li>Implement Logging</li>
</ul>
<p>&nbsp;</p>
<p>&nbsp;</p>

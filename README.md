This is a GraphQL-based API built using ASP.NET Core and Entity Framework Core. 
It allows fetching user details along with their posts dynamically using GraphQL queries.

Key Features:  

✅ Fetch user information along with related posts in a single API call  
✅ Flexible data retrieval by modifying GraphQL queries (e.g., include/exclude fields)  
✅ Uses Entity Framework Core for database operations  
✅ Implements GraphQL.AspNET to handle queries  
✅ Supports real-time data fetching if needed (via GraphQL subscriptions)  

Technologies Used:  
- C# (.NET 8)  
- GraphQL.AspNET  
- Entity Framework Core  
- SQL Server 
- ASP.NET Core  

How It Works:  
1. Users send a GraphQL query to the API.  
2. The API processes the query and fetches data from the database.  
3. Only the requested fields are returned, improving performance and flexibility.  

Example Query:
A client can request a user’s name and their posts with this GraphQL query:  

query {
  user(id: 1) {
    name
    posts {
      title
      content
    }
  }
}

Expected JSON Response:

{
  "data": {
    "user": {
      "name": "John Doe",
      "posts": [
        {
          "title": "GraphQL Basics",
          "content": "GraphQL is a query language for APIs..."
        }
      ]
    }
  }
}


Why Use GraphQL Instead of REST? 
✅ Flexible Queries - Fetch only the data you need.  
✅ Reduced API Calls - Fetch related data in a single request.  
✅ Performance Optimization - Avoid over-fetching and under-fetching.  


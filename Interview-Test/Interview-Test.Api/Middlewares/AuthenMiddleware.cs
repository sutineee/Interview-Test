namespace Interview_Test.Middlewares;

public class AuthenMiddleware : IMiddleware
{
     private const string hashedKey = "tJAcdP/L4qvMJ6TA1hJ174gUuiqCFAQx7SA+C8ciKlp75HlQYw7O4N7H9RZxiJX2j4cpKd5PFJH01uXEd+oEtA==";
 
     public Task InvokeAsync(HttpContext context, RequestDelegate next)
     {
         var apiKeyHeader = context.Request.Headers["x-api-key"];
         if (string.IsNullOrEmpty(apiKeyHeader))
         {
             context.Response.StatusCode = 401;
             return context.Response.WriteAsync("API Key is missing");
         }
    
         string hashedApiKey = HashString(apiKeyHeader);
         if (!string.Equals(hashedKey, hashedApiKey))
         {
             context.Response.StatusCode = 401;
             return context.Response.WriteAsync("Invalid API Key");
         }
    
         return next(context);
     }

     private static string HashString(string input)
     {
         using (var sha512 = SHA512.Create())
         {
             byte[] bytes = Encoding.UTF8.GetBytes(input);
             byte[] hashBytes = sha512.ComputeHash(bytes);
             return Convert.ToBase64String(hashBytes);
         }
     }
}

using System;

namespace AWSCloudFormationGenerator.APIGateway
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class APIGatewayResourceProperties : Attribute {
        public string PathPart { get; set; } 
        public bool EnableCORS {get; set;} = false;

        public APIGatewayResourceProperties(string PathPart){ 
            this.PathPart = PathPart;
        }
    }
}
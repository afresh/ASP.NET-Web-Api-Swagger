using System;

namespace WebApiSwagger.Swagger
{
    [AttributeUsage(AttributeTargets.All)]
    public class VersionedRoute : Attribute
    {
        public VersionedRoute(string name, int version)
        {
            Name = name;
            Version = version;
        }
        public string Name { get; set; }
        public int Version { get; set; }
    }
}
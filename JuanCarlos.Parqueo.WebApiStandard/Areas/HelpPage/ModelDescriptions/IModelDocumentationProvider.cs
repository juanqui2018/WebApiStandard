using System;
using System.Reflection;

namespace JuanCarlos.Parqueo.WebApiStandard.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}